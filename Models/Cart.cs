namespace ProjectOrangeApi.Models;

public class Cart
{
    public int Id { get; set; }
    public string Code { get; set; } = Guid.NewGuid().ToString("N");

    public List<CartItem> Entries { get; set; } = [];
    public List<CartVoucher> AppliedVouchers { get; set; } = [];
}
