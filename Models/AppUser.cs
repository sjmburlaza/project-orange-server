using Microsoft.AspNetCore.Identity;

namespace ProjectOrangeApi.Models;

public class AppUser : IdentityUser
{
    public string? FullName { get; set; }

    public List<Cart> Carts { get; set; } = [];
}
