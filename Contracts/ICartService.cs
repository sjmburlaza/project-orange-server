using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.DTOs;

public interface ICartService
{
    Task<CartResponseDto> GetCartAsync(string cartCode);
    Task<CartResponseDto> AddToCartAsync(string cartCode, AddToCartRequest request);
    Task<CartResponseDto> UpdateQuantityAsync(string cartCode, int productId, UpdateQuantityRequest request);
    Task<CartResponseDto> RemoveItemAsync(string cartCode, int productId);
    Task<CartResponseDto> ApplyVoucherAsync(string cartCode, ApplyVoucherRequest request);
}
