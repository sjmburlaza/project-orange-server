using System.Text.Json.Serialization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ProjectOrangeApi.Data;
using ProjectOrangeApi.Services;
using ProjectOrangeApi.Models;
using ProjectOrangeApi.Contracts;
using ProjectOrangeApi.Authorization;
using ProjectOrangeApi.Data.Seeds;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
  .AddJsonOptions(options =>
  {
      options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
  });

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var isVoucherEndpoint =
            context.ActionDescriptor.RouteValues.TryGetValue("controller", out var controller) &&
            controller == "Carts" &&
            context.HttpContext.Request.Path.Value?.Contains("/vouchers", StringComparison.OrdinalIgnoreCase) == true;

        var problem = new ProblemDetails
        {
            Status = StatusCodes.Status400BadRequest,
            Title = "Invalid request.",
            Detail = "Request validation failed."
        };

        problem.Extensions["code"] = isVoucherEndpoint
            ? ApiErrorCodes.VoucherCodeInvalidFormat
            : "REQUEST_VALIDATION_FAILED";

        return new BadRequestObjectResult(problem);
    };
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<CheckoutFormService>();
builder.Services.AddScoped<ShippingPricingService>();
builder.Services.AddScoped<SiteContext>();
builder.Services.AddScoped<ISiteContext>(provider => provider.GetRequiredService<SiteContext>());
builder.Services.AddScoped<ISiteContextAccessor>(provider => provider.GetRequiredService<SiteContext>());
builder.Services.AddSingleton<TradeInSessionService>();
builder.Services.AddHttpClient<GeoCountryService>(client =>
{
    client.Timeout = TimeSpan.FromSeconds(2);
    client.DefaultRequestHeaders.UserAgent.ParseAdd("ProjectOrangeApi/1.0");
});

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));
}
else
{
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));
}



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy
            .WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Events.OnRedirectToLogin = context =>
    {
        if (context.Request.Path.StartsWithSegments("/api"))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        }

        context.Response.Redirect(context.RedirectUri);
        return Task.CompletedTask;
    };

    options.Events.OnRedirectToAccessDenied = context =>
    {
        if (context.Request.Path.StartsWithSegments("/api"))
        {
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            return Task.CompletedTask;
        }

        context.Response.Redirect(context.RedirectUri);
        return Task.CompletedTask;
    };
});

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],

            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)
            ),

            NameClaimType = ClaimTypes.NameIdentifier,
            RoleClaimType = ClaimTypes.Role
        };

        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                if (string.IsNullOrWhiteSpace(context.Token) &&
                    context.Request.Cookies.TryGetValue(AuthCookies.Session, out var token))
                {
                    context.Token = token;
                }

                return Task.CompletedTask;
            },
            OnTokenValidated = async context =>
            {
                var sessionId = context.Principal?.FindFirstValue(ClaimTypes.Sid);
                var userId = context.Principal?.FindFirstValue(ClaimTypes.NameIdentifier);
                var siteCode = context.Principal?.FindFirstValue(AppClaimTypes.SiteCode);

                if (string.IsNullOrWhiteSpace(sessionId) ||
                    string.IsNullOrWhiteSpace(userId) ||
                    string.IsNullOrWhiteSpace(siteCode))
                {
                    context.Fail("The authentication session is missing.");
                    return;
                }

                var db = context.HttpContext.RequestServices.GetRequiredService<AppDbContext>();
                var siteContext = context.HttpContext.RequestServices.GetRequiredService<ISiteContext>();
                var now = DateTimeOffset.UtcNow;

                if (!string.Equals(siteContext.SiteCode, siteCode, StringComparison.OrdinalIgnoreCase))
                {
                    context.Fail("The authentication session belongs to a different site.");
                    return;
                }

                var isActiveSession = await db.AuthSessions
                    .AsNoTracking()
                    .AnyAsync(session =>
                        session.Id == sessionId &&
                        session.SiteId == siteContext.SiteId &&
                        session.UserId == userId &&
                        session.RevokedAtUtc == null &&
                        session.ExpiresAtUtc > now);

                if (!isActiveSession)
                {
                    context.Fail("The authentication session is no longer active.");
                }
            }
        };
    });

builder.Services.AddAuthorization(options =>
{
    foreach (var permission in AppPermissions.All)
    {
        options.AddPolicy(permission, policy =>
            policy.RequireClaim(AppClaimTypes.Permission, permission));
    }
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await DevelopmentUserSeed.SeedAsync(app.Services);

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("AllowAngularApp");

app.UseMiddleware<SiteResolutionMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
