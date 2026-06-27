using System.Text.Json;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductPresentationSeed
{
    public static string GetFeaturesJson(string productName, int baseCategoryId)
    {
        return Serialize(GetFeatures(productName, baseCategoryId));
    }

    public static string GetWhatsInTheBoxJson(string productName, int baseCategoryId)
    {
        return Serialize(GetWhatsInTheBox(productName, baseCategoryId));
    }

    private static List<string> GetFeatures(string productName, int baseCategoryId)
    {
        return baseCategoryId switch
        {
            1 =>
            [
                $"{productName} with unlocked connectivity",
                "All-day battery for everyday use",
                "Advanced camera system",
                "Fast USB-C charging support"
            ],
            2 =>
            [
                $"{productName} built for productivity",
                "Portable design for work anywhere",
                "High-resolution display",
                "Fast USB-C charging support"
            ],
            4 =>
            [
                $"{productName} with crisp display clarity",
                "Comfortable screen size for multitasking",
                "Easy desk setup",
                "Designed for everyday productivity"
            ],
            _ =>
            [
                $"{productName} ready for everyday use",
                "Simple setup",
                "Covered by standard manufacturer warranty"
            ]
        };
    }

    private static List<string> GetWhatsInTheBox(string productName, int baseCategoryId)
    {
        return baseCategoryId switch
        {
            1 =>
            [
                productName,
                "USB-C charge cable",
                "Documentation"
            ],
            2 =>
            [
                productName,
                "Power adapter",
                "USB-C charge cable",
                "Documentation"
            ],
            4 =>
            [
                productName,
                "Stand",
                "Power cable",
                "Display cable",
                "Documentation"
            ],
            _ =>
            [
                productName,
                "Quick start guide"
            ]
        };
    }

    private static string Serialize(List<string> values)
    {
        return JsonSerializer.Serialize(values);
    }
}
