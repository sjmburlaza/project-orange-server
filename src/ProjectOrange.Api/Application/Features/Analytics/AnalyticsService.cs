using System.Globalization;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class AnalyticsService
{
    private const string DefaultFailureReason = "Payment authorization failed";

    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public AnalyticsService(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    public async Task<AnalyticsDashboardDto> GetDashboardAsync(string? siteCode, string? period)
    {
        var window = CreatePeriodWindow(period);
        var events = await GetAnalyticsEventsAsync(siteCode, window);

        return BuildDashboard(events, window);
    }

    public async Task<AnalyticsDashboardDto> SaveEventsAsync(
        JsonElement body,
        string? routeSiteCode,
        string? dashboardSiteCode,
        string? dashboardPeriod)
    {
        var incomingEvents = await NormalizeAnalyticsPayloadAsync(body, routeSiteCode);
        var acceptedEvents = await RemoveDuplicateEventsAsync(incomingEvents);

        if (acceptedEvents.Count > 0)
        {
            _context.AnalyticsEvents.AddRange(acceptedEvents);
            await _context.SaveChangesAsync();
        }

        return await GetDashboardAsync(dashboardSiteCode, dashboardPeriod);
    }

    private async Task<List<AnalyticsEvent>> GetAnalyticsEventsAsync(
        string? siteCode,
        AnalyticsPeriodWindow window)
    {
        var normalizedSiteCode = NormalizeSite(siteCode);
        var query = _context.AnalyticsEvents
            .Include(e => e.Items)
            .AsNoTracking();

        if (!string.IsNullOrWhiteSpace(normalizedSiteCode))
        {
            query = query.Where(e => e.Site.Code == normalizedSiteCode);
        }

        if (window.StartAtUtc is not null)
        {
            query = query.Where(e => e.OccurredAt >= window.StartAtUtc);
        }

        return await query.ToListAsync();
    }

    private async Task<List<AnalyticsEvent>> NormalizeAnalyticsPayloadAsync(
        JsonElement body,
        string? routeSiteCode)
    {
        var eventElements = GetPayloadEvents(body);
        if (eventElements.Count == 0)
        {
            return [];
        }

        var normalizedRouteSiteCode = NormalizeSite(routeSiteCode);
        var explicitSiteCodes = normalizedRouteSiteCode is null
            ? eventElements
                .Select(element => NormalizeSite(GetString(element, "site")))
                .Where(siteCode => siteCode is not null)
                .Distinct(StringComparer.Ordinal)
                .ToList()
            : [];

        var siteIdsByCode = explicitSiteCodes.Count == 0
            ? new Dictionary<string, int>(StringComparer.Ordinal)
            : await _context.Sites
                .AsNoTracking()
                .Where(site => site.IsActive && explicitSiteCodes.Contains(site.Code))
                .ToDictionaryAsync(site => site.Code, site => site.Id);

        var events = new List<AnalyticsEvent>();
        foreach (var eventElement in eventElements)
        {
            var siteId = ResolveEventSiteId(eventElement, normalizedRouteSiteCode, siteIdsByCode);
            if (siteId is null)
            {
                continue;
            }

            var analyticsEvent = NormalizeAnalyticsEvent(eventElement, siteId.Value);
            if (analyticsEvent is not null)
            {
                events.Add(analyticsEvent);
            }
        }

        return events;
    }

    private int? ResolveEventSiteId(
        JsonElement eventElement,
        string? routeSiteCode,
        IReadOnlyDictionary<string, int> siteIdsByCode)
    {
        if (routeSiteCode is not null)
        {
            return _siteContext.SiteId;
        }

        var eventSiteCode = NormalizeSite(GetString(eventElement, "site"));
        if (eventSiteCode is null)
        {
            return _siteContext.SiteId;
        }

        return siteIdsByCode.TryGetValue(eventSiteCode, out var siteId)
            ? siteId
            : null;
    }

    private static AnalyticsEvent? NormalizeAnalyticsEvent(JsonElement eventElement, int siteId)
    {
        var type = GetString(eventElement, "type");
        if (type is null || !AnalyticsEventTypes.All.Contains(type))
        {
            return null;
        }

        var occurredAt = GetDateTimeOffset(eventElement, "occurredAt") ?? DateTimeOffset.UtcNow;

        return new AnalyticsEvent
        {
            Id = GetString(eventElement, "id", 128) ?? CreateId(type),
            SiteId = siteId,
            Type = type,
            OccurredAt = occurredAt.ToUniversalTime(),
            VisitorId = GetString(eventElement, "visitorId", 128) ?? CreateId("visitor"),
            SessionId = GetString(eventElement, "sessionId", 128) ?? CreateId("session"),
            ProductId = GetInt(eventElement, "productId"),
            ProductName = GetString(eventElement, "productName", 256),
            CategoryName = GetString(eventElement, "categoryName", 128),
            Quantity = GetInt(eventElement, "quantity"),
            Value = GetDecimal(eventElement, "value"),
            OrderNumber = GetString(eventElement, "orderNumber", 64),
            FailureReason = GetString(eventElement, "failureReason", 256),
            Items = GetItems(eventElement)
        };
    }

    private async Task<List<AnalyticsEvent>> RemoveDuplicateEventsAsync(List<AnalyticsEvent> events)
    {
        if (events.Count == 0)
        {
            return events;
        }

        var eventIds = events
            .Select(e => e.Id)
            .Distinct(StringComparer.Ordinal)
            .ToList();

        var existingEventIds = await _context.AnalyticsEvents
            .AsNoTracking()
            .Where(e => eventIds.Contains(e.Id))
            .Select(e => e.Id)
            .ToListAsync();

        var duplicateEventIds = existingEventIds.ToHashSet(StringComparer.Ordinal);
        var purchaseOrderNumbers = events
            .Where(e => e.Type == AnalyticsEventTypes.Purchase && e.OrderNumber is not null)
            .Select(e => e.OrderNumber!)
            .Distinct(StringComparer.Ordinal)
            .ToList();

        var existingPurchaseKeys = purchaseOrderNumbers.Count == 0
            ? []
            : await _context.AnalyticsEvents
                .AsNoTracking()
                .Where(e =>
                    e.Type == AnalyticsEventTypes.Purchase &&
                    e.OrderNumber != null &&
                    purchaseOrderNumbers.Contains(e.OrderNumber))
                .Select(e => new PurchaseKey(e.SiteId, e.OrderNumber!))
                .ToListAsync();

        var duplicatePurchaseKeys = existingPurchaseKeys.ToHashSet();
        var seenEventIds = new HashSet<string>(StringComparer.Ordinal);
        var seenPurchaseKeys = new HashSet<PurchaseKey>();
        var acceptedEvents = new List<AnalyticsEvent>();

        foreach (var analyticsEvent in events)
        {
            if (!seenEventIds.Add(analyticsEvent.Id) || duplicateEventIds.Contains(analyticsEvent.Id))
            {
                continue;
            }

            if (analyticsEvent.Type == AnalyticsEventTypes.Purchase &&
                analyticsEvent.OrderNumber is not null)
            {
                var purchaseKey = new PurchaseKey(analyticsEvent.SiteId, analyticsEvent.OrderNumber);
                if (duplicatePurchaseKeys.Contains(purchaseKey) || !seenPurchaseKeys.Add(purchaseKey))
                {
                    continue;
                }
            }

            acceptedEvents.Add(analyticsEvent);
        }

        return acceptedEvents;
    }

    private static AnalyticsDashboardDto BuildDashboard(
        IReadOnlyCollection<AnalyticsEvent> events,
        AnalyticsPeriodWindow window)
    {
        var visitors = events
            .Where(e => e.Type == AnalyticsEventTypes.Visitor)
            .Select(e => e.VisitorId)
            .Distinct(StringComparer.Ordinal)
            .Count();
        var productViews = CountEvents(events, AnalyticsEventTypes.ProductView);
        var addToCarts = CountEvents(events, AnalyticsEventTypes.AddToCart);
        var checkoutStarts = CountEvents(events, AnalyticsEventTypes.CheckoutStart);
        var purchases = CountEvents(events, AnalyticsEventTypes.Purchase);
        var paymentFailures = CountEvents(events, AnalyticsEventTypes.PaymentFailure);
        var purchaseEvents = events
            .Where(e => e.Type == AnalyticsEventTypes.Purchase)
            .ToList();
        var revenue = purchaseEvents.Sum(e => e.Value ?? 0);
        var unitsSold = purchaseEvents.Sum(e => SumItems(e.Items));
        var topProducts = BuildTopProducts(events);
        var topCategories = BuildTopCategories(topProducts);

        return new AnalyticsDashboardDto
        {
            Visitors = visitors,
            ProductViews = productViews,
            AddToCarts = addToCarts,
            CheckoutStarts = checkoutStarts,
            Purchases = purchases,
            Revenue = revenue,
            AverageOrderValue = SafeDivideMoney(revenue, purchases),
            AddToCartRate = SafeDivide(addToCarts, productViews),
            CheckoutStartRate = SafeDivide(checkoutStarts, addToCarts),
            PurchaseConversionRate = SafeDivide(purchases, visitors),
            CartAbandonmentRate = SafeDivide(Math.Max(addToCarts - purchases, 0), addToCarts),
            PaymentFailures = paymentFailures,
            PaymentFailureRate = SafeDivide(paymentFailures, purchases + paymentFailures),
            UnitsSold = unitsSold,
            Daily = BuildTrendPoints(events, window),
            Funnel = BuildFunnel(visitors, productViews, addToCarts, checkoutStarts, purchases),
            TopProducts = topProducts,
            TopCategories = topCategories,
            Orders = BuildOrders(purchaseEvents),
            PaymentFailureEvents = BuildPaymentFailures(
                events.Where(e => e.Type == AnalyticsEventTypes.PaymentFailure))
        };
    }

    private static List<AnalyticsDailyPointDto> BuildTrendPoints(
        IReadOnlyCollection<AnalyticsEvent> events,
        AnalyticsPeriodWindow window)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);
        var points = new Dictionary<string, AnalyticsDailyPointDto>(StringComparer.Ordinal);

        if (window.Granularity == AnalyticsPeriodGranularity.Month)
        {
            var startMonth = window.StartDate ??
                events
                    .Select(e => DateOnly.FromDateTime(e.OccurredAt.UtcDateTime))
                    .DefaultIfEmpty(today)
                    .Min();

            startMonth = new DateOnly(startMonth.Year, startMonth.Month, 1);
            var currentMonth = new DateOnly(today.Year, today.Month, 1);

            for (var month = startMonth; month <= currentMonth; month = month.AddMonths(1))
            {
                var key = MonthKey(month);
                points[key] = new AnalyticsDailyPointDto
                {
                    DateKey = key,
                    Label = month.ToDateTime(TimeOnly.MinValue).ToString("MMM yyyy", CultureInfo.InvariantCulture)
                };
            }
        }
        else
        {
            var startDate = window.StartDate ?? today.AddDays(-6);

            for (var date = startDate; date <= today; date = date.AddDays(1))
            {
                var key = DateKey(date);
                points[key] = new AnalyticsDailyPointDto
                {
                    DateKey = key,
                    Label = date.ToDateTime(TimeOnly.MinValue).ToString("MMM d", CultureInfo.InvariantCulture)
                };
            }
        }

        foreach (var analyticsEvent in events)
        {
            var eventDate = DateOnly.FromDateTime(analyticsEvent.OccurredAt.UtcDateTime);
            var key = window.Granularity == AnalyticsPeriodGranularity.Month
                ? MonthKey(eventDate)
                : DateKey(eventDate);

            if (!points.TryGetValue(key, out var point))
            {
                continue;
            }

            switch (analyticsEvent.Type)
            {
                case AnalyticsEventTypes.Visitor:
                    point.Visitors += 1;
                    break;
                case AnalyticsEventTypes.ProductView:
                    point.ProductViews += 1;
                    break;
                case AnalyticsEventTypes.AddToCart:
                    point.AddToCarts += 1;
                    break;
                case AnalyticsEventTypes.CheckoutStart:
                    point.CheckoutStarts += 1;
                    break;
                case AnalyticsEventTypes.Purchase:
                    point.Purchases += 1;
                    point.Revenue += analyticsEvent.Value ?? 0;
                    break;
                case AnalyticsEventTypes.PaymentFailure:
                    point.PaymentFailures += 1;
                    break;
            }
        }

        return points.Values.ToList();
    }

    private static List<AnalyticsFunnelStepDto> BuildFunnel(
        int visitors,
        int productViews,
        int addToCarts,
        int checkoutStarts,
        int purchases)
    {
        var steps = new List<AnalyticsFunnelStepDto>
        {
            new() { Label = "Visitors", Value = visitors },
            new() { Label = "Product views", Value = productViews },
            new() { Label = "Add to cart", Value = addToCarts },
            new() { Label = "Checkout started", Value = checkoutStarts },
            new() { Label = "Purchases", Value = purchases }
        };

        for (var index = 0; index < steps.Count; index += 1)
        {
            steps[index].RateFromPrevious = index == 0
                ? 1
                : SafeDivide(steps[index].Value, steps[index - 1].Value);
            steps[index].RateFromVisitors = SafeDivide(steps[index].Value, visitors);
        }

        return steps;
    }

    private static List<AnalyticsTopProductDto> BuildTopProducts(IReadOnlyCollection<AnalyticsEvent> events)
    {
        var products = new Dictionary<int, AnalyticsTopProductDto>();

        foreach (var analyticsEvent in events)
        {
            if (analyticsEvent.Type is AnalyticsEventTypes.ProductView or AnalyticsEventTypes.AddToCart)
            {
                var product = ProductSummaryFromEvent(analyticsEvent);
                if (product is null)
                {
                    continue;
                }

                var summary = GetProductSummary(
                    products,
                    product.ProductId,
                    product.ProductName,
                    product.CategoryName);

                if (analyticsEvent.Type == AnalyticsEventTypes.ProductView)
                {
                    summary.Views += 1;
                }
                else
                {
                    var quantity = analyticsEvent.Quantity.GetValueOrDefault();
                    summary.AddToCarts += quantity > 0 ? quantity : 1;
                }
            }

            if (analyticsEvent.Type == AnalyticsEventTypes.Purchase)
            {
                foreach (var item in analyticsEvent.Items)
                {
                    var summary = GetProductSummary(
                        products,
                        item.ProductId,
                        item.ProductName,
                        item.CategoryName);

                    summary.UnitsSold += item.Quantity;
                    summary.Revenue += item.Price * item.Quantity;
                }
            }
        }

        return products.Values
            .Select(product =>
            {
                product.ConversionRate = SafeDivide(product.UnitsSold, product.Views);
                return product;
            })
            .OrderByDescending(product => product.Revenue)
            .ThenByDescending(product => product.Views)
            .Take(8)
            .ToList();
    }

    private static List<AnalyticsTopCategoryDto> BuildTopCategories(IEnumerable<AnalyticsTopProductDto> products)
    {
        var categories = new Dictionary<string, AnalyticsTopCategoryDto>(StringComparer.Ordinal);

        foreach (var product in products)
        {
            if (!categories.TryGetValue(product.CategoryName, out var category))
            {
                category = new AnalyticsTopCategoryDto
                {
                    CategoryName = product.CategoryName
                };
                categories[product.CategoryName] = category;
            }

            category.Views += product.Views;
            category.AddToCarts += product.AddToCarts;
            category.UnitsSold += product.UnitsSold;
            category.Revenue += product.Revenue;
            category.ConversionRate = SafeDivide(category.UnitsSold, category.Views);
        }

        return categories.Values
            .OrderByDescending(category => category.Revenue)
            .ThenByDescending(category => category.Views)
            .ToList();
    }

    private static List<AnalyticsOrderSummaryDto> BuildOrders(IEnumerable<AnalyticsEvent> events)
    {
        return events
            .OrderByDescending(e => e.OccurredAt)
            .Take(10)
            .Select(e => new AnalyticsOrderSummaryDto
            {
                OrderNumber = e.OrderNumber ?? e.Id,
                OccurredAt = ToIsoString(e.OccurredAt),
                Items = ToItemDtos(e.Items),
                Units = SumItems(e.Items),
                Revenue = e.Value ?? 0
            })
            .ToList();
    }

    private static List<AnalyticsPaymentFailureSummaryDto> BuildPaymentFailures(IEnumerable<AnalyticsEvent> events)
    {
        return events
            .OrderByDescending(e => e.OccurredAt)
            .Take(12)
            .Select(e => new AnalyticsPaymentFailureSummaryDto
            {
                Id = e.Id,
                OccurredAt = ToIsoString(e.OccurredAt),
                Amount = e.Value ?? 0,
                Reason = e.FailureReason ?? DefaultFailureReason,
                Items = ToItemDtos(e.Items)
            })
            .ToList();
    }

    private static AnalyticsTopProductDto GetProductSummary(
        Dictionary<int, AnalyticsTopProductDto> products,
        int productId,
        string productName,
        string categoryName)
    {
        if (products.TryGetValue(productId, out var existing))
        {
            return existing;
        }

        var next = new AnalyticsTopProductDto
        {
            ProductId = productId,
            ProductName = productName,
            CategoryName = string.IsNullOrWhiteSpace(categoryName) ? "Uncategorized" : categoryName
        };

        products[productId] = next;
        return next;
    }

    private static ProductSummary? ProductSummaryFromEvent(AnalyticsEvent analyticsEvent)
    {
        if (!analyticsEvent.ProductId.HasValue ||
            analyticsEvent.ProductId.Value == 0 ||
            string.IsNullOrWhiteSpace(analyticsEvent.ProductName))
        {
            return null;
        }

        return new ProductSummary(
            analyticsEvent.ProductId.Value,
            analyticsEvent.ProductName,
            analyticsEvent.CategoryName ?? "Uncategorized");
    }

    private static List<AnalyticsEventItem> GetItems(JsonElement eventElement)
    {
        if (!TryGetProperty(eventElement, "items", out var itemsElement) ||
            itemsElement.ValueKind != JsonValueKind.Array)
        {
            return [];
        }

        var items = new List<AnalyticsEventItem>();
        foreach (var itemElement in itemsElement.EnumerateArray())
        {
            if (itemElement.ValueKind != JsonValueKind.Object)
            {
                continue;
            }

            items.Add(new AnalyticsEventItem
            {
                ProductId = GetInt(itemElement, "productId") ?? 0,
                ProductName = GetString(itemElement, "productName", 256) ?? string.Empty,
                CategoryName = GetString(itemElement, "categoryName", 128) ?? "Uncategorized",
                Price = GetDecimal(itemElement, "price") ?? 0,
                Quantity = GetInt(itemElement, "quantity") ?? 0
            });
        }

        return items;
    }

    private static List<JsonElement> GetPayloadEvents(JsonElement body)
    {
        if (body.ValueKind is JsonValueKind.Undefined or JsonValueKind.Null)
        {
            return [];
        }

        if (body.ValueKind == JsonValueKind.Object &&
            TryGetProperty(body, "events", out var eventsElement) &&
            eventsElement.ValueKind == JsonValueKind.Array)
        {
            return eventsElement.EnumerateArray()
                .Where(element => element.ValueKind == JsonValueKind.Object)
                .ToList();
        }

        if (body.ValueKind == JsonValueKind.Array)
        {
            return body.EnumerateArray()
                .Where(element => element.ValueKind == JsonValueKind.Object)
                .ToList();
        }

        return body.ValueKind == JsonValueKind.Object
            ? [body]
            : [];
    }

    private static List<AnalyticsItemDto> ToItemDtos(IEnumerable<AnalyticsEventItem> items)
    {
        return items
            .Select(item => new AnalyticsItemDto
            {
                ProductId = item.ProductId,
                ProductName = item.ProductName,
                CategoryName = item.CategoryName,
                Price = item.Price,
                Quantity = item.Quantity
            })
            .ToList();
    }

    private static int CountEvents(IEnumerable<AnalyticsEvent> events, string type)
    {
        return events.Count(e => e.Type == type);
    }

    private static int SumItems(IEnumerable<AnalyticsEventItem> items)
    {
        return items.Sum(item => item.Quantity);
    }

    private static decimal SafeDivideMoney(decimal numerator, int denominator)
    {
        return denominator > 0 ? numerator / denominator : 0;
    }

    private static double SafeDivide(int numerator, int denominator)
    {
        return denominator > 0 ? (double)numerator / denominator : 0;
    }

    private static string? GetString(JsonElement element, string propertyName, int? maxLength = null)
    {
        if (!TryGetProperty(element, propertyName, out var property) ||
            property.ValueKind != JsonValueKind.String)
        {
            return null;
        }

        var value = property.GetString();
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        return maxLength.HasValue && value.Length > maxLength.Value
            ? value[..maxLength.Value]
            : value;
    }

    private static int? GetInt(JsonElement element, string propertyName)
    {
        if (!TryGetProperty(element, propertyName, out var property))
        {
            return null;
        }

        if (property.ValueKind == JsonValueKind.Number &&
            property.TryGetInt32(out var number))
        {
            return number;
        }

        return property.ValueKind == JsonValueKind.String &&
            int.TryParse(property.GetString(), NumberStyles.Integer, CultureInfo.InvariantCulture, out number)
                ? number
                : null;
    }

    private static decimal? GetDecimal(JsonElement element, string propertyName)
    {
        if (!TryGetProperty(element, propertyName, out var property))
        {
            return null;
        }

        if (property.ValueKind == JsonValueKind.Number &&
            property.TryGetDecimal(out var number))
        {
            return number;
        }

        return property.ValueKind == JsonValueKind.String &&
            decimal.TryParse(property.GetString(), NumberStyles.Number, CultureInfo.InvariantCulture, out number)
                ? number
                : null;
    }

    private static DateTimeOffset? GetDateTimeOffset(JsonElement element, string propertyName)
    {
        var value = GetString(element, propertyName);
        if (value is null)
        {
            return null;
        }

        return DateTimeOffset.TryParse(
            value,
            CultureInfo.InvariantCulture,
            DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
            out var date)
                ? date
                : null;
    }

    private static bool TryGetProperty(JsonElement element, string propertyName, out JsonElement value)
    {
        if (element.ValueKind == JsonValueKind.Object &&
            element.TryGetProperty(propertyName, out value))
        {
            return true;
        }

        if (element.ValueKind == JsonValueKind.Object)
        {
            foreach (var property in element.EnumerateObject())
            {
                if (string.Equals(property.Name, propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    value = property.Value;
                    return true;
                }
            }
        }

        value = default;
        return false;
    }

    private static string? NormalizeSite(string? siteCode)
    {
        return string.IsNullOrWhiteSpace(siteCode)
            ? null
            : siteCode.Trim().ToLowerInvariant();
    }

    private static AnalyticsPeriodWindow CreatePeriodWindow(string? period)
    {
        var normalizedPeriod = AnalyticsDashboardPeriods.Normalize(period);
        var today = DateOnly.FromDateTime(DateTime.UtcNow);

        return normalizedPeriod switch
        {
            AnalyticsDashboardPeriods.PastMonth => new AnalyticsPeriodWindow(
                normalizedPeriod,
                today.AddDays(-29),
                AnalyticsPeriodGranularity.Day),
            AnalyticsDashboardPeriods.PastYear => new AnalyticsPeriodWindow(
                normalizedPeriod,
                new DateOnly(today.Year, today.Month, 1).AddMonths(-11),
                AnalyticsPeriodGranularity.Month),
            AnalyticsDashboardPeriods.FromStart => new AnalyticsPeriodWindow(
                normalizedPeriod,
                null,
                AnalyticsPeriodGranularity.Month),
            _ => new AnalyticsPeriodWindow(
                AnalyticsDashboardPeriods.Last7Days,
                today.AddDays(-6),
                AnalyticsPeriodGranularity.Day)
        };
    }

    private static string CreateId(string prefix)
    {
        return $"{prefix}-{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}-{Guid.NewGuid():N}";
    }

    private static string DateKey(DateOnly date)
    {
        return date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }

    private static string MonthKey(DateOnly date)
    {
        return date.ToString("yyyy-MM", CultureInfo.InvariantCulture);
    }

    private static string ToIsoString(DateTimeOffset date)
    {
        return date
            .ToUniversalTime()
            .ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);
    }

    private sealed record ProductSummary(
        int ProductId,
        string ProductName,
        string CategoryName);

    private sealed record PurchaseKey(int SiteId, string OrderNumber);

    private sealed record AnalyticsPeriodWindow(
        string Period,
        DateOnly? StartDate,
        AnalyticsPeriodGranularity Granularity)
    {
        public DateTimeOffset? StartAtUtc => StartDate is null
            ? null
            : new DateTimeOffset(StartDate.Value.ToDateTime(TimeOnly.MinValue), TimeSpan.Zero);
    }

    private enum AnalyticsPeriodGranularity
    {
        Day,
        Month
    }
}
