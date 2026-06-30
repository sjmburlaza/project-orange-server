using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;
using ProjectOrangeApi.Tests.Support;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class OrderEndpointTests
{
    [Fact]
    public async Task PlaceOrder_FromCartEntry_IncludesSubcategoryName()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"order-subcategory-{Guid.NewGuid():N}")
            .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        await using var db = new AppDbContext(options);
        var category = new Category
        {
            Id = 100,
            SiteId = site.Id,
            Site = site,
            Name = "Phones",
            Subcategories = ["Smartphones"]
        };
        var product = new Product
        {
            Id = 200,
            SiteId = site.Id,
            Site = site,
            Name = "Orange Phone",
            Description = "A phone for order tests.",
            Price = 100m,
            StockQuantity = 5,
            ImageUrl = "/images/products/orange-phone.png",
            CategoryId = category.Id,
            Category = category,
            SubcategoryName = "Smartphones"
        };

        db.Sites.Add(site);
        db.Categories.Add(category);
        db.Products.Add(product);
        await db.SaveChangesAsync();

        var service = new OrderService(
            db,
            siteContext,
            new ShippingPricingService(siteContext));

        var confirmation = await service.PlaceOrderAsync(new PlaceOrderRequestDto
        {
            Cart = new CartResponseDto
            {
                Code = "CART-ORDER",
                Entries =
                [
                    new CartItemDto
                    {
                        ProductId = product.Id,
                        ProductName = "Orange Phone",
                        Price = 100m,
                        Quantity = 2,
                        ImageUrl = "/images/products/orange-phone.png",
                        CategoryName = "Phones",
                        SubcategoryName = "Smartphones"
                    }
                ]
            },
            CustomerName = "Order Tester",
            CustomerEmail = "order@example.com"
        });

        var item = Assert.Single(confirmation.Items);

        Assert.Equal("Smartphones", item.SubcategoryName);
        Assert.Equal("Smartphones", Assert.Single(db.OrderItems).SubcategoryName);

        var json = JsonSerializer.Serialize(item, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        using var document = JsonDocument.Parse(json);
        Assert.Equal("Smartphones", document.RootElement.GetProperty("subcategoryName").GetString());
    }

    [Fact]
    public async Task LookupOrder_IncludesShippingAmount()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"order-shipping-{Guid.NewGuid():N}")
            .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

        await using var db = new AppDbContext(options);
        var category = new Category
        {
            Id = 101,
            SiteId = site.Id,
            Site = site,
            Name = "Phones",
            Subcategories = ["Smartphones"]
        };
        var product = new Product
        {
            Id = 201,
            SiteId = site.Id,
            Site = site,
            Name = "Orange Phone",
            Description = "A phone for order lookup tests.",
            Price = 100m,
            StockQuantity = 5,
            ImageUrl = "/images/products/orange-phone.png",
            CategoryId = category.Id,
            Category = category,
            SubcategoryName = "Smartphones"
        };

        db.Sites.Add(site);
        db.Categories.Add(category);
        db.Products.Add(product);
        await db.SaveChangesAsync();

        var service = new OrderService(
            db,
            siteContext,
            new ShippingPricingService(siteContext));

        var confirmation = await service.PlaceOrderAsync(new PlaceOrderRequestDto
        {
            Cart = new CartResponseDto
            {
                Code = "CART-SHIPPING",
                Entries =
                [
                    new CartItemDto
                    {
                        ProductId = product.Id,
                        ProductName = "Orange Phone",
                        Price = 100m,
                        Quantity = 2,
                        ImageUrl = "/images/products/orange-phone.png",
                        CategoryName = "Phones",
                        SubcategoryName = "Smartphones"
                    }
                ],
                CartSummary =
                [
                    new CartSummaryAttributeDto { Name = "Subtotal", Amount = 200m },
                    new CartSummaryAttributeDto { Name = "Shipping", Amount = 50m },
                    new CartSummaryAttributeDto { Name = "Total", Amount = 250m }
                ]
            },
            CustomerName = "Order Tester",
            CustomerEmail = "order@example.com"
        });

        db.ChangeTracker.Clear();

        var lookup = await service.LookupOrderAsync(confirmation.OrderNumber, "ORDER@example.com");

        Assert.NotNull(lookup);
        Assert.Equal(50m, lookup!.ShippingAmount);

        var json = JsonSerializer.Serialize(lookup, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        using var document = JsonDocument.Parse(json);
        Assert.Equal(50m, document.RootElement.GetProperty("shippingAmount").GetDecimal());
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
