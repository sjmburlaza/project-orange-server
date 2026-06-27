namespace ProjectOrangeApi.DTOs;

public class AddonDto
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal? Amount { get; set; }
    public string BillingFrequency { get; set; } = string.Empty;
    public string SelectedOptionCode { get; set; } = string.Empty;
    public string SelectedOptionName { get; set; } = string.Empty;
    public bool IsAdded { get; set; }
}
