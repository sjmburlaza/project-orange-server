# Local Development

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

- [Documentation index](README.md) - deep technical documentation, route reference, business rules, and maintainer guidance.
- [ProjectOrange.Api.http](../src/ProjectOrange.Api/ProjectOrange.Api.http) - sample HTTP requests for local development.
