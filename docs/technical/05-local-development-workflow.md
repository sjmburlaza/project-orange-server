# 5. Local Development Workflow

## Prerequisites

- .NET 10 SDK
- SQL Server
- EF Core CLI tools if applying migrations manually

Install EF Core CLI tools if needed:

```bash
dotnet tool install --global dotnet-ef
```

## Restore, Build, Migrate, Run

```bash
dotnet restore ProjectOrangeApi.sln
dotnet build ProjectOrangeApi.sln
dotnet ef database update --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
dotnet run --project src/ProjectOrange.Api/ProjectOrange.Api.csproj
```

## HTTP Scratch File

`src/ProjectOrange.Api/ProjectOrange.Api.http` contains sample requests for:

- Geo country lookup
- Admin analytics dashboard
- Analytics event ingestion
- Order lookup
- Password reset request
- Password reset completion

The file defaults to:

```http
@ProjectOrangeApi_HostAddress = http://localhost:5175
```
