# 2. Repository Layout

```text
.
+-- src/
|   +-- ProjectOrange.Api/
|       +-- Controllers/
|       +-- Application/
|       |   +-- Common/
|       |   |   +-- Authorization/
|       |   |   +-- Exceptions/
|       |   |   +-- Interfaces/
|       |   |   +-- Tenancy/
|       |   +-- Features/
|       |       +-- Analytics/
|       |       +-- Authentication/
|       |       +-- Cart/
|       |       +-- Checkout/
|       |       +-- Fulfillment/
|       |       +-- Geo/
|       |       +-- Options/
|       |       +-- Orders/
|       |       +-- Products/
|       |       +-- Sites/
|       |       +-- TradeIns/
|       +-- Config/
|       +-- Domain/Entities/
|       +-- Infrastructure/
|       |   +-- Middleware/
|       |   +-- Persistence/
|       |   |   +-- Migrations/
|       |   +-- SeedData/
|       +-- Program.cs
|       +-- ProjectOrange.Api.csproj
|       +-- ProjectOrange.Api.http
|       +-- appsettings.json
|       +-- appsettings.Development.json
+-- ProjectOrange.sln
+-- README.md
```

## Important Directory Responsibilities

| Directory | Responsibility |
| --- | --- |
| `src/ProjectOrange.Api/Controllers/` | HTTP route definitions, model binding, auth attributes, response status selection, and feature orchestration. |
| `src/ProjectOrange.Api/Application/Common/` | Shared authorization constants, service interfaces, tenancy context, and structured API errors. |
| `src/ProjectOrange.Api/Application/Features/` | Feature-owned DTOs and use-case logic for products, cart, checkout, orders, fulfillment, analytics, auth, trade-ins, sites, geo, and options. |
| `src/ProjectOrange.Api/Domain/Entities/` | EF Core entity types persisted in SQL Server. |
| `src/ProjectOrange.Api/Infrastructure/Persistence/` | EF Core `AppDbContext`, design-time context factory, and migration history. |
| `src/ProjectOrange.Api/Infrastructure/SeedData/` | Static seed sources for product catalog, sites, options, shipping rules, roles, and test/dev data. |
| `src/ProjectOrange.Api/Infrastructure/Middleware/` | Request pipeline middleware such as site resolution. |
| `src/ProjectOrange.Api/Config/` | Default and site-specific checkout form definitions loaded at runtime by `CheckoutFormService`. |
