# 1. System Overview

Project Orange API is an ASP.NET Core Web API that powers a multi-site ecommerce checkout experience. The backend exposes site-aware product catalog, category, cart, add-on, voucher, shipping, checkout-form, order, authentication, trade-in, geolocation, and analytics endpoints.

The current application is a single ASP.NET Core project:

- Application framework: ASP.NET Core Web API
- Target framework: `.NET 10`
- Persistence: Entity Framework Core with SQL Server
- Identity: ASP.NET Core Identity
- Authentication: JWT bearer validation with the JWT stored in a secure HttpOnly cookie
- Documentation/runtime inspection: Swagger/OpenAPI in development
- CI: GitHub Actions restore and release build

The API is organized as a single ASP.NET Core project with feature-sliced application folders:

```text
HTTP request
  -> ASP.NET Core routing
  -> SiteResolutionMiddleware
  -> Authentication
  -> Authorization
  -> Controller
  -> Feature-owned use-case logic
  -> EF Core DbContext / seed-backed rule tables
  -> SQL Server or in-memory process state
```

Most user-facing ecommerce state is scoped to a resolved site. A request for `ph`, `fr`, `cn`, or `jp` can see different products, categories, feature flags, currencies, checkout forms, shipping rules, orders, carts, auth sessions, and analytics records.
