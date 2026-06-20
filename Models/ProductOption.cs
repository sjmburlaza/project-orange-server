namespace ProjectOrangeApi.Models;

public class ProductOption
{
    public int Id { get; set; }
    public int ProductOptionGroupId { get; set; }
    public ProductOptionGroup ProductOptionGroup { get; set; } = null!;
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string? Hex { get; set; }
    public string? ImageUrl { get; set; }
    public int SortOrder { get; set; }

    public List<ProductVariantOption> VariantOptions { get; set; } = [];
}
