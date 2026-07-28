# Project Orange Server

Project Orange Server is an ASP.NET Core backend for a multi-site ecommerce checkout experience. It serves site-aware catalog, cart, wishlist, checkout, shipping, order, authentication, voucher, trade-in, and analytics workflows for frontend clients.

For architecture details, endpoint references, business rules, and extension guides, see the [documentation index](docs/README.md).

## Tech Stack

- ASP.NET Core Web API
- .NET 10
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- Secure cookie-backed JWT sessions
- Swagger/OpenAPI via Swashbuckle

## Features

- Multi-site storefront support for the Philippines, France, China, and Japan
- Site resolution by `/api/{siteCode}/...` route prefix, `X-Site-Code` header, `siteCode` query parameter, or default site fallback
- Site-scoped product catalog, categories, carts, orders, auth sessions, and checkout forms
- Localized seeded product data with site currencies
- Product catalog with category, price filtering, sorting, and product specs
- Category management
- Cart creation and cart lookup by cart code
- Authenticated user cart lookup
- Cart item quantity updates and removal
- Authenticated user wishlist management
- Product add-ons, insurance plans, mobile plans, and trade-in selections with site feature flags
- Voucher application and voucher removal with site feature flags
- Site-specific shipping-price lookup by postal code
- Country detection from edge provider headers or client IP lookup
- Checkout form configuration loaded from site-specific JSON files
- Site-specific postal-code serviceability validation
- Basic site-scoped order creation with stock validation
- Trade-in configuration and in-memory site-scoped trade-in session flow
- User registration and login with secure cookie-backed, site-scoped sessions

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
+-- ProjectOrange.sln          # Solution file
+-- docs/                         # Setup and technical documentation
```

## Local Development

See [docs/local-setup.md](docs/local-setup.md) for prerequisites, local setup, site selection, and useful development commands.
