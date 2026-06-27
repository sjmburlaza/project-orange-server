using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/analytics")]
[Route("api/{siteCode:alpha:length(2)}/analytics")]
public class AnalyticsController : ControllerBase
{
    private readonly AnalyticsService _analyticsService;
    private readonly ISiteContext _siteContext;

    public AnalyticsController(AnalyticsService analyticsService, ISiteContext siteContext)
    {
        _analyticsService = analyticsService;
        _siteContext = siteContext;
    }

    [HttpPost("events")]
    public async Task<ActionResult<AnalyticsDashboardDto>> SaveEvents(
        [FromBody] JsonElement body,
        [FromRoute] string? siteCode,
        [FromQuery(Name = "site")] string? querySite,
        [FromQuery] string? period)
    {
        var dashboardSiteCode = siteCode ?? querySite ?? _siteContext.SiteCode;
        var dashboard = await _analyticsService.SaveEventsAsync(
            body,
            siteCode,
            dashboardSiteCode,
            period);

        return StatusCode(StatusCodes.Status201Created, dashboard);
    }
}
