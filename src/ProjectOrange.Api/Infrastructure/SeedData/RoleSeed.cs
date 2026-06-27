using Microsoft.AspNetCore.Identity;
using ProjectOrangeApi.Authorization;

namespace ProjectOrangeApi.Data.Seeds;

public static class RoleSeed
{
    public static readonly IdentityRole[] Roles =
    [
        Create(AppRoles.Admin),
        Create(AppRoles.Customer),
        Create(AppRoles.SupportAgent),
        Create(AppRoles.InventoryManager)
    ];

    private static IdentityRole Create(string name) =>
        new()
        {
            Id = $"role-{name}",
            Name = name,
            NormalizedName = name.ToUpperInvariant(),
            ConcurrencyStamp = $"role-{name}"
        };
}
