using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Data.Seeds;

public static class TradeInSeed
{
    public static readonly TradeInDto TradeIn = new()
    {
        StepsHeader =
        [
            new() { Label = "1", Title = "Device", Subtext = "Find your device" },
            new() { Label = "2", Title = "IMEI", Subtext = "Verify ownership" },
            new() { Label = "3", Title = "Condition", Subtext = "Answer condition checks" },
            new() { Label = "4", Title = "Review", Subtext = "Confirm estimate" }
        ],
        StepOneDescription = new()
        {
            Title = "Tell us about your device",
            Content = "Select the category, brand, model, and storage of the device you want to trade in.",
            Note = "Trade-in estimates are subject to final inspection."
        },
        FooterText = "Final trade-in value may change after device verification."
    };

    public static readonly List<CategoryTIDto> Categories =
    [
        new() { Category = "Phones", Code = "cat_smartphone", Name = "Phones" },
        new() { Category = "Laptops", Code = "cat_laptop", Name = "Laptops" }
    ];

    public static readonly List<BrandTIDto> Brands =
    [
        new() { BrandName = "Apple", Code = "brand_apple", Amount = 3000, CategoryCode = "cat_smartphone", Name = "Apple" },
        new() { BrandName = "Samsung", Code = "brand_samsung", Amount = 2500, CategoryCode = "cat_smartphone", Name = "Samsung" },
        new() { BrandName = "Google", Code = "brand_google", Amount = 2200, CategoryCode = "cat_smartphone", Name = "Google" },
        new() { BrandName = "Apple", Code = "brand_apple", Amount = 9000, CategoryCode = "cat_laptop", Name = "Apple" },
        new() { BrandName = "Dell", Code = "brand_dell", Amount = 6500, CategoryCode = "cat_laptop", Name = "Dell" },
        new() { BrandName = "Lenovo", Code = "brand_lenovo", Amount = 6000, CategoryCode = "cat_laptop", Name = "Lenovo" }
    ];

    public static readonly List<DeviceTIDto> Devices =
    [
        new() { DeviceName = "iPhone 14", BrandName = "Apple", Code = "dev_iphone_14", Amount = 9000, CategoryCode = "cat_smartphone", Name = "iPhone 14" },
        new() { DeviceName = "iPhone 13", BrandName = "Apple", Code = "dev_iphone_13", Amount = 7000, CategoryCode = "cat_smartphone", Name = "iPhone 13" },
        new() { DeviceName = "Galaxy S23", BrandName = "Samsung", Code = "dev_galaxy_s23", Amount = 7500, CategoryCode = "cat_smartphone", Name = "Galaxy S23" },
        new() { DeviceName = "Pixel 7", BrandName = "Google", Code = "dev_pixel_7", Amount = 5500, CategoryCode = "cat_smartphone", Name = "Pixel 7" },
        new() { DeviceName = "MacBook Air M2", BrandName = "Apple", Code = "dev_macbook_air_m2", Amount = 18000, CategoryCode = "cat_laptop", Name = "MacBook Air M2" },
        new() { DeviceName = "Dell XPS 13", BrandName = "Dell", Code = "dev_dell_xps_13", Amount = 14000, CategoryCode = "cat_laptop", Name = "Dell XPS 13" },
        new() { DeviceName = "ThinkPad X1 Carbon", BrandName = "Lenovo", Code = "dev_thinkpad_x1_carbon", Amount = 13000, CategoryCode = "cat_laptop", Name = "ThinkPad X1 Carbon" }
    ];

    public static readonly List<StorageTIDto> Storages =
    [
        new() { Size = "128GB", Code = "stor_iphone_14_128", Amount = 0, DeviceCode = "dev_iphone_14", Name = "128GB" },
        new() { Size = "256GB", Code = "stor_iphone_14_256", Amount = 1500, DeviceCode = "dev_iphone_14", Name = "256GB" },
        new() { Size = "128GB", Code = "stor_iphone_13_128", Amount = 0, DeviceCode = "dev_iphone_13", Name = "128GB" },
        new() { Size = "256GB", Code = "stor_iphone_13_256", Amount = 1200, DeviceCode = "dev_iphone_13", Name = "256GB" },
        new() { Size = "128GB", Code = "stor_galaxy_s23_128", Amount = 0, DeviceCode = "dev_galaxy_s23", Name = "128GB" },
        new() { Size = "256GB", Code = "stor_galaxy_s23_256", Amount = 1000, DeviceCode = "dev_galaxy_s23", Name = "256GB" },
        new() { Size = "128GB", Code = "stor_pixel_7_128", Amount = 0, DeviceCode = "dev_pixel_7", Name = "128GB" },
        new() { Size = "256GB", Code = "stor_pixel_7_256", Amount = 900, DeviceCode = "dev_pixel_7", Name = "256GB" },
        new() { Size = "256GB", Code = "stor_macbook_air_m2_256", Amount = 0, DeviceCode = "dev_macbook_air_m2", Name = "256GB" },
        new() { Size = "512GB", Code = "stor_macbook_air_m2_512", Amount = 2500, DeviceCode = "dev_macbook_air_m2", Name = "512GB" },
        new() { Size = "512GB", Code = "stor_dell_xps_13_512", Amount = 0, DeviceCode = "dev_dell_xps_13", Name = "512GB" },
        new() { Size = "1TB", Code = "stor_dell_xps_13_1tb", Amount = 2000, DeviceCode = "dev_dell_xps_13", Name = "1TB" },
        new() { Size = "512GB", Code = "stor_thinkpad_x1_carbon_512", Amount = 0, DeviceCode = "dev_thinkpad_x1_carbon", Name = "512GB" },
        new() { Size = "1TB", Code = "stor_thinkpad_x1_carbon_1tb", Amount = 1800, DeviceCode = "dev_thinkpad_x1_carbon", Name = "1TB" }
    ];

