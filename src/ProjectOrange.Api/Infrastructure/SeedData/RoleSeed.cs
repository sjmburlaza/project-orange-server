using Microsoft.AspNetCore.Identity;
using ProjectOrange.Authorization;

namespace ProjectOrange.Data.Seeds;

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
