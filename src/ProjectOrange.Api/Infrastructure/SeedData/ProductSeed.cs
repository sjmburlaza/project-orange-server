using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductSeed
{
    private const int LegacyProductsPerSite = 20;
    private const int FirstAdditionalProductId = LegacyProductsPerSite + 1;
    private static readonly decimal[] ReviewRatings =
    [
        3.8m,
        3.9m,
        4.0m,
        4.1m,
        4.2m,
        4.3m,
        4.4m,
        4.5m,
        4.6m,
        4.7m,
        4.8m,
        4.9m
    ];

    private static readonly IReadOnlyDictionary<string, ProductSeedEntry[]> ProductsBySite =
        new Dictionary<string, ProductSeedEntry[]>(StringComparer.OrdinalIgnoreCase)
        {
            ["ph"] = PhilippinesProductSeed.Products,
            ["fr"] = FranceProductSeed.Products,
            ["cn"] = ChinaProductSeed.Products,
            ["jp"] = JapanProductSeed.Products
        };

    public static Product[] Products =>
        SiteSeed.Sites
            .SelectMany(site =>
                ProductsBySite[site.Code].Select(product => new Product
                {
                    Id = GetProductId(site.Id, product.Id),
                    SiteId = site.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    ReviewRating = GetReviewRating(site.Id, product.Id),
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl,
                    SubcategoryName = product.SubcategoryName,
                    FeaturesJson = ProductPresentationSeed.GetFeaturesJson(
                        product.Name,
                        product.CategoryId),
                    WhatsInTheBoxJson = ProductPresentationSeed.GetWhatsInTheBoxJson(
                        product.Name,
                        product.CategoryId),
                    CategoryId = CategorySeed.GetCategoryId(site.Id, product.CategoryId)
                }))
            .ToArray();

    private static decimal GetReviewRating(int siteId, int baseProductId)
    {
        var ratingIndex = ((baseProductId * 7) + (siteId * 3)) % ReviewRatings.Length;
        return ReviewRatings[ratingIndex];
    }

    public static int GetProductId(int siteId, int baseProductId)
    {
        if (baseProductId <= LegacyProductsPerSite)
        {
            var siteIndex = siteId - 1;
            return (siteIndex * LegacyProductsPerSite) + baseProductId;
        }

        return (SiteSeed.Sites.Length * LegacyProductsPerSite)
            + ((baseProductId - FirstAdditionalProductId) * SiteSeed.Sites.Length)
            + siteId;
    }
}

internal sealed record ProductSeedEntry(
    int Id,
    string Name,
    string Description,
    decimal Price,
    int StockQuantity,
    string ImageUrl,
    int CategoryId,
    string SubcategoryName = "");
