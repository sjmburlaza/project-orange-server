public class ShippingOptionDto
{
    public string Code { get; set; } = "";
    public string Label { get; set; } = "";
    public decimal Price { get; set; }
    public string EstimatedDelivery { get; set; } = "";
}