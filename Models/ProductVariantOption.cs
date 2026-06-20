namespace ProjectOrangeApi.Models;

public class ProductVariantOption
{
    public int Id { get; set; }
    public int ProductVariantId { get; set; }
    public ProductVariant ProductVariant { get; set; } = null!;
    public int ProductOptionId { get; set; }
    public ProductOption ProductOption { get; set; } = null!;
}
