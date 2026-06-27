using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class SiteSeed
{
    public const string DefaultCode = "ph";
    public const int DefaultId = 1;

    public static Site[] Sites =>
    [
        new()
        {
            Id = 1,
            Code = "ph",
            CountryName = "Philippines",
            Locale = "en-PH",
            Currency = "PHP",
            DefaultLanguage = "en",
            SupportedLanguages = "en",
            InsuranceEnabled = true,
            TradeInEnabled = true,
            VouchersEnabled = true,
            IsActive = true
        },
        new()
        {
            Id = 2,
            Code = "fr",
            CountryName = "France",
            Locale = "fr-FR",
            Currency = "EUR",
            DefaultLanguage = "fr",
            SupportedLanguages = "fr",
            InsuranceEnabled = true,
            TradeInEnabled = false,
            VouchersEnabled = true,
            IsActive = true
        },
        new()
        {
            Id = 3,
            Code = "cn",
            CountryName = "China",
            Locale = "zh-CN",
            Currency = "CNY",
            DefaultLanguage = "zh",
            SupportedLanguages = "zh",
            InsuranceEnabled = true,
            TradeInEnabled = true,
            VouchersEnabled = true,
            IsActive = true
        },
        new()
        {
            Id = 4,
            Code = "jp",
            CountryName = "Japan",
            Locale = "ja-JP",
            Currency = "JPY",
            DefaultLanguage = "ja",
            SupportedLanguages = "ja",
            InsuranceEnabled = true,
            TradeInEnabled = true,
            VouchersEnabled = true,
            IsActive = true
        }
    ];

    public static int? GetSiteId(string code)
    {
        var site = Sites.FirstOrDefault(site =>
            string.Equals(site.Code, code, StringComparison.OrdinalIgnoreCase));

        return site?.Id;
    }
}
