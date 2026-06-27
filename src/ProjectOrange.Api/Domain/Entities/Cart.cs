namespace ProjectOrangeApi.Models;

public class Cart
{
    public int Id { get; set; }
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;
    public string Code { get; set; } = Guid.NewGuid().ToString("N");

    public string? UserId { get; set; }
    public AppUser? User { get; set; }

    public string? ShippingPostalCode { get; set; }
    public string? ShippingMethodCode { get; set; }
    public decimal? ShippingPrice { get; set; }

    public List<CartItem> Entries { get; set; } = [];
    public List<CartVoucher> AppliedVouchers { get; set; } = [];
}
