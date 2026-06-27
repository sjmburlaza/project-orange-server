namespace ProjectOrangeApi.Data.Seeds;

public static class AddonSeed
{
    public static readonly List<Addon> Addons =
    [
        new()
        {
            Id = "mobile-plan",
            Name = "Mobile Plan",
            Title = "Add a mobile plan",
            Description = "Choose a monthly mobile plan for your phone.",
            ImageUrl = "",
            EligibleCategories = ["Phones"]
        },
        new()
        {
            Id = "insurance",
            Name = "Insurance",
            Title = "Protect your device",
            Description = "Choose a protection plan for accidental damage and repair support.",
            ImageUrl = "",
            EligibleCategories = ["Phones", "Laptops", "Monitors"]
        },
        new()
        {
            Id = "trade-in",
            Name = "Trade-In",
            Title = "Trade in an old device",
            Description = "Answer a few questions and get an estimated trade-in value.",
            ImageUrl = "",
            EligibleCategories = ["Phones", "Laptops"]
        }
    ];

    public static List<Addon> GetEligibleAddons(string categoryName)
    {
        return Addons
            .Where(addon => addon.EligibleCategories.Contains(categoryName, StringComparer.OrdinalIgnoreCase))
            .ToList();
    }

    public static Addon? FindById(string id)
    {
        return Addons.FirstOrDefault(addon =>
            string.Equals(addon.Id, id, StringComparison.OrdinalIgnoreCase));
    }
}

public class Addon
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> EligibleCategories { get; set; } = [];
}
