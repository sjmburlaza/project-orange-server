using Microsoft.AspNetCore.Http;

namespace ProjectOrangeApi.Services;

public class ApiErrorException : Exception
{
    public ApiErrorException(
        string code,
        int statusCode,
        string title,
        string message,
        IReadOnlyDictionary<string, object?>? errorDetails = null) : base(message)
    {
        Code = code;
        StatusCode = statusCode;
        Title = title;
        ErrorDetails = errorDetails ?? new Dictionary<string, object?>();
    }

    public string Code { get; }
    public int StatusCode { get; }
    public string Title { get; }
    public IReadOnlyDictionary<string, object?> ErrorDetails { get; }
}

public class AddonValidationException : ApiErrorException
{
    private AddonValidationException(
        string code,
        int statusCode,
        string message) : base(
            code,
            statusCode,
            "Add-on validation failed.",
            message)
    {
    }

    public static AddonValidationException NotAvailable(string message = "Selected add-on is not available for this product.")
    {
        return new AddonValidationException(
            ApiErrorCodes.Addon.NotAvailable,
            StatusCodes.Status422UnprocessableEntity,
            message);
    }

    public static AddonValidationException LimitReached(string message)
    {
        return new AddonValidationException(
            ApiErrorCodes.Addon.LimitReached,
            StatusCodes.Status409Conflict,
            message);
    }
}

public class CartNotFoundException : ApiErrorException
{
    public CartNotFoundException() : base(
        ApiErrorCodes.Cart.NotFound,
        StatusCodes.Status404NotFound,
        "Cart not found.",
        "Cart not found.")
    {
    }
}

public class CartItemNotFoundException : ApiErrorException
{
    public CartItemNotFoundException() : base(
        ApiErrorCodes.Cart.ItemNotFound,
        StatusCodes.Status404NotFound,
        "Cart item not found.",
        "Cart item not found.")
    {
    }
}

public class CartValidationException : ApiErrorException
{
    private CartValidationException(
        string code,
        int statusCode,
        string message) : base(
            code,
            statusCode,
            "Cart validation failed.",
            message)
    {
    }

    public static CartValidationException InvalidRequest(string message)
    {
        return new CartValidationException(
            ApiErrorCodes.Cart.InvalidRequest,
            StatusCodes.Status400BadRequest,
            message);
    }

    public static CartValidationException VariantNotFound(int variantId)
    {
        return new CartValidationException(
            ApiErrorCodes.Cart.VariantNotFound,
            StatusCodes.Status400BadRequest,
            $"Variant with ID {variantId} not found.");
    }
}

public class OrderValidationException : ApiErrorException
{
    private OrderValidationException(
        string code,
        int statusCode,
        string message) : base(
            code,
            statusCode,
            "Order validation failed.",
            message)
    {
    }

    public static OrderValidationException InvalidRequest(string message)
    {
        return new OrderValidationException(
            ApiErrorCodes.Order.InvalidRequest,
            StatusCodes.Status400BadRequest,
            message);
    }

    public static OrderValidationException ProductNotFound(int productId)
    {
        return new OrderValidationException(
            ApiErrorCodes.Order.ProductNotFound,
            StatusCodes.Status400BadRequest,
            $"Product with ID {productId} not found.");
    }

    public static OrderValidationException InsufficientStock(string productName)
    {
        return new OrderValidationException(
            ApiErrorCodes.Order.InsufficientStock,
            StatusCodes.Status409Conflict,
            $"Not enough stock for product: {productName}");
    }
}

public class VoucherValidationException : ApiErrorException
{
    private VoucherValidationException(
        string code,
        int statusCode,
        string message,
        IReadOnlyDictionary<string, object?>? errorDetails = null) : base(
            code,
            statusCode,
            "Voucher validation failed.",
            message,
            errorDetails)
    {
    }

    public static VoucherValidationException InvalidFormat(string message)
    {
        return new VoucherValidationException(
            ApiErrorCodes.Voucher.CodeInvalidFormat,
            StatusCodes.Status400BadRequest,
            message);
    }

    public static VoucherValidationException NotApplicable(string message = "This voucher cannot be applied.")
    {
        return new VoucherValidationException(
            ApiErrorCodes.Voucher.NotApplicable,
            StatusCodes.Status422UnprocessableEntity,
            message);
    }

    public static VoucherValidationException MinimumSubtotalNotMet(decimal minimumSubtotal)
    {
        return new VoucherValidationException(
            ApiErrorCodes.Voucher.MinimumSubtotalNotMet,
            StatusCodes.Status422UnprocessableEntity,
            $"Voucher requires a subtotal of at least {minimumSubtotal:0.00}.",
            new Dictionary<string, object?>
            {
                ["minimumSubtotal"] = minimumSubtotal
            });
    }

    public static VoucherValidationException AlreadyApplied()
    {
        return new VoucherValidationException(
            ApiErrorCodes.Voucher.AlreadyApplied,
            StatusCodes.Status409Conflict,
            "Voucher is already applied.");
    }

    public static VoucherValidationException LimitReached()
    {
        return new VoucherValidationException(
            ApiErrorCodes.Voucher.LimitReached,
            StatusCodes.Status409Conflict,
            "Only one voucher can be applied to a cart.");
    }
}

public class WishlistValidationException : ApiErrorException
{
    private WishlistValidationException(
        string code,
        int statusCode,
        string message) : base(
            code,
            statusCode,
            "Wishlist validation failed.",
            message)
    {
    }

    public static WishlistValidationException ProductNotFound(int productId)
    {
        return new WishlistValidationException(
            ApiErrorCodes.Wishlist.ProductNotFound,
            StatusCodes.Status404NotFound,
            $"Product with ID {productId} was not found.");
    }
}
