using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class InsurancePlanSeed
{
    private static readonly Dictionary<string, List<InsurancePlanDto>> PlansByCategory =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Phones"] =
            [
                new()
                {
                    Name = "Essential Phone Care",
                    Code = "PHONE_CARE_ESSENTIAL",
                    Description = "Covers accidental screen damage and standard repair support for one year.",
                    Amount = "P799"
                },
                new()
                {
                    Name = "Premium Phone Care",
                    Code = "PHONE_CARE_PREMIUM",
                    Description = "Adds priority repair handling, extended accidental damage coverage, and battery support.",
                    Amount = "P1,299"
                },
                new()
                {
                    Name = "Complete Phone Care",
                    Code = "PHONE_CARE_COMPLETE",
                    Description = "Full phone protection with priority repairs, accidental damage coverage, and replacement support.",
                    Amount = "P1,899"
                }
            ],
            ["Laptops"] =
            [
                new()
                {
                    Name = "Essential Laptop Care",
                    Code = "LAPTOP_CARE_ESSENTIAL",
                    Description = "Covers hardware diagnostics, accidental damage protection, and standard repair support.",
                    Amount = "P2,499"
                },
                new()
                {
                    Name = "Premium Laptop Care",
                    Code = "LAPTOP_CARE_PREMIUM",
                    Description = "Adds priority service, liquid damage coverage, and extended repair support.",
                    Amount = "P3,999"
                },
                new()
                {
                    Name = "Complete Laptop Care",
                    Code = "LAPTOP_CARE_COMPLETE",
                    Description = "Comprehensive laptop protection with priority repairs, accidental damage coverage, and battery support.",
                    Amount = "P5,499"
                }
            ]
        };

    public static List<InsurancePlanDto> GetPlans(string categoryName)
    {
        return PlansByCategory.TryGetValue(categoryName, out var plans)
            ? plans
            : [];
    }

    public static InsurancePlanDto? FindPlan(string categoryName, string code)
    {
        return GetPlans(categoryName).FirstOrDefault(plan =>
            string.Equals(plan.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}
