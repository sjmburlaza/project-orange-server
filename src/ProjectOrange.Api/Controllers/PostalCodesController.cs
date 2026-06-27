using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/postal-codes")]
[Route("api/{siteCode:alpha:length(2)}/postal-codes")]
public class PostalCodesController : ControllerBase
{
    private readonly ShippingPricingService _shippingPricingService;

    public PostalCodesController(ShippingPricingService shippingPricingService)
    {
        _shippingPricingService = shippingPricingService;
    }

    [HttpGet("validate")]
    public ActionResult<PostalCodeValidationDto> ValidatePostalCode(
        [FromQuery] string postalCode
    )
    {
        if (string.IsNullOrWhiteSpace(postalCode))
        {
            return BadRequest(new PostalCodeValidationDto
            {
                IsValid = false,
                Message = "Postal code is required."
            });
        }

        var isValid = _shippingPricingService.IsPostalCodeServiceable(postalCode);

        return Ok(new PostalCodeValidationDto
        {
            IsValid = isValid,
            Message = isValid
                ? null
                : "This postal code is not serviceable."
        });
    }
}
