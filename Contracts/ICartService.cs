using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public interface ICartService
{
    Task<CartResponseDto> GetCartAsync(string cartCode, string? userId);
    Task<CartResponseDto> GetCartByUserIdAsync(string userId);
    Task<CartResponseDto> AddToCartAsync(string? cartCode, AddToCartRequest request, string? userId);
    Task<CartResponseDto> UpdateQuantityAsync(string cartCode, int productId, UpdateQuantityRequest request, string? userId);
    Task<CartResponseDto> RemoveItemAsync(string cartCode, int productId, string? userId);
    Task<CartResponseDto> ApplyVoucherAsync(string cartCode, ApplyVoucherRequest request, string? userId);
}
