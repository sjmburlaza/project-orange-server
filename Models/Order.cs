namespace ProjectOrangeApi.Models;

public class Order
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string OrderNumber { get; set; } = string.Empty;
    public string PaymentStatus { get; set; } = string.Empty;
    public string OrderStatus { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public string RecipientName { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; }
    public string? Barangay { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string DeliveryEstimate { get; set; } = string.Empty;
    public decimal TotalAmount { get; set; }
    public string CheckoutDataJson { get; set; } = "{}";
    public string NextStepsJson { get; set; } = "[]";
    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}
