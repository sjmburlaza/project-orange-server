namespace ProjectOrangeApi.DTOs;

public record RegisterRequest(string FullName, string Email, string Password);
public record LoginRequest(string Email, string Password);
public record AuthUserDto(
    string Id,
    string Email,
    string? FullName,
    IReadOnlyCollection<string> Roles,
    IReadOnlyCollection<string> Permissions);
public record AuthSessionSummaryDto(
    string Id,
    DateTimeOffset CreatedAtUtc,
    DateTimeOffset ExpiresAtUtc);
public record AuthResponse(AuthUserDto User, AuthSessionSummaryDto Session);
