using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Tests.Support;

internal sealed class TestSiteContext : ISiteContextAccessor
{
    private Site? _current;

    public Site Current => _current
        ?? throw new InvalidOperationException("The current site has not been set.");

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
