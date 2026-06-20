namespace ProjectOrangeApi.DTOs;

public class AddonSelectionRequest
{
    public string? InsurancePlanCode { get; set; }
    public string? MobilePlanCode { get; set; }
    public string? TradeInSessionId { get; set; }
}

public class AddToCartRequest : AddonSelectionRequest
{
    public int VariantId { get; set; }
    public int Quantity { get; set; }
    public List<AddonDto> Addons { get; set; } = [];
}

public class UpdateCartItemAddonRequest : AddonSelectionRequest;
