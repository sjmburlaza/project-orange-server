using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
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
            .Where(p => p.Id == id)
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
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;
        var addons = AddonSeed.GetEligibleAddons(categoryName)
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
        var product = await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;

        return Ok(InsurancePlanSeed.GetPlans(categoryName));
    }

    [HttpGet("{id}/mobile-plans")]
    public async Task<ActionResult<IEnumerable<MobilePlanDto>>> GetProductMobilePlans(int id)
    {
        var product = await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.Id == id);

        if (product is null)
            return NotFound();

        var categoryName = product.Category?.Name ?? string.Empty;

        return Ok(MobilePlanSeed.GetPlans(categoryName));
    }
}
