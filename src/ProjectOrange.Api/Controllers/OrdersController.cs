using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Route("api/{siteCode:alpha:length(2)}/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrdersController(OrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrderConfirmationDto>>> GetOrders()
    {
        return Ok(await _orderService.GetOrdersAsync());
    }

    [HttpGet("lookup")]
    public async Task<ActionResult<OrderConfirmationDto>> LookupOrder(
        [FromQuery] string? orderNumber,
        [FromQuery] string? email)
    {
        if (string.IsNullOrWhiteSpace(orderNumber) || string.IsNullOrWhiteSpace(email))
        {
            return CreateErrorResponse(OrderValidationException.InvalidRequest(
                "Order number and email are required to look up an order."));
        }

        var order = await _orderService.LookupOrderAsync(orderNumber, email);

        return order is null ? NotFound() : Ok(order);
    }

    [HttpGet("{orderNumber}")]
    public async Task<ActionResult<OrderConfirmationDto>> GetOrder(string orderNumber)
    {
        var order = await _orderService.GetOrderAsync(orderNumber);

        return order is null ? NotFound() : Ok(order);
    }

    [HttpPost]
    public async Task<ActionResult<OrderConfirmationDto>> CreateOrder(PlaceOrderRequestDto request)
    {
        try
        {
            var order = await _orderService.PlaceOrderAsync(request);

            return Ok(order);
        }
        catch (ApiErrorException ex)
        {
            return CreateErrorResponse(ex);
        }
    }

    private ObjectResult CreateErrorResponse(ApiErrorException exception)
    {
        var problem = new ProblemDetails
        {
            Status = exception.StatusCode,
            Title = exception.Title,
            Detail = exception.Message,
            Type = $"https://project-orange-api/errors/{exception.Code.ToLowerInvariant()}"
        };

        problem.Extensions["code"] = exception.Code;

        foreach (var detail in exception.ErrorDetails)
        {
            problem.Extensions[detail.Key] = detail.Value;
        }

        return StatusCode(exception.StatusCode, problem);
    }
}
