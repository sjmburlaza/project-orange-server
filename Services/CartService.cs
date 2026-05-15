
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class CartService : ICartService
{
    private readonly AppDbContext _context;

    public CartService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<CartResponseDto> GetCartAsync(string cartCode)
    {
        var cart = await GetCartEntityAsync(cartCode);

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> AddToCartAsync(string? cartCode, AddToCartRequest request)
    {
        var cart = await GetOrCreateCartAsync(cartCode);
        var existingItem = cart.Entries.FirstOrDefault(x => x.ProductId == request.ProductId);

        if (existingItem is not null)
        {
            existingItem.Quantity += request.Quantity;
        }
        else
        {
            var cartItem = new CartItem
            {
                ProductId = request.ProductId,
                ProductName = request.ProductName,
                Price = request.Price,
                Quantity = request.Quantity,
                ImageUrl = request.ImageUrl,
                Addons = request.Addons.Select(a => new CartItemAddon
                {
                    AddonId = a.Id,
                    Name = a.Name,
                    Title = a.Title,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    IsAdded = a.IsAdded
                }).ToList()
            };

            cart.Entries.Add(cartItem);
        }

        await _context.SaveChangesAsync();
        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> UpdateQuantityAsync(
      string cartCode,
      int productId,
      UpdateQuantityRequest request)
    {
        var cart = await GetCartEntityAsync(cartCode);
        var item = cart.Entries.FirstOrDefault(x => x.ProductId == productId);

        if (item is null)
            throw new Exception("Cart item not found.");

        if (request.Quantity <= 0)
        {
            cart.Entries.Remove(item);
        }
        else
        {
            item.Quantity = request.Quantity;
        }

        await _context.SaveChangesAsync();
        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> RemoveItemAsync(string cartCode, int productId)
    {
        var cart = await GetCartEntityAsync(cartCode);
        var item = cart.Entries.FirstOrDefault(x => x.ProductId == productId);

        if (item is null)
            throw new Exception("Cart item not found.");

        cart.Entries.Remove(item);

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> ApplyVoucherAsync(string cartCode, ApplyVoucherRequest request)
    {
        var cart = await GetCartEntityAsync(cartCode);
        var alreadyApplied = cart.AppliedVouchers.Any(v => v.Code == request.Code);

        if (!alreadyApplied)
        {
            cart.AppliedVouchers.Add(new CartVoucher
            {
                Code = request.Code,
                Name = "Promo Voucher",
                Description = "Voucher applied successfully"
            });
        }

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    private async Task<Cart> GetOrCreateCartAsync(string? cartCode)
    {
        if (!string.IsNullOrWhiteSpace(cartCode))
        {
            var existingCart = await _context.Carts
                .Include(c => c.Entries)
                .ThenInclude(i => i.Addons)
                .Include(c => c.AppliedVouchers)
                .FirstOrDefaultAsync(c => c.Code == cartCode);

            if (existingCart is not null)
                return existingCart;
        }

        var newCart = new Cart
        {
            Code = GenerateCartCode()
        };

        _context.Carts.Add(newCart);
        await _context.SaveChangesAsync();

        return newCart;
    }

    private static string GenerateCartCode()
    {
        return $"CART-{Guid.NewGuid():N}".ToUpper()[..13];
    }

    private async Task<Cart> GetCartEntityAsync(string cartCode)
    {
        var cart = await _context.Carts
          .Include(c => c.Entries)
          .ThenInclude(i => i.Addons)
          .Include(c => c.AppliedVouchers)
          .FirstOrDefaultAsync(c => c.Code == cartCode);

        if (cart is null)
            throw new Exception("Cart not found.");

        return cart;
    }

    private CartResponseDto MapToResponse(Cart cart)
    {
        var subtotal = cart.Entries.Sum(item => item.Price * item.Quantity);
        var discount = cart.AppliedVouchers.Any()
          ? subtotal * 0.10m
          : 0;

        var shipping = subtotal > 0 ? 150 : 0;
        var total = subtotal - discount + shipping;

        return new CartResponseDto
        {
            Code = cart.Code,
            Entries = cart.Entries.Select(item => new CartItemDto
            {
                ProductId = item.ProductId,
                ProductName = item.ProductName,
                Price = item.Price,
                Quantity = item.Quantity,
                ImageUrl = item.ImageUrl,
                Addons = item.Addons.Select(addon => new AddonDto
                {
                    Id = addon.AddonId,
                    Name = addon.Name,
                    Title = addon.Title,
                    Description = addon.Description,
                    ImageUrl = addon.ImageUrl,
                    IsAdded = addon.IsAdded
                }).ToList()
            }).ToList(),

            AppliedVouchers = cart.AppliedVouchers.Select(voucher => new VoucherDto
            {
                Code = voucher.Code,
                Name = voucher.Name,
                Description = voucher.Description
            }).ToList(),

            CartSummary =
          [
            new CartSummaryAttributeDto
        {
          Name = "Subtotal",
          Amount = subtotal
        },
        new CartSummaryAttributeDto
        {
          Name = "Discount",
          Amount = -discount
        },
        new CartSummaryAttributeDto
        {
          Name = "Shipping",
          Amount = shipping
        },
        new CartSummaryAttributeDto
        {
          Name = "Total",
          Amount = total
        }
          ]
        };
    }
}
