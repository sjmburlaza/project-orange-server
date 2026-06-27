namespace ProjectOrangeApi.DTOs;

public class InsurancePlanDto
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string BillingFrequency { get; set; } = string.Empty;
}
