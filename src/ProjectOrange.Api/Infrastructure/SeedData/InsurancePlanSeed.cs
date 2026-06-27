namespace ProjectOrangeApi.Data.Seeds;

public static class InsurancePlanSeed
{
    private static readonly Dictionary<string, List<InsurancePlan>> PlansByCategory =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Phones"] =
            [
                new()
                {
                    Name = "Essential Phone Care",
                    Code = "PHONE_CARE_ESSENTIAL",
                    Description = "Covers accidental screen damage and standard repair support for one year.",
                    Amount = 799
                },
                new()
                {
                    Name = "Premium Phone Care",
                    Code = "PHONE_CARE_PREMIUM",
                    Description = "Adds priority repair handling, extended accidental damage coverage, and battery support.",
                    Amount = 1299
                },
                new()
                {
                    Name = "Complete Phone Care",
                    Code = "PHONE_CARE_COMPLETE",
                    Description = "Full phone protection with priority repairs, accidental damage coverage, and replacement support.",
                    Amount = 1899
                }
            ],
            ["Laptops"] =
            [
                new()
                {
                    Name = "Essential Laptop Care",
                    Code = "LAPTOP_CARE_ESSENTIAL",
                    Description = "Covers hardware diagnostics, accidental damage protection, and standard repair support.",
                    Amount = 2499
                },
                new()
                {
                    Name = "Premium Laptop Care",
                    Code = "LAPTOP_CARE_PREMIUM",
                    Description = "Adds priority service, liquid damage coverage, and extended repair support.",
                    Amount = 3999
                },
                new()
                {
                    Name = "Complete Laptop Care",
                    Code = "LAPTOP_CARE_COMPLETE",
                    Description = "Comprehensive laptop protection with priority repairs, accidental damage coverage, and battery support.",
                    Amount = 5499
                }
            ],
            ["Monitors"] =
            [
                new()
                {
                    Name = "Essential Monitor Care",
                    Code = "MONITOR_CARE_ESSENTIAL",
                    Description = "Covers panel diagnostics, standard repair support, and power-related issues.",
                    Amount = 1199
                },
                new()
                {
                    Name = "Premium Monitor Care",
                    Code = "MONITOR_CARE_PREMIUM",
                    Description = "Adds accidental damage coverage, priority service, and extended parts support.",
                    Amount = 1899
                },
                new()
                {
                    Name = "Complete Monitor Care",
                    Code = "MONITOR_CARE_COMPLETE",
                    Description = "Comprehensive monitor protection with priority repairs, accidental damage coverage, and replacement support.",
                    Amount = 2499
                }
            ]
        };

    public static List<InsurancePlan> GetPlans(string categoryName)
    {
        return PlansByCategory.TryGetValue(categoryName, out var plans)
            ? plans
            : [];
    }

    public static InsurancePlan? FindPlan(string categoryName, string code)
    {
        return GetPlans(categoryName).FirstOrDefault(plan =>
            string.Equals(plan.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}

public class InsurancePlan
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string BillingFrequency { get; set; } = string.Empty;
}
