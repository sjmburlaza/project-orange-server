# 14. CI and Quality Gates

GitHub Actions workflow: `.github/workflows/ci.yml`

Triggers:

- Push to `develop`
- Push to `main`
- Pull request targeting `develop`
- Pull request targeting `main`

Build job:

```text
checkout
setup-dotnet 10.0.x
dotnet restore ProjectOrangeApi.sln
dotnet build ProjectOrangeApi.sln --configuration Release --no-restore
```

The repository includes `tests/ProjectOrangeApi.Tests` for unit and endpoint-level coverage. Recommended next coverage areas are:

- Unit tests for `CartService` voucher/add-on/shipping summary rules.
- Unit tests for `OrderService` stock validation and total calculation.
- Unit tests for `SiteResolutionMiddleware` resolution precedence.
- Unit tests for `ShippingPricingService` site-specific postal validation.
- Integration tests for auth session site binding.
- Integration tests for site-scoped catalog/cart/order isolation.
