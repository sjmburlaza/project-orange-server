using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class ProductVariantSeed
{
    private static readonly VariantDefinition[] PhoneVariants =
    [
        new(1, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage128OptionCode)
        ]),
        new(2, 3, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage256OptionCode)
        ]),
        new(3, 1, 1.18m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage512OptionCode)
        ]),
        new(4, 1, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlueOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage128OptionCode)
        ]),
        new(5, 0, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlueOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage256OptionCode)
        ]),
        new(6, 3, 1.18m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlueOptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage512OptionCode)
        ])
    ];

    private static readonly VariantDefinition[] LaptopVariants =
    [
        new(1, 3, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.MidnightOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory8OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage256OptionCode)
        ]),
        new(2, 2, 1.16m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.MidnightOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory16OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage512OptionCode)
        ]),
        new(3, 1, 1.32m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.MidnightOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory32OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage1TbOptionCode)
        ]),
        new(4, 3, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory8OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage256OptionCode)
        ]),
        new(5, 2, 1.16m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory16OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage512OptionCode)
        ]),
        new(6, 0, 1.32m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.MemoryGroupCode, ProductOptionSeed.Memory32OptionCode),
            new(ProductOptionSeed.StorageGroupCode, ProductOptionSeed.Storage1TbOptionCode)
        ])
    ];

    private static readonly VariantDefinition[] MonitorVariants =
    [
        new(1, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.StandGroupCode, ProductOptionSeed.StandardStandOptionCode)
        ]),
        new(2, 2, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.StandGroupCode, ProductOptionSeed.HeightAdjustableStandOptionCode)
        ]),
        new(3, 2, 1.03m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.StandGroupCode, ProductOptionSeed.StandardStandOptionCode)
        ]),
        new(4, 0, 1.11m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.StandGroupCode, ProductOptionSeed.HeightAdjustableStandOptionCode)
        ])
    ];

    private static readonly VariantDefinition[] KeyboardVariants =
    [
        new(0, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.WiredUsbCOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.CompactOptionCode),
            new(ProductOptionSeed.SwitchGroupCode, ProductOptionSeed.TactileOptionCode)
        ]),
        new(1, 3, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.CompactOptionCode),
            new(ProductOptionSeed.SwitchGroupCode, ProductOptionSeed.TactileOptionCode)
        ]),
        new(2, 2, 1.12m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.CompactOptionCode),
            new(ProductOptionSeed.SwitchGroupCode, ProductOptionSeed.LinearOptionCode)
        ]),
        new(3, 1, 1.15m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.WiredUsbCOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.FullSizeOptionCode),
            new(ProductOptionSeed.SwitchGroupCode, ProductOptionSeed.TactileOptionCode)
        ])
    ];

    private static readonly VariantDefinition[] MouseVariants =
    [
        new(0, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.ErgonomicOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.Dpi4000OptionCode)
        ]),
        new(1, 3, 1.12m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.Wireless24GhzOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.ErgonomicOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.Dpi8000OptionCode)
        ]),
        new(2, 2, 1.05m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.AmbidextrousOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.Dpi4000OptionCode)
        ]),
        new(3, 1, 1.16m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.Wireless24GhzOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.AmbidextrousOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.Dpi8000OptionCode)
        ])
    ];

    private static readonly VariantDefinition[] EarbudsVariants =
    [
        new(0, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.InEarOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.StandardNoiseControlOptionCode)
        ]),
        new(1, 3, 1.18m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.InEarOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.ActiveNoiseCancellingOptionCode)
        ]),
        new(2, 2, 1.2m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.WhiteOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.InEarOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.ActiveNoiseCancellingOptionCode)
        ]),
        new(3, 1, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.WhiteOptionCode),
            new(ProductOptionSeed.FormFactorGroupCode, ProductOptionSeed.OpenEarOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.StandardNoiseControlOptionCode)
        ])
    ];

    private static readonly VariantDefinition[] HeadphonesVariants =
    [
        new(0, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.StandardNoiseControlOptionCode)
        ]),
        new(1, 3, 1.15m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.ActiveNoiseCancellingOptionCode)
        ]),
        new(2, 2, 1.18m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.BluetoothOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.ActiveNoiseCancellingOptionCode)
        ]),
        new(3, 1, 1.05m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.SilverOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.WiredUsbCOptionCode),
            new(ProductOptionSeed.FeatureGroupCode, ProductOptionSeed.StandardNoiseControlOptionCode)
        ])
    ];

    private static readonly VariantDefinition[] HeadsetVariants =
    [
        new(0, 4, 1m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.WiredUsbCOptionCode),
            new(ProductOptionSeed.MicrophoneGroupCode, ProductOptionSeed.BoomMicOptionCode)
        ]),
        new(1, 3, 1.08m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.WiredUsbCOptionCode),
            new(ProductOptionSeed.MicrophoneGroupCode, ProductOptionSeed.DetachableMicOptionCode)
        ]),
        new(2, 2, 1.12m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.BlackOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.Wireless24GhzOptionCode),
            new(ProductOptionSeed.MicrophoneGroupCode, ProductOptionSeed.BoomMicOptionCode)
        ]),
        new(3, 1, 1.18m,
        [
            new(ProductOptionSeed.ColorGroupCode, ProductOptionSeed.WhiteOptionCode),
            new(ProductOptionSeed.ConnectionGroupCode, ProductOptionSeed.Wireless24GhzOptionCode),
            new(ProductOptionSeed.MicrophoneGroupCode, ProductOptionSeed.DetachableMicOptionCode)
        ])
    ];

    public static ProductVariant[] Variants =>
        ProductSeed.Products
            .SelectMany(CreateVariants)
            .ToArray();

    public static ProductVariantOption[] VariantOptions =>
        ProductSeed.Products
            .SelectMany(CreateVariantOptions)
            .ToArray();

    public static int GetDefaultVariantId(int productId)
    {
        return productId * 100;
    }

    private static IEnumerable<ProductVariant> CreateVariants(Product product)
    {
        var profile = ProductOptionSeed.GetOptionProfile(product.Id);
        if (profile == ProductOptionSeed.ProductOptionProfile.None)
        {
            yield return new ProductVariant
            {
                Id = GetDefaultVariantId(product.Id),
                ProductId = product.Id,
                Sku = $"PROD-{product.Id}-BASE",
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                ImageUrl = product.ImageUrl
            };

            yield break;
        }

        var definitions = GetVariantDefinitions(profile);
        var stockQuantities = AllocateStock(product.StockQuantity, definitions, profile);

        foreach (var definition in definitions)
        {
            yield return new ProductVariant
            {
                Id = GetConfiguredVariantId(product.Id, definition.Index),
                ProductId = product.Id,
                Sku = $"PROD-{product.Id}-{string.Join("-", definition.Options.Select(option => option.OptionCode.ToUpperInvariant()))}",
                Price = GetPrice(product.Price, definition.PriceMultiplier),
                StockQuantity = stockQuantities[definition.Index],
                ImageUrl = product.ImageUrl
            };
        }
    }

    private static IEnumerable<ProductVariantOption> CreateVariantOptions(Product product)
    {
        var profile = ProductOptionSeed.GetOptionProfile(product.Id);
        if (profile == ProductOptionSeed.ProductOptionProfile.None)
        {
            yield break;
        }

        foreach (var definition in GetVariantDefinitions(profile))
        {
            var variantId = GetConfiguredVariantId(product.Id, definition.Index);

            for (var i = 0; i < definition.Options.Length; i++)
            {
                yield return new ProductVariantOption
                {
                    Id = (variantId * 10) + i + 1,
                    ProductVariantId = variantId,
                    ProductOptionId = ProductOptionSeed.GetOptionId(
                        product.Id,
                        definition.Options[i].GroupCode,
                        definition.Options[i].OptionCode)
                };
            }
        }
    }

    private static int GetConfiguredVariantId(int productId, int variantIndex)
    {
        return (productId * 100) + variantIndex;
    }

    private static VariantDefinition[] GetVariantDefinitions(ProductOptionSeed.ProductOptionProfile profile)
    {
        var definitions = profile switch
        {
            ProductOptionSeed.ProductOptionProfile.Phone => PhoneVariants,
            ProductOptionSeed.ProductOptionProfile.Laptop => LaptopVariants,
            ProductOptionSeed.ProductOptionProfile.Monitor => MonitorVariants,
            ProductOptionSeed.ProductOptionProfile.Keyboard => KeyboardVariants,
            ProductOptionSeed.ProductOptionProfile.Mouse => MouseVariants,
            ProductOptionSeed.ProductOptionProfile.Earbuds => EarbudsVariants,
            ProductOptionSeed.ProductOptionProfile.Headphones => HeadphonesVariants,
            ProductOptionSeed.ProductOptionProfile.Headset => HeadsetVariants,
            _ => []
        };

        return AddMissingColorVariants(definitions, ProductOptionSeed.GetColorOptionCodes(profile));
    }

    private static VariantDefinition[] AddMissingColorVariants(
        VariantDefinition[] definitions,
        IEnumerable<string> colorOptionCodes)
    {
        if (definitions.Length == 0)
        {
            return definitions;
        }

        var existingColorCodes = definitions
            .SelectMany(definition => definition.Options)
            .Where(option => option.GroupCode == ProductOptionSeed.ColorGroupCode)
            .Select(option => option.OptionCode)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);
        var expandedDefinitions = definitions.ToList();
        var nextIndex = definitions.Max(definition => definition.Index) + 1;
        var template = definitions[0];

        foreach (var colorOptionCode in colorOptionCodes.Where(color => !existingColorCodes.Contains(color)))
        {
            expandedDefinitions.Add(template with
            {
                Index = nextIndex++,
                StockWeight = 1,
                Options = template.Options
                    .Select(option => option.GroupCode == ProductOptionSeed.ColorGroupCode
                        ? option with { OptionCode = colorOptionCode }
                        : option)
                    .ToArray()
            });
        }

        return expandedDefinitions.ToArray();
    }

    private static decimal GetPrice(decimal basePrice, decimal priceMultiplier)
    {
        return decimal.Round(basePrice * priceMultiplier, 2, MidpointRounding.AwayFromZero);
    }

    private static Dictionary<int, int> AllocateStock(
        int totalStockQuantity,
        IReadOnlyCollection<VariantDefinition> definitions,
        ProductOptionSeed.ProductOptionProfile profile)
    {
        var stockQuantities = profile == ProductOptionSeed.ProductOptionProfile.Phone
            ? AllocatePhoneStock(totalStockQuantity, definitions)
            : AllocateWeightedStock(totalStockQuantity, definitions);

        EnsureEachColorIsInStock(totalStockQuantity, definitions, stockQuantities);
        return stockQuantities;
    }

    private static void EnsureEachColorIsInStock(
        int totalStockQuantity,
        IReadOnlyCollection<VariantDefinition> definitions,
        Dictionary<int, int> stockQuantities)
    {
        var variantsByColor = definitions
            .Select(definition => new
            {
                Definition = definition,
                Color = definition.Options.First(option =>
                    option.GroupCode == ProductOptionSeed.ColorGroupCode).OptionCode
            })
            .GroupBy(item => item.Color, StringComparer.OrdinalIgnoreCase)
            .ToArray();

        if (totalStockQuantity < variantsByColor.Length)
        {
            return;
        }

        foreach (var colorVariants in variantsByColor)
        {
            if (colorVariants.Any(item => stockQuantities[item.Definition.Index] > 0))
            {
                continue;
            }

            var donorColor = variantsByColor
                .Where(group => group.Sum(item => stockQuantities[item.Definition.Index]) > 1)
                .OrderByDescending(group => group.Sum(item => stockQuantities[item.Definition.Index]))
                .ThenBy(group => group.Key, StringComparer.OrdinalIgnoreCase)
                .First();
            var donor = donorColor
                .Where(item => stockQuantities[item.Definition.Index] > 0)
                .OrderByDescending(item => stockQuantities[item.Definition.Index])
                .ThenBy(item => item.Definition.Index)
                .First()
                .Definition;
            var recipient = colorVariants
                .OrderBy(item => item.Definition.Index)
                .First()
                .Definition;

            stockQuantities[donor.Index]--;
            stockQuantities[recipient.Index]++;
        }
    }

    private static Dictionary<int, int> AllocatePhoneStock(
        int totalStockQuantity,
        IEnumerable<VariantDefinition> definitions)
    {
        var black128 = totalStockQuantity / 3;
        var black256 = totalStockQuantity / 4;
        var black512 = totalStockQuantity >= 5 ? 1 : 0;
        var blue128 = totalStockQuantity >= 3 ? 1 : 0;
        const int blue256 = 0;
        var blue512 = Math.Max(0, totalStockQuantity - black128 - black256 - black512 - blue128 - blue256);

        return definitions.ToDictionary(
            definition => definition.Index,
            definition => definition.Index switch
            {
                1 => black128,
                2 => black256,
                3 => black512,
                4 => blue128,
                5 => blue256,
                6 => blue512,
                _ => 0
            });
    }

    private static Dictionary<int, int> AllocateWeightedStock(
        int totalStockQuantity,
        IReadOnlyCollection<VariantDefinition> definitions)
    {
        var stockQuantities = definitions.ToDictionary(definition => definition.Index, _ => 0);
        var stockedDefinitions = definitions
            .Where(definition => definition.StockWeight > 0)
            .ToArray();

        if (totalStockQuantity <= 0 || stockedDefinitions.Length == 0)
        {
            return stockQuantities;
        }

        var totalWeight = stockedDefinitions.Sum(definition => definition.StockWeight);
        var assignedQuantity = 0;

        foreach (var definition in stockedDefinitions)
        {
            var stockQuantity = (totalStockQuantity * definition.StockWeight) / totalWeight;
            stockQuantities[definition.Index] = stockQuantity;
            assignedQuantity += stockQuantity;
        }

        var remainingQuantity = totalStockQuantity - assignedQuantity;
        foreach (var definition in stockedDefinitions
            .OrderByDescending(definition => definition.StockWeight)
            .ThenBy(definition => definition.Index))
        {
            if (remainingQuantity == 0)
            {
                break;
            }

            stockQuantities[definition.Index]++;
            remainingQuantity--;
        }

        return stockQuantities;
    }

    private sealed record VariantDefinition(
        int Index,
        int StockWeight,
        decimal PriceMultiplier,
        VariantOptionSelection[] Options);

    private sealed record VariantOptionSelection(string GroupCode, string OptionCode);
}
