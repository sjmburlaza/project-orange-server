using System.Text.Json;

namespace ProjectOrangeApi.DTOs;

public class PlaceOrderRequestDto
{
    public CartResponseDto? Cart { get; set; }
    public Dictionary<string, Dictionary<string, JsonElement>>? CheckoutData { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public List<CreateOrderItemDto> Items { get; set; } = new();
}

public class CreateOrderDto : PlaceOrderRequestDto
{
}

public class CreateOrderItemDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class OrderConfirmationDto
{
    public string Id { get; set; } = string.Empty;
    public string OrderNumber { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
    public string OrderStatus { get; set; } = string.Empty;
    public List<OrderConfirmationItemDto> Items { get; set; } = [];
    public OrderShippingAddressDto ShippingAddress { get; set; } = new();
    public string DeliveryEstimate { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public List<string> NextSteps { get; set; } = [];
    public DateTime PlacedAt { get; set; }
}

public class OrderConfirmationItemDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public List<string> ItemSpecs { get; set; } = [];
}

public class OrderShippingAddressDto
{
    public string RecipientName { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; }
    public string? Barangay { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}
