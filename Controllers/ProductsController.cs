using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
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
        [FromQuery] decimal? maxPrice
    )
    {
        var query = _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .Where(p => p.SiteId == _siteContext.SiteId)
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

        query = sortBy switch
        {
            "price-asc" => query.OrderBy(p => p.Price),
            "price-desc" => query.OrderByDescending(p => p.Price),
            "name-asc" => query.OrderBy(p => p.Name),
            "name-desc" => query.OrderByDescending(p => p.Name),
            _ => query.OrderBy(p => p.Id)
        };

        var products = await query
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                ImageUrl = p.ImageUrl,
                CategoryId = p.CategoryId,
                CategoryName = p.Category != null ? p.Category.Name : string.Empty,

                ItemSpecs = p.ItemSpecs.Select(spec => new ProductSpecDto
                {
                    Name = spec.Name,
                    Value = spec.Value
                }).ToList()
            })
            .ToListAsync();

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDto>> GetProduct(int id)
    {
        var product = await _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .Where(p => p.Id == id && p.SiteId == _siteContext.SiteId)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockQuantity = p.StockQuantity,
                ImageUrl = p.ImageUrl,
                CategoryId = p.CategoryId,
                CategoryName = p.Category != null ? p.Category.Name : string.Empty,

                ItemSpecs = p.ItemSpecs.Select(spec => new ProductSpecDto
                {
                    Name = spec.Name,
                    Value = spec.Value
                }).ToList()
            })
            .FirstOrDefaultAsync();

        if (product == null)
            return NotFound();

        return Ok(product);
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
}
