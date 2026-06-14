using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class CategorySeed
{
    private static readonly string[] CategoryNames =
    [
        "Phones",
        "Laptops",
        "Accessories"
    ];

    public static Category[] Categories =>
        SiteSeed.Sites
            .SelectMany((site, siteIndex) =>
                CategoryNames.Select((name, categoryIndex) => new Category
                {
                    Id = (siteIndex * CategoryNames.Length) + categoryIndex + 1,
                    SiteId = site.Id,
                    Name = name
                }))
            .ToArray();

    public static int GetCategoryId(int siteId, int baseCategoryId)
    {
        var siteIndex = siteId - 1;
        return (siteIndex * CategoryNames.Length) + baseCategoryId;
    }
}
