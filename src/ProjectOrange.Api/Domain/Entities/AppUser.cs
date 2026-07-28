using Microsoft.AspNetCore.Identity;

namespace ProjectOrange.Models;

public class AppUser : IdentityUser
{
    public string? FullName { get; set; }

    public List<Cart> Carts { get; set; } = [];
    public List<WishlistItem> WishlistItems { get; set; } = [];
    public List<AuthSession> AuthSessions { get; set; } = [];
}
