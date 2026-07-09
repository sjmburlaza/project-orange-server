using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/admin/products")]
[Route("api/{siteCode:alpha:length(2)}/admin/products")]
public class AdminProductsController : ControllerBase
{
    private const string ProductValidationFailedCode = "PRODUCT_VALIDATION_FAILED";
    private const string CategoryNotFoundCode = "CATEGORY_NOT_FOUND";
    private const string ProductInUseCode = "PRODUCT_IN_USE";

    private static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.Web);

    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public AdminProductsController(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    [Authorize(Policy = AppPermissions.ProductsRead)]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(
        [FromQuery] int? categoryId,
        [FromQuery] string? search,
        [FromQuery] string? sortBy,
        [FromQuery] decimal? minPrice,
        [FromQuery] decimal? maxPrice)
    {
        var query = LoadProductConfigureQuery()
            .AsNoTracking()
            .Where(product => product.SiteId == _siteContext.SiteId);

        if (categoryId.HasValue)
        {
            query = query.Where(product => product.CategoryId == categoryId.Value);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            var normalizedSearch = search.Trim();
            query = query.Where(product =>
                product.Name.Contains(normalizedSearch) ||
                product.Description.Contains(normalizedSearch) ||
                product.SubcategoryName.Contains(normalizedSearch));
        }

        if (minPrice.HasValue)
        {
            query = query.Where(product => product.Price >= minPrice.Value);
        }

        if (maxPrice.HasValue)
        {
            query = query.Where(product => product.Price <= maxPrice.Value);
        }

        query = sortBy switch
        {
            "price-asc" => query.OrderBy(product => product.Price),
            "price-desc" => query.OrderByDescending(product => product.Price),
            "stock-asc" => query.OrderBy(product => product.StockQuantity),
            "stock-desc" => query.OrderByDescending(product => product.StockQuantity),
            "name-asc" => query.OrderBy(product => product.Name),
            "name-desc" => query.OrderByDescending(product => product.Name),
            _ => query.OrderBy(product => product.Id)
        };

        var products = await query.ToListAsync();

        return Ok(products.Select(MapProduct));
    }

    [Authorize(Policy = AppPermissions.ProductsRead)]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductConfigureDto>> GetProduct(int id)
    {
        var product = await LoadProductConfigureQuery()
            .AsNoTracking()
            .FirstOrDefaultAsync(product =>
                product.Id == id &&
                product.SiteId == _siteContext.SiteId);

        return product is null
            ? NotFound()
            : Ok(MapProductConfigure(product));
    }

    [Authorize(Policy = AppPermissions.ProductsCreate)]
    [HttpPost]
    public async Task<ActionResult<ProductConfigureDto>> CreateProduct(AdminProductRequest request)
    {
        var buildResult = BuildProductChildren(request);

        if (!buildResult.IsValid)
        {
            return CreateValidationError(buildResult.Errors);
        }

        var category = await FindCategoryAsync(request.CategoryId);

        if (category is null)
        {
            return CreateCategoryNotFoundError(request.CategoryId);
        }

        var product = new Product
        {
            SiteId = _siteContext.SiteId
        };

        ApplyProductRequest(product, request, category.Id);
        ApplyProductChildren(product, buildResult);

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        var createdProduct = await LoadProductConfigureQuery()
            .AsNoTracking()
            .FirstAsync(candidate => candidate.Id == product.Id);

        return CreatedAtAction(
            nameof(GetProduct),
            new { siteCode = _siteContext.SiteCode, id = createdProduct.Id },
            MapProductConfigure(createdProduct));
    }

    [Authorize(Policy = AppPermissions.ProductsUpdate)]
    [HttpPut("{id:int}")]
    public async Task<ActionResult<ProductConfigureDto>> UpdateProduct(
        int id,
        AdminProductRequest request)
    {
        var buildResult = BuildProductChildren(request);

        if (!buildResult.IsValid)
        {
            return CreateValidationError(buildResult.Errors);
        }

        var category = await FindCategoryAsync(request.CategoryId);

        if (category is null)
        {
            return CreateCategoryNotFoundError(request.CategoryId);
        }

        var product = await LoadProductConfigureQuery()
            .FirstOrDefaultAsync(candidate =>
                candidate.Id == id &&
                candidate.SiteId == _siteContext.SiteId);

        if (product is null)
        {
            return NotFound();
        }

        RemoveProductChildren(product);
        await _context.SaveChangesAsync();

        ApplyProductRequest(product, request, category.Id);
        ApplyProductChildren(product, buildResult);
        await _context.SaveChangesAsync();

        var updatedProduct = await LoadProductConfigureQuery()
            .AsNoTracking()
            .FirstAsync(candidate => candidate.Id == product.Id);

        return Ok(MapProductConfigure(updatedProduct));
    }

    [Authorize(Policy = AppPermissions.ProductsDelete)]
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await LoadProductConfigureQuery()
            .FirstOrDefaultAsync(candidate =>
                candidate.Id == id &&
                candidate.SiteId == _siteContext.SiteId);

        if (product is null)
        {
            return NotFound();
        }

        var isReferenced = await _context.CartItems.AnyAsync(item => item.ProductId == id) ||
            await _context.OrderItems.AnyAsync(item => item.ProductId == id);

        if (isReferenced)
        {
            return Conflict(new ProblemDetails
            {
                Status = StatusCodes.Status409Conflict,
                Title = "Product is in use.",
                Detail = "Products referenced by active carts or orders cannot be deleted.",
                Extensions =
                {
                    ["code"] = ProductInUseCode
                }
            });
        }

        RemoveProductChildren(product);
        await _context.SaveChangesAsync();

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private IQueryable<Product> LoadProductConfigureQuery()
    {
        return _context.Products
            .Include(product => product.Category)
            .Include(product => product.ItemSpecs)
            .Include(product => product.OptionGroups)
                .ThenInclude(group => group.Options)
            .Include(product => product.Variants)
                .ThenInclude(variant => variant.VariantOptions)
                    .ThenInclude(variantOption => variantOption.ProductOption)
                        .ThenInclude(option => option.ProductOptionGroup)
            .AsSplitQuery();
    }

    private async Task<Category?> FindCategoryAsync(int categoryId)
    {
        return await _context.Categories.FirstOrDefaultAsync(category =>
            category.Id == categoryId &&
            category.SiteId == _siteContext.SiteId);
    }

    private static void ApplyProductRequest(
        Product product,
        AdminProductRequest request,
        int categoryId)
    {
        product.Name = NormalizeRequiredText(request.Name);
        product.Description = NormalizeOptionalText(request.Description);
        product.Price = request.Price;
        product.ReviewRating = request.ReviewRating;
        product.StockQuantity = request.StockQuantity;
        product.ImageUrl = NormalizeOptionalText(request.ImageUrl);
        product.CategoryId = categoryId;
        product.SubcategoryName = NormalizeOptionalText(request.SubcategoryName);
        product.FeaturesJson = SerializeStringList(request.Features);
        product.WhatsInTheBoxJson = SerializeStringList(request.WhatsInTheBox);
    }

    private static void ApplyProductChildren(
        Product product,
        ProductChildrenBuildResult buildResult)
    {
        product.ItemSpecs = buildResult.ItemSpecs;
        product.OptionGroups = buildResult.OptionGroups;
        product.Variants = buildResult.Variants;
    }

    private void RemoveProductChildren(Product product)
    {
        _context.ProductVariantOptions.RemoveRange(product.Variants.SelectMany(variant => variant.VariantOptions));
        _context.ProductVariants.RemoveRange(product.Variants);
        _context.ProductOptions.RemoveRange(product.OptionGroups.SelectMany(group => group.Options));
        _context.ProductOptionGroups.RemoveRange(product.OptionGroups);
        _context.ProductSpecs.RemoveRange(product.ItemSpecs);

        product.Variants.Clear();
        product.OptionGroups.Clear();
        product.ItemSpecs.Clear();
    }

    private ActionResult<ProductConfigureDto> CreateValidationError(
        Dictionary<string, List<string>> errors)
    {
        var problem = new ValidationProblemDetails(
            errors.ToDictionary(error => error.Key, error => error.Value.ToArray()))
        {
            Status = StatusCodes.Status400BadRequest,
            Title = "Invalid product.",
            Detail = "Product validation failed."
        };

        problem.Extensions["code"] = ProductValidationFailedCode;

        return BadRequest(problem);
    }

    private ActionResult<ProductConfigureDto> CreateCategoryNotFoundError(int categoryId)
    {
        return NotFound(new ProblemDetails
        {
            Status = StatusCodes.Status404NotFound,
            Title = "Category not found.",
            Detail = $"Category '{categoryId}' does not exist for site '{_siteContext.SiteCode}'.",
            Extensions =
            {
                ["code"] = CategoryNotFoundCode
            }
        });
    }

    private static ProductChildrenBuildResult BuildProductChildren(AdminProductRequest request)
    {
        var result = new ProductChildrenBuildResult();

        ValidateProductScalars(request, result);
        AddProductSpecs(request, result);
        var optionsByGroup = AddOptionGroups(request, result);
        AddVariants(request, result, optionsByGroup);

        return result;
    }

    private static void ValidateProductScalars(
        AdminProductRequest request,
        ProductChildrenBuildResult result)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            result.AddError(nameof(request.Name), "Product name is required.");
        }

        if (request.Price < 0)
        {
            result.AddError(nameof(request.Price), "Product price cannot be negative.");
        }

        if (request.ReviewRating is < 0 or > 5)
        {
            result.AddError(nameof(request.ReviewRating), "Product review rating must be between 0 and 5.");
        }

        if (request.StockQuantity < 0)
        {
            result.AddError(nameof(request.StockQuantity), "Product stock quantity cannot be negative.");
        }

        if (request.CategoryId <= 0)
        {
            result.AddError(nameof(request.CategoryId), "Category is required.");
        }
    }

    private static void AddProductSpecs(
        AdminProductRequest request,
        ProductChildrenBuildResult result)
    {
        for (var index = 0; index < request.ItemSpecs.Count; index++)
        {
            var spec = request.ItemSpecs[index];
            var name = NormalizeOptionalText(spec.Name);
            var value = NormalizeOptionalText(spec.Value);

            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(value))
            {
                continue;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(value))
            {
                result.AddError($"itemSpecs[{index}]", "Product specs require both name and value.");
                continue;
            }

            result.ItemSpecs.Add(new ProductSpec
            {
                Name = name,
                Value = value
            });
        }
    }

    private static Dictionary<string, Dictionary<string, ProductOption>> AddOptionGroups(
        AdminProductRequest request,
        ProductChildrenBuildResult result)
    {
        var groupCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var optionsByGroup = new Dictionary<string, Dictionary<string, ProductOption>>(StringComparer.OrdinalIgnoreCase);

        for (var groupIndex = 0; groupIndex < request.OptionGroups.Count; groupIndex++)
        {
            var groupRequest = request.OptionGroups[groupIndex];
            var groupCode = NormalizeCode(groupRequest.Code);
            var groupLabel = NormalizeOptionalText(groupRequest.Label);

            if (string.IsNullOrWhiteSpace(groupCode))
            {
                result.AddError($"optionGroups[{groupIndex}].code", "Option group code is required.");
                continue;
            }

            if (string.IsNullOrWhiteSpace(groupLabel))
            {
                result.AddError($"optionGroups[{groupIndex}].label", "Option group label is required.");
            }

            if (!groupCodes.Add(groupCode))
            {
                result.AddError($"optionGroups[{groupIndex}].code", $"Option group code '{groupCode}' is duplicated.");
                continue;
            }

            var group = new ProductOptionGroup
            {
                Code = groupCode,
                Label = groupLabel,
                SortOrder = groupRequest.SortOrder
            };

            var optionCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var optionsByCode = new Dictionary<string, ProductOption>(StringComparer.OrdinalIgnoreCase);

            for (var optionIndex = 0; optionIndex < groupRequest.Options.Count; optionIndex++)
            {
                var optionRequest = groupRequest.Options[optionIndex];
                var optionCode = NormalizeCode(optionRequest.Code);
                var optionLabel = NormalizeOptionalText(optionRequest.Label);

                if (string.IsNullOrWhiteSpace(optionCode))
                {
                    result.AddError($"optionGroups[{groupIndex}].options[{optionIndex}].code", "Option code is required.");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(optionLabel))
                {
                    result.AddError($"optionGroups[{groupIndex}].options[{optionIndex}].label", "Option label is required.");
                }

                if (!optionCodes.Add(optionCode))
                {
                    result.AddError(
                        $"optionGroups[{groupIndex}].options[{optionIndex}].code",
                        $"Option code '{optionCode}' is duplicated in group '{groupCode}'.");
                    continue;
                }

                var option = new ProductOption
                {
                    Code = optionCode,
                    Label = optionLabel,
                    Hex = NormalizeNullableText(optionRequest.Hex),
                    ImageUrl = NormalizeNullableText(optionRequest.ImageUrl),
                    SortOrder = optionRequest.SortOrder
                };

                group.Options.Add(option);
                optionsByCode[optionCode] = option;
            }

            result.OptionGroups.Add(group);
            optionsByGroup[groupCode] = optionsByCode;
        }

        return optionsByGroup;
    }

    private static void AddVariants(
        AdminProductRequest request,
        ProductChildrenBuildResult result,
        Dictionary<string, Dictionary<string, ProductOption>> optionsByGroup)
    {
        var variantSkus = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (var variantIndex = 0; variantIndex < request.Variants.Count; variantIndex++)
        {
            var variantRequest = request.Variants[variantIndex];
            var sku = NormalizeRequiredText(variantRequest.Sku);

            if (string.IsNullOrWhiteSpace(sku))
            {
                result.AddError($"variants[{variantIndex}].sku", "Variant SKU is required.");
                continue;
            }

            if (!variantSkus.Add(sku))
            {
                result.AddError($"variants[{variantIndex}].sku", $"Variant SKU '{sku}' is duplicated.");
                continue;
            }

            if (variantRequest.Price < 0)
            {
                result.AddError($"variants[{variantIndex}].price", "Variant price cannot be negative.");
            }

            if (variantRequest.StockQuantity < 0)
            {
                result.AddError($"variants[{variantIndex}].stockQuantity", "Variant stock quantity cannot be negative.");
            }

            var variant = new ProductVariant
            {
                Sku = sku,
                Price = variantRequest.Price,
                StockQuantity = variantRequest.StockQuantity,
                ImageUrl = NormalizeNullableText(variantRequest.ImageUrl)
            };

            foreach (var selectedOption in variantRequest.Options)
            {
                var groupCode = NormalizeCode(selectedOption.Key);
                var optionCode = NormalizeCode(selectedOption.Value);

                if (!optionsByGroup.TryGetValue(groupCode, out var optionsByCode))
                {
                    result.AddError(
                        $"variants[{variantIndex}].options.{selectedOption.Key}",
                        $"Option group '{selectedOption.Key}' does not exist on this product.");
                    continue;
                }

                if (!optionsByCode.TryGetValue(optionCode, out var option))
                {
                    result.AddError(
                        $"variants[{variantIndex}].options.{selectedOption.Key}",
                        $"Option '{selectedOption.Value}' does not exist in group '{selectedOption.Key}'.");
                    continue;
                }

                variant.VariantOptions.Add(new ProductVariantOption
                {
                    ProductOption = option
                });
            }

            result.Variants.Add(variant);
        }
    }

    private static ProductDto MapProduct(Product product)
    {
        var stockQuantity = GetProductStockQuantity(product);

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = GetProductPrice(product),
            ReviewRating = product.ReviewRating,
            StockQuantity = stockQuantity,
            StockStatus = GetStockStatus(stockQuantity),
            ImageUrl = product.ImageUrl,
            CategoryId = product.CategoryId,
            CategoryName = product.Category != null ? product.Category.Name : string.Empty,
            SubcategoryName = product.SubcategoryName,
            ItemSpecs = MapProductSpecs(product),
            AvailableColors = MapAvailableColors(product)
        };
    }

    private static ProductConfigureDto MapProductConfigure(Product product)
    {
        var stockQuantity = GetProductStockQuantity(product);

        return new ProductConfigureDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = GetProductPrice(product),
            ReviewRating = product.ReviewRating,
            StockQuantity = stockQuantity,
            StockStatus = GetStockStatus(stockQuantity),
            ImageUrl = product.ImageUrl,
            CategoryId = product.CategoryId,
            CategoryName = product.Category != null ? product.Category.Name : string.Empty,
            SubcategoryName = product.SubcategoryName,
            Category = product.Category == null ? null : MapCategory(product.Category),
            ItemSpecs = MapProductSpecs(product),
            AvailableColors = MapAvailableColors(product),
            Features = DeserializeStringList(product.FeaturesJson),
            WhatsInTheBox = DeserializeStringList(product.WhatsInTheBoxJson),
            OptionGroups = product.OptionGroups
                .OrderBy(group => group.SortOrder)
                .ThenBy(group => group.Id)
                .Select(group => new ProductOptionGroupDto
                {
                    Code = group.Code,
                    Label = group.Label,
                    Options = group.Options
                        .OrderBy(option => option.SortOrder)
                        .ThenBy(option => option.Id)
                        .Select(option => new ProductOptionDto
                        {
                            Code = option.Code,
                            Label = option.Label,
                            Hex = option.Hex,
                            ImageUrl = option.ImageUrl
                        })
                        .ToList()
                })
                .ToList(),
            Variants = product.Variants
                .OrderBy(variant => variant.Price)
                .ThenBy(variant => variant.Id)
                .Select(MapProductVariant)
                .ToList()
        };
    }

    private static CategoryDto MapCategory(Category category)
    {
        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Subcategories = category.Subcategories
        };
    }

    private static ProductVariantDto MapProductVariant(ProductVariant variant)
    {
        return new ProductVariantDto
        {
            Id = variant.Id,
            Sku = variant.Sku,
            Price = variant.Price,
            StockQuantity = variant.StockQuantity,
            StockStatus = GetStockStatus(variant.StockQuantity),
            ImageUrl = variant.ImageUrl,
            Options = GetVariantOptions(variant)
        };
    }

    private static List<ProductSpecDto> MapProductSpecs(Product product)
    {
        return product.ItemSpecs.Select(spec => new ProductSpecDto
        {
            Name = spec.Name,
            Value = spec.Value
        }).ToList();
    }

    private static List<ProductOptionDto> MapAvailableColors(Product product)
    {
        return product.OptionGroups
            .Where(group => string.Equals(
                group.Code,
                ProductOptionSeed.ColorGroupCode,
                StringComparison.OrdinalIgnoreCase))
            .OrderBy(group => group.SortOrder)
            .ThenBy(group => group.Id)
            .SelectMany(group => group.Options
                .OrderBy(option => option.SortOrder)
                .ThenBy(option => option.Id)
                .Select(option => new ProductOptionDto
                {
                    Code = option.Code,
                    Label = option.Label,
                    Hex = option.Hex,
                    ImageUrl = option.ImageUrl
                }))
            .ToList();
    }

    private static decimal GetProductPrice(Product product)
    {
        return product.Variants.Count > 0
            ? product.Variants.Min(variant => variant.Price)
            : product.Price;
    }

    private static int GetProductStockQuantity(Product product)
    {
        return product.Variants.Count > 0
            ? product.Variants.Sum(variant => variant.StockQuantity)
            : product.StockQuantity;
    }

    private static string GetStockStatus(int stockQuantity)
    {
        if (stockQuantity <= 0)
        {
            return "outOfStock";
        }

        return stockQuantity <= 5 ? "lowStock" : "inStock";
    }

    private static Dictionary<string, string> GetVariantOptions(ProductVariant variant)
    {
        return variant.VariantOptions
            .Where(variantOption =>
                variantOption.ProductOption.ProductOptionGroup != null &&
                !string.IsNullOrWhiteSpace(variantOption.ProductOption.ProductOptionGroup.Code))
            .OrderBy(variantOption => variantOption.ProductOption.ProductOptionGroup.SortOrder)
            .ThenBy(variantOption => variantOption.ProductOption.SortOrder)
            .ToDictionary(
                variantOption => variantOption.ProductOption.ProductOptionGroup.Code,
                variantOption => variantOption.ProductOption.Code,
                StringComparer.OrdinalIgnoreCase);
    }

    private static List<string> DeserializeStringList(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            return JsonSerializer.Deserialize<List<string>>(json) ?? [];
        }
        catch (JsonException)
        {
            return [];
        }
    }

    private static string SerializeStringList(IEnumerable<string>? values)
    {
        var normalizedValues = values?
            .Select(NormalizeOptionalText)
            .Where(value => !string.IsNullOrWhiteSpace(value))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList() ?? [];

        return JsonSerializer.Serialize(normalizedValues, JsonSerializerOptions);
    }

    private static string NormalizeRequiredText(string? value)
    {
        return value?.Trim() ?? string.Empty;
    }

    private static string NormalizeOptionalText(string? value)
    {
        return value?.Trim() ?? string.Empty;
    }

    private static string? NormalizeNullableText(string? value)
    {
        var normalized = value?.Trim();

        return string.IsNullOrWhiteSpace(normalized)
            ? null
            : normalized;
    }

    private static string NormalizeCode(string? value)
    {
        return value?.Trim().ToLowerInvariant() ?? string.Empty;
    }

    private sealed class ProductChildrenBuildResult
    {
        public Dictionary<string, List<string>> Errors { get; } = [];
        public List<ProductSpec> ItemSpecs { get; } = [];
        public List<ProductOptionGroup> OptionGroups { get; } = [];
        public List<ProductVariant> Variants { get; } = [];
        public bool IsValid => Errors.Count == 0;

        public void AddError(string field, string message)
        {
            if (!Errors.TryGetValue(field, out var messages))
            {
                messages = [];
                Errors[field] = messages;
            }

            messages.Add(message);
        }
    }
}
