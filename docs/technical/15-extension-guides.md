# 15. Extension Guides

## Add a New Site

1. Add a new `Site` entry in `SiteSeed`.
2. Add localized categories/products/specs in `CategorySeed`, `ProductSeed`, and `ProductSpecSeed`.
3. Add `Config/sites/{siteCode}/checkout-form.json`.
4. Add shipping validation/rates in `ShippingPricingService` or seed-backed rules.
5. Confirm feature flags for insurance, trade-ins, and vouchers.
6. Add migration if seeded EF data changed.
7. Verify:
   - `GET /api/sites`
   - `GET /api/{siteCode}/products`
   - `GET /api/{siteCode}/checkout/form`
   - cart, voucher, shipping, auth session, and order flows.

## Add a Product

1. Add product row to `ProductSeed`.
2. Add any specs to `ProductSpecSeed`.
3. Ensure category ID is correct for each site.
4. Add or verify image URL.
5. Add migration for EF seed data changes.
6. Verify product list, product detail, cart add, and order placement.

## Add an Add-on Type

1. Add definition to `AddonSeed`.
2. Decide eligible categories.
3. Add response mapping if the product add-on list needs extra fields.
4. Extend `CartService.CreateCartItemAddonSnapshot` if the add-on has special pricing or selection requirements.
5. Update `CartService.GetAddonSummary` behavior if it affects totals.
6. Add tests for cart add, replace, remove, and summary behavior.

## Add a Voucher

1. Add voucher rule to `VoucherSeed`.
2. Set status, discount percent, optional time window, and minimum subtotal.
3. Remember minimum subtotal is treated as a PHP amount and converted for other currencies.
4. Verify apply/remove on each enabled site.

## Add an Auth-Protected Endpoint

1. Add `[Authorize]` or a role/policy-specific authorize attribute.
2. If permission-based, use an existing permission constant or add a new one to `AppPermissions`.
3. Add the permission to `AppPermissions.All`.
4. Update `RolePermissionMap`.
5. Ensure JWTs include the claim by logging in after the change.
6. Add integration coverage for anonymous, wrong-role, and allowed-role requests.

## Add an Analytics Event Type

1. Add constant to `AnalyticsEventTypes`.
2. Add it to `AnalyticsEventTypes.All`.
3. Update normalization and dashboard aggregation if the event contributes to metrics.
4. Add database indexes if query patterns change.
5. Update frontend tracking and this documentation.
