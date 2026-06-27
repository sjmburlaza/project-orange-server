using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Services;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[Route("api/{siteCode:alpha:length(2)}/[controller]")]
public class AuthController : ControllerBase
{
    private static readonly TimeSpan SessionLifetime = TimeSpan.FromHours(2);
    private const string ForgotPasswordMessage =
        "If an account matches that email, password reset instructions will be sent.";

    private readonly UserManager<AppUser> _userManager;
    private readonly AppDbContext _db;
    private readonly IConfiguration _config;
    private readonly ISiteContext _siteContext;
    private readonly IWebHostEnvironment _environment;

    public AuthController(
        UserManager<AppUser> userManager,
        AppDbContext db,
        IConfiguration config,
        ISiteContext siteContext,
        IWebHostEnvironment environment)
    {
        _userManager = userManager;
        _db = db;
        _config = config;
        _siteContext = siteContext;
        _environment = environment;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var user = new AppUser
        {
            UserName = request.Email,
            Email = request.Email,
            FullName = request.FullName
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        var roleResult = await _userManager.AddToRoleAsync(user, AppRoles.Customer);

        if (!roleResult.Succeeded)
        {
            await _userManager.DeleteAsync(user);
            return BadRequest(roleResult.Errors);
        }

        var accessProfile = await GetAccessProfileAsync(user);

        return Ok(new
        {
            message = "Registration successful",
            user = ToUserDto(user, accessProfile.Roles, accessProfile.Permissions)
        });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            return Unauthorized();
        }

        var validPassword = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!validPassword)
        {
            return Unauthorized();
        }

        var accessProfile = await GetAccessProfileAsync(user);
        var authSession = CreateAuthSession(user);
        var token = GenerateJwtToken(user, accessProfile.Roles, accessProfile.Permissions, authSession);

        _db.AuthSessions.Add(authSession);
        await _db.SaveChangesAsync();

        WriteSessionCookie(token, authSession.ExpiresAtUtc);

