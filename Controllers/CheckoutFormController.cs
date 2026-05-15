using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/checkoutForm")]
public class CheckoutFormController : ControllerBase
{
  [HttpGet]
  public IActionResult Get()
  {
    return Ok(new
    {
      steps = new[]
      {
        new { code = "shipping", title = "Shipping" },
        new { code = "payment", title = "Payment" },
        new { code = "review", title = "Review" }
      }
    });
  }
}