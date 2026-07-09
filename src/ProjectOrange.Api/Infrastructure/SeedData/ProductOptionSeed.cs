using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductOptionSeed
{
    public const string ColorGroupCode = "color";
    public const string StorageGroupCode = "storage";
    public const string MemoryGroupCode = "memory";
    public const string StandGroupCode = "stand";
    public const string ConnectionGroupCode = "connection";
    public const string FormFactorGroupCode = "form-factor";
    public const string SwitchGroupCode = "switch";
    public const string FeatureGroupCode = "feature";
    public const string MicrophoneGroupCode = "microphone";
    public const string BlackOptionCode = "black";
    public const string BlueOptionCode = "blue";
    public const string MidnightOptionCode = "midnight";
    public const string SilverOptionCode = "silver";
    public const string WhiteOptionCode = "white";
    public const string Storage128OptionCode = "128gb";
    public const string Storage256OptionCode = "256gb";
    public const string Storage512OptionCode = "512gb";
    public const string Storage1TbOptionCode = "1tb";
    public const string Memory8OptionCode = "8gb";
    public const string Memory16OptionCode = "16gb";
    public const string Memory32OptionCode = "32gb";
    public const string StandardStandOptionCode = "standard";
    public const string HeightAdjustableStandOptionCode = "height-adjustable";
    public const string WiredUsbCOptionCode = "wired-usb-c";
    public const string BluetoothOptionCode = "bluetooth";
    public const string Wireless24GhzOptionCode = "wireless-2-4ghz";
    public const string CompactOptionCode = "compact";
    public const string FullSizeOptionCode = "full-size";
    public const string ErgonomicOptionCode = "ergonomic";
    public const string AmbidextrousOptionCode = "ambidextrous";
    public const string InEarOptionCode = "in-ear";
    public const string OpenEarOptionCode = "open-ear";
    public const string TactileOptionCode = "tactile";
    public const string LinearOptionCode = "linear";
    public const string Dpi4000OptionCode = "4000-dpi";
    public const string Dpi8000OptionCode = "8000-dpi";
    public const string StandardNoiseControlOptionCode = "standard";
    public const string ActiveNoiseCancellingOptionCode = "anc";
    public const string BoomMicOptionCode = "boom";
    public const string DetachableMicOptionCode = "detachable";

    private static readonly Dictionary<string, ProductOptionProfile> AccessoryProfilesBySubcategory =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Keyboard"] = ProductOptionProfile.Keyboard,
            ["Mouse"] = ProductOptionProfile.Mouse,
            ["Earbuds"] = ProductOptionProfile.Earbuds,
            ["Headphones"] = ProductOptionProfile.Headphones,
            ["Headset"] = ProductOptionProfile.Headset
        };

    public static ProductOptionGroup[] OptionGroups =>
        ProductSeed.Products
            .SelectMany(product => CreateOptionGroups(product.Id, GetOptionProfile(product)))
            .ToArray();

    public static ProductOption[] Options =>
        ProductSeed.Products
            .SelectMany(product => CreateOptions(product.Id, GetOptionProfile(product)))
            .ToArray();

    public static bool IsConfigurableProductId(int productId)
    {
        return GetOptionProfile(productId) != ProductOptionProfile.None;
    }

    public static ProductOptionProfile GetOptionProfile(int productId)
    {
        var product = ProductSeed.Products.FirstOrDefault(candidate => candidate.Id == productId);
        if (product is not null)
        {
            return GetOptionProfile(product);
        }

        return ProductOptionProfile.None;
    }

    public static string[] GetColorOptionCodes(ProductOptionProfile profile)
    {
        return GetOptionGroupDefinitions(profile)
            .Where(group => group.Code == ColorGroupCode)
            .SelectMany(group => group.Options)
            .Select(option => option.Code)
            .ToArray();
    }

    private static ProductOptionProfile GetOptionProfile(Product product)
    {
        if (product.CategoryId == CategorySeed.GetCategoryId(product.SiteId, 1))
        {
            return ProductOptionProfile.Phone;
        }

        if (product.CategoryId == CategorySeed.GetCategoryId(product.SiteId, 2))
        {
            return ProductOptionProfile.Laptop;
        }

        if (product.CategoryId == CategorySeed.GetCategoryId(product.SiteId, 4))
        {
            return ProductOptionProfile.Monitor;
        }

        var accessoryCategoryId = CategorySeed.GetCategoryId(product.SiteId, 3);
        if (product.CategoryId == accessoryCategoryId &&
            AccessoryProfilesBySubcategory.TryGetValue(product.SubcategoryName, out var accessoryProfile))
        {
            return accessoryProfile;
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
                    new(BlueOptionCode, "Blue", "#2563eb"),
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(WhiteOptionCode, "White", "#f9fafb")
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
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(BlackOptionCode, "Black", "#111827"),
                    new(WhiteOptionCode, "White", "#f9fafb")
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
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb")
                ]),
                new(StandGroupCode, "Stand",
                [
                    new(StandardStandOptionCode, "Standard Stand"),
                    new(HeightAdjustableStandOptionCode, "Height Adjustable Stand")
                ])
            ],
            ProductOptionProfile.Keyboard =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb")
                ]),
                new(ConnectionGroupCode, "Connection",
                [
                    new(WiredUsbCOptionCode, "Wired USB-C"),
                    new(BluetoothOptionCode, "Bluetooth")
                ]),
                new(FormFactorGroupCode, "Layout",
                [
                    new(CompactOptionCode, "Compact"),
                    new(FullSizeOptionCode, "Full-size")
                ]),
                new(SwitchGroupCode, "Switch",
                [
                    new(TactileOptionCode, "Tactile"),
                    new(LinearOptionCode, "Linear")
                ])
            ],
            ProductOptionProfile.Mouse =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb")
                ]),
                new(ConnectionGroupCode, "Connection",
                [
                    new(BluetoothOptionCode, "Bluetooth"),
                    new(Wireless24GhzOptionCode, "2.4GHz Wireless")
                ]),
                new(FormFactorGroupCode, "Shape",
                [
                    new(ErgonomicOptionCode, "Ergonomic"),
                    new(AmbidextrousOptionCode, "Ambidextrous")
                ]),
                new(FeatureGroupCode, "Sensitivity",
                [
                    new(Dpi4000OptionCode, "4,000 DPI"),
                    new(Dpi8000OptionCode, "8,000 DPI")
                ])
            ],
            ProductOptionProfile.Earbuds =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb"),
                    new(SilverOptionCode, "Silver", "#d1d5db")
                ]),
                new(FormFactorGroupCode, "Fit",
                [
                    new(InEarOptionCode, "In-ear"),
                    new(OpenEarOptionCode, "Open-ear")
                ]),
                new(FeatureGroupCode, "Noise Control",
                [
                    new(StandardNoiseControlOptionCode, "Standard"),
                    new(ActiveNoiseCancellingOptionCode, "Active Noise Cancelling")
                ])
            ],
            ProductOptionProfile.Headphones =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(SilverOptionCode, "Silver", "#d1d5db"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb")
                ]),
                new(ConnectionGroupCode, "Connection",
                [
                    new(BluetoothOptionCode, "Bluetooth"),
                    new(WiredUsbCOptionCode, "Wired USB-C")
                ]),
                new(FeatureGroupCode, "Noise Control",
                [
                    new(StandardNoiseControlOptionCode, "Standard"),
                    new(ActiveNoiseCancellingOptionCode, "Active Noise Cancelling")
                ])
            ],
            ProductOptionProfile.Headset =>
            [
                new(ColorGroupCode, "Color",
                [
                    new(BlackOptionCode, "Black", "#111827"),
                    new(WhiteOptionCode, "White", "#f9fafb"),
                    new(BlueOptionCode, "Blue", "#2563eb"),
                    new(SilverOptionCode, "Silver", "#d1d5db")
                ]),
                new(ConnectionGroupCode, "Connection",
                [
                    new(WiredUsbCOptionCode, "Wired USB-C"),
                    new(Wireless24GhzOptionCode, "2.4GHz Wireless")
                ]),
                new(MicrophoneGroupCode, "Microphone",
                [
                    new(BoomMicOptionCode, "Boom Mic"),
                    new(DetachableMicOptionCode, "Detachable Mic")
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
            ConnectionGroupCode => 5,
            FormFactorGroupCode => 6,
            SwitchGroupCode => 7,
            FeatureGroupCode => 8,
            MicrophoneGroupCode => 9,
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
            (ColorGroupCode, WhiteOptionCode) => 5,
            (StorageGroupCode, Storage128OptionCode) => 1,
            (StorageGroupCode, Storage256OptionCode) => 2,
            (StorageGroupCode, Storage512OptionCode) => 3,
            (StorageGroupCode, Storage1TbOptionCode) => 4,
            (MemoryGroupCode, Memory8OptionCode) => 1,
            (MemoryGroupCode, Memory16OptionCode) => 2,
            (MemoryGroupCode, Memory32OptionCode) => 3,
            (StandGroupCode, StandardStandOptionCode) => 1,
            (StandGroupCode, HeightAdjustableStandOptionCode) => 2,
            (ConnectionGroupCode, WiredUsbCOptionCode) => 1,
            (ConnectionGroupCode, BluetoothOptionCode) => 2,
            (ConnectionGroupCode, Wireless24GhzOptionCode) => 3,
            (FormFactorGroupCode, CompactOptionCode) => 1,
            (FormFactorGroupCode, FullSizeOptionCode) => 2,
            (FormFactorGroupCode, ErgonomicOptionCode) => 3,
            (FormFactorGroupCode, AmbidextrousOptionCode) => 4,
            (FormFactorGroupCode, InEarOptionCode) => 5,
            (FormFactorGroupCode, OpenEarOptionCode) => 6,
            (SwitchGroupCode, TactileOptionCode) => 1,
            (SwitchGroupCode, LinearOptionCode) => 2,
            (FeatureGroupCode, Dpi4000OptionCode) => 1,
            (FeatureGroupCode, Dpi8000OptionCode) => 2,
            (FeatureGroupCode, StandardNoiseControlOptionCode) => 3,
            (FeatureGroupCode, ActiveNoiseCancellingOptionCode) => 4,
            (MicrophoneGroupCode, BoomMicOptionCode) => 1,
            (MicrophoneGroupCode, DetachableMicOptionCode) => 2,
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
        Monitor,
        Keyboard,
        Mouse,
        Earbuds,
        Headphones,
        Headset
    }
}
