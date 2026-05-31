namespace ProjectOrangeApi.Data.Seeds;

public static class ShippingRateSeed
{
    public static readonly List<ShippingRateRule> Rules =
    [
        new()
        {
            Prefixes = ["10", "11", "12"],
            Options =
            [
                new()
                {
                    Code = "standard",
                    Label = "Standard Delivery",
                    Price = 80,
                    EstimatedDelivery = "2-4 days"
                },
                new()
                {
                    Code = "express",
                    Label = "Express Delivery",
                    Price = 150,
                    EstimatedDelivery = "1-2 days"
                },
                new()
                {
                    Code = "same-day",
                    Label = "Same Day Delivery",
                    Price = 250,
                    EstimatedDelivery = "Within the day"
                }
            ]
        },

        new()
        {
            Prefixes = ["40"],
            Options =
            [
                new()
                {
                    Code = "standard",
                    Label = "Standard Delivery",
                    Price = 120,
                    EstimatedDelivery = "3-5 days"
                },
                new()
                {
                    Code = "express",
                    Label = "Express Delivery",
                    Price = 220,
                    EstimatedDelivery = "2-3 days"
                },
                new()
                {
                    Code = "priority",
                    Label = "Priority Delivery",
                    Price = 300,
                    EstimatedDelivery = "Next day"
                }
            ]
        },

        new()
        {
            Prefixes = ["41"],
            Options =
            [
                new()
                {
                    Code = "standard",
                    Label = "Standard Delivery",
                    Price = 130,
                    EstimatedDelivery = "3-5 days"
                },
                new()
                {
                    Code = "express",
                    Label = "Express Delivery",
                    Price = 240,
                    EstimatedDelivery = "2-3 days"
                },
                new()
                {
                    Code = "priority",
                    Label = "Priority Delivery",
                    Price = 320,
                    EstimatedDelivery = "Next day"
                }
            ]
        }
    ];
}

public class ShippingRateRule
{
    public List<string> Prefixes { get; set; } = [];
    public List<ShippingOptionDto> Options { get; set; } = [];
}