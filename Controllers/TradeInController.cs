using Microsoft.AspNetCore.Mvc;
using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/trade-ins")]
[Route("api/{siteCode:alpha:length(2)}/trade-ins")]
public class TradeInsController : ControllerBase
{
    private readonly ISiteContext _siteContext;

    public TradeInsController(ISiteContext siteContext)
    {
        _siteContext = siteContext;
    }

    [HttpGet("config")]
    public ActionResult<TradeInDto> GetTradeIn()
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        return Ok(TradeInSeed.TradeIn);
    }

    [HttpGet("categories")]
    public ActionResult<List<CategoryTIDto>> GetCategories()
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        return Ok(TradeInSeed.Categories);
    }

    [HttpGet("brands")]
    public ActionResult<List<BrandTIDto>> GetBrands([FromQuery] string? categoryCode)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        return Ok(TradeInSeed.GetBrands(categoryCode));
    }

    [HttpGet("devices")]
    public ActionResult<List<DeviceTIDto>> GetDevices(
        [FromQuery] string? categoryCode,
        [FromQuery] string? brandCode)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        return Ok(TradeInSeed.GetDevices(categoryCode, brandCode));
    }

    [HttpGet("storages")]
    public ActionResult<List<StorageTIDto>> GetStorages([FromQuery] string? deviceCode)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        return Ok(TradeInSeed.GetStorages(deviceCode));
    }
}

[ApiController]
[Route("api/trade-in-sessions")]
[Route("api/{siteCode:alpha:length(2)}/trade-in-sessions")]
public class TradeInSessionsController : ControllerBase
{
    private readonly TradeInSessionService _tradeInSessionService;
    private readonly ISiteContext _siteContext;

    public TradeInSessionsController(
        TradeInSessionService tradeInSessionService,
        ISiteContext siteContext)
    {
        _tradeInSessionService = tradeInSessionService;
        _siteContext = siteContext;
    }

    [HttpPost]
    public ActionResult<TradeInSessionDto> CreateSession(
        [FromBody] CreateTradeInSessionRequest? request)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.CreateSession(request ?? new(), _siteContext.SiteCode);

        return CreatedAtAction(
            nameof(GetSession),
            new { siteCode = _siteContext.SiteCode, sessionId = session.SessionId },
            session);
    }

    [HttpGet("{sessionId}")]
    public ActionResult<TradeInSessionDto> GetSession(string sessionId)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.GetSession(sessionId, _siteContext.SiteCode);

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
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.UpdateStepOne(sessionId, _siteContext.SiteCode, request);

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
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.UpdateStepTwo(sessionId, _siteContext.SiteCode, request);

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
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.UpdateStepThree(sessionId, _siteContext.SiteCode, request);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }

    [HttpPatch("{sessionId}/confirm")]
    public ActionResult<TradeInSessionDto> Confirm(string sessionId)
    {
        if (!_siteContext.TradeInEnabled)
        {
            return NotFound();
        }

        var session = _tradeInSessionService.Confirm(sessionId, _siteContext.SiteCode);

        if (session is null)
        {
            return NotFound();
        }

        return Ok(session);
    }
}
