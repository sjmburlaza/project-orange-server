using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/checkout")]
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