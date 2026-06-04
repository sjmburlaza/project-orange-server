using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/trade-ins")]
public class TradeInsController : ControllerBase
{
    [HttpGet("config")]
    public ActionResult<TradeInDto> GetTradeIn()
    {
        return Ok(TradeInSeed.TradeIn);
    }

    [HttpGet("categories")]
    public ActionResult<List<CategoryTIDto>> GetCategories()
    {
        return Ok(TradeInSeed.Categories);
    }

    [HttpGet("brands")]
    public ActionResult<List<BrandTIDto>> GetBrands([FromQuery] string? categoryCode)
    {
        return Ok(TradeInSeed.GetBrands(categoryCode));
    }

    [HttpGet("devices")]
    public ActionResult<List<DeviceTIDto>> GetDevices(
        [FromQuery] string? categoryCode,
        [FromQuery] string? brandCode)
    {
        return Ok(TradeInSeed.GetDevices(categoryCode, brandCode));
    }

    [HttpGet("storages")]
    public ActionResult<List<StorageTIDto>> GetStorages([FromQuery] string? deviceCode)
    {
        return Ok(TradeInSeed.GetStorages(deviceCode));
    }
}

[ApiController]
[Route("api/trade-in-sessions")]
public class TradeInSessionsController : ControllerBase
{
    private readonly TradeInSessionService _tradeInSessionService;

    public TradeInSessionsController(TradeInSessionService tradeInSessionService)
    {
        _tradeInSessionService = tradeInSessionService;
    }

    [HttpPost]
    public ActionResult<TradeInSessionDto> CreateSession(
        [FromBody] CreateTradeInSessionRequest? request)
    {
        var session = _tradeInSessionService.CreateSession(request ?? new());

        return CreatedAtAction(
            nameof(GetSession),
            new { sessionId = session.SessionId },
            session);
    }

    [HttpGet("{sessionId}")]
    public ActionResult<TradeInSessionDto> GetSession(string sessionId)
    {
        var session = _tradeInSessionService.GetSession(sessionId);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }

    [HttpPatch("{sessionId}/step-one")]
    public ActionResult<TradeInSessionDto> UpdateStepOne(
        string sessionId,
        UpdateTradeInStepOneRequest request)
    {
        var session = _tradeInSessionService.UpdateStepOne(sessionId, request);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }

    [HttpPatch("{sessionId}/step-two")]
    public ActionResult<TradeInSessionDto> UpdateStepTwo(
        string sessionId,
        UpdateTradeInStepTwoRequest request)
    {
        var session = _tradeInSessionService.UpdateStepTwo(sessionId, request);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }

    [HttpPatch("{sessionId}/step-three")]
    public ActionResult<TradeInSessionDto> UpdateStepThree(
        string sessionId,
        UpdateTradeInStepThreeRequest request)
    {
        var session = _tradeInSessionService.UpdateStepThree(sessionId, request);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }

    [HttpPatch("{sessionId}/confirm")]
    public ActionResult<TradeInSessionDto> Confirm(string sessionId)
    {
        var session = _tradeInSessionService.Confirm(sessionId);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }
}