    public static readonly StepTwoDto StepTwo = new()
    {
        Text1 = "Enter your device IMEI or serial number.",
        Icon = "info",
        IconText = "Where to find this",
        Text2 = "This helps us verify the device before final valuation.",
        Imei = new()
        {
            Label = "IMEI or Serial Number",
            Placeholder = "Enter IMEI or serial number",
            Value = ""
        }
    };

    public static readonly List<StepThreeFieldDto> StepThree =
    [
        new() { Code = "powers-on", Question = "Does the device power on?", Info = "The screen should turn on normally.", Response = "" },
        new() { Code = "screen-condition", Question = "Is the screen free from cracks?", Info = "Minor scratches are acceptable.", Response = "" },
        new() { Code = "body-condition", Question = "Is the body free from major dents?", Info = "Normal wear is acceptable.", Response = "" },
        new() { Code = "accessories", Question = "Do you still have the original charger?", Info = "Accessories may improve the estimate.", Response = "" }
    ];

    public static readonly StepFourDto StepFour = new()
    {
        BoxHeader = "Estimated trade-in value",
        BoxSubtext = "This estimate is based on the information you provided.",
        Disclaimer = "Final value is subject to physical inspection.",
        TncHeader = "Terms and Conditions",
        TncText1 = "Trade-in value may be adjusted after verification.",
        TncText2 = "The device must not be reported lost, stolen, or locked."
    };

    public static List<BrandTIDto> GetBrands(string? categoryCode)
    {
        return string.IsNullOrWhiteSpace(categoryCode)
            ? Brands
            : Brands.Where(brand => string.Equals(brand.CategoryCode, categoryCode, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static List<DeviceTIDto> GetDevices(string? categoryCode, string? brandCode)
    {
        var query = Devices.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(categoryCode))
        {
            query = query.Where(device =>
                string.Equals(device.CategoryCode, categoryCode, StringComparison.OrdinalIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(brandCode))
        {
            var brandNames = Brands
                .Where(brand => string.Equals(brand.Code, brandCode, StringComparison.OrdinalIgnoreCase))
                .Select(brand => brand.BrandName)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            query = query.Where(device => brandNames.Contains(device.BrandName, StringComparer.OrdinalIgnoreCase));
        }

        return query.ToList();
    }

    public static List<StorageTIDto> GetStorages(string? deviceCode)
    {
        return string.IsNullOrWhiteSpace(deviceCode)
            ? Storages
            : Storages.Where(storage => string.Equals(storage.DeviceCode, deviceCode, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public static TradeInStepDto CreateDefaultSteps()
    {
        return new()
        {
            Id = 1,
            StepOne =
            [
                new()
                {
                    Title = "Postal Code",
                    FieldName = "postalCode",
                    Placeholder = "Enter postal code",
                    Value = "",
                    Options = Array.Empty<string>()
                },
                new()
                {
                    Title = "Category",
                    FieldName = "category",
                    Placeholder = "Select category",
                    Value = "",
                    Options = Categories
                },
                new()
                {
                    Title = "Brand",
                    FieldName = "brand",
                    Placeholder = "Select brand",
                    Value = "",
                    Options = Array.Empty<BrandTIDto>()
                },
                new()
                {
                    Title = "Device",
                    FieldName = "device",
                    Placeholder = "Select device",
                    Value = "",
                    Options = Array.Empty<DeviceTIDto>()
                },
                new()
                {
                    Title = "Storage",
                    FieldName = "storage",
                    Placeholder = "Select storage",
                    Value = "",
                    Options = Array.Empty<StorageTIDto>()
                }
            ],
            FormData = new(),
            Summary = new(),
            StepTwo = StepTwo,
            StepThree = StepThree,
            StepFour = StepFour
        };
    }
}
