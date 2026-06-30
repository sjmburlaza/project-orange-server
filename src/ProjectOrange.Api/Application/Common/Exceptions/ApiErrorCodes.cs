namespace ProjectOrangeApi.Services;

public static class ApiErrorCodes
{
    public static class Addon
    {
        public const string LimitReached = "ADDON_LIMIT_REACHED";
        public const string NotAvailable = "ADDON_NOT_AVAILABLE";
    }

    public static class Cart
    {
        public const string InvalidRequest = "CART_INVALID_REQUEST";
        public const string ItemNotFound = "CART_ITEM_NOT_FOUND";
        public const string NotFound = "CART_NOT_FOUND";
        public const string VariantNotFound = "CART_VARIANT_NOT_FOUND";
    }

    public static class Order
    {
        public const string InsufficientStock = "ORDER_INSUFFICIENT_STOCK";
        public const string InvalidRequest = "ORDER_INVALID_REQUEST";
        public const string ProductNotFound = "ORDER_PRODUCT_NOT_FOUND";
    }

    public static class Voucher
    {
        public const string AlreadyApplied = "VOUCHER_ALREADY_APPLIED";
        public const string CodeInvalidFormat = "VOUCHER_CODE_INVALID_FORMAT";
        public const string LimitReached = "VOUCHER_LIMIT_REACHED";
        public const string MinimumSubtotalNotMet = "VOUCHER_MINIMUM_SUBTOTAL_NOT_MET";
        public const string NotApplicable = "VOUCHER_NOT_APPLICABLE";
    }

    public static class Wishlist
    {
        public const string ProductNotFound = "WISHLIST_PRODUCT_NOT_FOUND";
    }
}
