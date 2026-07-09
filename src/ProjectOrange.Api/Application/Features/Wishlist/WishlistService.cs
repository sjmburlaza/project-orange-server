using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Contracts;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class WishlistService : IWishlistService
{
    private readonly AppDbContext _context;
    private readonly ISiteContext _siteContext;

    public WishlistService(AppDbContext context, ISiteContext siteContext)
    {
        _context = context;
        _siteContext = siteContext;
    }

    public async Task<WishlistResponseDto> GetWishlistAsync(string userId)
    {
        var items = await LoadWishlistItems(userId)
            .AsNoTracking()
            .OrderByDescending(item => item.CreatedAtUtc)
            .ThenBy(item => item.Id)
            .ToListAsync();

        return MapWishlist(items);
    }

    public async Task<WishlistResponseDto> AddItemAsync(AddWishlistItemRequest request, string userId)
    {
        var productExists = await _context.Products.AnyAsync(product =>
            product.Id == request.ProductId &&
            product.SiteId == _siteContext.SiteId);

        if (!productExists)
        {
            throw WishlistValidationException.ProductNotFound(request.ProductId);
        }

        var alreadyExists = await _context.WishlistItems.AnyAsync(item =>
            item.SiteId == _siteContext.SiteId &&
            item.UserId == userId &&
            item.ProductId == request.ProductId);

        if (!alreadyExists)
        {
            _context.WishlistItems.Add(new WishlistItem
            {
                SiteId = _siteContext.SiteId,
                UserId = userId,
                ProductId = request.ProductId,
                CreatedAtUtc = DateTimeOffset.UtcNow
            });

            await _context.SaveChangesAsync();
        }

        return await GetWishlistAsync(userId);
    }

    public async Task<WishlistResponseDto> RemoveItemAsync(int productId, string userId)
    {
        var item = await _context.WishlistItems.FirstOrDefaultAsync(candidate =>
            candidate.SiteId == _siteContext.SiteId &&
            candidate.UserId == userId &&
            candidate.ProductId == productId);

        if (item is not null)
        {
            _context.WishlistItems.Remove(item);
            await _context.SaveChangesAsync();
        }

        return await GetWishlistAsync(userId);
    }

    public async Task<WishlistStatusDto> GetItemStatusAsync(int productId, string userId)
    {
        var isWishlisted = await _context.WishlistItems.AnyAsync(item =>
            item.SiteId == _siteContext.SiteId &&
            item.UserId == userId &&
            item.ProductId == productId);

        return new WishlistStatusDto
        {
            ProductId = productId,
            IsWishlisted = isWishlisted
        };
    }

    private IQueryable<WishlistItem> LoadWishlistItems(string userId)
    {
        return _context.WishlistItems
            .Include(item => item.Product)
                .ThenInclude(product => product.Category)
            .Include(item => item.Product)
                .ThenInclude(product => product.ItemSpecs)
            .Include(item => item.Product)
                .ThenInclude(product => product.OptionGroups)
                    .ThenInclude(group => group.Options)
            .Include(item => item.Product)
                .ThenInclude(product => product.Variants)
            .Where(item =>
                item.SiteId == _siteContext.SiteId &&
                item.UserId == userId)
            .AsSplitQuery();
    }

    private static WishlistResponseDto MapWishlist(IEnumerable<WishlistItem> items)
    {
        return new WishlistResponseDto
        {
            Items = items
                .Select(item => new WishlistItemDto
                {
                    Id = item.Id,
                    ProductId = item.ProductId,
                    AddedAtUtc = item.CreatedAtUtc,
                    Product = MapProduct(item.Product)
                })
                .ToList()
        };
    }

    private static ProductDto MapProduct(Product product)
    {
        var stockQuantity = GetProductStockQuantity(product);

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = GetProductPrice(product),
            ReviewRating = product.ReviewRating,
            StockQuantity = stockQuantity,
            StockStatus = GetStockStatus(stockQuantity),
            ImageUrl = product.ImageUrl,
            CategoryId = product.CategoryId,
            CategoryName = product.Category?.Name ?? string.Empty,
            SubcategoryName = product.SubcategoryName,
            ItemSpecs = product.ItemSpecs.Select(spec => new ProductSpecDto
            {
                Name = spec.Name,
                Value = spec.Value
            }).ToList(),
            AvailableColors = MapAvailableColors(product)
        };
    }

    private static List<ProductOptionDto> MapAvailableColors(Product product)
    {
        return product.OptionGroups
            .Where(group => string.Equals(
                group.Code,
                ProductOptionSeed.ColorGroupCode,
                StringComparison.OrdinalIgnoreCase))
            .OrderBy(group => group.SortOrder)
            .ThenBy(group => group.Id)
            .SelectMany(group => group.Options
                .OrderBy(option => option.SortOrder)
                .ThenBy(option => option.Id)
                .Select(option => new ProductOptionDto
                {
                    Code = option.Code,
                    Label = option.Label,
                    Hex = option.Hex,
                    ImageUrl = option.ImageUrl
                }))
            .ToList();
    }

    private static decimal GetProductPrice(Product product)
    {
        return product.Variants.Count > 0
            ? product.Variants.Min(variant => variant.Price)
            : product.Price;
    }

    private static int GetProductStockQuantity(Product product)
    {
        return product.Variants.Count > 0
            ? product.Variants.Sum(variant => variant.StockQuantity)
            : product.StockQuantity;
    }

    private static string GetStockStatus(int stockQuantity)
    {
        if (stockQuantity <= 0)
        {
            return "outOfStock";
        }

        return stockQuantity <= 5 ? "lowStock" : "inStock";
    }
}
