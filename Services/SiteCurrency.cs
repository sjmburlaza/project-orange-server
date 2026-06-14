namespace ProjectOrangeApi.Services;

public static class SiteCurrency
{
    public static decimal ConvertPhpAmount(decimal phpAmount, string currency)
    {
        return currency switch
        {
            "EUR" => Math.Round(phpAmount / 60m, 2),
            "CNY" => Math.Round(phpAmount / 7.8m, 2),
            "JPY" => Math.Round(phpAmount * 2.7m, 0),
            _ => phpAmount
        };
    }

    public static string FormatAmount(decimal amount, string currency, bool monthly = false)
    {
        var value = currency switch
        {
            "JPY" => amount.ToString("N0"),
            _ => amount.ToString("N2")
        };

        var suffix = monthly ? "/month" : string.Empty;
        return $"{currency} {value}{suffix}";
    }

    public static string ConvertDisplayAmount(string amount, string currency)
    {
        var monthly = amount.Contains("/month", StringComparison.OrdinalIgnoreCase);
        var numericAmount = ParseAmount(amount);
        var convertedAmount = ConvertPhpAmount(numericAmount, currency);

        return FormatAmount(convertedAmount, currency, monthly);
    }

    public static decimal ParseAmount(string amount)
    {
        var amountText = new string(amount
            .Where(character => char.IsDigit(character) || character == '.' || character == '-')
            .ToArray());

        return decimal.TryParse(amountText, out var value)
            ? value
            : 0;
    }
}
