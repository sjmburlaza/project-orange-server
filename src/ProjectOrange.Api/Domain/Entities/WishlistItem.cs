namespace ProjectOrangeApi.Models;

public class WishlistItem
{
    public int Id { get; set; }

    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
    public AppUser User { get; set; } = null!;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public DateTimeOffset CreatedAtUtc { get; set; } = DateTimeOffset.UtcNow;
}
