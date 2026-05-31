namespace ProjectOrangeApi.DTOs;

public class CartSummaryAttributeDto
{
    public string Name { get; set; } = string.Empty;
    public decimal? Amount { get; set; }
    public string? DisplayValue { get; set; }
}
