namespace ProjectOrangeApi.DTOs;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string> Subcategories { get; set; } = [];
}

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal ReviewRating { get; set; }
    public int ReviewCount { get; set; }
    public string StockStatus { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string SubcategoryName { get; set; } = string.Empty;

    public List<ProductSpecDto> ItemSpecs { get; set; } = [];
    public List<ProductOptionDto> AvailableColors { get; set; } = [];
}

public class ProductConfigureDto : ProductDto
{
    public CategoryDto? Category { get; set; }
    public List<string> Features { get; set; } = [];
    public List<string> WhatsInTheBox { get; set; } = [];
    public List<ProductOptionGroupDto> OptionGroups { get; set; } = [];
    public List<ProductVariantDto> Variants { get; set; } = [];
}

public class ProductOptionGroupDto
{
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public List<ProductOptionDto> Options { get; set; } = [];
}

public class ProductOptionDto
{
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public decimal? Price { get; set; }
    public string? Hex { get; set; }
    public string? ImageUrl { get; set; }
}

public class ProductVariantDto
{
    public int Id { get; set; }
    public string Sku { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string StockStatus { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public Dictionary<string, string> Options { get; set; } = [];
}

public class ProductOptionsResponseDto
{
    public Dictionary<string, string> SelectedOptions { get; set; } = [];
    public List<ProductOptionAvailabilityGroupDto> OptionGroups { get; set; } = [];
}

public class ProductOptionAvailabilityGroupDto
{
    public string Code { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public List<ProductOptionAvailabilityDto> Options { get; set; } = [];
}

public class ProductOptionAvailabilityDto : ProductOptionDto
{
    public bool Available { get; set; }
}
