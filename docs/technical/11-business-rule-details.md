# 11. Business Rule Details

## Catalog and Add-ons

Products are site-scoped and returned with category and item specs. Add-ons are not stored on products in the database; instead, `AddonSeed` defines add-on definitions and eligible categories.

Feature-flagged add-ons:

- `insurance` is hidden when `InsuranceEnabled` is false.
- `trade-in` is hidden when `TradeInEnabled` is false.
- Other add-ons are available if eligible for the category.

Insurance and mobile plan prices are defined in PHP in seed data and converted to the active site's currency through `SiteCurrency`.

## Cart Ownership

Cart lookup is site-scoped and user-aware:

- Anonymous carts have `UserId = null`.
- Authenticated users get or create a user-owned cart.
- If an authenticated user adds to an existing anonymous cart, the cart is claimed by that user.
- A user cannot access another user's cart through `cartCode`.

Cart code format:

```text
CART-XXXXXXXX
```

The code is generated from an uppercase GUID string and truncated to 13 characters.

## Cart Item Merging

When adding a product already in the cart:

- If selected add-ons match the existing add-on snapshots, quantity is incremented.
- If selected add-ons differ, the service rejects the operation with `ADDON_LIMIT_REACHED`.

This avoids ambiguous line items where the same product ID would represent multiple different add-on bundles.

## Add-on Snapshot Rules

The service snapshots add-on choices into `CartItemAddon`.

Add-on types:

| Add-on | Required selection | Amount behavior |
| --- | --- | --- |
| `insurance` | `insurancePlanCode` | Positive one-time amount, multiplied by quantity. |
| `mobile-plan` | `mobilePlanCode` | Monthly amount, not included in one-time subtotal. |
| `trade-in` | confirmed `tradeInSessionId` | Negative credit, not multiplied by quantity. |
| Display-only add-on | none | No amount unless populated by the mapped type. |

`CartSummary` includes:

- Subtotal
- Site tax
- One-time add-on amounts
- Shipping
- Discount if present
- Total

Monthly add-ons are represented with a billing frequency and are not added to the one-time total.

Tax is calculated from the subtotal and rounded away from zero to the currency's
display precision:

| Site | Summary line | Calculation | Total behavior |
| --- | --- | --- | --- |
| Philippines (`ph`) | `Included VAT 12%` | `subtotal * 12% / 112%` | Already included |
| France (`fr`) | `Included VAT 20%` | `subtotal * 20% / 120%` | Already included |
| Japan (`jp`) | `Included Consumption Tax 10%` | `subtotal * 10% / 110%` | Already included |
| China (`cn`) | `VAT 13%` | `subtotal * 13%` | Added to total |

## Vouchers

Voucher rules come from `VoucherSeed`.

Validation rules:

- Site must have vouchers enabled.
- Voucher code is normalized to uppercase.
- Code must be between 3 and 32 characters.
- Code may contain letters, numbers, hyphens, and underscores.
- Cart must contain at least one item.
- Voucher must exist.
- Voucher must be active.
- Current time must be within optional start and expiration bounds.
- Subtotal must satisfy the converted site-currency minimum subtotal.
- The same voucher cannot be applied twice.
- Only one voucher can be applied to a cart at a time.

Discount calculation:

```text
discount = subtotal * (discountPercent / 100)
discount = min(discount, subtotal)
```

## Shipping

Postal-code validation is site-specific:

| Site | Validation rule |
| --- | --- |
| `ph` | Postal code must be in `PostalCodeSeed`. |
| `fr` | Exactly five digits. |
| `cn` | Exactly six digits. |
| `jp` | Exactly seven digits after removing hyphens. |

Fulfillment options:

- delivery prices and availability estimates are selected by site/country postal-code area rules.
- pickup options include local pickup location metadata and are filtered to nearby stores.
- postal code is optional for the options endpoint; omitting it returns the current site's default country-local options.
- unsupported or unserviceable postal codes return an empty list when supplied.

## Checkout Form Configuration

Checkout form DTO supports:

- Version
- Steps
- Fields
- Nested fields
- Validators
- Async validators
- Grid layout hints
- Options API paths
- Dependency fields
- Visibility rules
- Inline field options

Site-specific form JSON allows the frontend to render different address, payment, shipping, or localization experiences without changing C# code.

## Orders

Order placement creates durable snapshots from either:

- `CartResponseDto.Entries`, or
- legacy `Items` with product ID and quantity.

When cart entries are used, the service trusts cart item display data where available but validates product existence and stock against the database. Product stock is decremented before save.

Order totals:

- If cart summary contains a `Total` row, that value is used.
- Otherwise, total falls back to sum of `price * quantity`.

Customer and shipping fields are resolved from:

1. Explicit `customerName` and `customerEmail` request fields.
2. `checkoutData` customer, delivery, payment, and shipping groups.
3. Defaults used as compatibility fallbacks.

## Trade-In Sessions

Trade-in sessions are currently process-local. This is suitable for demos and short local flows, but production deployments with multiple instances or restarts should move this state into a durable store.

Concurrency is handled by a lock around the in-memory dictionary. The dictionary key is `sessionId`; site validation is performed on every lookup/update.

## Analytics

Analytics event storage is durable and site-scoped. The service computes dashboard metrics in memory after loading relevant events from the database.

Deduplication rules:

- Duplicate event IDs are ignored.
- Duplicate purchase events for the same `{ SiteId, OrderNumber }` are ignored.
- Duplicates within the same incoming batch are also ignored.

Indexes support common dashboard queries:

- `{ SiteId, Type, OccurredAt }`
- filtered `{ SiteId, OrderNumber }` for purchase events with non-null order numbers
