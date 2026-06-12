using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Contracts;

public interface ICartService
{
    Task<CartResponseDto> GetCartAsync(string cartCode, string? userId);
    Task<CartResponseDto> GetCartByUserIdAsync(string userId);
    Task<CartResponseDto> AddToCartAsync(string? cartCode, AddToCartRequest request, string? userId);
    Task<CartResponseDto> UpdateQuantityAsync(string cartCode, int productId, UpdateQuantityRequest request, string? userId);
    Task<CartResponseDto> RemoveItemAsync(string cartCode, int productId, string? userId);
    Task<CartResponseDto> UpsertCartItemAddonAsync(string cartCode, int productId, string addonId, UpdateCartItemAddonRequest request, string? userId);
    Task<CartResponseDto> RemoveCartItemAddonAsync(string cartCode, int productId, string addonId, string? userId);
    Task<CartResponseDto> ApplyVoucherAsync(string cartCode, ApplyVoucherRequest request, string? userId);
    Task<CartResponseDto> RemoveVoucherAsync(string cartCode, string voucherCode, string? userId);
    Task<CartResponseDto> UpdateShippingAsync(string cartCode, UpdateCartShippingRequest request, string? userId);
}
