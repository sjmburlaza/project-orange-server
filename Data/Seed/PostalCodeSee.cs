namespace ProjectOrangeApi.Data.Seeds;

public static class PostalCodeSeed
{
    private static readonly HashSet<string> ServiceablePostalCodes =
    [
        "1000",
        "1001",
        "1002",
        "1100",
        "1101",
        "1200",
        "1201",
        "4000",
        "4024",
        "4100",
        "4114"
    ];

    public static bool IsServiceable(string postalCode)
    {
        return ServiceablePostalCodes.Contains(postalCode);
    }
}