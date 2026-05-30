using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class BarangaySeed
{
    public static Dictionary<string, List<SelectOptionDto>> BarangaysByCity =>
        CitySeed.CitiesByRegion
            .SelectMany(region => region.Value)
            .DistinctBy(city => city.Value)
            .ToDictionary(
                city => city.Value,
                city => CreateBarangays(city.Value)
            );

    private static List<SelectOptionDto> CreateBarangays(string cityValue) =>
    [
        new() { Label = "Poblacion", Value = $"{cityValue}-poblacion" },
        new() { Label = "San Isidro", Value = $"{cityValue}-san-isidro" },
        new() { Label = "San Jose", Value = $"{cityValue}-san-jose" },
        new() { Label = "Santa Cruz", Value = $"{cityValue}-santa-cruz" },
        new() { Label = "Bagong Bayan", Value = $"{cityValue}-bagong-bayan" }
    ];
}