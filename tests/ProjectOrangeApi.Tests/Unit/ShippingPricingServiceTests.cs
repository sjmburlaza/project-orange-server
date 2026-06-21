using ProjectOrangeApi.Services;
using ProjectOrangeApi.Tests.Support;
using Xunit;

namespace ProjectOrangeApi.Tests.Unit;

public class ShippingPricingServiceTests
{
    [Fact]
    public void GetFulfillmentOptions_WhenPhilippinesPostalCodeMatchesCoreRule_ReturnsSameDayDeliveryAndPickup()
    {
        var service = CreateService("ph");

        var options = service.GetFulfillmentOptions("1000");

        var sameDay = Assert.Single(options, option => option.Code == "grab-same-day");
        Assert.Equal("delivery", sameDay.Type);
        Assert.Equal(240m, sameDay.Price);

        Assert.Contains(options, option =>
            option.Code == "pickup-sm-megamall" &&
            option.Type == "pickup" &&
            option.Price == 0m);
    }

    [Fact]
    public void GetFulfillmentOptions_WhenPhilippinesPostalCodeIsNotServiceable_ReturnsNoOptions()
    {
        var service = CreateService("ph");

        var options = service.GetFulfillmentOptions("9999");

        Assert.Empty(options);
    }

    [Theory]
    [InlineData("ph", "1000", true)]
    [InlineData("ph", "9999", false)]
    [InlineData("fr", "75001", true)]
    [InlineData("fr", "7501", false)]
    [InlineData("cn", "200000", true)]
    [InlineData("cn", "20000A", false)]
    [InlineData("jp", "100-0001", true)]
    [InlineData("jp", "100000", false)]
    public void IsPostalCodeServiceable_UsesCurrentSiteRules(
        string siteCode,
        string postalCode,
        bool expected)
    {
        var service = CreateService(siteCode);

        var isServiceable = service.IsPostalCodeServiceable(postalCode);

        Assert.Equal(expected, isServiceable);
    }

    private static ShippingPricingService CreateService(string siteCode)
    {
        var siteContext = new TestSiteContext();
        siteContext.SetSite(TestSites.Get(siteCode));

        return new ShippingPricingService(siteContext);
    }
}
