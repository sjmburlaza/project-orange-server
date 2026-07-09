namespace ProjectOrangeApi.DTOs;

public class AdminProductRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal ReviewRating { get; set; }
    public int ReviewCount { get; set; }
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public string SubcategoryName { get; set; } = string.Empty;
    public List<string> Features { get; set; } = [];
    public List<string> WhatsInTheBox { get; set; } = [];
    public List<ProductSpecDto> ItemSpecs { get; set; } = [];
    public List<AdminProductOptionGroupRequest> OptionGroups { get; set; } = [];
    public List<AdminProductVariantRequest> Variants { get; set; } = [];
}

public class AdminProductOptionGroupRequest
{
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public int SortOrder { get; set; }
    public List<AdminProductOptionRequest> Options { get; set; } = [];
}

public class AdminProductOptionRequest
{
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string? Hex { get; set; }
    public string? ImageUrl { get; set; }
    public int SortOrder { get; set; }
}

public class AdminProductVariantRequest
{
    public string Sku { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string? ImageUrl { get; set; }
    public Dictionary<string, string> Options { get; set; } = [];
}
