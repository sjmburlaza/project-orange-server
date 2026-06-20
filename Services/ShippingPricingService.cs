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

    public List<FulfillmentOptionDto> GetFulfillmentOptions(string? postalCode = null)
    {
        var siteSeed = FulfillmentOptionSeed.ForSite(_siteContext.SiteCode);

        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return GetFulfillmentOptionsForRule(siteSeed.DefaultRule, siteSeed);
        }

        var normalized = NormalizePostalCode(postalCode);

        if (!IsPostalCodeServiceable(normalized))
        {
            return [];
        }

        var rule = GetAreaRule(normalized, siteSeed);

        return GetFulfillmentOptionsForRule(rule, siteSeed);
    }

    public List<FulfillmentOptionDto> GetFulfillmentOptionsByPostalCode(string postalCode)
    {
        return GetFulfillmentOptions(postalCode);
    }

    public FulfillmentOptionDto? GetFulfillmentOptionByCode(string postalCode, string code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return null;
        }

        return GetFulfillmentOptionsByPostalCode(postalCode)
            .FirstOrDefault(option =>
                string.Equals(option.Code, code, StringComparison.OrdinalIgnoreCase));
    }

    public bool IsPostalCodeServiceable(string postalCode)
    {
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return false;
        }

        var normalized = NormalizePostalCode(postalCode);

        return _siteContext.SiteCode switch
        {
            "ph" => PostalCodeSeed.IsServiceable(normalized),
            "fr" => IsDigits(normalized, 5),
            "cn" => IsDigits(normalized, 6),
            "jp" => IsDigits(normalized.Replace("-", string.Empty), 7),
            _ => false
        };
    }

    private static FulfillmentAreaRule GetAreaRule(
        string postalCode,
        FulfillmentSiteSeed siteSeed)
    {
        return siteSeed.AreaRules.FirstOrDefault(rule =>
            rule.PostalCodePrefixes.Any(prefix =>
                postalCode.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))) ??
            siteSeed.DefaultRule;
    }

    private static List<FulfillmentOptionDto> GetFulfillmentOptionsForRule(
        FulfillmentAreaRule rule,
        FulfillmentSiteSeed siteSeed)
    {
        var deliveryOptions = rule.DeliveryOptions
            .Select(option => new FulfillmentOptionDto
            {
                Code = option.Code,
                Type = "delivery",
                Label = option.Label,
                Price = option.Price,
                EstimatedAvailability = option.EstimatedAvailability,
                CourierCode = option.CourierCode,
                CourierName = option.CourierName
            })
            .ToList();

        var pickupLocationIds = rule.PickupLocationIds.ToHashSet(StringComparer.OrdinalIgnoreCase);
        var pickupOptions = siteSeed.PickupLocations
            .Where(location => pickupLocationIds.Contains(location.Id))
            .Select(location => new FulfillmentOptionDto
            {
                Code = $"pickup-{location.Id}",
                Type = "pickup",
                Label = $"{siteSeed.PickupLabelPrefix} {location.Name}",
                Price = 0,
                EstimatedAvailability = location.EstimatedAvailability,
                PickupLocationId = location.Id,
                PickupLocationName = location.Name,
                PickupAddress = location.Address
            });

        deliveryOptions.AddRange(pickupOptions);

        return deliveryOptions;
    }

    private static string NormalizePostalCode(string postalCode)
    {
        return postalCode.Trim();
    }

    private static bool IsDigits(string value, int length)
    {
        return value.Length == length && value.All(char.IsDigit);
    }
}
