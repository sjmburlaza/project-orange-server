
using Microsoft.EntityFrameworkCore;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class CartService : ICartService
{
    private const string BillingTypeCredit = "credit";
    private const string BillingTypeMonthly = "monthly";
    private const string BillingTypeOneTime = "oneTime";

    private readonly AppDbContext _context;
    private readonly ShippingPricingService _shippingPricingService;
    private readonly TradeInSessionService _tradeInSessionService;

    public CartService(
        AppDbContext context,
        ShippingPricingService shippingPricingService,
        TradeInSessionService tradeInSessionService)
    {
        _context = context;
        _shippingPricingService = shippingPricingService;
        _tradeInSessionService = tradeInSessionService;
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

        var selectedAddons = GetSelectedAddonSnapshots(product, request);

        var existingItem = cart.Entries.FirstOrDefault(item =>
            item.ProductId == request.ProductId);

        if (existingItem is not null)
        {
            if (!HasSameAddons(existingItem.Addons, selectedAddons))
            {
                throw AddonValidationException.LimitReached(
                    "Product is already in cart with a different add-on selection.");
            }

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

                Addons = selectedAddons
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
            throw new CartItemNotFoundException();

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
            throw new CartItemNotFoundException();

        cart.Entries.Remove(item);

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> UpsertCartItemAddonAsync(
        string cartCode,
        int productId,
        string addonId,
        UpdateCartItemAddonRequest request,
        string? userId)
    {
        var normalizedAddonId = NormalizeAddonId(addonId);
        var cart = await GetCartEntityAsync(cartCode, userId);
        var item = GetCartItemOrThrow(cart, productId);
        var addon = GetEligibleAddonOrThrow(item.CategoryName, normalizedAddonId);
        var selectedAddon = CreateCartItemAddonSnapshot(addon, item.CategoryName, request);

        RemoveExistingAddons(item, normalizedAddonId);
        item.Addons.Add(selectedAddon);

        await _context.SaveChangesAsync();

        return MapToResponse(cart);
    }

    public async Task<CartResponseDto> RemoveCartItemAddonAsync(
        string cartCode,
        int productId,
        string addonId,
        string? userId)
    {
        var normalizedAddonId = NormalizeAddonId(addonId);
        var cart = await GetCartEntityAsync(cartCode, userId);
        var item = GetCartItemOrThrow(cart, productId);

        GetEligibleAddonOrThrow(item.CategoryName, normalizedAddonId);
        RemoveExistingAddons(item, normalizedAddonId);

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
        var addonSummary = GetAddonSummary(cart);
        var addonTotal = addonSummary.Sum(summary => summary.Amount ?? 0);
        var discount = GetDiscount(cart, subtotal);

        var hasSelectedShipping = cart.ShippingPrice.HasValue;
        var shipping = cart.ShippingPrice.HasValue ? cart.ShippingPrice.Value : 0;

        var total = subtotal + addonTotal - discount + shipping;

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

                Addons = MapAvailableAddons(item)
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
                .. addonSummary,
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

    private static string NormalizeAddonId(string? addonId)
    {
        if (string.IsNullOrWhiteSpace(addonId))
        {
            throw AddonValidationException.NotAvailable("Add-on id is required.");
        }

        return addonId.Trim();
    }

    private static CartItem GetCartItemOrThrow(Cart cart, int productId)
    {
        return cart.Entries.FirstOrDefault(item => item.ProductId == productId)
            ?? throw new CartItemNotFoundException();
    }

    private static Addon GetEligibleAddonOrThrow(string categoryName, string addonId)
    {
        var addon = AddonSeed.FindById(addonId);

        if (addon is null)
        {
            throw AddonValidationException.NotAvailable();
        }

        var isEligible = AddonSeed.GetEligibleAddons(categoryName).Any(eligibleAddon =>
            string.Equals(eligibleAddon.Id, addon.Id, StringComparison.OrdinalIgnoreCase));

        if (!isEligible)
        {
            throw AddonValidationException.NotAvailable();
        }

        return addon;
    }

    private void RemoveExistingAddons(CartItem item, string addonId)
    {
        var addonsToRemove = item.Addons
            .Where(addon => string.Equals(addon.AddonId, addonId, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (addonsToRemove.Count == 0)
        {
            return;
        }

        foreach (var addon in addonsToRemove)
        {
            item.Addons.Remove(addon);
        }

        _context.CartItemAddons.RemoveRange(addonsToRemove);
    }

    private List<CartItemAddon> GetSelectedAddonSnapshots(Product product, AddToCartRequest request)
    {
        var selectedAddonIds = request.Addons
            .Where(addon => addon.IsAdded)
            .Select(addon => addon.Id.Trim())
            .Where(id => !string.IsNullOrWhiteSpace(id))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        if (selectedAddonIds.Count == 0)
        {
            return [];
        }

        var categoryName = product.Category?.Name ?? string.Empty;
        var eligibleAddons = AddonSeed.GetEligibleAddons(categoryName);
        var selectedAddons = new List<CartItemAddon>();

        foreach (var addonId in selectedAddonIds)
        {
            var addon = AddonSeed.FindById(addonId);

            if (addon is null || !eligibleAddons.Any(eligibleAddon =>
                    string.Equals(eligibleAddon.Id, addon.Id, StringComparison.OrdinalIgnoreCase)))
            {
                throw AddonValidationException.NotAvailable();
            }

            selectedAddons.Add(CreateCartItemAddonSnapshot(addon, categoryName, request));
        }

        return selectedAddons;
    }

    private CartItemAddon CreateCartItemAddonSnapshot(
        Addon addon,
        string categoryName,
        AddonSelectionRequest request)
    {
        return addon.Id switch
        {
            "insurance" => CreateInsuranceAddonSnapshot(addon, categoryName, request),
            "trade-in" => CreateTradeInAddonSnapshot(addon, request),
            "mobile-plan" => CreateMobilePlanAddonSnapshot(addon, categoryName, request),
            _ => CreateDisplayOnlyAddonSnapshot(addon)
        };
    }

    private static CartItemAddon CreateInsuranceAddonSnapshot(
        Addon addon,
        string categoryName,
        AddonSelectionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.InsurancePlanCode))
        {
            throw AddonValidationException.NotAvailable("Select an insurance plan before adding insurance to cart.");
        }

        var plan = InsurancePlanSeed.FindPlan(categoryName, request.InsurancePlanCode);

        if (plan is null)
        {
            throw AddonValidationException.NotAvailable("Selected insurance plan is not available for this product.");
        }

        var snapshot = CreateDisplayOnlyAddonSnapshot(addon);
        snapshot.OptionCode = plan.Code;
        snapshot.OptionName = plan.Name;
        snapshot.Title = plan.Name;
        snapshot.Description = plan.Description;
        snapshot.Amount = ParseCurrencyAmount(plan.Amount);
        snapshot.AmountDisplay = plan.Amount;
        snapshot.BillingType = BillingTypeOneTime;
        snapshot.MultiplyByQuantity = true;

        return snapshot;
    }

    private CartItemAddon CreateTradeInAddonSnapshot(Addon addon, AddonSelectionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.TradeInSessionId))
        {
            throw AddonValidationException.NotAvailable("Complete a trade-in session before adding trade-in to cart.");
        }

        var session = _tradeInSessionService.GetSession(request.TradeInSessionId);

        if (session is null || !session.IsConfirmed || session.Summary is null)
        {
            throw AddonValidationException.NotAvailable("Trade-in session is not ready to be added to cart.");
        }

        if (session.Summary.FinalAmount <= 0)
        {
            throw AddonValidationException.NotAvailable("Trade-in estimate must be greater than zero.");
        }

        var optionName = string.IsNullOrWhiteSpace(session.Summary.Device)
            ? "Trade-In Credit"
            : $"{session.Summary.Device} Trade-In";

        var snapshot = CreateDisplayOnlyAddonSnapshot(addon);
        snapshot.OptionCode = session.SessionId;
        snapshot.OptionName = optionName;
        snapshot.Title = optionName;
        snapshot.Amount = -session.Summary.FinalAmount;
        snapshot.AmountDisplay = FormatPesoAmount(session.Summary.FinalAmount);
        snapshot.BillingType = BillingTypeCredit;
        snapshot.MultiplyByQuantity = false;

        return snapshot;
    }

    private static CartItemAddon CreateMobilePlanAddonSnapshot(
        Addon addon,
        string categoryName,
        AddonSelectionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.MobilePlanCode))
        {
            throw AddonValidationException.NotAvailable("Select a mobile plan before adding a mobile plan to cart.");
        }

        var plan = MobilePlanSeed.FindPlan(categoryName, request.MobilePlanCode);

        if (plan is null)
        {
            throw AddonValidationException.NotAvailable("Selected mobile plan is not available for this product.");
        }

        var snapshot = CreateDisplayOnlyAddonSnapshot(addon);
        snapshot.OptionCode = plan.Code;
        snapshot.OptionName = plan.Name;
        snapshot.Title = plan.Name;
        snapshot.Description = plan.Description;
        snapshot.Amount = ParseCurrencyAmount(plan.Amount);
        snapshot.AmountDisplay = plan.Amount;
        snapshot.BillingType = BillingTypeMonthly;
        snapshot.MultiplyByQuantity = false;

        return snapshot;
    }

    private static CartItemAddon CreateDisplayOnlyAddonSnapshot(Addon addon)
    {
        return new CartItemAddon
        {
            AddonId = addon.Id,
            Name = addon.Name,
            Title = addon.Title,
            Description = addon.Description,
            ImageUrl = addon.ImageUrl,
            IsAdded = true
        };
    }

    private static bool HasSameAddons(
        IEnumerable<CartItemAddon> cartAddons,
        IEnumerable<CartItemAddon> selectedAddons)
    {
        var cartAddonIds = cartAddons
            .Where(addon => addon.IsAdded)
            .Select(GetAddonComparisonKey)
            .OrderBy(id => id, StringComparer.OrdinalIgnoreCase)
            .ToList();

        var selectedAddonIds = selectedAddons
            .Select(GetAddonComparisonKey)
            .OrderBy(id => id, StringComparer.OrdinalIgnoreCase)
            .ToList();

        return cartAddonIds.SequenceEqual(selectedAddonIds, StringComparer.OrdinalIgnoreCase);
    }

    private static string GetAddonComparisonKey(CartItemAddon addon)
    {
        return $"{addon.AddonId}:{addon.OptionCode}";
    }

    private static List<AddonDto> MapAvailableAddons(CartItem item)
    {
        var selectedAddons = item.Addons
            .Where(addon => addon.IsAdded)
            .GroupBy(addon => addon.AddonId, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(
                group => group.Key,
                group => group.First(),
                StringComparer.OrdinalIgnoreCase);

        return AddonSeed.GetEligibleAddons(item.CategoryName)
            .Select(addon => MapAvailableAddon(item, addon, selectedAddons))
            .ToList();
    }

    private static AddonDto MapAvailableAddon(
        CartItem item,
        Addon addon,
        IReadOnlyDictionary<string, CartItemAddon> selectedAddons)
    {
        if (!selectedAddons.TryGetValue(addon.Id, out var selectedAddon))
        {
            return new AddonDto
            {
                Id = addon.Id,
                Name = addon.Name,
                Title = addon.Title,
                Description = addon.Description,
                ImageUrl = addon.ImageUrl,
                Amount = string.Empty,
                SelectedOptionCode = string.Empty,
                SelectedOptionName = string.Empty,
                IsAdded = false
            };
        }

        var selectedTitle = string.IsNullOrWhiteSpace(selectedAddon.OptionName)
            ? selectedAddon.Title
            : selectedAddon.OptionName;
        var selectedDescription = selectedAddon.Description;

        if (string.Equals(addon.Id, "insurance", StringComparison.OrdinalIgnoreCase))
        {
            var plan = InsurancePlanSeed.FindPlan(item.CategoryName, selectedAddon.OptionCode);

            selectedTitle = plan?.Name ?? selectedTitle;
            selectedDescription = plan?.Description ?? selectedDescription;
        }
        else if (string.Equals(addon.Id, "mobile-plan", StringComparison.OrdinalIgnoreCase))
        {
            var plan = MobilePlanSeed.FindPlan(item.CategoryName, selectedAddon.OptionCode);

            selectedTitle = plan?.Name ?? selectedTitle;
            selectedDescription = plan?.Description ?? selectedDescription;
        }

        return new AddonDto
        {
            Id = addon.Id,
            Name = addon.Name,
            Title = string.IsNullOrWhiteSpace(selectedTitle) ? addon.Title : selectedTitle,
            Description = string.IsNullOrWhiteSpace(selectedDescription) ? addon.Description : selectedDescription,
            ImageUrl = string.IsNullOrWhiteSpace(selectedAddon.ImageUrl) ? addon.ImageUrl : selectedAddon.ImageUrl,
            Amount = selectedAddon.AmountDisplay,
            SelectedOptionCode = selectedAddon.OptionCode,
            SelectedOptionName = selectedAddon.OptionName,
            IsAdded = true
        };
    }

    private static List<CartSummaryAttributeDto> GetAddonSummary(Cart cart)
    {
        return cart.Entries
            .SelectMany(item => item.Addons
                .Where(addon => addon.IsAdded)
                .Select(addon => new { Item = item, Addon = addon }))
            .Select(entry =>
            {
                var name = string.IsNullOrWhiteSpace(entry.Addon.OptionName)
                    ? entry.Addon.Name
                    : $"{entry.Addon.Name} - {entry.Addon.OptionName}";

                if (entry.Addon.BillingType == BillingTypeMonthly)
                {
                    return new CartSummaryAttributeDto
                    {
                        Name = name,
                        Amount = null,
                        DisplayValue = entry.Addon.AmountDisplay
                    };
                }

                var amount = entry.Addon.MultiplyByQuantity
                    ? entry.Addon.Amount * entry.Item.Quantity
                    : entry.Addon.Amount;

                return new CartSummaryAttributeDto
                {
                    Name = name,
                    Amount = amount
                };
            })
            .ToList();
    }

    private static decimal ParseCurrencyAmount(string amount)
    {
        var amountText = new string(amount
            .Where(character => char.IsDigit(character) || character == '.' || character == '-')
            .ToArray());

        return decimal.TryParse(amountText, out var value)
            ? value
            : 0;
    }

    private static string FormatPesoAmount(decimal amount)
    {
        return $"P{amount:N0}";
    }

    private static bool IsVoucherCodeCharacter(char character)
    {
        return character is >= 'A' and <= 'Z'
            || character is >= '0' and <= '9'
            || character is '-' or '_';
    }
}
