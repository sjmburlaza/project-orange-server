# 8. Seed Data

Seed sources live in `src/ProjectOrange.Api/Infrastructure/SeedData`.

## EF-Seeded Data

The following are seeded through `AppDbContext.OnModelCreating`:

- Identity roles from `RoleSeed`
- Sites from `SiteSeed`
- Categories from `CategorySeed`
- Products from `ProductSeed`
- Product specs from `ProductSpecSeed`

## Runtime Rule Seeds

Some domain rules are static in-memory seed tables rather than database tables:

| Seed | Used by | Purpose |
| --- | --- | --- |
| `AddonSeed` | `ProductsController`, `CartService` | Eligible add-ons by product category. |
| `InsurancePlanSeed` | `ProductsController`, `CartService` | Insurance plan options and amounts. |
| `MobilePlanSeed` | `ProductsController`, `CartService` | Mobile plan options and amounts. |
| `VoucherSeed` | `CartService` | Voucher availability, status, discount percent, and minimum subtotal. |
| `FulfillmentOptionSeed` | `ShippingPricingService` | Area-based delivery prices and nearby pickup fulfillment options. |
| `PostalCodeSeed` | `ShippingPricingService` | PH serviceable postal codes. |
| `RegionSeed` | `OptionsController` | PH region options. |
| `CitySeed` | `OptionsController` | PH cities by region. |
| `BarangaySeed` | `OptionsController` | PH barangays by city. |
| `TradeInSeed` | `TradeInsController`, `TradeInSessionService` | Trade-in wizard configuration and option values. |

When changing static runtime seeds, remember that no database migration is needed unless the change also affects EF-seeded data or persisted schema.
