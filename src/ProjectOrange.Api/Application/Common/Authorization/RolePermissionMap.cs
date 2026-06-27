namespace ProjectOrangeApi.Authorization;

public static class RolePermissionMap
{
    private static readonly IReadOnlyDictionary<string, string[]> PermissionsByRole =
        new Dictionary<string, string[]>(StringComparer.Ordinal)
        {
            [AppRoles.Admin] = AppPermissions.All,
            [AppRoles.Customer] =
            [
                AppPermissions.ProductsRead,
                AppPermissions.OrdersRead,
                AppPermissions.OrdersCancel
            ],
            [AppRoles.SupportAgent] =
            [
                AppPermissions.ProductsRead,
                AppPermissions.OrdersRead,
                AppPermissions.OrdersUpdate,
                AppPermissions.OrdersCancel,
                AppPermissions.UsersRead,
                AppPermissions.InventoryRead
            ],
            [AppRoles.InventoryManager] =
            [
                AppPermissions.ProductsRead,
                AppPermissions.ProductsCreate,
                AppPermissions.ProductsUpdate,
                AppPermissions.ProductsDelete,
                AppPermissions.OrdersRead,
                AppPermissions.InventoryRead,
                AppPermissions.InventoryUpdate
            ]
        };

    public static string[] NormalizeRoles(IEnumerable<string>? roles)
    {
        var normalizedRoles = (roles ?? [])
            .Where(AppRoles.IsKnown)
            .Distinct(StringComparer.Ordinal)
            .OrderBy(role => role, StringComparer.Ordinal)
            .ToArray();

        return normalizedRoles.Length > 0 ? normalizedRoles : [AppRoles.Customer];
    }

    public static string[] GetPermissionsForRoles(IEnumerable<string>? roles)
    {
        return NormalizeRoles(roles)
            .SelectMany(role => PermissionsByRole.TryGetValue(role, out var permissions)
                ? permissions
                : [])
            .Distinct(StringComparer.Ordinal)
            .OrderBy(permission => permission, StringComparer.Ordinal)
            .ToArray();
    }
}
