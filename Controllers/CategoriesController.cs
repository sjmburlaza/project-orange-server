using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
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
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
        var categories = await _context.Categories
            .Where(category => category.SiteId == _siteContext.SiteId)
            .ToListAsync();

        return Ok(categories);
    }

    [HttpPost]
    public async Task<ActionResult<Category>> CreateCategory(Category category)
    {
        category.Id = 0;
        category.SiteId = _siteContext.SiteId;
        category.Site = null!;

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
    }


}
