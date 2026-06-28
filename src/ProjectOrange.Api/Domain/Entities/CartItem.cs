namespace ProjectOrangeApi.Models;

public class CartItem
{
    public int Id { get; set; }

    public int CartId { get; set; }
    public Cart Cart { get; set; } = null!;

    public int ProductId { get; set; }
    public int? ProductVariantId { get; set; }
    public string? VariantSku { get; set; }
    public string VariantOptionsJson { get; set; } = "{}";
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string SubcategoryName { get; set; } = string.Empty;

    public List<CartItemAddon> Addons { get; set; } = [];
    public List<CartItemSpec> ItemSpecs { get; set; } = [];
}
