using ProjectOrange.Data.Seeds;
using ProjectOrange.Models;

namespace ProjectOrange.Tests.Support;

internal static class TestSites
{
    public static Site Get(string code)
    {
        return SiteSeed.Sites.First(site =>
            string.Equals(site.Code, code, StringComparison.OrdinalIgnoreCase));
    }
}
