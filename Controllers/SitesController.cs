using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/sites")]
public class SitesController : ControllerBase
{
    private readonly AppDbContext _context;

    public SitesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SiteDto>>> GetSites()
    {
        var sites = await _context.Sites
            .AsNoTracking()
            .Where(site => site.IsActive)
            .OrderBy(site => site.Id)
            .Select(site => SiteDtoMapper.ToDto(site))
            .ToListAsync();

        return Ok(sites);
    }

    [HttpGet("{code}")]
    public async Task<ActionResult<SiteDto>> GetSite(string code)
    {
        var site = await _context.Sites
            .AsNoTracking()
            .FirstOrDefaultAsync(site =>
                site.Code == code.ToLower() &&
                site.IsActive);

        return site is null
            ? NotFound()
            : Ok(SiteDtoMapper.ToDto(site));
    }
}
