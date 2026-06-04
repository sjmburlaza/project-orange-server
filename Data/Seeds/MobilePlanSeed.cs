using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class MobilePlanSeed
{
    public static readonly List<MobilePlanDto> Plans =
    [
        new()
        {
            Name = "Basic Mobile Plan",
            Code = "MOBILE_PLAN_BASIC",
            Amount = "P599/month",
            DataAllowance = "10GB",
            Description = "10GB monthly data with unlimited texts and standard calls."
        },
        new()
        {
            Name = "Plus Mobile Plan",
            Code = "MOBILE_PLAN_PLUS",
            Amount = "P899/month",
            DataAllowance = "25GB",
            Description = "25GB monthly data with unlimited texts and calls."
        },
        new()
        {
            Name = "Unlimited Mobile Plan",
            Code = "MOBILE_PLAN_UNLIMITED",
            Amount = "P1,299/month",
            DataAllowance = "Unlimited",
            Description = "Unlimited monthly data, calls, and texts."
        }
    ];

    public static List<MobilePlanDto> GetPlans(string categoryName)
    {
        return string.Equals(categoryName, "Phones", StringComparison.OrdinalIgnoreCase)
            ? Plans
            : [];
    }

    public static MobilePlanDto? FindPlan(string categoryName, string code)
    {
        return GetPlans(categoryName).FirstOrDefault(plan =>
            string.Equals(plan.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}
