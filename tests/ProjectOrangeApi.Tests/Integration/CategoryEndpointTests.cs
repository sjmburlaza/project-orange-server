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

public class CategoryEndpointTests
{
    [Fact]
    public async Task GetCategories_WhenAccessoriesSeeded_ReturnsSubcategories()
    {
        var site = CloneSite(TestSites.Get("ph"));
        var siteContext = new TestSiteContext();
        siteContext.SetSite(site);

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"category-endpoints-{Guid.NewGuid():N}")
            .Options;

        await using var db = new AppDbContext(options);
        db.Sites.Add(site);
        db.Categories.AddRange(CategorySeed.Categories.Where(category => category.SiteId == site.Id));
        await db.SaveChangesAsync();

        var controller = new CategoriesController(db, siteContext);

        var response = await controller.GetCategories();

        var ok = Assert.IsType<OkObjectResult>(response.Result);
        var categories = Assert.IsAssignableFrom<IEnumerable<CategoryDto>>(ok.Value).ToList();
        var accessories = Assert.Single(categories, category => category.Name == "Accessories");

        Assert.Equal(
            ["Keyboard", "Mouse", "Earbuds", "Headphones", "Headset"],
            accessories.Subcategories);
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
