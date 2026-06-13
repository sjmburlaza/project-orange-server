namespace ProjectOrangeApi.Authorization;

public static class AppRoles
{
    public const string Admin = "admin";
    public const string Customer = "customer";
    public const string SupportAgent = "support-agent";
    public const string InventoryManager = "inventory-manager";

    public static readonly string[] All =
    [
        Admin,
        Customer,
        SupportAgent,
        InventoryManager
    ];

    public static bool IsKnown(string role) =>
        All.Contains(role, StringComparer.Ordinal);
}
