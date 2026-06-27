namespace ProjectOrangeApi.Models;

public class CartItemAddon
{
    public int Id { get; set; }

    public int CartItemId { get; set; }
    public CartItem CartItem { get; set; } = null!;

    public string AddonId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string OptionCode { get; set; } = string.Empty;
    public string OptionName { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string AmountDisplay { get; set; } = string.Empty;
    public string BillingType { get; set; } = string.Empty;
    public bool MultiplyByQuantity { get; set; }
    public bool IsAdded { get; set; }
}
