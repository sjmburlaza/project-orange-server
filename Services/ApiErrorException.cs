using Microsoft.AspNetCore.Http;

namespace ProjectOrangeApi.Services;

public static class ApiErrorCodes
{
    public const string CartNotFound = "CART_NOT_FOUND";
    public const string VoucherAlreadyApplied = "VOUCHER_ALREADY_APPLIED";
    public const string VoucherCodeInvalidFormat = "VOUCHER_CODE_INVALID_FORMAT";
    public const string VoucherLimitReached = "VOUCHER_LIMIT_REACHED";
    public const string VoucherMinimumSubtotalNotMet = "VOUCHER_MINIMUM_SUBTOTAL_NOT_MET";
    public const string VoucherNotApplicable = "VOUCHER_NOT_APPLICABLE";
}

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

public class CartNotFoundException : ApiErrorException
{
    public CartNotFoundException() : base(
        ApiErrorCodes.CartNotFound,
        StatusCodes.Status404NotFound,
        "Cart not found.",
        "Cart not found.")
    {
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
            ApiErrorCodes.VoucherCodeInvalidFormat,
            StatusCodes.Status400BadRequest,
            message);
    }

    public static VoucherValidationException NotApplicable(string message = "This voucher cannot be applied.")
    {
        return new VoucherValidationException(
            ApiErrorCodes.VoucherNotApplicable,
            StatusCodes.Status422UnprocessableEntity,
            message);
    }

    public static VoucherValidationException MinimumSubtotalNotMet(decimal minimumSubtotal)
    {
        return new VoucherValidationException(
            ApiErrorCodes.VoucherMinimumSubtotalNotMet,
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
            ApiErrorCodes.VoucherAlreadyApplied,
            StatusCodes.Status409Conflict,
            "Voucher is already applied.");
    }

    public static VoucherValidationException LimitReached()
    {
        return new VoucherValidationException(
            ApiErrorCodes.VoucherLimitReached,
            StatusCodes.Status409Conflict,
            "Only one voucher can be applied to a cart.");
    }
}
