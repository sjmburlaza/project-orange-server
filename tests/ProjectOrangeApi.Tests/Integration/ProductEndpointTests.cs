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

    private static readonly Dictionary<string, string[]> ExpectedAccessoryOptionGroupLabels =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Keyboard"] = ["Color", "Connection", "Layout", "Switch"],
            ["Mouse"] = ["Color", "Connection", "Shape", "Sensitivity"],
            ["Earbuds"] = ["Color", "Fit", "Noise Control"],
            ["Headphones"] = ["Color", "Connection", "Noise Control"],
            ["Headset"] = ["Color", "Connection", "Microphone"]
        };

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
    public void ProductOptionSeed_Accessories_HaveConfigurableOptionGroups()
    {
        var accessoryProducts = ProductSeed.Products
            .Where(product => product.CategoryId == CategorySeed.GetCategoryId(product.SiteId, 3))
            .ToList();
        var optionGroupsByProductId = ProductOptionSeed.OptionGroups
            .GroupBy(group => group.ProductId)
            .ToDictionary(group => group.Key, group => group.ToList());
        var optionsByGroupId = ProductOptionSeed.Options
            .GroupBy(option => option.ProductOptionGroupId)
            .ToDictionary(group => group.Key, group => group.ToList());
        var variantsByProductId = ProductVariantSeed.Variants
            .GroupBy(variant => variant.ProductId)
            .ToDictionary(group => group.Key, group => group.ToList());
        var variantOptionsByVariantId = ProductVariantSeed.VariantOptions
            .GroupBy(variantOption => variantOption.ProductVariantId)
            .ToDictionary(group => group.Key, group => group.ToList());

        Assert.All(accessoryProducts, product =>
        {
            var groups = optionGroupsByProductId[product.Id]
                .OrderBy(group => group.SortOrder)
                .ThenBy(group => group.Id)
                .ToList();

            Assert.Equal(
                ExpectedAccessoryOptionGroupLabels[product.SubcategoryName],
                groups.Select(group => group.Label));
            Assert.All(groups, group =>
            {
                Assert.True(optionsByGroupId.ContainsKey(group.Id));
                Assert.NotEmpty(optionsByGroupId[group.Id]);
            });

            var variants = variantsByProductId[product.Id];
            Assert.Equal(4, variants.Count);
            Assert.Contains(variants, variant => variant.Id == ProductVariantSeed.GetDefaultVariantId(product.Id));
            Assert.All(variants, variant =>
            {
                Assert.True(variantOptionsByVariantId.ContainsKey(variant.Id));
                Assert.Equal(groups.Count, variantOptionsByVariantId[variant.Id].Count);
            });
        });
    }

    [Fact]
    public async Task GetProduct_WhenAccessorySeeded_IncludesOptionGroups()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);
        var product = ProductSeed.Products.Single(candidate => candidate.Id == ProductSeed.GetProductId(site.Id, 11));
        var category = CategorySeed.Categories.Single(candidate => candidate.Id == product.CategoryId);
        var optionGroups = ProductOptionSeed.OptionGroups
            .Where(group => group.ProductId == product.Id)
            .ToList();
        var groupIds = optionGroups.Select(group => group.Id).ToHashSet();
        var options = ProductOptionSeed.Options
            .Where(option => groupIds.Contains(option.ProductOptionGroupId))
            .ToList();
        var variants = ProductVariantSeed.Variants
            .Where(variant => variant.ProductId == product.Id)
            .ToList();
        var variantIds = variants.Select(variant => variant.Id).ToHashSet();
        var variantOptions = ProductVariantSeed.VariantOptions
            .Where(variantOption => variantIds.Contains(variantOption.ProductVariantId))
            .ToList();

        var dbOptions = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"accessory-product-options-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(dbOptions);
        db.Sites.Add(site);
        db.Categories.Add(category);
        db.Products.Add(product);
        db.ProductOptionGroups.AddRange(optionGroups);
        db.ProductOptions.AddRange(options);
        db.ProductVariants.AddRange(variants);
        db.ProductVariantOptions.AddRange(variantOptions);
        await db.SaveChangesAsync();

        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetProduct(product.Id);

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var result = Assert.IsType<ProductConfigureDto>(ok.Value);

        Assert.Equal(["Color", "Connection", "Layout", "Switch"], result.OptionGroups.Select(group => group.Label));
        Assert.All(result.OptionGroups, group => Assert.NotEmpty(group.Options));
        Assert.Equal(4, result.Variants.Count);
        Assert.All(result.Variants, variant => Assert.Equal(result.OptionGroups.Count, variant.Options.Count));
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

    [Fact]
    public async Task GetSearchSuggestions_RanksMatchesAndReturnsAtMostFiveForCurrentSite()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var otherSite = CloneSite(TestSites.Get("fr"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"product-search-suggestions-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.AddRange(site, otherSite);
        db.Categories.AddRange(
            new Category { Id = 100, SiteId = site.Id, Name = "Accessories" },
            new Category { Id = 200, SiteId = otherSite.Id, Name = "Accessories" });
        db.Products.AddRange(
            CreateProduct(1000, site.Id, 100, "Mouse", "A compact pointing device.", "Mouse"),
            CreateProduct(1001, site.Id, 100, "Mouse Pad", "A smooth desk surface.", "Mouse"),
            CreateProduct(1002, site.Id, 100, "Mouse Bungee", "Keeps cables tidy.", "Mouse"),
            CreateProduct(1003, site.Id, 100, "Gaming Mouse", "A precise gaming device.", "Mouse"),
            CreateProduct(1004, site.Id, 100, "Precision Mouse", "A precise work device.", "Mouse"),
            CreateProduct(1005, site.Id, 100, "Wireless Mouse", "A wireless work device.", "Mouse"),
            CreateProduct(2000, otherSite.Id, 200, "Mouse Trap", "Must not cross sites.", "Mouse"));
        await db.SaveChangesAsync();

        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetSearchSuggestions("mouse");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var suggestions = Assert.IsAssignableFrom<IEnumerable<string>>(ok.Value).ToList();

        Assert.Equal(5, suggestions.Count);
        Assert.Equal("Mouse", suggestions[0]);
        Assert.Equal(["Mouse Bungee", "Mouse Pad"], suggestions.Skip(1).Take(2));
        Assert.DoesNotContain("Mouse Trap", suggestions);
    }

    [Fact]
    public async Task GetProducts_WithSearch_DefaultsToRelevanceOrdering()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"product-search-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.Add(site);
        db.Categories.Add(new Category { Id = 100, SiteId = site.Id, Name = "Accessories" });
        db.Products.AddRange(
            CreateProduct(1000, site.Id, 100, "Mechanical Keyboard", "For typing.", "Keyboard"),
            CreateProduct(1001, site.Id, 100, "Keyboard Case", "Protective cover.", "Cases"),
            CreateProduct(1002, site.Id, 100, "Keyboard", "Compact keyboard.", "Keyboard"),
            CreateProduct(1003, site.Id, 100, "Desktop Stand", "A stand with a keyboard tray.", "Stands"),
            CreateProduct(1004, site.Id, 100, "Wireless Mouse", "A pointing device.", "Mouse"));
        await db.SaveChangesAsync();

        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetProducts(
            categoryId: null,
            sortBy: null,
            minPrice: null,
            maxPrice: null,
            search: "  KEYBOARD ");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductDto>>(ok.Value).ToList();

        Assert.Equal(
            ["Keyboard", "Keyboard Case", "Mechanical Keyboard", "Desktop Stand"],
            products.Select(product => product.Name));
    }

    [Fact]
    public async Task GetSearchSuggestions_WithBlankQuery_ReturnsEmptyList()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"blank-product-search-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var controller = new ProductsController(db, siteContext);

        var response = await controller.GetSearchSuggestions(" ");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        Assert.Empty(Assert.IsAssignableFrom<IEnumerable<string>>(ok.Value));
    }

    private static Product CreateProduct(
        int id,
        int siteId,
        int categoryId,
        string name,
        string description,
        string subcategory)
    {
        return new Product
        {
            Id = id,
            SiteId = siteId,
            CategoryId = categoryId,
            Name = name,
            Description = description,
            SubcategoryName = subcategory,
            Price = 100m,
            StockQuantity = 10,
            ImageUrl = $"/images/products/{id}.png"
        };
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
