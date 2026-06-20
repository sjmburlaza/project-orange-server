using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/fulfillment")]
[Route("api/{siteCode:alpha:length(2)}/fulfillment")]
[Route("api/shipping")]
[Route("api/{siteCode:alpha:length(2)}/shipping")]
public class FulfillmentController : ControllerBase
{
    private readonly ShippingPricingService _shippingPricingService;

    public FulfillmentController(ShippingPricingService shippingPricingService)
    {
        _shippingPricingService = shippingPricingService;
    }

    [HttpGet("options")]
    public ActionResult<List<FulfillmentOptionDto>> GetOptions(
        [FromQuery] string? postalCode = null)
    {
        var options = _shippingPricingService.GetFulfillmentOptions(postalCode);

        return Ok(options);
    }
}
