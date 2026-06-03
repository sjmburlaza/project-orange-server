
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class CartService : ICartService
{
    private readonly AppDbContext _context;
    private readonly ShippingPricingService _shippingPricingService;

    public CartService(AppDbContext context, ShippingPricingService shippingPricingService)
    {
        _context = context;
        _shippingPricingService = shippingPricingService;
    }

    public async Task<CartResponseDto> GetCartAsync(string cartCode, string? userId)
    {
        var cart = await GetCartEntityAsync(cartCode, userId);

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> AddToCartAsync(string? cartCode, AddToCartRequest request, string? userId)
    {
        if (request.Quantity <= 0)
        {
            throw new Exception("Quantity must be greater than zero.");
        }

        var cart = await GetOrCreateCartAsync(cartCode, userId);

        var product = await _context.Products
            .Include(p => p.Category)
            .Include(p => p.ItemSpecs)
            .FirstOrDefaultAsync(p => p.Id == request.ProductId)
            ?? throw new Exception("Product not found.");

        var existingItem = cart.Entries.FirstOrDefault(x => x.ProductId == request.ProductId);

        if (existingItem is not null)
        {
            existingItem.Quantity += request.Quantity;
        }
        else
        {
            var cartItem = new CartItem
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = request.Quantity,
                StockQuantity = product.StockQuantity,
                ImageUrl = product.ImageUrl,
                CategoryName = product.Category?.Name ?? string.Empty,

                ItemSpecs = product.ItemSpecs.Select(spec => new CartItemSpec
                {
                    Name = spec.Name,
                    Value = spec.Value
                }).ToList(),

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
      UpdateQuantityRequest request,
      string? userId)
    {
        var cart = await GetCartEntityAsync(cartCode, userId);
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

    public async Task<CartResponseDto> RemoveItemAsync(string cartCode, int productId, string? userId)
    {
        var cart = await GetCartEntityAsync(cartCode, userId);
        var item = cart.Entries.FirstOrDefault(x => x.ProductId == productId);

        if (item is null)
            throw new Exception("Cart item not found.");

        cart.Entries.Remove(item);

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> ApplyVoucherAsync(string cartCode, ApplyVoucherRequest request, string? userId)
    {
        var voucherCode = NormalizeVoucherCode(request.Code);

        var voucher = VoucherSeed.FindByCode(voucherCode);

        if (voucher is null)
        {
            throw VoucherValidationException.NotApplicable();
        }

        var cart = await GetCartEntityAsync(cartCode, userId);

        if (!cart.Entries.Any())
        {
            throw VoucherValidationException.NotApplicable("Add at least one item before applying a voucher.");
        }

        ValidateVoucherEligibility(voucher, cart, DateTimeOffset.UtcNow);

        var alreadyApplied = cart.AppliedVouchers.Any(v =>
            string.Equals(v.Code, voucher.Code, StringComparison.OrdinalIgnoreCase));

        if (alreadyApplied)
        {
            throw VoucherValidationException.AlreadyApplied();
        }

        if (cart.AppliedVouchers.Any())
        {
            throw VoucherValidationException.LimitReached();
        }

        cart.AppliedVouchers.Add(new CartVoucher
        {
            Code = voucher.Code,
            Name = voucher.Name,
            Description = voucher.Description
        });

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> RemoveVoucherAsync(string cartCode, string voucherCode, string? userId)
    {
        var normalizedVoucherCode = NormalizeVoucherCode(voucherCode);
        var cart = await GetCartEntityAsync(cartCode, userId);

        var appliedVoucher = cart.AppliedVouchers.FirstOrDefault(voucher =>
            string.Equals(voucher.Code, normalizedVoucherCode, StringComparison.OrdinalIgnoreCase));

        if (appliedVoucher is null)
        {
            throw VoucherValidationException.NotApplicable("Voucher is not applied to this cart.");
        }

        cart.AppliedVouchers.Remove(appliedVoucher);
        _context.CartVouchers.Remove(appliedVoucher);

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    private async Task<Cart> GetOrCreateCartAsync(string? cartCode, string? userId)
    {
        if (!string.IsNullOrWhiteSpace(userId))
        {
            var userCart = await LoadCartQuery()
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (userCart is not null)
            {
                return userCart;
            }
        }

        if (!string.IsNullOrWhiteSpace(cartCode))
        {
            var existingCart = await LoadCartQuery()
                .FirstOrDefaultAsync(c => c.Code == cartCode);

            if (existingCart is not null)
            {
                if (!string.IsNullOrWhiteSpace(userId) &&
                    string.IsNullOrWhiteSpace(existingCart.UserId))
                {
                    existingCart.UserId = userId;

                    await _context.SaveChangesAsync();
                }

                return existingCart;
            }
        }

        var newCart = new Cart
        {
            Code = GenerateCartCode(),
            UserId = userId
        };

        _context.Carts.Add(newCart);

        await _context.SaveChangesAsync();

        return newCart;
    }

    private IQueryable<Cart> LoadCartQuery()
    {
        return _context.Carts
            .Include(c => c.Entries)
                .ThenInclude(i => i.ItemSpecs)
            .Include(c => c.Entries)
                .ThenInclude(i => i.Addons)
            .Include(c => c.AppliedVouchers);
    }

    private static string GenerateCartCode()
    {
        return $"CART-{Guid.NewGuid():N}".ToUpper()[..13];
    }

    private async Task<Cart> GetCartEntityAsync(string cartCode, string? userId)
    {
        var cart = await LoadCartQuery()
            .FirstOrDefaultAsync(c =>
                c.Code == cartCode &&
                (c.UserId == null || c.UserId == userId));

        if (cart is null)
        {
            throw new CartNotFoundException();
        }

        return cart;
    }

    private CartResponseDto MapToResponse(Cart cart)
    {
        var subtotal = GetSubtotal(cart);
        var discount = GetDiscount(cart, subtotal);

        var hasSelectedShipping = cart.ShippingPrice.HasValue;
        var shipping = cart.ShippingPrice.HasValue ? cart.ShippingPrice.Value : 0;

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
                StockQuantity = item.StockQuantity,
                ImageUrl = item.ImageUrl,
                CategoryName = item.CategoryName,

                ItemSpecs = item.ItemSpecs.Select(spec => new ProductSpecDto
                {
                    Name = spec.Name,
                    Value = spec.Value
                }).ToList(),

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
                    Name = "Shipping",
                    Amount = hasSelectedShipping ? shipping : null,
                    DisplayValue = hasSelectedShipping ? null : "To be calculated"
                },
                new CartSummaryAttributeDto
                {
                    Name = "Discount",
                    Amount = -discount
                },
                new CartSummaryAttributeDto
                {
                    Name = "Total",
                    Amount = total
                }
            ]
        };
    }

    public async Task<CartResponseDto> GetCartByUserIdAsync(string userId)
    {
        var cart = await LoadCartQuery()
            .FirstOrDefaultAsync(c => c.UserId == userId);

        if (cart is null)
            throw new CartNotFoundException();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> UpdateShippingAsync(
        string cartCode,
        UpdateCartShippingRequest request,
        string? userId)
    {
        var cart = await GetCartEntityAsync(cartCode, userId);

        var options = _shippingPricingService.GetRatesByPostalCode(request.PostalCode);

        var selectedOption = options.FirstOrDefault(option =>
            option.Code == request.ShippingMethodCode);

        if (selectedOption is null)
        {
            throw new Exception("Invalid shipping option.");
        }

        cart.ShippingPostalCode = request.PostalCode;
        cart.ShippingMethodCode = selectedOption.Code;
        cart.ShippingPrice = selectedOption.Price;

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    private static string NormalizeVoucherCode(string? code)
    {
        var normalizedCode = code?.Trim().ToUpperInvariant();

        if (string.IsNullOrWhiteSpace(normalizedCode))
        {
            throw VoucherValidationException.InvalidFormat("Voucher code is required.");
        }

        if (normalizedCode.Length < 3)
        {
            throw VoucherValidationException.InvalidFormat("Voucher code must be at least 3 characters.");
        }

        if (normalizedCode.Length > 32)
        {
            throw VoucherValidationException.InvalidFormat("Voucher code must be 32 characters or fewer.");
        }

        if (!normalizedCode.All(IsVoucherCodeCharacter))
        {
            throw VoucherValidationException.InvalidFormat("Voucher code can only contain letters, numbers, hyphens, or underscores.");
        }

        return normalizedCode;
    }

    private static void ValidateVoucherEligibility(Voucher voucher, Cart cart, DateTimeOffset now)
    {
        if (voucher.Status == VoucherStatus.Expired)
        {
            throw VoucherValidationException.NotApplicable();
        }

        if (voucher.Status == VoucherStatus.Scheduled)
        {
            throw VoucherValidationException.NotApplicable();
        }

        if (voucher.Status != VoucherStatus.Active)
        {
            throw VoucherValidationException.NotApplicable();
        }

        if (voucher.StartsAtUtc.HasValue && now < voucher.StartsAtUtc.Value)
        {
            throw VoucherValidationException.NotApplicable();
        }

        if (voucher.ExpiresAtUtc.HasValue && now >= voucher.ExpiresAtUtc.Value)
        {
            throw VoucherValidationException.NotApplicable();
        }

        var subtotal = GetSubtotal(cart);

        if (voucher.MinimumSubtotal > 0 && subtotal < voucher.MinimumSubtotal)
        {
            throw VoucherValidationException.MinimumSubtotalNotMet(voucher.MinimumSubtotal);
        }
    }

    private static decimal GetDiscount(Cart cart, decimal subtotal)
    {
        var discount = cart.AppliedVouchers.Sum(voucher =>
        {
            var voucherRule = VoucherSeed.FindByCode(voucher.Code);

            if (voucherRule is null)
            {
                return 0;
            }

            return subtotal * (voucherRule.DiscountPercent / 100);
        });

        return Math.Min(discount, subtotal);
    }

    private static decimal GetSubtotal(Cart cart)
    {
        return cart.Entries.Sum(item => item.Price * item.Quantity);
    }

    private static bool IsVoucherCodeCharacter(char character)
    {
        return character is >= 'A' and <= 'Z'
            || character is >= '0' and <= '9'
            || character is '-' or '_';
    }
}
