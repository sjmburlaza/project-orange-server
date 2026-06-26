using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Route("api/{siteCode:alpha:length(2)}/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public CategoriesController(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
    {
        var categories = await _context.Categories
            .Where(category => category.SiteId == _siteContext.SiteId)
            .OrderBy(category => category.Id)
            .ToListAsync();

        return Ok(categories.Select(MapCategory));
    }

    [HttpPost]
    public async Task<ActionResult<CategoryDto>> CreateCategory(CategoryDto request)
    {
        var category = new Category
        {
            SiteId = _siteContext.SiteId,
            Name = request.Name,
            Subcategories = NormalizeSubcategories(request.Subcategories)
        };

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, MapCategory(category));
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

    private static List<string> NormalizeSubcategories(IEnumerable<string>? subcategories)
    {
        return subcategories?
            .Select(subcategory => subcategory.Trim())
            .Where(subcategory => !string.IsNullOrWhiteSpace(subcategory))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList() ?? [];
    }
}
