using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Controllers;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Tests.Support;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class ProductEndpointTests
{
    private static readonly HashSet<string> AllowedAccessorySubcategories =
    [
        "Keyboard",
        "Mouse",
        "Earbuds",
        "Headphones",
        "Headset"
    ];

    [Fact]
    public void ProductSeed_Accessories_HaveAllowedSubcategoryNames()
    {
        var accessoryProducts = ProductSeed.Products
            .Where(product => product.CategoryId == CategorySeed.GetCategoryId(product.SiteId, 3))
            .ToList();

        Assert.Equal(SiteSeed.Sites.Length * 9, accessoryProducts.Count);
        Assert.All(accessoryProducts, product =>
        {
            Assert.Contains(product.SubcategoryName, AllowedAccessorySubcategories);
        });
    }

    [Fact]
    public async Task GetProducts_WhenProductHasSubcategory_IncludesSubcategoryName()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"product-subcategory-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.Add(site);
        db.Categories.Add(new Category
        {
            Id = 100,
            SiteId = site.Id,
            Name = "Accessories"
        });
        db.Products.Add(new Product
        {
            Id = 1000,
            SiteId = site.Id,
            Name = "Mechanical Keyboard",
            Description = "Compact RGB mechanical keyboard.",
            Price = 3500m,
            StockQuantity = 25,
            ImageUrl = "/images/products/mechanical-keyboard.png",
            CategoryId = 100,
            SubcategoryName = "Keyboard"
        });
        await db.SaveChangesAsync();

        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetProducts(
            categoryId: null,
            sortBy: null,
            minPrice: null,
            maxPrice: null);

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductDto>>(ok.Value);
        var product = Assert.Single(products);

        Assert.Equal("Keyboard", product.SubcategoryName);
    }

    [Fact]
    public async Task GetProducts_WhenProductHasColorOptions_IncludesAvailableColors()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"product-endpoints-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        await SeedProductWithColorsAsync(db, site);

        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetProducts(
            categoryId: null,
            sortBy: null,
            minPrice: null,
            maxPrice: null);

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductDto>>(ok.Value);
        var product = Assert.Single(products);

        Assert.Collection(
            product.AvailableColors,
            color =>
            {
                Assert.Equal(ProductOptionSeed.BlackOptionCode, color.Code);
                Assert.Equal("Black", color.Label);
                Assert.Equal("#111827", color.Hex);
            },
            color =>
            {
                Assert.Equal(ProductOptionSeed.BlueOptionCode, color.Code);
                Assert.Equal("Blue", color.Label);
                Assert.Equal("#2563eb", color.Hex);
                Assert.Equal("/images/products/test-phone-blue.png", color.ImageUrl);
            });
    }

    private static async Task SeedProductWithColorsAsync(AppDbContext db, Site site)
    {
        var category = new Category
        {
            Id = 100,
            SiteId = site.Id,
            Name = "Phones"
        };

        var product = new Product
        {
            Id = 1000,
            SiteId = site.Id,
            Name = "Test Phone",
            Description = "A configurable phone for endpoint tests.",
            Price = 999m,
            StockQuantity = 10,
            ImageUrl = "/images/products/test-phone.png",
            CategoryId = category.Id
        };

        var colorGroup = new ProductOptionGroup
        {
            Id = 10000,
            ProductId = product.Id,
            Code = ProductOptionSeed.ColorGroupCode,
            Label = "Color",
            SortOrder = 1
        };

        var storageGroup = new ProductOptionGroup
        {
            Id = 10001,
            ProductId = product.Id,
            Code = ProductOptionSeed.StorageGroupCode,
            Label = "Storage",
            SortOrder = 2
        };

        db.Sites.Add(site);
        db.Categories.Add(category);
        db.Products.Add(product);
        db.ProductOptionGroups.AddRange(colorGroup, storageGroup);
        db.ProductOptions.AddRange(
            new ProductOption
            {
                Id = 100000,
                ProductOptionGroupId = colorGroup.Id,
                Code = ProductOptionSeed.BlackOptionCode,
                Label = "Black",
                Hex = "#111827",
                SortOrder = 1
            },
            new ProductOption
            {
                Id = 100001,
                ProductOptionGroupId = colorGroup.Id,
                Code = ProductOptionSeed.BlueOptionCode,
                Label = "Blue",
                Hex = "#2563eb",
                ImageUrl = "/images/products/test-phone-blue.png",
                SortOrder = 2
            },
            new ProductOption
            {
                Id = 100002,
                ProductOptionGroupId = storageGroup.Id,
                Code = ProductOptionSeed.Storage128OptionCode,
                Label = "128GB",
                SortOrder = 1
            });
        db.ProductVariants.Add(new ProductVariant
        {
            Id = 1000000,
            ProductId = product.Id,
            Sku = "TEST-PHONE-BLACK-128GB",
            Price = 999m,
            StockQuantity = 10,
            ImageUrl = product.ImageUrl
        });

        await db.SaveChangesAsync();
    }

    private static Site CloneSite(Site site)
    {
        return new Site
        {
            Id = site.Id,
            Code = site.Code,
            CountryName = site.CountryName,
            Locale = site.Locale,
            Currency = site.Currency,
            DefaultLanguage = site.DefaultLanguage,
            SupportedLanguages = site.SupportedLanguages,
            InsuranceEnabled = site.InsuranceEnabled,
            TradeInEnabled = site.TradeInEnabled,
            VouchersEnabled = site.VouchersEnabled,
            IsActive = site.IsActive
        };
    }
}
