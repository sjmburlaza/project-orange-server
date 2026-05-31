using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;
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
        var cart = await _cartService.GetCartAsync(cartCode, UserId);

        return Ok(cart);
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<ActionResult<CartResponseDto>> GetMyCart()
    {
        var cart = await _cartService.GetCartByUserIdAsync(UserId!);

        return Ok(cart);
    }

    [HttpPost("items")]
    public async Task<ActionResult<CartResponseDto>> AddToNewCart(
      AddToCartRequest request)
    {
        var cart = await _cartService.AddToCartAsync(
            null,
            request,
            UserId);

        return Ok(cart);
    }

    [HttpPost("{cartCode}/items")]
    public async Task<ActionResult<CartResponseDto>> AddToExistingCart(
      string cartCode,
      AddToCartRequest request)
    {
        var cart = await _cartService.AddToCartAsync(
            cartCode,
            request,
            UserId);

        return Ok(cart);
    }

    [HttpPut("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> UpdateQuantity(
        string cartCode,
        int productId,
        UpdateQuantityRequest request)
    {
        var cart = await _cartService.UpdateQuantityAsync(
            cartCode,
            productId,
            request,
            UserId);

        return Ok(cart);
    }

    [HttpDelete("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> RemoveItem(
        string cartCode,
        int productId)
    {
        var cart = await _cartService.RemoveItemAsync(
            cartCode,
            productId,
            UserId);

        return Ok(cart);
    }

    [HttpPost("{cartCode}/vouchers")]
    public async Task<ActionResult<CartResponseDto>> ApplyVoucher(
        string cartCode,
        ApplyVoucherRequest request)
    {
        var cart = await _cartService.ApplyVoucherAsync(
            cartCode,
            request,
            UserId);

        return Ok(cart);
    }

    [HttpPut("{cartCode}/shipping")]
    public async Task<ActionResult<CartResponseDto>> UpdateShipping(
    string cartCode,
    UpdateCartShippingRequest request)
    {
        var userId = User.Identity?.Name;

        var cart = await _cartService.UpdateShippingAsync(
            cartCode,
            request,
            userId
        );

        return Ok(cart);
    }
}
