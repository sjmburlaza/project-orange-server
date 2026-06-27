using Microsoft.AspNetCore.Identity;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Data.Seeds;

public static class DevelopmentUserSeed
{
    private static readonly SampleUser[] SampleUsers =
    [
        new("admin@example.com", "Admin123!", AppRoles.Admin, "Sample Admin"),
        new("customer@example.com", "Customer123!", AppRoles.Customer, "Sample Customer"),
        new("support@example.com", "Support123!", AppRoles.SupportAgent, "Sample Support Agent"),
        new("inventory@example.com", "Inventory123!", AppRoles.InventoryManager, "Sample Inventory Manager")
    ];

    public static async Task SeedAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

        await EnsureRolesAsync(roleManager);

        foreach (var sample in SampleUsers)
        {
            var user = await userManager.FindByEmailAsync(sample.Email);

            if (user is null)
            {
                user = new AppUser
                {
                    UserName = sample.Email,
                    Email = sample.Email,
                    FullName = sample.FullName
                };

                var createResult = await userManager.CreateAsync(user, sample.Password);

                if (!createResult.Succeeded)
                {
                    throw CreateSeedException(sample.Email, createResult.Errors);
                }
            }

            await EnsureSingleAppRoleAsync(userManager, user, sample.Role);
        }
    }

    private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
    {
        foreach (var role in RoleSeed.Roles)
        {
            if (role.Name is null || await roleManager.RoleExistsAsync(role.Name))
            {
                continue;
            }

            var createResult = await roleManager.CreateAsync(new IdentityRole
            {
                Id = role.Id,
                Name = role.Name,
                NormalizedName = role.NormalizedName,
                ConcurrencyStamp = role.ConcurrencyStamp
            });

            if (!createResult.Succeeded)
            {
                throw CreateSeedException(role.Name, createResult.Errors);
            }
        }
    }

    private static async Task EnsureSingleAppRoleAsync(
        UserManager<AppUser> userManager,
        AppUser user,
        string role)
    {
        var currentRoles = await userManager.GetRolesAsync(user);
        var rolesToRemove = currentRoles
            .Where(currentRole => AppRoles.IsKnown(currentRole) && currentRole != role)
            .ToArray();

        if (rolesToRemove.Length > 0)
        {
            var removeResult = await userManager.RemoveFromRolesAsync(user, rolesToRemove);

            if (!removeResult.Succeeded)
            {
                throw CreateSeedException(user.Email ?? user.Id, removeResult.Errors);
            }
        }

        if (currentRoles.Contains(role, StringComparer.Ordinal))
        {
            return;
        }

        var addResult = await userManager.AddToRoleAsync(user, role);

        if (!addResult.Succeeded)
        {
            throw CreateSeedException(user.Email ?? user.Id, addResult.Errors);
        }
    }

    private static InvalidOperationException CreateSeedException(
        string subject,
        IEnumerable<IdentityError> errors)
    {
        var details = string.Join("; ", errors.Select(error => $"{error.Code}: {error.Description}"));
        return new InvalidOperationException($"Failed to seed development identity data for '{subject}'. {details}");
    }

    private sealed record SampleUser(string Email, string Password, string Role, string FullName);
}
