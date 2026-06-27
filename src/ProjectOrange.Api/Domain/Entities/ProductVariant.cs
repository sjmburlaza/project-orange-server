namespace ProjectOrangeApi.Models;

public class ProductVariant
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public string Sku { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string? ImageUrl { get; set; }

    public List<ProductVariantOption> VariantOptions { get; set; } = [];
}
