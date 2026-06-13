namespace ProjectOrangeApi.Models;

public class AuthSession
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string UserId { get; set; } = string.Empty;
    public AppUser User { get; set; } = null!;
    public DateTimeOffset CreatedAtUtc { get; set; }
    public DateTimeOffset ExpiresAtUtc { get; set; }
    public DateTimeOffset? RevokedAtUtc { get; set; }
    public string? CreatedByIpAddress { get; set; }
    public string? RevokedByIpAddress { get; set; }
}
