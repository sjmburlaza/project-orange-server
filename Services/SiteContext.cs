using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Services;

public class SiteContext : ISiteContextAccessor
{
    private Site? _current;

    public Site Current => _current
        ?? throw new InvalidOperationException("The current site has not been resolved for this request.");

    public int SiteId => Current.Id;
    public string SiteCode => Current.Code;
    public string Currency => Current.Currency;
    public bool InsuranceEnabled => Current.InsuranceEnabled;
    public bool TradeInEnabled => Current.TradeInEnabled;
    public bool VouchersEnabled => Current.VouchersEnabled;

    public void SetSite(Site site)
    {
        _current = site;
    }
}
