using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class OrderService
{
    private const string PaymentStatusPaid = "paid";
    private const string PaymentStatusPending = "pending";
    private const string OrderStatusConfirmed = "confirmed";
    private const string OrderStatusPendingPayment = "pending_payment";

    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public OrderService(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    public async Task<List<OrderConfirmationDto>> GetOrdersAsync()
    {
        var orders = await LoadOrders()
            .OrderByDescending(order => order.CreatedAt)
            .ToListAsync();

        return orders.Select(MapToConfirmation).ToList();
    }

    public async Task<OrderConfirmationDto?> GetOrderAsync(string orderNumber)
    {
        var order = await FindOrderAsync(orderNumber);

        return order is null ? null : MapToConfirmation(order);
    }

    public async Task<OrderConfirmationDto?> LookupOrderAsync(string orderNumber, string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return null;
        }

        var order = await FindOrderAsync(orderNumber);

        if (order is null || !EmailMatches(order.CustomerEmail, email))
        {
            return null;
        }

        return MapToConfirmation(order);
    }

    private async Task<Order?> FindOrderAsync(string orderNumber)
    {
        if (string.IsNullOrWhiteSpace(orderNumber))
        {
            return null;
        }

        var normalizedOrderNumber = orderNumber.Trim();
        var query = LoadOrders()
            .Where(order => order.OrderNumber == normalizedOrderNumber);

        if (int.TryParse(normalizedOrderNumber, out var orderId))
        {
            query = LoadOrders()
                .Where(order =>
                    order.OrderNumber == normalizedOrderNumber ||
                    order.Id == orderId);
        }

        var order = await query.FirstOrDefaultAsync();

        return order;
    }

    public async Task<OrderConfirmationDto> PlaceOrderAsync(PlaceOrderRequestDto request)
    {
        var checkoutData = new CheckoutDataResolver(request.CheckoutData);
        var paymentMethod = checkoutData.ReadPaymentString("paymentMethod") ?? "card";
        var shippingMethod = checkoutData.ReadShippingString("shippingMethod") ?? "standard";
        var paymentStatus = GetPaymentStatus(paymentMethod);
        var orderStatus = GetOrderStatus(paymentStatus);
        var shippingAddress = GetShippingAddress(request, checkoutData);
        var customerEmail = GetCustomerEmail(request, checkoutData);
        var customerName = GetCustomerName(request, checkoutData, shippingAddress.RecipientName);
        var nextSteps = GetNextSteps(customerEmail, paymentStatus);

        await using var transaction = await _context.Database.BeginTransactionAsync();

        var itemSnapshots = await GetOrderItemSnapshotsAsync(request);
        var orderNumber = await CreateOrderNumberAsync();

        var order = new Order
        {
            SiteId = _siteContext.SiteId,
            OrderNumber = orderNumber,
            PaymentStatus = paymentStatus,
            OrderStatus = orderStatus,
            CustomerName = customerName,
            CustomerEmail = customerEmail,
            RecipientName = shippingAddress.RecipientName,
            MobileNumber = shippingAddress.MobileNumber,
            AddressLine1 = shippingAddress.AddressLine1,
            AddressLine2 = shippingAddress.AddressLine2,
            Barangay = shippingAddress.Barangay,
            City = shippingAddress.City,
            Region = shippingAddress.Region,
            PostalCode = shippingAddress.PostalCode,
            Country = shippingAddress.Country,
            DeliveryEstimate = GetDeliveryEstimate(shippingMethod),
            TotalAmount = GetTotalAmount(request.Cart, itemSnapshots),
            CheckoutDataJson = SerializeCheckoutData(request.CheckoutData),
            NextStepsJson = SerializeList(nextSteps),
            CreatedAt = DateTime.UtcNow,
            Items = itemSnapshots.Select(snapshot => new OrderItem
            {
                ProductId = snapshot.ProductId,
                ProductName = snapshot.ProductName,
                Price = snapshot.Price,
                Quantity = snapshot.Quantity,
                ImageUrl = snapshot.ImageUrl,
                CategoryName = snapshot.CategoryName,
                ItemSpecsJson = SerializeItemSpecs(snapshot.ItemSpecs),
                AddonsJson = SerializeAddons(snapshot.Addons)
            }).ToList()
        };

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        await transaction.CommitAsync();

        return MapToConfirmation(order);
    }

    private IQueryable<Order> LoadOrders()
    {
        return _context.Orders
            .Where(order => order.SiteId == _siteContext.SiteId)
            .Include(order => order.Items)
                .ThenInclude(item => item.Product)
                    .ThenInclude(product => product.Category)
            .Include(order => order.Items)
                .ThenInclude(item => item.Product)
                    .ThenInclude(product => product.ItemSpecs);
    }

    private async Task<List<OrderItemSnapshot>> GetOrderItemSnapshotsAsync(PlaceOrderRequestDto request)
    {
        var cartEntries = request.Cart?.Entries ?? [];

        if (cartEntries.Count > 0)
        {
            return await GetCartItemSnapshotsAsync(cartEntries);
        }

        var legacyItems = request.Items ?? [];

        if (legacyItems.Count > 0)
        {
            return await GetLegacyItemSnapshotsAsync(legacyItems);
        }

        throw OrderValidationException.InvalidRequest("Order must contain at least one item.");
    }

    private async Task<List<OrderItemSnapshot>> GetCartItemSnapshotsAsync(List<CartItemDto> cartEntries)
    {
        var productIds = cartEntries.Select(item => item.ProductId).Distinct().ToList();
        var products = await LoadProducts(productIds).ToListAsync();
        var snapshots = new List<OrderItemSnapshot>();

        foreach (var item in cartEntries)
        {
            ValidateQuantity(item.Quantity);

            var product = GetProductOrThrow(products, item.ProductId);
            ValidateStock(product, item.Quantity);
            product.StockQuantity -= item.Quantity;

            snapshots.Add(new OrderItemSnapshot(
                item.ProductId,
                string.IsNullOrWhiteSpace(item.ProductName) ? product.Name : item.ProductName,
                item.Price,
                item.Quantity,
                string.IsNullOrWhiteSpace(item.ImageUrl) ? product.ImageUrl : item.ImageUrl,
                string.IsNullOrWhiteSpace(item.CategoryName) ? product.Category?.Name ?? string.Empty : item.CategoryName,
                GetOrderItemSpecs(item.ItemSpecs, product),
                GetOrderItemAddons(item.Addons)));
        }

        return snapshots;
    }

    private async Task<List<OrderItemSnapshot>> GetLegacyItemSnapshotsAsync(List<CreateOrderItemDto> legacyItems)
    {
        var productIds = legacyItems.Select(item => item.ProductId).Distinct().ToList();
        var products = await LoadProducts(productIds).ToListAsync();
        var snapshots = new List<OrderItemSnapshot>();

        foreach (var item in legacyItems)
        {
            ValidateQuantity(item.Quantity);

            var product = GetProductOrThrow(products, item.ProductId);
            ValidateStock(product, item.Quantity);
            product.StockQuantity -= item.Quantity;

            snapshots.Add(new OrderItemSnapshot(
                product.Id,
                product.Name,
                product.Price,
                item.Quantity,
                product.ImageUrl,
                product.Category?.Name ?? string.Empty,
                GetProductSpecs(product),
                []));
        }

        return snapshots;
    }

    private IQueryable<Product> LoadProducts(List<int> productIds)
    {
        return _context.Products
            .Include(product => product.Category)
            .Include(product => product.ItemSpecs)
            .Where(product =>
                product.SiteId == _siteContext.SiteId &&
                productIds.Contains(product.Id));
    }

    private static Product GetProductOrThrow(List<Product> products, int productId)
    {
        return products.FirstOrDefault(product => product.Id == productId)
            ?? throw OrderValidationException.ProductNotFound(productId);
    }

    private static void ValidateQuantity(int quantity)
    {
        if (quantity <= 0)
        {
            throw OrderValidationException.InvalidRequest("Quantity must be greater than zero.");
        }
    }

    private static void ValidateStock(Product product, int quantity)
    {
        if (product.StockQuantity < quantity)
        {
            throw OrderValidationException.InsufficientStock(product.Name);
        }
    }

    private static List<ProductSpecDto> GetOrderItemSpecs(List<ProductSpecDto>? itemSpecs, Product product)
    {
        var specs = (itemSpecs ?? [])
            .Where(spec => !string.IsNullOrWhiteSpace(spec.Name) || !string.IsNullOrWhiteSpace(spec.Value))
            .Select(spec => new ProductSpecDto
            {
                Name = spec.Name,
                Value = spec.Value
            })
            .ToList();

        return specs.Count > 0 ? specs : GetProductSpecs(product);
    }

    private static List<ProductSpecDto> GetProductSpecs(Product product)
    {
        return product.ItemSpecs
            .Select(spec => new ProductSpecDto
            {
                Name = spec.Name,
                Value = spec.Value
            })
            .Where(spec => !string.IsNullOrWhiteSpace(spec.Name) || !string.IsNullOrWhiteSpace(spec.Value))
            .ToList();
    }

    private static List<AddonDto> GetOrderItemAddons(List<AddonDto>? addons)
    {
        return (addons ?? [])
            .Where(addon => addon.IsAdded)
            .Select(addon => new AddonDto
            {
                Id = addon.Id,
                Name = addon.Name,
                Title = addon.Title,
                Description = addon.Description,
                ImageUrl = addon.ImageUrl,
                Amount = addon.Amount,
                BillingFrequency = addon.BillingFrequency,
                SelectedOptionCode = addon.SelectedOptionCode,
                SelectedOptionName = addon.SelectedOptionName,
                IsAdded = addon.IsAdded
            })
            .ToList();
    }

    private async Task<string> CreateOrderNumberAsync()
    {
        var date = DateTime.UtcNow;

        for (var attempt = 0; attempt < 5; attempt++)
        {
            var random = Random.Shared.Next(1000, 10000);
            var orderNumber = $"OR-{date:yyyyMMdd}-{random}";
            var exists = await _context.Orders.AnyAsync(order =>
                order.SiteId == _siteContext.SiteId &&
                order.OrderNumber == orderNumber);

            if (!exists)
            {
                return orderNumber;
            }
        }

        return $"OR-{date:yyyyMMdd}-{Guid.NewGuid().ToString("N")[..8].ToUpperInvariant()}";
    }

    private static string GetPaymentStatus(string paymentMethod)
    {
        return string.Equals(paymentMethod, "cod", StringComparison.OrdinalIgnoreCase)
            ? PaymentStatusPending
            : PaymentStatusPaid;
    }

    private static string GetOrderStatus(string paymentStatus)
    {
        return paymentStatus == PaymentStatusPaid
            ? OrderStatusConfirmed
            : OrderStatusPendingPayment;
    }

    private static string GetDeliveryEstimate(string shippingMethod)
    {
        return shippingMethod.ToLowerInvariant() switch
        {
            "express" => "1-2 business days",
            "free" => "5-7 business days",
            _ => "3-5 business days"
        };
    }

    private OrderShippingAddressDto GetShippingAddress(
        PlaceOrderRequestDto request,
        CheckoutDataResolver checkoutData)
    {
        var firstName = checkoutData.ReadCustomerString("firstName");
        var lastName = checkoutData.ReadCustomerString("lastName");
        var recipientName = string.Join(" ", new[] { firstName, lastName }
            .Where(value => !string.IsNullOrWhiteSpace(value)));

        if (string.IsNullOrWhiteSpace(recipientName))
        {
            recipientName =
                checkoutData.ReadDeliveryString("recipientName", "fullName", "name") ??
                request.CustomerName;
        }

        return new OrderShippingAddressDto
        {
            RecipientName = string.IsNullOrWhiteSpace(recipientName) ? "Orange Customer" : recipientName,
            MobileNumber = checkoutData.ReadCustomerString("mobileNumber", "phoneNumber", "phone") ?? "09170000000",
            AddressLine1 = checkoutData.ReadDeliveryString("addressLine1", "street") ?? "123 Orange Avenue",
            AddressLine2 = EmptyToNull(checkoutData.ReadDeliveryString("addressLine2", "apartment", "unit")),
            Barangay = EmptyToNull(checkoutData.ReadDeliveryString("barangay")),
            City = EmptyToNull(checkoutData.ReadDeliveryString("city")),
            Region = EmptyToNull(checkoutData.ReadDeliveryString("region", "state", "province", "prefecture")),
            PostalCode = checkoutData.ReadDeliveryString("postalCode", "zipCode", "zip") ?? "1000",
            Country = checkoutData.ReadDeliveryString("country") ?? _siteContext.Current.CountryName
        };
    }

    private static string GetCustomerName(
        PlaceOrderRequestDto request,
        CheckoutDataResolver checkoutData,
        string recipientName)
    {
        if (!string.IsNullOrWhiteSpace(request.CustomerName))
        {
            return request.CustomerName;
        }

        var firstName = checkoutData.ReadCustomerString("firstName");
        var lastName = checkoutData.ReadCustomerString("lastName");
        var fullName = string.Join(" ", new[] { firstName, lastName }
            .Where(value => !string.IsNullOrWhiteSpace(value)));

        return string.IsNullOrWhiteSpace(fullName)
            ? checkoutData.ReadCustomerString("fullName", "name") ?? recipientName
            : fullName;
    }

    private static string GetCustomerEmail(
        PlaceOrderRequestDto request,
        CheckoutDataResolver checkoutData)
    {
        if (!string.IsNullOrWhiteSpace(request.CustomerEmail))
        {
            return request.CustomerEmail;
        }

        return checkoutData.ReadCustomerString("email", "deliveryEmail") ?? string.Empty;
    }

    private static decimal GetTotalAmount(CartResponseDto? cart, IReadOnlyList<OrderItemSnapshot> items)
    {
        var cartTotal = cart?.CartSummary
            .FirstOrDefault(item => string.Equals(item.Name, "total", StringComparison.OrdinalIgnoreCase))
            ?.Amount;

        if (cartTotal.HasValue)
        {
            return cartTotal.Value;
        }

        return items.Sum(item => item.Price * item.Quantity);
    }

    private static List<string> GetNextSteps(string email, string paymentStatus)
    {
        var paymentMessage =
            paymentStatus == PaymentStatusPaid
                ? "Your payment has been processed successfully."
                : "Payment will be collected when your order is delivered.";

        return
        [
            paymentMessage,
            string.IsNullOrWhiteSpace(email)
                ? "We sent the order details to your email."
                : $"We sent the order details to {email}.",
            "We will notify you when the order starts processing."
        ];
    }

    private static OrderConfirmationDto MapToConfirmation(Order order)
    {
        var orderNumber = string.IsNullOrWhiteSpace(order.OrderNumber)
            ? CreateLegacyOrderNumber(order)
            : order.OrderNumber;
        var paymentStatus = string.IsNullOrWhiteSpace(order.PaymentStatus)
            ? PaymentStatusPaid
            : order.PaymentStatus;
        var orderStatus = string.IsNullOrWhiteSpace(order.OrderStatus)
            ? GetOrderStatus(paymentStatus)
            : order.OrderStatus;
        var nextSteps = DeserializeList(order.NextStepsJson);

        if (nextSteps.Count == 0)
        {
            nextSteps = GetNextSteps(order.CustomerEmail, paymentStatus);
        }

        return new OrderConfirmationDto
        {
            Id = orderNumber,
            OrderNumber = orderNumber,
            CustomerEmail = EmptyToNull(order.CustomerEmail),
            PaymentStatus = paymentStatus,
            OrderStatus = orderStatus,
            Items = order.Items.Select(MapItemToConfirmation).ToList(),
            ShippingAddress = new OrderShippingAddressDto
            {
                RecipientName = FirstNonEmpty(order.RecipientName, order.CustomerName, "Orange Customer"),
                MobileNumber = FirstNonEmpty(order.MobileNumber, "09170000000"),
                AddressLine1 = FirstNonEmpty(order.AddressLine1, "123 Orange Avenue"),
                AddressLine2 = EmptyToNull(order.AddressLine2),
                Barangay = EmptyToNull(order.Barangay),
                City = EmptyToNull(order.City),
                Region = EmptyToNull(order.Region),
                PostalCode = FirstNonEmpty(order.PostalCode, "1000"),
                Country = FirstNonEmpty(order.Country, "Philippines")
            },
            DeliveryEstimate = FirstNonEmpty(order.DeliveryEstimate, "3-5 business days"),
            SubtotalAmount = GetSubtotalAmount(order),
            TotalAmount = order.TotalAmount,
            NextSteps = nextSteps,
            PlacedAt = order.CreatedAt
        };
    }

    private static OrderProductItemDto MapItemToConfirmation(OrderItem item)
    {
        var product = item.Product;
        var specs = DeserializeItemSpecs(item.ItemSpecsJson, product);
        var addons = DeserializeAddons(item.AddonsJson);

        return new OrderProductItemDto
        {
            ProductId = item.ProductId,
            ProductName = FirstNonEmpty(item.ProductName, product?.Name, "Unknown product"),
            Price = item.Price,
            Quantity = item.Quantity,
            ImageUrl = FirstNonEmpty(item.ImageUrl, product?.ImageUrl, string.Empty),
            CategoryName = FirstNonEmpty(item.CategoryName, product?.Category?.Name, string.Empty),
            ItemSpecs = specs,
            Addons = addons.Count == 0 ? null : addons
        };
    }

    private static string CreateLegacyOrderNumber(Order order)
    {
        var createdAt = order.CreatedAt == default ? DateTime.UtcNow : order.CreatedAt;
        return $"OR-{createdAt:yyyyMMdd}-{order.Id:0000}";
    }

    private static decimal GetSubtotalAmount(Order order)
    {
        return order.Items.Sum(item => item.Price * item.Quantity);
    }

    private static string SerializeCheckoutData(
        Dictionary<string, Dictionary<string, JsonElement>>? checkoutData)
    {
        return JsonSerializer.Serialize(checkoutData ?? []);
    }

    private static string SerializeList(List<string> values)
    {
        return JsonSerializer.Serialize(values);
    }

    private static string SerializeItemSpecs(List<ProductSpecDto> values)
    {
        return JsonSerializer.Serialize(values);
    }

    private static string SerializeAddons(List<AddonDto> values)
    {
        return JsonSerializer.Serialize(values);
    }

    private static List<string> DeserializeList(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            return JsonSerializer.Deserialize<List<string>>(json) ?? [];
        }
        catch (JsonException)
        {
            return [];
        }
    }

    private static List<ProductSpecDto> DeserializeItemSpecs(string? json, Product? product)
    {
        var specs = DeserializeItemSpecSnapshot(json);

        if (specs.Count > 0 && product?.ItemSpecs is not null)
        {
            return AddProductSpecNames(specs, product);
        }

        if (specs.Count > 0 || product?.ItemSpecs is null)
        {
            return specs;
        }

        return product.ItemSpecs
            .Select(spec => new ProductSpecDto
            {
                Name = spec.Name,
                Value = spec.Value
            })
            .Where(spec => !string.IsNullOrWhiteSpace(spec.Name) || !string.IsNullOrWhiteSpace(spec.Value))
            .ToList();
    }

    private static List<ProductSpecDto> AddProductSpecNames(List<ProductSpecDto> specs, Product product)
    {
        foreach (var spec in specs.Where(spec =>
            string.IsNullOrWhiteSpace(spec.Name) &&
            !string.IsNullOrWhiteSpace(spec.Value)))
        {
            var productSpec = product.ItemSpecs.FirstOrDefault(candidate =>
                string.Equals(candidate.Value, spec.Value, StringComparison.OrdinalIgnoreCase));

            if (productSpec is not null)
            {
                spec.Name = productSpec.Name;
            }
        }

        return specs;
    }

    private static List<ProductSpecDto> DeserializeItemSpecSnapshot(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            using var document = JsonDocument.Parse(json);

            if (document.RootElement.ValueKind != JsonValueKind.Array)
            {
                return [];
            }

            var specs = new List<ProductSpecDto>();

            foreach (var element in document.RootElement.EnumerateArray())
            {
                if (element.ValueKind == JsonValueKind.String)
                {
                    var value = element.GetString();

                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        specs.Add(new ProductSpecDto { Value = value });
                    }

                    continue;
                }

                if (element.ValueKind != JsonValueKind.Object)
                {
                    continue;
                }

                var spec = element.Deserialize<ProductSpecDto>();

                if (spec is not null &&
                    (!string.IsNullOrWhiteSpace(spec.Name) || !string.IsNullOrWhiteSpace(spec.Value)))
                {
                    specs.Add(spec);
                }
            }

            return specs;
        }
        catch (JsonException)
        {
            return [];
        }
    }

    private static List<AddonDto> DeserializeAddons(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            return (JsonSerializer.Deserialize<List<AddonDto>>(json) ?? [])
                .Where(addon => addon.IsAdded)
                .Select(addon => new AddonDto
                {
                    Id = addon.Id,
                    Name = addon.Name,
                    Title = addon.Title,
                    Description = addon.Description,
                    ImageUrl = addon.ImageUrl,
                    Amount = addon.Amount,
                    BillingFrequency = addon.BillingFrequency,
                    SelectedOptionCode = addon.SelectedOptionCode,
                    SelectedOptionName = addon.SelectedOptionName,
                    IsAdded = addon.IsAdded
                })
                .ToList();
        }
        catch (JsonException)
        {
            return [];
        }
    }

    private static string FirstNonEmpty(params string?[] values)
    {
        return values.FirstOrDefault(value => !string.IsNullOrWhiteSpace(value)) ?? string.Empty;
    }

    private static string? EmptyToNull(string? value)
    {
        return string.IsNullOrWhiteSpace(value) ? null : value;
    }

    private static bool EmailMatches(string orderEmail, string lookupEmail)
    {
        return !string.IsNullOrWhiteSpace(orderEmail) &&
            string.Equals(
                orderEmail.Trim(),
                lookupEmail.Trim(),
                StringComparison.OrdinalIgnoreCase);
    }

    private sealed class CheckoutDataResolver
    {
        private readonly List<CheckoutFieldValue> _fields = [];

        public CheckoutDataResolver(Dictionary<string, Dictionary<string, JsonElement>>? checkoutData)
        {
            if (checkoutData is null)
            {
                return;
            }

            foreach (var step in checkoutData)
            {
                foreach (var field in step.Value)
                {
                    CollectField(
                        step.Key,
                        [step.Key, field.Key],
                        field.Key,
                        field.Value);
                }
            }
        }

        public string? ReadCustomerString(params string[] keys)
        {
            return ReadStepString("customer", keys) ?? ReadAnyString(keys);
        }

        public string? ReadDeliveryString(params string[] keys)
        {
            return ReadGroupString("deliveryAddress", keys) ??
                ReadStepString("delivery", keys) ??
                ReadStepString("shippingAddress", keys) ??
                ReadAnyString(keys);
        }

        public string? ReadPaymentString(params string[] keys)
        {
            return ReadStepString("payment", keys) ?? ReadAnyString(keys);
        }

        public string? ReadShippingString(params string[] keys)
        {
            return ReadStepString("shipping", keys) ?? ReadAnyString(keys);
        }

        private string? ReadStepString(string stepId, params string[] keys)
        {
            return ReadString(_fields.Where(field =>
                string.Equals(field.StepId, stepId, StringComparison.OrdinalIgnoreCase) &&
                MatchesAny(field.Key, keys)));
        }

        private string? ReadGroupString(string groupName, params string[] keys)
        {
            return ReadString(_fields.Where(field =>
                field.Path.Any(pathPart => string.Equals(pathPart, groupName, StringComparison.OrdinalIgnoreCase)) &&
                MatchesAny(field.Key, keys)));
        }

        private string? ReadAnyString(params string[] keys)
        {
            return ReadString(_fields.Where(field => MatchesAny(field.Key, keys)));
        }

        private static string? ReadString(IEnumerable<CheckoutFieldValue> fields)
        {
            foreach (var field in fields)
            {
                var value = GetScalarString(field.Value);

                if (!string.IsNullOrWhiteSpace(value))
                {
                    return value;
                }
            }

            return null;
        }

        private void CollectField(string stepId, List<string> path, string key, JsonElement value)
        {
            _fields.Add(new CheckoutFieldValue(stepId, key, [.. path], value));

            if (value.ValueKind != JsonValueKind.Object)
            {
                return;
            }

            foreach (var property in value.EnumerateObject())
            {
                CollectField(
                    stepId,
                    [.. path, property.Name],
                    property.Name,
                    property.Value);
            }
        }

        private static bool MatchesAny(string key, string[] keys)
        {
            return keys.Any(candidate => string.Equals(key, candidate, StringComparison.OrdinalIgnoreCase));
        }

        private static string? GetScalarString(JsonElement value)
        {
            return value.ValueKind switch
            {
                JsonValueKind.String => value.GetString(),
                JsonValueKind.Number => value.GetRawText(),
                JsonValueKind.True => bool.TrueString,
                JsonValueKind.False => bool.FalseString,
                _ => null
            };
        }
    }

    private sealed record CheckoutFieldValue(
        string StepId,
        string Key,
        IReadOnlyList<string> Path,
        JsonElement Value);

    private sealed record OrderItemSnapshot(
        int ProductId,
        string ProductName,
        decimal Price,
        int Quantity,
        string ImageUrl,
        string CategoryName,
        List<ProductSpecDto> ItemSpecs,
        List<AddonDto> Addons);
}
