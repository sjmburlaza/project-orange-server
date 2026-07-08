using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductSeed
{
    private const int LegacyProductsPerSite = 20;
    private const int FirstAdditionalProductId = LegacyProductsPerSite + 1;

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
