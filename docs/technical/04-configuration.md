# 4. Configuration

The committed `appsettings.json` intentionally keeps the default SQL Server connection string empty:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": ""
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

Runtime configuration is expected from `appsettings.Development.json`, user secrets, environment variables, or deployment configuration.

## Required Configuration Keys

| Key | Purpose |
| --- | --- |
| `ConnectionStrings:DefaultConnection` | SQL Server connection string used by EF Core. |
| `Jwt:Issuer` | Expected JWT issuer. |
| `Jwt:Audience` | Expected JWT audience. |
| `Jwt:Key` | Symmetric signing key used for HMAC SHA-256 tokens. Use a long secret. |

## Optional Configuration Keys

| Key | Purpose |
| --- | --- |
| `PasswordReset:ClientResetUrl` | Frontend reset-password URL. Defaults to `http://localhost:4200/reset-password` in development flows if omitted. |

## Environment Variable Names

ASP.NET Core converts double underscores into configuration nesting:

```bash
ConnectionStrings__DefaultConnection="Server=localhost,1433;Database=ProjectOrangeDb;User Id=sa;Password=<password>;TrustServerCertificate=True"
Jwt__Issuer="ProjectOrange"
Jwt__Audience="ProjectOrangeClient"
Jwt__Key="<long-secret>"
PasswordReset__ClientResetUrl="http://localhost:4200/reset-password"
```

## Local Secrets

Prefer .NET user secrets or environment variables for local credentials:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=ProjectOrangeDb;User Id=sa;Password=<password>;TrustServerCertificate=True" --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
dotnet user-secrets set "Jwt:Issuer" "ProjectOrange" --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
dotnet user-secrets set "Jwt:Audience" "ProjectOrangeClient" --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
dotnet user-secrets set "Jwt:Key" "<long-secret>" --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
```

`appsettings.Development.json`, local `.env` variants, and local database files should stay out of source control.
