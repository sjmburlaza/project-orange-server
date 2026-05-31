using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/postal-codes")]
public class PostalCodesController : ControllerBase
{
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

        var normalizedPostalCode = postalCode.Trim();

        if (normalizedPostalCode.Length != 4)
        {
            return Ok(new PostalCodeValidationDto
            {
                IsValid = false,
                Message = "Postal code must be 4 digits."
            });
        }

        var isValid = PostalCodeSeed.IsServiceable(normalizedPostalCode);

        return Ok(new PostalCodeValidationDto
        {
            IsValid = isValid,
            Message = isValid
                ? null
                : "This postal code is not serviceable."
        });
    }
}