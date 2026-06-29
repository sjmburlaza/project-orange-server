using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Contracts;

public interface IWishlistService
{
    Task<WishlistResponseDto> GetWishlistAsync(string userId);
    Task<WishlistResponseDto> AddItemAsync(AddWishlistItemRequest request, string userId);
    Task<WishlistResponseDto> RemoveItemAsync(int productId, string userId);
    Task<WishlistStatusDto> GetItemStatusAsync(int productId, string userId);
}
