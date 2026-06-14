using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class ShippingPricingService
{
    private readonly ISiteContext _siteContext;

    public ShippingPricingService(ISiteContext siteContext)
    {
        _siteContext = siteContext;
    }

    public List<ShippingOptionDto> GetRatesByPostalCode(string postalCode)
    {
        if (!IsPostalCodeServiceable(postalCode))
        {
            return [];
        }

        var code = postalCode.Trim();

        if (_siteContext.SiteCode != "ph")
        {
            return GetDefaultRatesForSite();
        }

        var rule = ShippingRateSeed.Rules.FirstOrDefault(rule =>
            rule.Prefixes.Any(prefix => code.StartsWith(prefix)));

        if (rule is null)
        {
            return [];
        }

        return rule.Options
            .Select(option => new ShippingOptionDto
            {
                Code = option.Code,
                Label = option.Label,
                Price = option.Price,
                EstimatedDelivery = option.EstimatedDelivery
            })
            .ToList();
    }

    public bool IsPostalCodeServiceable(string postalCode)
    {
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return false;
        }

        var normalized = postalCode.Trim();

        return _siteContext.SiteCode switch
        {
            "ph" => PostalCodeSeed.IsServiceable(normalized),
            "fr" => IsDigits(normalized, 5),
            "cn" => IsDigits(normalized, 6),
            "jp" => IsDigits(normalized.Replace("-", string.Empty), 7),
            _ => false
        };
    }

    private List<ShippingOptionDto> GetDefaultRatesForSite()
    {
        return _siteContext.SiteCode switch
        {
            "fr" =>
            [
                new() { Code = "standard", Label = "Standard Delivery", Price = 6.90m, EstimatedDelivery = "3-5 days" },
                new() { Code = "express", Label = "Express Delivery", Price = 14.90m, EstimatedDelivery = "1-2 days" }
            ],
            "cn" =>
            [
                new() { Code = "standard", Label = "Standard Delivery", Price = 30, EstimatedDelivery = "3-5 days" },
                new() { Code = "express", Label = "Express Delivery", Price = 60, EstimatedDelivery = "1-2 days" }
            ],
            "jp" =>
            [
                new() { Code = "standard", Label = "Standard Delivery", Price = 700, EstimatedDelivery = "3-5 days" },
                new() { Code = "express", Label = "Express Delivery", Price = 1200, EstimatedDelivery = "1-2 days" }
            ],
            _ => []
        };
    }

    private static bool IsDigits(string value, int length)
    {
        return value.Length == length && value.All(char.IsDigit);
    }
}
