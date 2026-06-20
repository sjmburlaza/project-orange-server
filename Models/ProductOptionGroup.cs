namespace ProjectOrangeApi.Models;

public class ProductOptionGroup
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public List<ProductOption> Options { get; set; } = [];
}
