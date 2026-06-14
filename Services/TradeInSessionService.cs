using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class TradeInSessionService
{
    private readonly Lock _lock = new();
    private readonly Dictionary<string, TradeInSessionDto> _sessions = new(StringComparer.OrdinalIgnoreCase);

    public TradeInSessionDto CreateSession(CreateTradeInSessionRequest request, string siteCode)
    {
        var now = DateTimeOffset.UtcNow;
        var defaultSteps = TradeInSeed.CreateDefaultSteps();

        var session = new TradeInSessionDto
        {
            SessionId = Guid.NewGuid().ToString("N"),
            SiteCode = NormalizeSiteCode(siteCode),
            CurrentStep = 1,
            StepOne = defaultSteps.StepOne,
            FormData = defaultSteps.FormData,
            Summary = defaultSteps.Summary,
            StepTwo = defaultSteps.StepTwo,
            StepThree = defaultSteps.StepThree,
            StepFour = defaultSteps.StepFour,
            CreatedAtUtc = now,
            UpdatedAtUtc = now
        };

        lock (_lock)
        {
            _sessions[session.SessionId] = session;
        }

        return session;
    }

    public TradeInSessionDto? GetSession(string sessionId, string siteCode)
    {
        lock (_lock)
        {
            return GetSessionForSite(sessionId, siteCode);
        }
    }

    public TradeInSessionDto? UpdateStepOne(string sessionId, string siteCode, UpdateTradeInStepOneRequest request)
    {
        lock (_lock)
        {
            var session = GetSessionForSite(sessionId, siteCode);

            if (session is null)
            {
                return null;
            }

            session.CurrentStep = 1;
            session.StepOne = request.StepOne ?? session.StepOne;
            session.FormData = request.FormData ?? session.FormData;
            session.Summary = request.Summary ?? session.Summary;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    public TradeInSessionDto? UpdateStepTwo(string sessionId, string siteCode, UpdateTradeInStepTwoRequest request)
    {
        lock (_lock)
        {
            var session = GetSessionForSite(sessionId, siteCode);

            if (session is null)
            {
                return null;
            }

            session.CurrentStep = 2;
            session.StepTwo = request.StepTwo ?? session.StepTwo;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    public TradeInSessionDto? UpdateStepThree(string sessionId, string siteCode, UpdateTradeInStepThreeRequest request)
    {
        lock (_lock)
        {
            var session = GetSessionForSite(sessionId, siteCode);

            if (session is null)
            {
                return null;
            }

            session.CurrentStep = 3;
            session.StepThree = request.StepThree ?? session.StepThree;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    public TradeInSessionDto? Confirm(string sessionId, string siteCode)
    {
        lock (_lock)
        {
            var session = GetSessionForSite(sessionId, siteCode);

            if (session is null)
            {
                return null;
            }

            session.CurrentStep = 4;
            session.IsConfirmed = true;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    private TradeInSessionDto? GetSessionForSite(string sessionId, string siteCode)
    {
        if (!_sessions.TryGetValue(sessionId, out var session))
        {
            return null;
        }

        return string.Equals(session.SiteCode, NormalizeSiteCode(siteCode), StringComparison.OrdinalIgnoreCase)
            ? session
            : null;
    }

    private static string NormalizeSiteCode(string siteCode)
    {
        return siteCode.Trim().ToLowerInvariant();
    }
}
