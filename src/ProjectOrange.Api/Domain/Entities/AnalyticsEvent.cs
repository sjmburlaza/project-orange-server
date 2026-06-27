namespace ProjectOrangeApi.Models;

public class AnalyticsEvent
{
    public string Id { get; set; } = string.Empty;
    public int SiteId { get; set; }
    public Site Site { get; set; } = null!;
    public string Type { get; set; } = string.Empty;
    public DateTimeOffset OccurredAt { get; set; } = DateTimeOffset.UtcNow;
    public string VisitorId { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;
    public int? ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? CategoryName { get; set; }
    public int? Quantity { get; set; }
    public decimal? Value { get; set; }
    public string? OrderNumber { get; set; }
    public string? FailureReason { get; set; }
    public ICollection<AnalyticsEventItem> Items { get; set; } = new List<AnalyticsEventItem>();
}
