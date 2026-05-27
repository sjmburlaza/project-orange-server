namespace ProjectOrangeApi.Models;

public class Cart
{
    public int Id { get; set; }
    public string Code { get; set; } = Guid.NewGuid().ToString("N");

    public string? UserId { get; set; }
    public AppUser? User { get; set; }

    public List<CartItem> Entries { get; set; } = [];
    public List<CartVoucher> AppliedVouchers { get; set; } = [];
}
