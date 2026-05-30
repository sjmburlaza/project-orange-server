using System.Text.Json;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class CheckoutFormService
{
    private readonly IWebHostEnvironment _env;

    public CheckoutFormService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public async Task<CheckoutFormDto?> GetFormAsync()
    {
        var path = Path.Combine(
            _env.ContentRootPath,
            "Config",
            "checkout-form.json"
        );

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