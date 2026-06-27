namespace ProjectOrangeApi.Authorization;

public static class AppPermissions
{
    public const string ProductsRead = "products.read";
    public const string ProductsCreate = "products.create";
    public const string ProductsUpdate = "products.update";
    public const string ProductsDelete = "products.delete";
    public const string OrdersRead = "orders.read";
    public const string OrdersUpdate = "orders.update";
    public const string OrdersCancel = "orders.cancel";
    public const string UsersRead = "users.read";
    public const string UsersManage = "users.manage";
    public const string InventoryRead = "inventory.read";
    public const string InventoryUpdate = "inventory.update";

    public static readonly string[] All =
    [
        ProductsRead,
        ProductsCreate,
        ProductsUpdate,
        ProductsDelete,
        OrdersRead,
        OrdersUpdate,
        OrdersCancel,
        UsersRead,
        UsersManage,
        InventoryRead,
        InventoryUpdate
    ];

    public static bool IsKnown(string permission) =>
        All.Contains(permission, StringComparer.Ordinal);
}
