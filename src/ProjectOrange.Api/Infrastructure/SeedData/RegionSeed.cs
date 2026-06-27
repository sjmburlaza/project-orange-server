using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class RegionSeed
{
    public static List<SelectOptionDto> Regions =>
    [
        new() { Label = "Metro Manila", Value = "metro-manila" },
        new() { Label = "Central Luzon", Value = "central-luzon" },
        new() { Label = "CALABARZON", Value = "calabarzon" },
        new() { Label = "Ilocos Region", Value = "ilocos-region" },
        new() { Label = "Cagayan Valley", Value = "cagayan-valley" },
        new() { Label = "Bicol Region", Value = "bicol-region" },
        new() { Label = "Western Visayas", Value = "western-visayas" },
        new() { Label = "Central Visayas", Value = "central-visayas" },
        new() { Label = "Eastern Visayas", Value = "eastern-visayas" },
        new() { Label = "Zamboanga Peninsula", Value = "zamboanga-peninsula" },
        new() { Label = "Northern Mindanao", Value = "northern-mindanao" },
        new() { Label = "Davao Region", Value = "davao-region" },
        new() { Label = "SOCCSKSARGEN", Value = "soccsksargen" },
        new() { Label = "Caraga", Value = "caraga" },
        new() { Label = "BARMM", Value = "barmm" },
        new() { Label = "Cordillera Administrative Region", Value = "car" },
        new() { Label = "MIMAROPA", Value = "mimaropa" },
        new() { Label = "Negros Island Region", Value = "negros-island-region" },
        new() { Label = "Aurora Province", Value = "aurora-province" },
        new() { Label = "Palawan", Value = "palawan" }
    ];
}