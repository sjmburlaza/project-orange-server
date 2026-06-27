using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.DTOs;

public record SiteFeaturesDto(
    bool Insurance,
    bool TradeIn,
    bool Vouchers);

public record SiteDto(
    string Code,
    string CountryName,
    string Locale,
    string Currency,
    string DefaultLanguage,
    IReadOnlyList<string> SupportedLanguages,
    SiteFeaturesDto Features);

public static class SiteDtoMapper
{
    public static SiteDto ToDto(Site site) =>
        new(
            site.Code,
            site.CountryName,
            site.Locale,
            site.Currency,
            site.DefaultLanguage,
            SplitLanguages(site.SupportedLanguages),
            new SiteFeaturesDto(
                site.InsuranceEnabled,
                site.TradeInEnabled,
                site.VouchersEnabled));

    private static string[] SplitLanguages(string supportedLanguages)
    {
        if (string.IsNullOrWhiteSpace(supportedLanguages))
        {
            return [];
        }

        return supportedLanguages
            .Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    }
}
