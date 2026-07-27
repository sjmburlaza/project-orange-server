# 16. Operational Notes

## Migrations

Create a migration:

```bash
dotnet ef migrations add <MigrationName> --project src/ProjectOrange.Api/ProjectOrange.Api.csproj --output-dir Infrastructure/Persistence/Migrations
```

Apply migrations:

```bash
dotnet ef database update --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
```

The design-time factory reads:

1. `appsettings.json`
2. `appsettings.{ASPNETCORE_ENVIRONMENT}.json`
3. Environment variables

If `ConnectionStrings:DefaultConnection` is missing or blank, design-time EF operations fail with:

```text
Connection string 'DefaultConnection' is not configured.
```

## Currency Conversion

`SiteCurrency` converts PHP seed amounts to the active site's currency for insurance, mobile plans, trade-in credits, and voucher minimum subtotals. Treat PHP as the canonical seed amount unless the currency conversion helper is redesigned.

## CORS

Current CORS policy allows:

```text
http://localhost:4200
```

It allows any header, any method, and credentials. Production deployments should replace or externalize this origin list.

## External Network Dependency

`GeoCountryService` may call:

```text
https://ipapi.co/{ip}/country/
```

The HTTP client timeout is two seconds. Lookup errors are swallowed and return `null`.

## In-Memory State

`TradeInSessionService` stores sessions in memory. This state is:

- Not persisted to SQL Server.
- Not shared across instances.
- Lost on application restart.

Use a persistent table or distributed cache if trade-in sessions must survive deployment, restart, or horizontal scaling.
