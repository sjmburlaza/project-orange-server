using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.DTOs;
using ProjectOrangeApi.Models;

namespace ProjectOrangeApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private static readonly TimeSpan SessionLifetime = TimeSpan.FromHours(2);

    private readonly UserManager<AppUser> _userManager;
    private readonly AppDbContext _db;
    private readonly IConfiguration _config;

    public AuthController(
        UserManager<AppUser> userManager,
        AppDbContext db,
        IConfiguration config)
    {
        _userManager = userManager;
        _db = db;
        _config = config;
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
                .FirstOrDefaultAsync(authSession => authSession.Id == sessionId);

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
            new Claim(ClaimTypes.Sid, session.Id)
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
            UserId = user.Id,
            CreatedAtUtc = now,
            ExpiresAtUtc = now.Add(SessionLifetime),
            CreatedByIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString()
        };
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
