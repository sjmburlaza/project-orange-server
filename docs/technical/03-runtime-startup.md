# 3. Runtime Startup

Application startup is defined in `Program.cs`.

## Service Registration

The API registers:

- MVC controllers with JSON cycle ignoring via `ReferenceHandler.IgnoreCycles`.
- Custom invalid model-state responses through `ApiBehaviorOptions.InvalidModelStateResponseFactory`.
- Swagger/OpenAPI services.
- EF Core SQL Server context using `ConnectionStrings:DefaultConnection`.
- CORS policy named `AllowAngularApp`.
- ASP.NET Core Identity using `AppUser` and `IdentityRole`.
- JWT bearer authentication.
- Authorization policies for every permission in `AppPermissions.All`.
- Application services:
  - `ICartService` -> `CartService`
  - `OrderService`
  - `CheckoutFormService`
  - `ShippingPricingService`
  - `AnalyticsService`
  - `SiteContext`
  - `ISiteContext`
  - `ISiteContextAccessor`
  - `TradeInSessionService` as singleton
  - `GeoCountryService` through `HttpClient`

## Middleware Order

The configured request pipeline is:

```text
UseHttpsRedirection
UseRouting
UseCors("AllowAngularApp")
UseMiddleware<SiteResolutionMiddleware>
UseAuthentication
UseAuthorization
MapControllers
```

This order is important:

1. Routing must run before `SiteResolutionMiddleware` so route values like `{siteCode}` are available.
2. Site resolution must run before authentication because JWT validation verifies that the session site matches the current request site.
3. Authentication must run before authorization.

## Development Behavior

When `ASPNETCORE_ENVIRONMENT=Development`, startup:

- Seeds a development user through `DevelopmentUserSeed.SeedAsync`.
- Enables Swagger and Swagger UI.

Development launch profiles:

| Profile | URL |
| --- | --- |
| `http` | `http://localhost:5175` |
| `https` | `https://localhost:7196;http://localhost:5175` |

Swagger UI is available in development at:

- `http://localhost:5175/swagger`
- `https://localhost:7196/swagger`
