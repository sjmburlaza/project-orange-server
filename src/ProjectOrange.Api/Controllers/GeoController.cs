using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/geo")]
[Route("api/{siteCode:alpha:length(2)}/geo")]
public class GeoController : ControllerBase
{
    private readonly GeoCountryService _geoCountryService;

    public GeoController(GeoCountryService geoCountryService)
    {
        _geoCountryService = geoCountryService;
    }

    [HttpGet("country")]
    public async Task<ActionResult<GeoCountryResponseDto>> GetCountry(
        CancellationToken cancellationToken)
    {
        var countryCode = await _geoCountryService.GetCountryCodeAsync(
            HttpContext,
            cancellationToken);

        return Ok(new GeoCountryResponseDto(countryCode));
    }
}
