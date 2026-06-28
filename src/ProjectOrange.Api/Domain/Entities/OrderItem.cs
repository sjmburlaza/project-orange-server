namespace ProjectOrangeApi.Models;

public class OrderItem
{
    public int Id { get; set; }
    public int? OrderId { get; set; }
    public Order? Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int? ProductVariantId { get; set; }
    public string? VariantSku { get; set; }
    public string VariantOptionsJson { get; set; } = "{}";
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string SubcategoryName { get; set; } = string.Empty;
    public string ItemSpecsJson { get; set; } = "[]";
    public string AddonsJson { get; set; } = "[]";
}
