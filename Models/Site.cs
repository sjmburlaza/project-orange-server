namespace ProjectOrangeApi.Models;

public class Site
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string CountryName { get; set; } = string.Empty;
    public string Locale { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public string DefaultLanguage { get; set; } = string.Empty;
    public string SupportedLanguages { get; set; } = string.Empty;
    public bool InsuranceEnabled { get; set; }
    public bool TradeInEnabled { get; set; }
    public bool VouchersEnabled { get; set; }
    public bool IsActive { get; set; } = true;

    public List<Category> Categories { get; set; } = [];
    public List<Product> Products { get; set; } = [];
    public List<Cart> Carts { get; set; } = [];
    public List<Order> Orders { get; set; } = [];
    public List<AuthSession> AuthSessions { get; set; } = [];
    public List<AnalyticsEvent> AnalyticsEvents { get; set; } = [];
}
