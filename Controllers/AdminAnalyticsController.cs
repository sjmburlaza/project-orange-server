using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Authorize(Roles = AppRoles.Admin)]
[Route("api/admin/analytics")]
[Route("api/{siteCode:alpha:length(2)}/admin/analytics")]
public class AdminAnalyticsController : ControllerBase
{
    private readonly AnalyticsService _analyticsService;
    private readonly ISiteContext _siteContext;

    public AdminAnalyticsController(AnalyticsService analyticsService, ISiteContext siteContext)
    {
        _analyticsService = analyticsService;
        _siteContext = siteContext;
    }

    [HttpGet("dashboard")]
    public async Task<ActionResult<AnalyticsDashboardDto>> GetDashboard(
        [FromRoute] string? siteCode,
        [FromQuery(Name = "site")] string? querySite)
    {
        return Ok(await _analyticsService.GetDashboardAsync(siteCode ?? querySite ?? _siteContext.SiteCode));
    }
}
