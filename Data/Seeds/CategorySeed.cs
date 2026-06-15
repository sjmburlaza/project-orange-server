using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class CategorySeed
{
    private const int LegacyCategoriesPerSite = 3;
    private const int FirstAdditionalBaseCategoryId = LegacyCategoriesPerSite + 1;

    private static readonly CategorySeedEntry[] CategoryEntries =
    [
        new(1, "Phones"),
        new(2, "Laptops"),
        new(3, "Accessories"),
        new(FirstAdditionalBaseCategoryId, "Monitors")
    ];

    public static Category[] Categories =>
        SiteSeed.Sites
            .SelectMany(site =>
                CategoryEntries.Select(category => new Category
                {
                    Id = GetCategoryId(site.Id, category.BaseCategoryId),
                    SiteId = site.Id,
                    Name = category.Name
                }))
            .ToArray();

    public static int GetCategoryId(int siteId, int baseCategoryId)
    {
        if (!CategoryEntries.Any(category => category.BaseCategoryId == baseCategoryId))
        {
            throw new ArgumentOutOfRangeException(
                nameof(baseCategoryId),
                baseCategoryId,
                "Unknown base category id.");
        }

        return baseCategoryId < FirstAdditionalBaseCategoryId
            ? GetLegacyCategoryId(siteId, baseCategoryId)
            : GetAdditionalCategoryId(siteId, baseCategoryId);
    }

    private static int GetLegacyCategoryId(int siteId, int baseCategoryId) =>
        ((siteId - 1) * LegacyCategoriesPerSite) + baseCategoryId;

    private static int GetAdditionalCategoryId(int siteId, int baseCategoryId) =>
        (SiteSeed.Sites.Length * LegacyCategoriesPerSite)
        + ((baseCategoryId - FirstAdditionalBaseCategoryId) * SiteSeed.Sites.Length)
        + siteId;

    private sealed record CategorySeedEntry(int BaseCategoryId, string Name);
}
