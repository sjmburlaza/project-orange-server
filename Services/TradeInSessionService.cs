using ProjectOrangeApi.Data.Seeds;
using ProjectOrangeApi.DTOs;

namespace ProjectOrangeApi.Services;

public class TradeInSessionService
{
    private readonly Lock _lock = new();
    private readonly Dictionary<string, TradeInSessionDto> _sessions = new(StringComparer.OrdinalIgnoreCase);

    public TradeInSessionDto CreateSession(CreateTradeInSessionRequest request)
    {
        var now = DateTimeOffset.UtcNow;
        var defaultSteps = TradeInSeed.CreateDefaultSteps();

        var session = new TradeInSessionDto
        {
            SessionId = Guid.NewGuid().ToString("N"),
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

    public TradeInSessionDto? GetSession(string sessionId)
    {
        lock (_lock)
        {
            return _sessions.GetValueOrDefault(sessionId);
        }
    }

    public TradeInSessionDto? UpdateStepOne(string sessionId, UpdateTradeInStepOneRequest request)
    {
        lock (_lock)
        {
            if (!_sessions.TryGetValue(sessionId, out var session))
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

    public TradeInSessionDto? UpdateStepTwo(string sessionId, UpdateTradeInStepTwoRequest request)
    {
        lock (_lock)
        {
            if (!_sessions.TryGetValue(sessionId, out var session))
            {
                return null;
            }

            session.CurrentStep = 2;
            session.StepTwo = request.StepTwo ?? session.StepTwo;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    public TradeInSessionDto? UpdateStepThree(string sessionId, UpdateTradeInStepThreeRequest request)
    {
        lock (_lock)
        {
            if (!_sessions.TryGetValue(sessionId, out var session))
            {
                return null;
            }

            session.CurrentStep = 3;
            session.StepThree = request.StepThree ?? session.StepThree;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }

    public TradeInSessionDto? Confirm(string sessionId)
    {
        lock (_lock)
        {
            if (!_sessions.TryGetValue(sessionId, out var session))
            {
                return null;
            }

            session.CurrentStep = 4;
            session.IsConfirmed = true;
            session.UpdatedAtUtc = DateTimeOffset.UtcNow;

            return session;
        }
    }
}
