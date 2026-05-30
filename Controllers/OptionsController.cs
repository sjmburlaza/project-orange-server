using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/options")]
public class OptionsController : ControllerBase
{
    [HttpGet("regions")]
    public ActionResult<List<SelectOptionDto>> GetRegions(
        [FromQuery] string? search
    )
    {
        return Filter(RegionSeed.Regions, search);
    }

    [HttpGet("cities")]
    public ActionResult<List<SelectOptionDto>> GetCities(
        [FromQuery] string? parent,
        [FromQuery] string? search
    )
    {
        if (string.IsNullOrWhiteSpace(parent))
        {
            return new List<SelectOptionDto>();
        }

        var cities = CitySeed.CitiesByRegion.TryGetValue(parent, out var result)
            ? result
            : [];

        return Filter(cities, search);
    }

    [HttpGet("barangays")]
    public ActionResult<List<SelectOptionDto>> GetBarangays(
        [FromQuery] string? parent,
        [FromQuery] string? search
    )
    {
        if (string.IsNullOrWhiteSpace(parent))
        {
            return new List<SelectOptionDto>();
        }

        var barangays = BarangaySeed.BarangaysByCity.TryGetValue(parent, out var result)
            ? result
            : [];

        return Filter(barangays, search);
    }

    private static List<SelectOptionDto> Filter(
        List<SelectOptionDto> options,
        string? search
    )
    {
        if (string.IsNullOrWhiteSpace(search))
        {
            return options;
        }

        return options
            .Where(x => x.Label.Contains(search, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}