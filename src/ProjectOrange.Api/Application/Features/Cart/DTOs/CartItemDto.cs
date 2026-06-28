namespace ProjectOrangeApi.DTOs;

public class CartItemDto
{
    public int ProductId { get; set; }
    public int? VariantId { get; set; }
    public string? VariantSku { get; set; }
    public Dictionary<string, string> Options { get; set; } = [];
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => Price * Quantity;
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string SubcategoryName { get; set; } = string.Empty;
    public List<AddonDto> Addons { get; set; } = [];
    public List<ProductSpecDto> ItemSpecs { get; set; } = [];
}
