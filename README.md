# Project Orange API

Project Orange API is an ASP.NET Core backend for a multi-site ecommerce checkout experience. It serves site-aware catalog, cart, wishlist, checkout, shipping, order, authentication, voucher, trade-in, and analytics workflows for frontend clients.

For architecture details, endpoint references, business rules, and extension guides, see [TECHNICAL_README.md](TECHNICAL_README.md).

## At a Glance

- ASP.NET Core Web API targeting .NET 10
- Entity Framework Core with SQL Server
- ASP.NET Core Identity with secure cookie-backed JWT sessions
- Swagger/OpenAPI enabled in development
- Multi-site support for `ph`, `fr`, `cn`, and `jp`

## Core Capabilities

- Resolves site context from route prefix, `X-Site-Code` header, `siteCode` query parameter, or the default `ph` site.
- Serves site-scoped products, categories, prices, currencies, feature flags, checkout forms, carts, wishlists, orders, and auth sessions.
- Supports customer registration, login, logout, password reset, and authenticated user flows.
- Provides checkout support for vouchers, shipping prices, postal-code validation, trade-ins, add-ons, insurance, and mobile plans.
- Includes development seed data and Swagger UI for local exploration.

## Repository Layout

```text
.
+-- src/ProjectOrange.Api/        # ASP.NET Core API project
|   +-- Controllers/              # HTTP endpoints
|   +-- Application/              # Feature logic, DTOs, tenancy, shared contracts
|   +-- Domain/Entities/          # EF Core entities
|   +-- Infrastructure/           # Persistence, seed data, middleware
|   +-- Config/                   # Default and site-specific checkout forms
+-- tests/                        # Test projects, when present
+-- ProjectOrangeApi.sln          # Solution file
+-- TECHNICAL_README.md           # Detailed technical reference
```

## Local Setup

Prerequisites:

- .NET 10 SDK
- SQL Server
- EF Core CLI tools, if applying migrations manually

Configure the required connection string and JWT settings through user secrets, environment variables, or local appsettings:

```text
ConnectionStrings__DefaultConnection
Jwt__Issuer
Jwt__Audience
Jwt__Key
```

Run locally:

```bash
dotnet restore ProjectOrangeApi.sln
dotnet ef database update --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
dotnet run --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
```

Development URLs:

- API: `http://localhost:5175`
- Swagger: `http://localhost:5175/swagger`
- HTTPS profile: `https://localhost:7196`

## Site Selection

Most ecommerce state is scoped to a site. Requests can select a site with a prefixed route, header, query parameter, or the default `ph` fallback:

```http
GET /api/jp/products
```

```http
GET /api/products?siteCode=fr
```

```http
GET /api/products
X-Site-Code: cn
```

Use `GET /api/sites` to discover configured sites.

## Useful Commands

```bash
dotnet build ProjectOrangeApi.sln
dotnet test ProjectOrangeApi.sln
dotnet ef migrations add <MigrationName> --project src/ProjectOrange.Api/ProjectOrange.Api.csproj --output-dir Infrastructure/Persistence/Migrations
```

## More Documentation

- [TECHNICAL_README.md](TECHNICAL_README.md) - deep technical documentation, route reference, business rules, and maintainer guidance.
- [src/ProjectOrange.Api/ProjectOrange.Api.http](src/ProjectOrange.Api/ProjectOrange.Api.http) - sample HTTP requests for local development.
