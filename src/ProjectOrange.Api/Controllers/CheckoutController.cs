using Microsoft.AspNetCore.Mvc;
using ProjectOrange.DTOs;
using ProjectOrange.Services;

namespace ProjectOrange.Controllers;

[ApiController]
[Route("api/checkout")]
[Route("api/{siteCode:alpha:length(2)}/checkout")]
public class CheckoutController : ControllerBase
{
    private readonly CheckoutFormService _checkoutFormService;

    public CheckoutController(
        CheckoutFormService checkoutFormService
    )
    {
        _checkoutFormService = checkoutFormService;
    }

    [HttpGet("form")]
    public async Task<ActionResult<CheckoutFormDto>> GetForm()
    {
        var form = await _checkoutFormService.GetFormAsync();

        if (form is null)
        {
            return NotFound();
        }

        return Ok(form);
    }
}
