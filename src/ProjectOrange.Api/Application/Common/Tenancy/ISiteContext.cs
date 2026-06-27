using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public interface ISiteContext
{
    Site Current { get; }
    int SiteId { get; }
    string SiteCode { get; }
    string Currency { get; }
    bool InsuranceEnabled { get; }
    bool TradeInEnabled { get; }
    bool VouchersEnabled { get; }
}

public interface ISiteContextAccessor : ISiteContext
{
    void SetSite(Site site);
}
