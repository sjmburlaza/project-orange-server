namespace ProjectOrangeApi.Models;

public class Product
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public string FeaturesJson { get; set; } = "[]";
    public string WhatsInTheBoxJson { get; set; } = "[]";

    public int CategoryId { get; set; }
    public Category? Category { get; set; } = null;
    public List<ProductSpec> ItemSpecs { get; set; } = [];
    public List<ProductOptionGroup> OptionGroups { get; set; } = [];
    public List<ProductVariant> Variants { get; set; } = [];
}
