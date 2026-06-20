using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductOptionSeed
{
    public const string ColorGroupCode = "color";
    public const string StorageGroupCode = "storage";
    public const string MemoryGroupCode = "memory";
    public const string StandGroupCode = "stand";
    public const string BlackOptionCode = "black";
    public const string BlueOptionCode = "blue";
    public const string MidnightOptionCode = "midnight";
    public const string SilverOptionCode = "silver";
    public const string Storage128OptionCode = "128gb";
    public const string Storage256OptionCode = "256gb";
    public const string Storage512OptionCode = "512gb";
    public const string Storage1TbOptionCode = "1tb";
    public const string Memory8OptionCode = "8gb";
    public const string Memory16OptionCode = "16gb";
    public const string Memory32OptionCode = "32gb";
    public const string StandardStandOptionCode = "standard";
    public const string HeightAdjustableStandOptionCode = "height-adjustable";

    private static readonly Dictionary<int, ProductOptionProfile> ProfilesByBaseProductId = new()
    {
        [1] = ProductOptionProfile.Phone,
        [2] = ProductOptionProfile.Phone,
        [3] = ProductOptionProfile.Phone,
        [4] = ProductOptionProfile.Phone,
        [5] = ProductOptionProfile.Phone,
        [6] = ProductOptionProfile.Laptop,
        [7] = ProductOptionProfile.Laptop,
        [8] = ProductOptionProfile.Laptop,
        [9] = ProductOptionProfile.Laptop,
        [10] = ProductOptionProfile.Laptop,
        [20] = ProductOptionProfile.Monitor,
        [21] = ProductOptionProfile.Monitor,
        [22] = ProductOptionProfile.Monitor,
        [23] = ProductOptionProfile.Monitor
    };

    public static ProductOptionGroup[] OptionGroups =>
        SiteSeed.Sites
            .SelectMany(site => ProfilesByBaseProductId
                .SelectMany(profile => CreateOptionGroups(
                    ProductSeed.GetProductId(site.Id, profile.Key),
                    profile.Value)))
            .ToArray();

    public static ProductOption[] Options =>
        SiteSeed.Sites
            .SelectMany(site => ProfilesByBaseProductId
                .SelectMany(profile => CreateOptions(
                    ProductSeed.GetProductId(site.Id, profile.Key),
                    profile.Value)))
            .ToArray();

    public static bool IsConfigurableProductId(int productId)
    {
        return GetOptionProfile(productId) != ProductOptionProfile.None;
    }

    public static ProductOptionProfile GetOptionProfile(int productId)
    {
        foreach (var site in SiteSeed.Sites)
        {
            foreach (var profile in ProfilesByBaseProductId)
            {
                if (ProductSeed.GetProductId(site.Id, profile.Key) == productId)
                {
                    return profile.Value;
                }
            }
        }

        return ProductOptionProfile.None;
    }

    public static int GetOptionGroupId(int productId, string groupCode)
    {
        return productId * 10 + GetGroupIndex(groupCode);
    }

    public static int GetOptionId(int productId, string groupCode, string optionCode)
    {
        return productId * 100 + (GetGroupIndex(groupCode) * 10) + GetOptionIndex(groupCode, optionCode);
    }

    private static ProductOptionGroup[] CreateOptionGroups(int productId, ProductOptionProfile profile)
    {
        return GetOptionGroupDefinitions(profile)
            .Select((group, index) => new ProductOptionGroup
            {
                Id = GetOptionGroupId(productId, group.Code),
                ProductId = productId,
                Code = group.Code,
                Label = group.Label,
                SortOrder = index + 1
            })
            .ToArray();
    }

    private static ProductOption[] CreateOptions(int productId, ProductOptionProfile profile)
    {
        return GetOptionGroupDefinitions(profile)
            .SelectMany(group => group.Options
                .Select((option, index) => new ProductOption
                {
                    Id = GetOptionId(productId, group.Code, option.Code),
                    ProductOptionGroupId = GetOptionGroupId(productId, group.Code),
                    Code = option.Code,
                    Label = option.Label,
                    Hex = option.Hex,
                    ImageUrl = option.ImageUrl,
                    SortOrder = index + 1
                }))
            .ToArray();
    }

    private static OptionGroupDefinition[] GetOptionGroupDefinitions(ProductOptionProfile profile)
    {
        return profile switch
        {
            ProductOptionProfile.Phone =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(BlueOptionCode, "Blue", "#2563eb")
                ]),
                new(StorageGroupCode, "Storage",
                [
                    new(Storage128OptionCode, "128GB"),
                    new(Storage256OptionCode, "256GB"),
                    new(Storage512OptionCode, "512GB")
                ])
            ],
            ProductOptionProfile.Laptop =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(MidnightOptionCode, "Midnight", "#1f2937"),
                    new(SilverOptionCode, "Silver", "#d1d5db")
                ]),
                new(MemoryGroupCode, "Memory",
                [
                    new(Memory8OptionCode, "8GB"),
                    new(Memory16OptionCode, "16GB"),
                    new(Memory32OptionCode, "32GB")
                ]),
                new(StorageGroupCode, "Storage",
                [
                    new(Storage256OptionCode, "256GB"),
                    new(Storage512OptionCode, "512GB"),
                    new(Storage1TbOptionCode, "1TB")
                ])
            ],
            ProductOptionProfile.Monitor =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(SilverOptionCode, "Silver", "#d1d5db")
                ]),
                new(StandGroupCode, "Stand",
                [
                    new(StandardStandOptionCode, "Standard Stand"),
                    new(HeightAdjustableStandOptionCode, "Height Adjustable Stand")
                ])
            ],
            _ => []
        };
    }

    private static int GetGroupIndex(string groupCode)
    {
        return groupCode switch
        {
            ColorGroupCode => 1,
            StorageGroupCode => 2,
            MemoryGroupCode => 3,
            StandGroupCode => 4,
            _ => throw new ArgumentOutOfRangeException(nameof(groupCode), groupCode, "Unknown option group code.")
        };
    }

    private static int GetOptionIndex(string groupCode, string optionCode)
    {
        return (groupCode, optionCode) switch
        {
            (ColorGroupCode, BlackOptionCode) => 1,
            (ColorGroupCode, BlueOptionCode) => 2,
            (ColorGroupCode, MidnightOptionCode) => 3,
            (ColorGroupCode, SilverOptionCode) => 4,
            (StorageGroupCode, Storage128OptionCode) => 1,
            (StorageGroupCode, Storage256OptionCode) => 2,
            (StorageGroupCode, Storage512OptionCode) => 3,
            (StorageGroupCode, Storage1TbOptionCode) => 4,
            (MemoryGroupCode, Memory8OptionCode) => 1,
            (MemoryGroupCode, Memory16OptionCode) => 2,
            (MemoryGroupCode, Memory32OptionCode) => 3,
            (StandGroupCode, StandardStandOptionCode) => 1,
            (StandGroupCode, HeightAdjustableStandOptionCode) => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(optionCode), optionCode, "Unknown option code.")
        };
    }

    private sealed record OptionGroupDefinition(string Code, string Label, OptionDefinition[] Options);

    private sealed record OptionDefinition(
        string Code,
        string Label,
        string? Hex = null,
        string? ImageUrl = null);

    public enum ProductOptionProfile
    {
        None,
        Phone,
        Laptop,
        Monitor
    }
}
