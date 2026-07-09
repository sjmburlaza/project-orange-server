using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Controllers;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;
using ProjectOrangeApi.Tests.Support;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class CartRecommendedProductsEndpointTests
{
    [Fact]
    public async Task GetRecommendedProducts_WhenCartHasLaptop_ReturnsRelevantAccessories()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"cart-recommendations-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        SeedLaptopCartWithAccessories(db, site);
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.GetRecommendedProducts("CART-TEST");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductConfigureDto>>(ok.Value).ToList();

        Assert.Collection(
            products,
            product => AssertRecommendedProduct(product, "Desk Keyboard", "Keyboard"),
            product => AssertRecommendedProduct(product, "Desk Mouse", "Mouse"),
            product => AssertRecommendedProduct(product, "Travel Earbuds", "Earbuds"),
            product => AssertRecommendedProduct(product, "Focus Headphones", "Headphones"),
            product => AssertRecommendedProduct(product, "Meeting Headset", "Headset"));

        var keyboard = products[0];
        var keyboardCategory = Assert.IsType<CategoryDto>(keyboard.Category);
        Assert.Equal("Accessories", keyboardCategory.Name);
        Assert.Contains("Keyboard", keyboardCategory.Subcategories);
        Assert.Equal(["Low-profile switches", "Bluetooth connectivity"], keyboard.Features);
        Assert.Equal(["Desk Keyboard", "USB-C cable"], keyboard.WhatsInTheBox);
        Assert.Equal(4.5m, keyboard.ReviewRating);
        Assert.Equal(315, keyboard.ReviewCount);
        var variant = Assert.Single(keyboard.Variants);
        Assert.Equal(100100, variant.Id);
        Assert.Equal("KEYBOARD-BLACK", variant.Sku);
        Assert.Equal("inStock", variant.StockStatus);
    }

    [Fact]
    public async Task GetRecommendedProducts_WhenAccessoryAlreadyInCart_ExcludesCartProduct()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"cart-recommendations-exclude-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var seeded = SeedLaptopCartWithAccessories(db, site);

        seeded.Cart.Entries.Add(new CartItem
        {
            Id = 502,
            ProductId = seeded.Keyboard.Id,
            ProductName = seeded.Keyboard.Name,
            Price = seeded.Keyboard.Price,
            Quantity = 1,
            StockQuantity = seeded.Keyboard.StockQuantity,
            ImageUrl = seeded.Keyboard.ImageUrl,
            CategoryName = "Accessories"
        });

        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.GetRecommendedProducts("CART-TEST");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductConfigureDto>>(ok.Value).ToList();

        Assert.DoesNotContain(products, product => product.Id == seeded.Keyboard.Id);
        Assert.Contains(products, product => product.Name == "Desk Mouse");
    }

    [Fact]
    public async Task GetRecommendedProducts_WhenCartHasOnlyAccessories_ReturnsEmptyList()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"cart-recommendations-empty-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        var seeded = SeedLaptopCartWithAccessories(db, site);
        seeded.Cart.Entries.Clear();
        seeded.Cart.Entries.Add(new CartItem
        {
            Id = 503,
            ProductId = seeded.Keyboard.Id,
            ProductName = seeded.Keyboard.Name,
            Price = seeded.Keyboard.Price,
            Quantity = 1,
            StockQuantity = seeded.Keyboard.StockQuantity,
            ImageUrl = seeded.Keyboard.ImageUrl,
            CategoryName = "Accessories"
        });

        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.GetRecommendedProducts("CART-TEST");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var products = Assert.IsAssignableFrom<IEnumerable<ProductConfigureDto>>(ok.Value);

        Assert.Empty(products);
    }

    private static SeededRecommendationCatalog SeedLaptopCartWithAccessories(AppDbContext db, Site site)
    {
        var laptopCategory = new Category
        {
            Id = 100,
            SiteId = site.Id,
            Name = "Laptops"
        };

        var accessoriesCategory = new Category
        {
            Id = 101,
            SiteId = site.Id,
            Name = "Accessories",
            Subcategories = ["Keyboard", "Mouse", "Earbuds", "Headphones", "Headset"]
        };

        var laptop = CreateProduct(1000, site, laptopCategory, "Work Laptop", "A laptop for work.", 50000m, 5);
        var keyboard = CreateProduct(1001, site, accessoriesCategory, "Desk Keyboard", "A keyboard.", 2500m, 12, "Keyboard");
        var mouse = CreateProduct(1002, site, accessoriesCategory, "Desk Mouse", "A mouse.", 1200m, 20, "Mouse");
        var earbuds = CreateProduct(1003, site, accessoriesCategory, "Travel Earbuds", "Wireless earbuds.", 3200m, 10, "Earbuds");
        var headphones = CreateProduct(1004, site, accessoriesCategory, "Focus Headphones", "Noise cancelling headphones.", 8200m, 8, "Headphones");
        var headset = CreateProduct(1005, site, accessoriesCategory, "Meeting Headset", "USB headset.", 1800m, 15, "Headset");
        var webcam = CreateProduct(1006, site, accessoriesCategory, "Desk Webcam", "An unrelated accessory.", 2200m, 7, "Webcam");
        var outOfStockMouse = CreateProduct(1007, site, accessoriesCategory, "Out of Stock Mouse", "Unavailable mouse.", 900m, 0, "Mouse");

        var cart = new Cart
        {
            Id = 500,
            SiteId = site.Id,
            Code = "CART-TEST",
            Entries =
            [
                new CartItem
                {
                    Id = 501,
                    ProductId = laptop.Id,
                    ProductName = laptop.Name,
                    Price = laptop.Price,
                    Quantity = 1,
                    StockQuantity = laptop.StockQuantity,
                    ImageUrl = laptop.ImageUrl,
                    CategoryName = "Laptops"
                }
            ]
        };

        db.Sites.Add(site);
        db.Categories.AddRange(laptopCategory, accessoriesCategory);
        db.Products.AddRange(laptop, keyboard, mouse, earbuds, headphones, headset, webcam, outOfStockMouse);
        db.ProductVariants.Add(new ProductVariant
        {
            Id = 100100,
            ProductId = keyboard.Id,
            Product = keyboard,
            Sku = "KEYBOARD-BLACK",
            Price = keyboard.Price,
            StockQuantity = keyboard.StockQuantity,
            ImageUrl = keyboard.ImageUrl
        });
        db.Carts.Add(cart);

        return new SeededRecommendationCatalog(cart, keyboard);
    }

    private static Product CreateProduct(
        int id,
        Site site,
        Category category,
        string name,
        string description,
        decimal price,
        int stockQuantity,
        string subcategoryName = "")
    {
        return new Product
        {
            Id = id,
            SiteId = site.Id,
            Name = name,
            Description = description,
            Price = price,
            ReviewRating = 4.5m,
            ReviewCount = 315,
            StockQuantity = stockQuantity,
            ImageUrl = $"/images/products/{id}.png",
            CategoryId = category.Id,
            Category = category,
            SubcategoryName = subcategoryName,
            FeaturesJson = subcategoryName == "Keyboard"
                ? """["Low-profile switches","Bluetooth connectivity"]"""
                : "[]",
            WhatsInTheBoxJson = subcategoryName == "Keyboard"
                ? """["Desk Keyboard","USB-C cable"]"""
                : "[]"
        };
    }

    private static CartsController CreateController(AppDbContext db, TestSiteContext siteContext)
    {
        var service = new CartService(
            db,
            new ShippingPricingService(siteContext),
            new TradeInSessionService(),
            siteContext);

        return new CartsController(service)
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext()
            }
        };
    }

    private static void AssertRecommendedProduct(
        ProductConfigureDto product,
        string name,
        string subcategoryName)
    {
        Assert.Equal(name, product.Name);
        Assert.Equal("Accessories", product.CategoryName);
        Assert.Equal(subcategoryName, product.SubcategoryName);
        Assert.Equal("inStock", product.StockStatus);
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

    private sealed record SeededRecommendationCatalog(Cart Cart, Product Keyboard);
}
