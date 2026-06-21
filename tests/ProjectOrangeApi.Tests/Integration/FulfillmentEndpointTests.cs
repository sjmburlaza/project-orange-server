using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectOrangeApi.Controllers;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;
using Xunit;

namespace ProjectOrangeApi.Tests.Integration;

public class FulfillmentEndpointTests : IClassFixture<FulfillmentApiFixture>
{
    private readonly HttpClient _client;

    public FulfillmentEndpointTests(FulfillmentApiFixture fixture)
    {
        _client = fixture.Client;
    }

    [Fact]
    public async Task GetOptions_WhenRouteSiteCodeIsFrance_ReturnsFranceOptions()
    {
        using var response = await _client.GetAsync(
            "/api/fr/fulfillment/options?postalCode=75001");
        var failureBody = await response.Content.ReadAsStringAsync();
        Assert.True(response.IsSuccessStatusCode, failureBody);

        var options = await response.Content.ReadFromJsonAsync<List<FulfillmentOptionDto>>();

        Assert.True(options is not null);
        Assert.Contains(options, option =>
            option.Code == "coursier-paris-same-day" &&
            option.Type == "delivery" &&
            option.Price == 19.90m);
        Assert.Contains(options, option =>
            option.Code == "pickup-paris-saint-lazare" &&
            option.Type == "pickup" &&
            option.Label.StartsWith("Retrait", StringComparison.Ordinal));
    }

    [Fact]
    public async Task GetOptions_WhenHeaderSiteCodeIsJapan_ReturnsJapanOptions()
    {
        using var request = new HttpRequestMessage(
            HttpMethod.Get,
            "/api/fulfillment/options?postalCode=100-0001");
        request.Headers.Add(SiteResolutionMiddleware.SiteCodeHeader, "jp");

        using var response = await _client.SendAsync(request);
        var failureBody = await response.Content.ReadAsStringAsync();
        Assert.True(response.IsSuccessStatusCode, failureBody);

        var options = await response.Content.ReadFromJsonAsync<List<FulfillmentOptionDto>>();

        Assert.True(options is not null);
        Assert.Contains(options, option =>
            option.Code == "tokyo-bike-same-day" &&
            option.Type == "delivery" &&
            option.Price == 1800m);
    }

    [Fact]
    public async Task GetOptions_WhenRouteSiteCodeIsUnsupported_ReturnsSiteNotFound()
    {
        using var response = await _client.GetAsync(
            "/api/xx/fulfillment/options?postalCode=75001");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

        var body = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();

        Assert.True(body is not null);
        Assert.Equal("SITE_NOT_FOUND", body!["code"]);
    }
}

public sealed class FulfillmentApiFixture : IAsyncLifetime
{
    private WebApplication? _app;

    public HttpClient Client { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        var builder = WebApplication.CreateBuilder(new WebApplicationOptions
        {
            EnvironmentName = "Testing"
        });

        builder.WebHost.UseKestrel();
        builder.WebHost.UseUrls("http://127.0.0.1:0");

        var databaseName = $"fulfillment-endpoints-{Guid.NewGuid():N}";

        builder.Services.AddControllers()
            .AddApplicationPart(typeof(FulfillmentController).Assembly);
        builder.Services.AddScoped<ShippingPricingService>();
        builder.Services.AddScoped<SiteContext>();
        builder.Services.AddScoped<ISiteContext>(provider =>
            provider.GetRequiredService<SiteContext>());
        builder.Services.AddScoped<ISiteContextAccessor>(provider =>
            provider.GetRequiredService<SiteContext>());
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase(databaseName));

        _app = builder.Build();

        await SeedSitesAsync(_app.Services);

        _app.UseRouting();
        _app.UseMiddleware<SiteResolutionMiddleware>();
        _app.MapControllers();

        await _app.StartAsync();

        var addresses = _app.Services
            .GetRequiredService<IServer>()
            .Features
            .Get<IServerAddressesFeature>()!
            .Addresses;
        var address = Assert.Single(addresses);

        Client = new HttpClient
        {
            BaseAddress = new Uri(address)
        };
    }

    public async Task DisposeAsync()
    {
        Client.Dispose();

        if (_app is not null)
        {
            await _app.DisposeAsync();
        }
    }

    private static async Task SeedSitesAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        db.Sites.AddRange(SiteSeed.Sites);
        await db.SaveChangesAsync();
    }
}
