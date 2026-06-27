namespace ProjectOrangeApi.DTOs;

public static class AnalyticsEventTypes
{
    public const string Visitor = "visitor";
    public const string ProductView = "product_view";
    public const string AddToCart = "add_to_cart";
    public const string CheckoutStart = "checkout_start";
    public const string Purchase = "purchase";
    public const string PaymentFailure = "payment_failure";

    public static readonly ISet<string> All = new HashSet<string>(StringComparer.Ordinal)
    {
        Visitor,
        ProductView,
        AddToCart,
        CheckoutStart,
        Purchase,
        PaymentFailure
    };
}

public static class AnalyticsDashboardPeriods
{
    public const string Last7Days = "last-7-days";
    public const string PastMonth = "past-month";
    public const string PastYear = "past-year";
    public const string FromStart = "from-start";

    public static readonly ISet<string> All = new HashSet<string>(StringComparer.Ordinal)
    {
        Last7Days,
        PastMonth,
        PastYear,
        FromStart
    };

    public static string Normalize(string? period)
    {
        return period is not null && All.Contains(period)
            ? period
            : Last7Days;
    }
}

public class AnalyticsItemDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class AnalyticsEventDto
{
    public string Id { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string OccurredAt { get; set; } = string.Empty;
    public string VisitorId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public int? ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? CategoryName { get; set; }
    public int? Quantity { get; set; }
    public decimal? Value { get; set; }
    public string? OrderNumber { get; set; }
    public string? FailureReason { get; set; }
    public List<AnalyticsItemDto>? Items { get; set; }
}

public class AnalyticsMetricCardDto
{
    public string Label { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Helper { get; set; } = string.Empty;
    public string? Tone { get; set; }
}

public class AnalyticsDailyPointDto
{
    public string DateKey { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public int Visitors { get; set; }
    public int ProductViews { get; set; }
    public int AddToCarts { get; set; }
    public int CheckoutStarts { get; set; }
    public int Purchases { get; set; }
    public decimal Revenue { get; set; }
    public int PaymentFailures { get; set; }
}

public class AnalyticsFunnelStepDto
{
    public string Label { get; set; } = string.Empty;
    public int Value { get; set; }
    public double RateFromPrevious { get; set; }
    public double RateFromVisitors { get; set; }
}

public class AnalyticsTopProductDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public int Views { get; set; }
    public int AddToCarts { get; set; }
    public int UnitsSold { get; set; }
    public decimal Revenue { get; set; }
    public double ConversionRate { get; set; }
}

public class AnalyticsTopCategoryDto
{
    public string CategoryName { get; set; } = string.Empty;
    public int Views { get; set; }
    public int AddToCarts { get; set; }
    public int UnitsSold { get; set; }
    public decimal Revenue { get; set; }
    public double ConversionRate { get; set; }
}

public class AnalyticsOrderSummaryDto
{
    public string OrderNumber { get; set; } = string.Empty;
    public string OccurredAt { get; set; } = string.Empty;
    public List<AnalyticsItemDto> Items { get; set; } = [];
    public int Units { get; set; }
    public decimal Revenue { get; set; }
}

public class AnalyticsPaymentFailureSummaryDto
{
    public string Id { get; set; } = string.Empty;
    public string OccurredAt { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Reason { get; set; } = string.Empty;
    public List<AnalyticsItemDto> Items { get; set; } = [];
}

public class AnalyticsDashboardDto
{
    public int Visitors { get; set; }
    public int ProductViews { get; set; }
    public int AddToCarts { get; set; }
    public int CheckoutStarts { get; set; }
    public int Purchases { get; set; }
    public decimal Revenue { get; set; }
    public decimal AverageOrderValue { get; set; }
    public double AddToCartRate { get; set; }
    public double CheckoutStartRate { get; set; }
    public double PurchaseConversionRate { get; set; }
    public double CartAbandonmentRate { get; set; }
    public int PaymentFailures { get; set; }
    public double PaymentFailureRate { get; set; }
    public int UnitsSold { get; set; }
    public List<AnalyticsDailyPointDto> Daily { get; set; } = [];
    public List<AnalyticsFunnelStepDto> Funnel { get; set; } = [];
    public List<AnalyticsTopProductDto> TopProducts { get; set; } = [];
    public List<AnalyticsTopCategoryDto> TopCategories { get; set; } = [];
    public List<AnalyticsOrderSummaryDto> Orders { get; set; } = [];
    public List<AnalyticsPaymentFailureSummaryDto> PaymentFailureEvents { get; set; } = [];
}
