namespace ProjectOrangeApi.Models;

public class AnalyticsEventItem
{
    public int Id { get; set; }
    public string AnalyticsEventId { get; set; } = string.Empty;
    public AnalyticsEvent AnalyticsEvent { get; set; } = null!;
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
