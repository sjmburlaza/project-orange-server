using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;

namespace ProjectOrangeApi.Services;

public class SiteResolutionMiddleware
{
    public const string SiteCodeHeader = "X-Site-Code";

    private readonly RequestDelegate _next;

    public SiteResolutionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext httpContext,
        AppDbContext db,
        ISiteContextAccessor siteContext)
    {
        if (!httpContext.Request.Path.StartsWithSegments("/api"))
        {
            await _next(httpContext);
            return;
        }

        var siteCode = ResolveSiteCode(httpContext);
        var site = await db.Sites
            .AsNoTracking()
            .FirstOrDefaultAsync(site =>
                site.Code == siteCode &&
                site.IsActive);

        if (site is null)
        {
            httpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            await httpContext.Response.WriteAsJsonAsync(new
            {
                code = "SITE_NOT_FOUND",
                message = $"Site '{siteCode}' is not supported."
            });
            return;
        }

        siteContext.SetSite(site);
        await _next(httpContext);
    }

    private static string ResolveSiteCode(HttpContext httpContext)
    {
        if (httpContext.Request.RouteValues.TryGetValue("siteCode", out var routeSiteCode) &&
            routeSiteCode is not null &&
            !string.IsNullOrWhiteSpace(routeSiteCode.ToString()))
        {
            return Normalize(routeSiteCode.ToString());
        }

        if (httpContext.Request.Headers.TryGetValue(SiteCodeHeader, out var headerSiteCode) &&
            !string.IsNullOrWhiteSpace(headerSiteCode.ToString()))
        {
            return Normalize(headerSiteCode.ToString());
        }

        if (httpContext.Request.Query.TryGetValue("siteCode", out var querySiteCode) &&
            !string.IsNullOrWhiteSpace(querySiteCode.ToString()))
        {
            return Normalize(querySiteCode.ToString());
        }

        return SiteSeed.DefaultCode;
    }

    private static string Normalize(string? siteCode) =>
        string.IsNullOrWhiteSpace(siteCode)
            ? SiteSeed.DefaultCode
            : siteCode.Trim().ToLowerInvariant();
}
