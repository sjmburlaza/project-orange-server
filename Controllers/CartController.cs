using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;

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

    [HttpGet("{cartCode}")]
    public async Task<ActionResult<CartResponseDto>> GetCart(string cartCode)
    {
        var cart = await _cartService.GetCartAsync(cartCode);

        return Ok(cart);
    }

    [HttpPost("items")]
    public async Task<ActionResult<CartResponseDto>> AddToNewCart(
      AddToCartRequest request)
    {
        var cart = await _cartService.AddToCartAsync(null, request);

        return Ok(cart);
    }

    [HttpPost("{cartCode}/items")]
    public async Task<ActionResult<CartResponseDto>> AddToExistingCart(
      string cartCode,
      AddToCartRequest request)
    {
        var cart = await _cartService.AddToCartAsync(cartCode, request);

        return Ok(cart);
    }

    [HttpPut("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> UpdateQuantity(
        string cartCode,
        int productId,
        UpdateQuantityRequest request)
    {
        var cart = await _cartService.UpdateQuantityAsync(cartCode, productId, request);

        return Ok(cart);
    }

    [HttpDelete("{cartCode}/items/{productId}")]
    public async Task<ActionResult<CartResponseDto>> RemoveItem(
        string cartCode,
        int productId)
    {
        var cart = await _cartService.RemoveItemAsync(cartCode, productId);

        return Ok(cart);
    }

    [HttpPost("{cartCode}/vouchers")]
    public async Task<ActionResult<CartResponseDto>> ApplyVoucher(
        string cartCode,
        ApplyVoucherRequest request)
    {
        var cart = await _cartService.ApplyVoucherAsync(cartCode, request);

        return Ok(cart);
    }
}
