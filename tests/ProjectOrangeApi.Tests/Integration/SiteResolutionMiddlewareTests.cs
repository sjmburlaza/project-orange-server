using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.Services;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class SiteResolutionMiddlewareTests
{
    [Fact]
    public async Task InvokeAsync_WhenRouteSiteCodeIsActive_SetsSiteContextAndCallsNext()
    {
        await using var db = CreateDbContext();
        var siteContext = new SiteContext();
        var nextCalled = false;
        var middleware = new SiteResolutionMiddleware(_ =>
        {
            nextCalled = true;
            return Task.CompletedTask;
        });
        var httpContext = new DefaultHttpContext();
        httpContext.Request.Path = "/api/fr/fulfillment/options";
        httpContext.Request.RouteValues = new RouteValueDictionary
        {
            ["siteCode"] = "fr"
        };

        await middleware.InvokeAsync(httpContext, db, siteContext);

        Assert.True(nextCalled);
        Assert.Equal("fr", siteContext.SiteCode);
        Assert.Equal(2, siteContext.SiteId);
    }

    [Fact]
    public async Task InvokeAsync_WhenSiteCodeIsUnsupported_ReturnsNotFoundAndSkipsNext()
    {
        await using var db = CreateDbContext();
        var siteContext = new SiteContext();
        var nextCalled = false;
        var middleware = new SiteResolutionMiddleware(_ =>
        {
            nextCalled = true;
            return Task.CompletedTask;
        });
        var httpContext = new DefaultHttpContext();
        httpContext.Request.Path = "/api/fulfillment/options";
        httpContext.Request.Headers[SiteResolutionMiddleware.SiteCodeHeader] = "xx";
        httpContext.Response.Body = new MemoryStream();

        await middleware.InvokeAsync(httpContext, db, siteContext);

        Assert.False(nextCalled);
        Assert.Equal(StatusCodes.Status404NotFound, httpContext.Response.StatusCode);

        httpContext.Response.Body.Position = 0;
        var body = await JsonSerializer.DeserializeAsync<Dictionary<string, string>>(
            httpContext.Response.Body);

        Assert.True(body is not null);
        Assert.Equal("SITE_NOT_FOUND", body!["code"]);
        Assert.Contains("xx", body["message"]);
    }

    private static AppDbContext CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase($"site-resolution-{Guid.NewGuid():N}")
            .Options;
        var db = new AppDbContext(options);

        db.Sites.AddRange(SiteSeed.Sites);
        db.SaveChanges();

        return db;
    }
}
