namespace ProjectOrangeApi.Data.Seeds;

public static class MobilePlanSeed
{
    public static readonly List<MobilePlan> Plans =
    [
        new()
        {
            Name = "Basic Mobile Plan",
            Code = "MOBILE_PLAN_BASIC",
            Amount = 599,
            BillingFrequency = "month",
            DataAllowance = "10GB",
            Description = "10GB monthly data with unlimited texts and standard calls."
        },
        new()
        {
            Name = "Plus Mobile Plan",
            Code = "MOBILE_PLAN_PLUS",
            Amount = 899,
            BillingFrequency = "month",
            DataAllowance = "25GB",
            Description = "25GB monthly data with unlimited texts and calls."
        },
        new()
        {
            Name = "Unlimited Mobile Plan",
            Code = "MOBILE_PLAN_UNLIMITED",
            Amount = 1299,
            BillingFrequency = "month",
            DataAllowance = "Unlimited",
            Description = "Unlimited monthly data, calls, and texts."
        }
    ];

    public static List<MobilePlan> GetPlans(string categoryName)
    {
        return string.Equals(categoryName, "Phones", StringComparison.OrdinalIgnoreCase)
            ? Plans
            : [];
    }

    public static MobilePlan? FindPlan(string categoryName, string code)
    {
        return GetPlans(categoryName).FirstOrDefault(plan =>
            string.Equals(plan.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}

public class MobilePlan
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string BillingFrequency { get; set; } = string.Empty;
    public string DataAllowance { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
