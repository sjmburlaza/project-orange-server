using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class ShippingPricingService
{
    public List<ShippingOptionDto> GetRatesByPostalCode(string postalCode)
    {
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return [];
        }

        var code = postalCode.Trim();

        if (!PostalCodeSeed.IsServiceable(code))
        {
            return [];
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
}