# 18. Maintainer Checklist

Before merging backend changes, check:

- Does the change preserve site scoping?
- Does auth/session behavior still bind to the current site?
- Are new persisted fields included in migrations?
- Are seed changes reflected in migrations if EF-seeded?
- Are public write endpoints intentionally public?
- Are cart/order snapshots still backward compatible?
- Are error codes stable for frontend handling?
- Does Swagger still start in development?
- Does `dotnet build ProjectOrangeApi.sln --configuration Release` pass?
- Does the frontend need documentation updates for new request/response shapes?
