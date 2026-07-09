using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Route("api/{siteCode:alpha:length(2)}/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public ProductsController(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(
        [FromQuery] int? categoryId,
        [FromQuery] string? sortBy,
        [FromQuery] decimal? minPrice,
        [FromQuery] decimal? maxPrice,
        [FromQuery] string? search = null
    )
    {
        var normalizedSearch = NormalizeSearch(search);
        var query = _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .Include(p => p.OptionGroups)
                .ThenInclude(group => group.Options)
            .Include(p => p.Variants)
            .Where(p => p.SiteId == _siteContext.SiteId)
            .AsSplitQuery()
            .AsQueryable();

        if (categoryId.HasValue)
        {
            query = query.Where(p => p.CategoryId == categoryId.Value);
        }

        if (minPrice.HasValue)
        {
            query = query.Where(p => p.Price >= minPrice.Value);
        }

        if (maxPrice.HasValue)
        {
            query = query.Where(p => p.Price <= maxPrice.Value);
        }

        if (normalizedSearch is not null)
        {
            query = query.Where(product =>
                product.Name.ToLower().Contains(normalizedSearch) ||
                product.Description.ToLower().Contains(normalizedSearch) ||
                product.SubcategoryName.ToLower().Contains(normalizedSearch) ||
                (product.Category != null &&
                    product.Category.Name.ToLower().Contains(normalizedSearch)));
        }

        query = sortBy switch
        {
            "price-asc" => query.OrderBy(p => p.Price),
            "price-desc" => query.OrderByDescending(p => p.Price),
            "name-asc" => query.OrderBy(p => p.Name),
            "name-desc" => query.OrderByDescending(p => p.Name),
            _ => query.OrderBy(p => p.Id)
        };

        var products = await query.ToListAsync();

        if (normalizedSearch is not null && string.IsNullOrWhiteSpace(sortBy))
        {
            products = products
                .OrderBy(product => GetProductSearchScore(product, normalizedSearch))
                .ThenBy(product => product.Name, StringComparer.OrdinalIgnoreCase)
                .ThenBy(product => product.Id)
                .ToList();
        }

        return Ok(products.Select(MapProduct));
    }

    [HttpGet("search/suggestions")]
    [HttpGet("search-suggestions")]
    public async Task<ActionResult<IEnumerable<string>>> GetSearchSuggestions(
        [FromQuery] string? query,
        [FromQuery(Name = "q")] string? queryAlias = null)
    {
        var normalizedSearch = NormalizeSearch(query) ?? NormalizeSearch(queryAlias);

        if (normalizedSearch is null)
        {
            return Ok(Array.Empty<string>());
        }

        var matchingProducts = await _context.Products
            .AsNoTracking()
            .Where(product =>
                product.SiteId == _siteContext.SiteId &&
                (product.Name.ToLower().Contains(normalizedSearch) ||
                    product.Description.ToLower().Contains(normalizedSearch) ||
                    product.SubcategoryName.ToLower().Contains(normalizedSearch) ||
                    (product.Category != null &&
                        product.Category.Name.ToLower().Contains(normalizedSearch))))
            .Select(product => new
            {
                product.Name,
                product.Description,
                product.SubcategoryName,
                CategoryName = product.Category == null ? string.Empty : product.Category.Name
            })
            .ToListAsync();

        var matchingCategories = await _context.Categories
            .AsNoTracking()
            .Where(category =>
                category.SiteId == _siteContext.SiteId &&
                category.Name.ToLower().Contains(normalizedSearch))
            .Select(category => category.Name)
            .ToListAsync();

        var suggestions = new List<(string Term, int Score)>();

        suggestions.AddRange(matchingCategories.Select(category =>
            (category, GetTextSearchScore(category, normalizedSearch, sourcePenalty: 0))));

        foreach (var product in matchingProducts)
        {
            suggestions.Add((
                product.Name,
                GetProductSearchScore(
                    product.Name,
                    product.Description,
                    product.SubcategoryName,
                    product.CategoryName,
                    normalizedSearch)));

            AddMatchingTerm(
                suggestions,
                product.SubcategoryName,
                normalizedSearch,
                sourcePenalty: 10);
        }

        var result = suggestions
            .Where(suggestion => !string.IsNullOrWhiteSpace(suggestion.Term))
            .GroupBy(suggestion => suggestion.Term.Trim(), StringComparer.OrdinalIgnoreCase)
            .Select(group => new
            {
                Term = group.Key,
                Score = group.Min(suggestion => suggestion.Score)
            })
            .OrderBy(suggestion => suggestion.Score)
            .ThenBy(suggestion => suggestion.Term, StringComparer.OrdinalIgnoreCase)
            .Take(5)
            .Select(suggestion => suggestion.Term)
            .ToList();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductConfigureDto>> GetProduct(int id)
    {
        var product = await LoadProductConfigureQuery()
            .Where(p => p.Id == id && p.SiteId == _siteContext.SiteId)
            .FirstOrDefaultAsync();

        if (product == null)
            return NotFound();

        return Ok(MapProductConfigure(product));
    }

    [HttpGet("{id}/options")]
    public async Task<ActionResult<ProductOptionsResponseDto>> GetProductOptions(int id)
    {
        var product = await LoadProductConfigureQuery()
            .Where(p => p.Id == id && p.SiteId == _siteContext.SiteId)
            .FirstOrDefaultAsync();

        if (product == null)
            return NotFound();

        var selectedOptions = GetSelectedOptions(product, Request.Query);
        var optionGroups = product.OptionGroups
            .OrderBy(group => group.SortOrder)
            .ThenBy(group => group.Id)
            .Select(group => new ProductOptionAvailabilityGroupDto
            {
                Code = group.Code,
                Label = group.Label,
                Options = group.Options
                    .OrderBy(option => option.SortOrder)
                    .ThenBy(option => option.Id)
                    .Select(option => new ProductOptionAvailabilityDto
                    {
                        Code = option.Code,
                        Label = option.Label,
                        Price = GetOptionPrice(
                            product,
                            group.Code,
                            option.Code,
                            selectedOptions),
                        Hex = option.Hex,
                        ImageUrl = option.ImageUrl,
                        Available = IsOptionAvailable(product, group.Code, option.Code, selectedOptions)
                    })
                    .ToList()
            })
            .ToList();

        return Ok(new ProductOptionsResponseDto
        {
            SelectedOptions = selectedOptions,
            OptionGroups = optionGroups
        });
    }

    [HttpGet("{id}/addons")]
    public async Task<ActionResult<IEnumerable<AddonDto>>> GetProductAddons(int id)
    {
        var product = await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id && p.SiteId == _siteContext.SiteId);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;
        var addons = AddonSeed.GetEligibleAddons(categoryName)
            .Where(IsAddonEnabled)
            .Select(addon => new AddonDto
            {
                Id = addon.Id,
                Name = addon.Name,
                Title = addon.Title,
                Description = addon.Description,
                ImageUrl = addon.ImageUrl,
                IsAdded = false
            })
            .ToList();

        return Ok(addons);
    }

    [HttpGet("{id}/insurance-plans")]
    public async Task<ActionResult<IEnumerable<InsurancePlanDto>>> GetProductInsurancePlans(int id)
    {
        if (!_siteContext.InsuranceEnabled)
        {
            return NotFound();
        }

        var product = await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id && p.SiteId == _siteContext.SiteId);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;

        return Ok(InsurancePlanSeed.GetPlans(categoryName)
            .Select(plan => new InsurancePlanDto
            {
                Name = plan.Name,
                Code = plan.Code,
                Description = plan.Description,
                Amount = SiteCurrency.ConvertPhpAmount(plan.Amount, _siteContext.Currency),
                BillingFrequency = plan.BillingFrequency ?? string.Empty
            })
            .ToList());
    }

    [HttpGet("{id}/mobile-plans")]
    public async Task<ActionResult<IEnumerable<MobilePlanDto>>> GetProductMobilePlans(int id)
    {
        var product = await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id && p.SiteId == _siteContext.SiteId);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;

        return Ok(MobilePlanSeed.GetPlans(categoryName)
            .Select(plan => new MobilePlanDto
            {
                Name = plan.Name,
                Code = plan.Code,
                Amount = SiteCurrency.ConvertPhpAmount(plan.Amount, _siteContext.Currency),
                BillingFrequency = plan.BillingFrequency ?? string.Empty,
                DataAllowance = plan.DataAllowance,
                Description = plan.Description
            })
            .ToList());
    }

    private bool IsAddonEnabled(Addon addon)
    {
        return addon.Id switch
        {
            "insurance" => _siteContext.InsuranceEnabled,
            "trade-in" => _siteContext.TradeInEnabled,
            _ => true
        };
    }

    private static string? NormalizeSearch(string? search)
    {
        var normalized = search?.Trim().ToLowerInvariant();
        return string.IsNullOrWhiteSpace(normalized) ? null : normalized;
    }

    private static void AddMatchingTerm(
        ICollection<(string Term, int Score)> suggestions,
        string term,
        string normalizedSearch,
        int sourcePenalty)
    {
        if (!string.IsNullOrWhiteSpace(term) &&
            term.Contains(normalizedSearch, StringComparison.OrdinalIgnoreCase))
        {
            suggestions.Add((
                term,
                GetTextSearchScore(term, normalizedSearch, sourcePenalty)));
        }
    }

    private static int GetProductSearchScore(Product product, string normalizedSearch)
    {
        return GetProductSearchScore(
            product.Name,
            product.Description,
            product.SubcategoryName,
            product.Category?.Name ?? string.Empty,
            normalizedSearch);
    }

    private static int GetProductSearchScore(
        string name,
        string description,
        string subcategoryName,
        string categoryName,
        string normalizedSearch)
    {
        return new[]
        {
            GetTextSearchScore(name, normalizedSearch, sourcePenalty: 0),
            GetTextSearchScore(subcategoryName, normalizedSearch, sourcePenalty: 1_000),
            GetTextSearchScore(categoryName, normalizedSearch, sourcePenalty: 2_000),
            GetTextSearchScore(description, normalizedSearch, sourcePenalty: 3_000)
        }.Min();
    }

    private static int GetTextSearchScore(
        string text,
        string normalizedSearch,
        int sourcePenalty)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return int.MaxValue;
        }

        var normalizedText = text.Trim().ToLowerInvariant();

        if (normalizedText == normalizedSearch)
        {
            return sourcePenalty;
        }

        if (normalizedText.StartsWith(normalizedSearch, StringComparison.Ordinal))
        {
            return 100 + sourcePenalty;
        }

        if (StartsAnyWordWith(normalizedText, normalizedSearch))
        {
            return 200 + sourcePenalty;
        }

        return normalizedText.Contains(normalizedSearch, StringComparison.Ordinal)
            ? 300 + sourcePenalty
            : int.MaxValue;
    }

    private static bool StartsAnyWordWith(string text, string normalizedSearch)
    {
        for (var index = 1; index < text.Length; index++)
        {
            if (!char.IsLetterOrDigit(text[index - 1]) &&
                text.AsSpan(index).StartsWith(normalizedSearch, StringComparison.Ordinal))
            {
                return true;
            }
        }

        return false;
    }

    private IQueryable<Product> LoadProductConfigureQuery()
    {
        return _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .Include(p => p.OptionGroups)
                .ThenInclude(group => group.Options)
            .Include(p => p.Variants)
                .ThenInclude(variant => variant.VariantOptions)
                    .ThenInclude(variantOption => variantOption.ProductOption)
                        .ThenInclude(option => option.ProductOptionGroup);
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
            ReviewCount = product.ReviewCount,
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
            ReviewCount = product.ReviewCount,
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
                            Price = GetOptionPrice(product, group.Code, option.Code),
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

    private static Dictionary<string, string> GetSelectedOptions(
        Product product,
        IQueryCollection query)
    {
        var selectedOptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        foreach (var group in product.OptionGroups)
        {
            if (!query.TryGetValue(group.Code, out var values))
            {
                continue;
            }

            var requestedOptionCode = values.FirstOrDefault()?.Trim();

            if (string.IsNullOrWhiteSpace(requestedOptionCode))
            {
                continue;
            }

            var option = group.Options.FirstOrDefault(candidate =>
                string.Equals(candidate.Code, requestedOptionCode, StringComparison.OrdinalIgnoreCase));

            if (option is not null)
            {
                selectedOptions[group.Code] = option.Code;
            }
        }

        return selectedOptions;
    }

    private static bool IsOptionAvailable(
        Product product,
        string candidateGroupCode,
        string candidateOptionCode,
        Dictionary<string, string> selectedOptions)
    {
        var constraints = selectedOptions
            .Where(option => !string.Equals(option.Key, candidateGroupCode, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(option => option.Key, option => option.Value, StringComparer.OrdinalIgnoreCase);

        constraints[candidateGroupCode] = candidateOptionCode;

        return product.Variants.Any(variant =>
            variant.StockQuantity > 0 &&
            VariantMatches(variant, constraints));
    }

    private static decimal? GetOptionPrice(
        Product product,
        string candidateGroupCode,
        string candidateOptionCode,
        IReadOnlyDictionary<string, string>? selectedOptions = null)
    {
        var constraints = selectedOptions?
            .Where(option => !string.Equals(
                option.Key,
                candidateGroupCode,
                StringComparison.OrdinalIgnoreCase))
            .ToDictionary(
                option => option.Key,
                option => option.Value,
                StringComparer.OrdinalIgnoreCase)
            ?? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        constraints[candidateGroupCode] = candidateOptionCode;

        return product.Variants
            .Where(variant => VariantMatches(variant, constraints))
            .Select(variant => (decimal?)variant.Price)
            .Min();
    }

    private static bool VariantMatches(
        ProductVariant variant,
        Dictionary<string, string> selectedOptions)
    {
        var variantOptions = GetVariantOptions(variant);

        return selectedOptions.All(selectedOption =>
            variantOptions.TryGetValue(selectedOption.Key, out var variantOptionCode) &&
            string.Equals(variantOptionCode, selectedOption.Value, StringComparison.OrdinalIgnoreCase));
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
}
