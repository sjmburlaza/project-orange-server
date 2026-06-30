using System.Security.Claims;
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

public class WishlistEndpointTests
{
    private const string UserId = "wishlist-user";

    [Fact]
    public async Task AddItem_WhenProductExists_AddsProductAndReturnsWishlist()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"wishlist-add-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        SeedProduct(db, site, productId: 1000);
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.AddItem(new AddWishlistItemRequest
        {
            ProductId = 1000
        });

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var wishlist = Assert.IsType<WishlistResponseDto>(ok.Value);
        var item = Assert.Single(wishlist.Items);

        Assert.Equal(1, wishlist.Count);
        Assert.Equal(1000, item.ProductId);
        Assert.Equal("Orange Phone", item.Product.Name);
        Assert.Equal("Phones", item.Product.CategoryName);
        Assert.Equal("Smartphones", item.Product.SubcategoryName);
        Assert.Equal(1, await db.WishlistItems.CountAsync());
    }

    [Fact]
    public async Task AddItem_WhenAlreadyWishlisted_DoesNotCreateDuplicate()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"wishlist-duplicate-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        SeedProduct(db, site, productId: 1000);
        db.WishlistItems.Add(new WishlistItem
        {
            SiteId = site.Id,
            UserId = UserId,
            ProductId = 1000,
            CreatedAtUtc = DateTimeOffset.UtcNow.AddMinutes(-5)
        });
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.AddItem(new AddWishlistItemRequest
        {
            ProductId = 1000
        });

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var wishlist = Assert.IsType<WishlistResponseDto>(ok.Value);

        Assert.Single(wishlist.Items);
        Assert.Equal(1, await db.WishlistItems.CountAsync());
    }

    [Fact]
    public async Task AddItem_WhenProductBelongsToDifferentSite_ReturnsNotFoundProblem()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var otherSite = CloneSite(TestSites.Get("fr"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"wishlist-site-isolation-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.Add(site);
        SeedProduct(db, otherSite, productId: 2000);
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.AddItem(new AddWishlistItemRequest
        {
            ProductId = 2000
        });

        var notFound = Assert.IsType<ObjectResult>(response.Result);
        var problem = Assert.IsType<ProblemDetails>(notFound.Value);

        Assert.Equal(StatusCodes.Status404NotFound, notFound.StatusCode);
        Assert.Equal(ApiErrorCodes.Wishlist.ProductNotFound, problem.Extensions["code"]);
        Assert.Empty(db.WishlistItems);
    }

    [Fact]
    public async Task GetItemStatus_WhenProductIsWishlisted_ReturnsTrue()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"wishlist-status-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        SeedProduct(db, site, productId: 1000);
        db.WishlistItems.Add(new WishlistItem
        {
            SiteId = site.Id,
            UserId = UserId,
            ProductId = 1000,
            CreatedAtUtc = DateTimeOffset.UtcNow
        });
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.GetItemStatus(1000);

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var status = Assert.IsType<WishlistStatusDto>(ok.Value);

        Assert.Equal(1000, status.ProductId);
        Assert.True(status.IsWishlisted);
    }

    [Fact]
    public async Task RemoveItem_WhenProductIsWishlisted_RemovesItem()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"wishlist-remove-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        SeedProduct(db, site, productId: 1000);
        db.WishlistItems.Add(new WishlistItem
        {
            SiteId = site.Id,
            UserId = UserId,
            ProductId = 1000,
            CreatedAtUtc = DateTimeOffset.UtcNow
        });
        await db.SaveChangesAsync();

        var controller = CreateController(db, siteContext);

        var response = await controller.RemoveItem(1000);

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var wishlist = Assert.IsType<WishlistResponseDto>(ok.Value);

        Assert.Empty(wishlist.Items);
        Assert.Empty(db.WishlistItems);
    }

    private static WishlistController CreateController(
        AppDbContext db,
        TestSiteContext siteContext)
    {
        var service = new WishlistService(db, siteContext);
        var httpContext = new DefaultHttpContext
        {
            User = new ClaimsPrincipal(new ClaimsIdentity(
                [new Claim(ClaimTypes.NameIdentifier, UserId)],
                "test"))
        };

        return new WishlistController(service)
        {
            ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            }
        };
    }

    private static void SeedProduct(AppDbContext db, Site site, int productId)
    {
        var category = new Category
        {
            Id = productId + 10,
            SiteId = site.Id,
            Name = "Phones"
        };

        db.Sites.Add(site);
        db.Categories.Add(category);
        db.Products.Add(new Product
        {
            Id = productId,
            SiteId = site.Id,
            Name = "Orange Phone",
            Description = "A phone for wishlist endpoint tests.",
            Price = 999m,
            StockQuantity = 7,
            ImageUrl = "/images/products/orange-phone.png",
            CategoryId = category.Id,
            SubcategoryName = "Smartphones"
        });
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
