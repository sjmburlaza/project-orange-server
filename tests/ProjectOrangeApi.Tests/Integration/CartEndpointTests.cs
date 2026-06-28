using System.Text.Json;
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

public class CartEndpointTests
{
    [Fact]
    public async Task GetCart_ReturnsEntryTotalPrice()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"cart-total-price-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.Add(site);
        db.Carts.Add(new Cart
        {
            Id = 100,
            SiteId = site.Id,
            Code = "CART-TOTAL",
            Entries =
            [
                new CartItem
                {
                    Id = 101,
                    ProductId = 1,
                    ProductName = "Orange Phone",
                    Price = 12.50m,
                    Quantity = 3,
                    StockQuantity = 10,
                    ImageUrl = "/images/products/orange-phone.png",
                    CategoryName = "Phones",
                    SubcategoryName = "Smartphones"
                }
            ]
        });
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.GetCart("CART-TOTAL");

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var cart = Assert.IsType<CartResponseDto>(ok.Value);
        var entry = Assert.Single(cart.Entries);

        Assert.Equal(37.50m, entry.TotalPrice);
        Assert.Equal("Smartphones", entry.SubcategoryName);

        var json = JsonSerializer.Serialize(entry, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        using var document = JsonDocument.Parse(json);
        Assert.Equal(37.50m, document.RootElement.GetProperty("totalPrice").GetDecimal());
        Assert.Equal("Smartphones", document.RootElement.GetProperty("subcategoryName").GetString());
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
