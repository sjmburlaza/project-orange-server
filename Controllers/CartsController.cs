using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;
using ProjectOrangeApi.Contracts;
using System.Security.Claims;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/carts")]
public class CartsController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartsController(ICartService cartService)
    {
        _cartService = cartService;
    }
    private string? UserId =>
        User.FindFirstValue(ClaimTypes.NameIdentifier);

    [HttpGet("{cartCode}")]
    public async Task<ActionResult<CartResponseDto>> GetCart(string cartCode)
    {
        return await ExecuteCartAction(() =>
            _cartService.GetCartAsync(cartCode, UserId));
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<ActionResult<CartResponseDto>> GetMyCart()
    {
        return await ExecuteCartAction(() =>
            _cartService.GetCartByUserIdAsync(UserId!));
    }

    [HttpPost("items")]
    public async Task<ActionResult<CartResponseDto>> AddToNewCart(
      AddToCartRequest request)
    {
        return await ExecuteCartAction(() =>
            _cartService.AddToCartAsync(
                null,
                request,
                UserId));
    }

    [HttpPost("{cartCode}/items")]
    public async Task<ActionResult<CartResponseDto>> AddToExistingCart(
      string cartCode,
      AddToCartRequest request)
    {
        return await ExecuteCartAction(() =>
            _cartService.AddToCartAsync(
                cartCode,
                request,
                UserId));
    }

    [HttpPut("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> UpdateQuantity(
        string cartCode,
        int productId,
        UpdateQuantityRequest request)
    {
        return await ExecuteCartAction(() =>
            _cartService.UpdateQuantityAsync(
                cartCode,
                productId,
                request,
                UserId));
    }

    [HttpDelete("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> RemoveItem(
        string cartCode,
        int productId)
    {
        return await ExecuteCartAction(() =>
            _cartService.RemoveItemAsync(
                cartCode,
                productId,
                UserId));
    }

    [HttpPut("{cartCode}/items/{productId}/addons/{addonId}")]
    public async Task<ActionResult<CartResponseDto>> UpsertCartItemAddon(
        string cartCode,
        int productId,
        string addonId,
        UpdateCartItemAddonRequest request)
    {
        return await ExecuteCartAction(() =>
            _cartService.UpsertCartItemAddonAsync(
                cartCode,
                productId,
                addonId,
                request,
                UserId));
    }

    [HttpDelete("{cartCode}/items/{productId}/addons/{addonId}")]
    public async Task<ActionResult<CartResponseDto>> RemoveCartItemAddon(
        string cartCode,
        int productId,
        string addonId)
    {
        return await ExecuteCartAction(() =>
            _cartService.RemoveCartItemAddonAsync(
                cartCode,
                productId,
                addonId,
                UserId));
    }

    [HttpPost("{cartCode}/vouchers")]
    public async Task<ActionResult<CartResponseDto>> ApplyVoucher(
        string cartCode,
        ApplyVoucherRequest request)
    {
        return await ExecuteCartAction(() =>
            _cartService.ApplyVoucherAsync(
                cartCode,
                request,
                UserId));
    }

    [HttpDelete("{cartCode}/vouchers/{voucherCode}")]
    public async Task<ActionResult<CartResponseDto>> RemoveVoucher(
        string cartCode,
        string voucherCode)
    {
        return await ExecuteCartAction(() =>
            _cartService.RemoveVoucherAsync(
                cartCode,
                voucherCode,
                UserId));
    }

    [HttpPut("{cartCode}/shipping")]
    public async Task<ActionResult<CartResponseDto>> UpdateShipping(
    string cartCode,
    UpdateCartShippingRequest request)
    {
        var userId = User.Identity?.Name;

        return await ExecuteCartAction(() =>
            _cartService.UpdateShippingAsync(
                cartCode,
                request,
                userId
            ));
    }

    private async Task<ActionResult<CartResponseDto>> ExecuteCartAction(
        Func<Task<CartResponseDto>> action)
    {
        try
        {
            var cart = await action();

            return Ok(cart);
        }
        catch (ApiErrorException ex)
        {
            return CreateErrorResponse(ex);
        }
    }

    private ObjectResult CreateErrorResponse(ApiErrorException exception)
    {
        var problem = new ProblemDetails
        {
            Status = exception.StatusCode,
            Title = exception.Title,
            Detail = exception.Message,
            Type = $"https://project-orange-api/errors/{exception.Code.ToLowerInvariant()}"
        };

        problem.Extensions["code"] = exception.Code;

        foreach (var detail in exception.ErrorDetails)
        {
            problem.Extensions[detail.Key] = detail.Value;
        }

        return StatusCode(exception.StatusCode, problem);
    }
}
