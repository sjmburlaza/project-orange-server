using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Contracts;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Authorize]
[Route("api/wishlist")]
[Route("api/{siteCode:alpha:length(2)}/wishlist")]
public class WishlistController : ControllerBase
{
    private readonly IWishlistService _wishlistService;

    public WishlistController(IWishlistService wishlistService)
    {
        _wishlistService = wishlistService;
    }

    private string UserId =>
        User.FindFirstValue(ClaimTypes.NameIdentifier)
        ?? throw new InvalidOperationException("Authenticated user ID is missing.");

    [HttpGet]
    public async Task<ActionResult<WishlistResponseDto>> GetWishlist()
    {
        return await ExecuteWishlistAction(() =>
            _wishlistService.GetWishlistAsync(UserId));
    }

    [HttpPost("items")]
    public async Task<ActionResult<WishlistResponseDto>> AddItem(AddWishlistItemRequest request)
    {
        return await ExecuteWishlistAction(() =>
            _wishlistService.AddItemAsync(request, UserId));
    }

    [HttpDelete("items/{productId:int}")]
    public async Task<ActionResult<WishlistResponseDto>> RemoveItem(int productId)
    {
        return await ExecuteWishlistAction(() =>
            _wishlistService.RemoveItemAsync(productId, UserId));
    }

    [HttpGet("items/{productId:int}")]
    public async Task<ActionResult<WishlistStatusDto>> GetItemStatus(int productId)
    {
        return await ExecuteWishlistAction(() =>
            _wishlistService.GetItemStatusAsync(productId, UserId));
    }

    private async Task<ActionResult<T>> ExecuteWishlistAction<T>(
        Func<Task<T>> action)
    {
        try
        {
            var result = await action();

            return Ok(result);
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
