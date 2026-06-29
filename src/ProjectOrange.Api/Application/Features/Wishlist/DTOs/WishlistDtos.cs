using System.ComponentModel.DataAnnotations;

namespace ProjectOrangeApi.DTOs;

public class AddWishlistItemRequest
{
    [Range(1, int.MaxValue)]
    public int ProductId { get; set; }
}

public class WishlistResponseDto
{
    public int Count => Items.Count;
    public List<WishlistItemDto> Items { get; set; } = [];
}

public class WishlistItemDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTimeOffset AddedAtUtc { get; set; }
    public ProductDto Product { get; set; } = new();
}

public class WishlistStatusDto
{
    public int ProductId { get; set; }
    public bool IsWishlisted { get; set; }
}
