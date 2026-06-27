namespace ProjectOrangeApi.Data.Seeds;

public static class VoucherSeed
{
    public static readonly List<Voucher> Vouchers =
    [
        new()
        {
            Code = "ORANGE10",
            Name = "Orange 10% Off",
            Description = "10% discount applied",
            Status = VoucherStatus.Active,
            DiscountPercent = 10,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2027, 1, 1, 0, 0, 0, TimeSpan.Zero)
        },
        new()
        {
            Code = "WELCOME5",
            Name = "Welcome 5% Off",
            Description = "5% welcome discount applied",
            Status = VoucherStatus.Active,
            DiscountPercent = 5,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 12, 31, 23, 59, 59, TimeSpan.Zero)
        },
        new()
        {
            Code = "SUMMER15",
            Name = "Summer 15% Off",
            Description = "15% discount for summer orders",
            Status = VoucherStatus.Active,
            DiscountPercent = 15,
            StartsAtUtc = new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 8, 31, 23, 59, 59, TimeSpan.Zero),
            MinimumSubtotal = 5000
        },
        new()
        {
            Code = "MEGA20",
            Name = "Mega 20% Off",
            Description = "20% discount for high-value carts",
            Status = VoucherStatus.Active,
            DiscountPercent = 20,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 12, 31, 23, 59, 59, TimeSpan.Zero),
            MinimumSubtotal = 50000
        },
        new()
        {
            Code = "ACCESSORY8",
            Name = "Accessory 8% Off",
            Description = "8% discount for accessory orders",
            Status = VoucherStatus.Active,
            DiscountPercent = 8,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 10, 31, 23, 59, 59, TimeSpan.Zero),
            MinimumSubtotal = 1000
        },
        new()
        {
            Code = "LAPTOP18",
            Name = "Laptop 18% Off",
            Description = "18% discount for premium carts",
            Status = VoucherStatus.Active,
            DiscountPercent = 18,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 9, 30, 23, 59, 59, TimeSpan.Zero),
            MinimumSubtotal = 60000
        },
        new()
        {
            Code = "VIP25",
            Name = "VIP 25% Off",
            Description = "25% VIP discount",
            Status = VoucherStatus.Inactive,
            DiscountPercent = 25,
            StartsAtUtc = new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 12, 31, 23, 59, 59, TimeSpan.Zero)
        },
        new()
        {
            Code = "EARLYBIRD12",
            Name = "Early Bird 12% Off",
            Description = "12% early bird discount",
            Status = VoucherStatus.Scheduled,
            DiscountPercent = 12,
            StartsAtUtc = new DateTimeOffset(2026, 7, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 9, 1, 0, 0, 0, TimeSpan.Zero)
        },
        new()
        {
            Code = "HOLIDAY22",
            Name = "Holiday 22% Off",
            Description = "22% holiday discount",
            Status = VoucherStatus.Scheduled,
            DiscountPercent = 22,
            StartsAtUtc = new DateTimeOffset(2026, 12, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2027, 1, 1, 0, 0, 0, TimeSpan.Zero)
        },
        new()
        {
            Code = "FLASH30",
            Name = "Flash 30% Off",
            Description = "30% flash sale discount",
            Status = VoucherStatus.Expired,
            DiscountPercent = 30,
            StartsAtUtc = new DateTimeOffset(2026, 4, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2026, 5, 1, 0, 0, 0, TimeSpan.Zero)
        },
        new()
        {
            Code = "OLDWELCOME7",
            Name = "Old Welcome 7% Off",
            Description = "Expired 7% welcome discount",
            Status = VoucherStatus.Expired,
            DiscountPercent = 7,
            StartsAtUtc = new DateTimeOffset(2025, 1, 1, 0, 0, 0, TimeSpan.Zero),
            ExpiresAtUtc = new DateTimeOffset(2025, 12, 31, 23, 59, 59, TimeSpan.Zero)
        }
    ];

    public static Voucher? FindByCode(string code)
    {
        return Vouchers.FirstOrDefault(voucher =>
            string.Equals(voucher.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}

public class Voucher
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public VoucherStatus Status { get; set; } = VoucherStatus.Active;
    public decimal DiscountPercent { get; set; }
    public DateTimeOffset? StartsAtUtc { get; set; }
    public DateTimeOffset? ExpiresAtUtc { get; set; }
    public decimal MinimumSubtotal { get; set; }
}

public enum VoucherStatus
{
    Active,
    Inactive,
    Scheduled,
    Expired
}
