using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/shipping")]
[Route("api/{siteCode:alpha:length(2)}/shipping")]
public class ShippingController : ControllerBase
{
	private readonly ShippingPricingService _shippingPricingService;

	public ShippingController(ShippingPricingService shippingPricingService)
	{
		_shippingPricingService = shippingPricingService;
	}

	[HttpGet("options")]
	public ActionResult<List<ShippingOptionDto>> GetOptions(
		[FromQuery] string postalCode)
	{
		var options = _shippingPricingService.GetRatesByPostalCode(postalCode);

		return Ok(options);
	}
}