        return Ok(ToAuthResponse(user, accessProfile.Roles, accessProfile.Permissions, authSession));
    }

    [HttpPost("forgot-password")]
    public async Task<ActionResult<ForgotPasswordResponse>> ForgotPassword(ForgotPasswordRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user is null || string.IsNullOrWhiteSpace(user.Email))
        {
            return Ok(new ForgotPasswordResponse(ForgotPasswordMessage));
        }

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var encodedToken = EncodePasswordResetToken(token);

        if (_environment.IsDevelopment())
        {
            return Ok(new ForgotPasswordResponse(
                ForgotPasswordMessage,
                encodedToken,
                BuildPasswordResetUrl(user.Email, encodedToken)));
        }

        return Ok(new ForgotPasswordResponse(ForgotPasswordMessage));
    }

    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user is null)
        {
            return BadRequest(CreateInvalidPasswordResetError());
        }

        if (!TryDecodePasswordResetToken(request.Token, out var token))
        {
            return BadRequest(CreateInvalidPasswordResetError());
        }

        var result = await _userManager.ResetPasswordAsync(user, token, request.NewPassword);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        await RevokeUserSessionsAsync(user.Id);

        return Ok(new AuthMessageResponse("Password reset successful"));
    }

    [Authorize]
    [HttpGet("session")]
    public async Task<ActionResult<AuthResponse>> GetSession()
    {
        var session = await GetActiveSessionAsync();

        if (session is null)
        {
            ClearSessionCookie();
            return Unauthorized();
        }

        var user = await _userManager.FindByIdAsync(session.UserId);

        if (user is null)
        {
            ClearSessionCookie();
            return Unauthorized();
        }

        var accessProfile = await GetAccessProfileAsync(user);

        return Ok(ToAuthResponse(user, accessProfile.Roles, accessProfile.Permissions, session));
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        var sessionId = User.FindFirstValue(ClaimTypes.Sid);

        if (!string.IsNullOrWhiteSpace(sessionId))
        {
            var session = await _db.AuthSessions
                .FirstOrDefaultAsync(authSession =>
                    authSession.Id == sessionId &&
                    authSession.SiteId == _siteContext.SiteId);

            if (session is not null && session.RevokedAtUtc is null)
            {
                session.RevokedAtUtc = DateTimeOffset.UtcNow;
                session.RevokedByIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
                await _db.SaveChangesAsync();
            }
        }

        ClearSessionCookie();

        return Ok(new { message = "Logout successful" });
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<ActionResult<AuthUserDto>> GetMe()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrWhiteSpace(userId))
        {
            return Unauthorized();
        }

        var user = await _userManager.FindByIdAsync(userId);

        if (user is null)
        {
            return Unauthorized();
        }

        var accessProfile = await GetAccessProfileAsync(user);

        return Ok(ToUserDto(user, accessProfile.Roles, accessProfile.Permissions));
    }

    private string GenerateJwtToken(
        AppUser user,
        IReadOnlyCollection<string> roles,
        IReadOnlyCollection<string> permissions,
        AuthSession session)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.Id),
            new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
            new Claim(ClaimTypes.Sid, session.Id),
            new Claim(AppClaimTypes.SiteCode, _siteContext.SiteCode)
        };

        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));
        claims.AddRange(permissions.Select(permission => new Claim(AppClaimTypes.Permission, permission)));

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_config["Jwt:Key"]!)
        );

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: session.ExpiresAtUtc.UtcDateTime,
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private AuthSession CreateAuthSession(AppUser user)
    {
        var now = DateTimeOffset.UtcNow;

        return new AuthSession
            {
                SiteId = _siteContext.SiteId,
                UserId = user.Id,
                CreatedAtUtc = now,
            ExpiresAtUtc = now.Add(SessionLifetime),
            CreatedByIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString()
        };
    }

    private async Task RevokeUserSessionsAsync(string userId)
    {
        var now = DateTimeOffset.UtcNow;
        var sessions = await _db.AuthSessions
            .Where(session =>
                session.UserId == userId &&
                session.RevokedAtUtc == null &&
                session.ExpiresAtUtc > now)
            .ToListAsync();

        foreach (var session in sessions)
        {
            session.RevokedAtUtc = now;
            session.RevokedByIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
        }

        if (sessions.Count > 0)
        {
            await _db.SaveChangesAsync();
        }
    }

    private string BuildPasswordResetUrl(string email, string token)
    {
        var resetUrl = _config["PasswordReset:ClientResetUrl"];

        if (string.IsNullOrWhiteSpace(resetUrl))
        {
            resetUrl = "http://localhost:4200/reset-password";
        }

        resetUrl = resetUrl.Trim();

        var separator = resetUrl.Contains('?') ? '&' : '?';

        return string.Concat(
            resetUrl,
            separator,
            "email=",
            Uri.EscapeDataString(email),
            "&token=",
            Uri.EscapeDataString(token));
    }

    private static string EncodePasswordResetToken(string token)
    {
        return WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
    }

    private static bool TryDecodePasswordResetToken(string encodedToken, out string token)
    {
        token = string.Empty;

        if (string.IsNullOrWhiteSpace(encodedToken))
        {
            return false;
        }

        try
        {
            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(encodedToken));
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }
    }

    private static IEnumerable<IdentityError> CreateInvalidPasswordResetError()
    {
        return
        [
            new IdentityError
            {
                Code = "InvalidPasswordResetToken",
                Description = "The password reset token is invalid or has expired."
            }
        ];
    }

    private async Task<AuthSession?> GetActiveSessionAsync()
    {
        var sessionId = User.FindFirstValue(ClaimTypes.Sid);
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrWhiteSpace(sessionId) || string.IsNullOrWhiteSpace(userId))
        {
            return null;
        }

        var now = DateTimeOffset.UtcNow;

        return await _db.AuthSessions
            .AsNoTracking()
            .FirstOrDefaultAsync(session =>
                session.Id == sessionId &&
                session.SiteId == _siteContext.SiteId &&
                session.UserId == userId &&
                session.RevokedAtUtc == null &&
                session.ExpiresAtUtc > now);
    }

    private void WriteSessionCookie(string token, DateTimeOffset expiresAtUtc)
    {
        Response.Cookies.Append(
            AuthCookies.Session,
            token,
            new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Path = "/",
                Expires = expiresAtUtc,
                IsEssential = true
            });
    }

    private void ClearSessionCookie()
    {
        Response.Cookies.Delete(
            AuthCookies.Session,
            new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Path = "/",
                IsEssential = true
            });
    }

    private async Task<(string[] Roles, string[] Permissions)> GetAccessProfileAsync(AppUser user)
    {
        var currentRoles = await _userManager.GetRolesAsync(user);
        var roles = RolePermissionMap.NormalizeRoles(currentRoles);

        foreach (var role in roles.Except(currentRoles, StringComparer.Ordinal))
        {
            await _userManager.AddToRoleAsync(user, role);
        }

        var permissions = RolePermissionMap.GetPermissionsForRoles(roles);

        return (roles, permissions);
    }

    private static AuthUserDto ToUserDto(
        AppUser user,
        IReadOnlyCollection<string> roles,
        IReadOnlyCollection<string> permissions) =>
        new(
            user.Id,
            user.Email ?? string.Empty,
            user.FullName,
            roles,
            permissions);

    private static AuthResponse ToAuthResponse(
        AppUser user,
        IReadOnlyCollection<string> roles,
        IReadOnlyCollection<string> permissions,
        AuthSession session) =>
        new(
            ToUserDto(user, roles, permissions),
            new AuthSessionSummaryDto(
                session.Id,
                session.CreatedAtUtc,
                session.ExpiresAtUtc));
}
