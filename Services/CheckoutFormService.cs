using System.Text.Json;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class CheckoutFormService
{
    private readonly IWebHostEnvironment _env;
    private readonly ISiteContext _siteContext;

    public CheckoutFormService(IWebHostEnvironment env, ISiteContext siteContext)
    {
        _env = env;
        _siteContext = siteContext;
    }

    public async Task<CheckoutFormDto?> GetFormAsync()
    {
        var sitePath = Path.Combine(
            _env.ContentRootPath,
            "Config",
            "sites",
            _siteContext.SiteCode,
            "checkout-form.json");

        var fallbackPath = Path.Combine(
            _env.ContentRootPath,
            "Config",
            "checkout-form.json");

        var path = File.Exists(sitePath)
            ? sitePath
            : fallbackPath;

        if (!File.Exists(path))
        {
            return null;
        }

        var json = await File.ReadAllTextAsync(path);

        return JsonSerializer.Deserialize<CheckoutFormDto>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }
        );
    }
}
