# 10. API Route Reference

Unless otherwise noted, endpoints support both:

```text
/api/<resource>
/api/{siteCode}/<resource>
```

## Site Discovery

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/sites` | Public | Lists active sites. |
| `GET` | `/api/sites/{code}` | Public | Gets one active site by code. |

## Catalog

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/products` | Public | Lists products for the resolved site. Supports search, filters, and sorting. |
| `GET` | `/api/products/search/suggestions?query=` | Public | Returns up to five relevance-ranked catalog search terms for autocomplete. |
| `GET` | `/api/products/{id}` | Public | Gets one product by ID for the resolved site. |
| `GET` | `/api/products/{id}/addons` | Public | Lists eligible add-ons for a product category and current site feature flags. |
| `GET` | `/api/products/{id}/insurance-plans` | Public | Lists insurance plans if insurance is enabled for the site. |
| `GET` | `/api/products/{id}/mobile-plans` | Public | Lists mobile plans eligible for the product category. |
| `GET` | `/api/admin/products` | `products.read` | Lists products for admin management. Supports filters and sorting. |
| `GET` | `/api/admin/products/{id}` | `products.read` | Gets one product with specs, options, and variants. |
| `POST` | `/api/admin/products` | `products.create` | Creates a site-scoped product. |
| `PUT` | `/api/admin/products/{id}` | `products.update` | Updates a product and replaces specs, options, and variants. |
| `DELETE` | `/api/admin/products/{id}` | `products.delete` | Deletes a product if it is not referenced by carts or orders. |
| `GET` | `/api/categories` | Public | Lists categories for the resolved site. |
| `POST` | `/api/categories` | Public | Creates a category scoped to the resolved site. |

Product query parameters:

| Parameter | Type | Description |
| --- | --- | --- |
| `categoryId` | integer | Filters products by category ID. |
| `sortBy` | string | Supports `price-asc`, `price-desc`, `name-asc`, `name-desc`; defaults to ID ordering. |
| `minPrice` | decimal | Minimum product price. |
| `maxPrice` | decimal | Maximum product price. |
| `search` | string | Matches product names, descriptions, categories, and subcategories. Results default to relevance ordering unless `sortBy` is supplied. |

Product responses include:

- `id`
- `name`
- `description`
- `price`
- `reviewRating`
- `reviewCount`
- `stockQuantity`
- `imageUrl`
- `categoryId`
- `categoryName`
- `itemSpecs`
- `availableColors`

## Cart

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/carts/{cartCode}` | Public or cookie-aware | Gets a cart if it is anonymous or belongs to the current user. |
| `GET` | `/api/carts/{cartCode}/recommended-products` | Public or cookie-aware | Gets relevant in-stock accessory recommendations for the cart. |
| `GET` | `/api/carts/me` | Required | Gets the current user's cart. |
| `POST` | `/api/carts/items` | Public or cookie-aware | Creates or reuses a cart and adds an item. |
| `POST` | `/api/carts/{cartCode}/items` | Public or cookie-aware | Adds an item to an existing cart. |
| `PUT` | `/api/carts/{cartCode}/items/{productId}` | Public or cookie-aware | Updates quantity; quantity `<= 0` removes the item. |
| `DELETE` | `/api/carts/{cartCode}/items/{productId}` | Public or cookie-aware | Removes an item. |
| `PUT` | `/api/carts/{cartCode}/items/{productId}/addons/{addonId}` | Public or cookie-aware | Adds or replaces one add-on snapshot for an item. |
| `DELETE` | `/api/carts/{cartCode}/items/{productId}/addons/{addonId}` | Public or cookie-aware | Removes one add-on from an item. |
| `POST` | `/api/carts/{cartCode}/vouchers` | Public or cookie-aware | Applies a voucher to a cart. |
| `DELETE` | `/api/carts/{cartCode}/vouchers/{voucherCode}` | Public or cookie-aware | Removes an applied voucher. |
| `PUT` | `/api/carts/{cartCode}/shipping` | Public or cookie-aware | Stores selected shipping method and price on the cart. |

Add to cart request:

```json
{
  "productId": 1,
  "quantity": 1,
  "addons": [
    {
      "id": "insurance",
      "isAdded": true
    }
  ],
  "insurancePlanCode": "screen-protection",
  "mobilePlanCode": null,
  "tradeInSessionId": null
}
```

Update quantity request:

```json
{
  "quantity": 2
}
```

Apply voucher request:

```json
{
  "code": "ORANGE10"
}
```

Update shipping request:

```json
{
  "postalCode": "1000",
  "shippingMethodCode": "standard"
}
```

Cart response shape:

```json
{
  "code": "CART-XXXXXXXX",
  "entries": [
    {
      "productId": 1,
      "productName": "iPhone 15",
      "price": 59999,
      "quantity": 1,
      "totalPrice": 59999,
      "categoryName": "Phones",
      "subcategoryName": "Flagship"
    }
  ],
  "appliedVouchers": [],
  "cartSummary": [
    {
      "name": "Subtotal",
      "amount": 59999,
      "billingFrequency": "",
      "displayValue": null
    },
    {
      "name": "Included VAT 12%",
      "amount": 6428.46,
      "billingFrequency": "",
      "displayValue": null
    },
    {
      "name": "Shipping",
      "amount": null,
      "billingFrequency": "",
      "displayValue": "To be calculated"
    },
    {
      "name": "Total",
      "amount": 59999,
      "billingFrequency": "",
      "displayValue": null
    }
  ]
}
```

## Checkout and Address Options

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/checkout/form` | Public | Returns site-specific checkout form JSON with fallback to default config. |
| `GET` | `/api/options/regions?search=` | Public | Returns PH regions for `ph`; empty list for non-PH sites. |
| `GET` | `/api/options/cities?parent=&search=` | Public | Returns PH cities for a region; empty list for non-PH sites or missing parent. |
| `GET` | `/api/options/barangays?parent=&search=` | Public | Returns PH barangays for a city; empty list for non-PH sites or missing parent. |
| `GET` | `/api/postal-codes/validate?postalCode=` | Public | Validates serviceability for the current site. |
| `GET` | `/api/fulfillment/options?postalCode=` | Public | Returns postal-code-priced delivery and nearby pickup fulfillment options; `/api/shipping/options` remains an alias. |

Checkout form resolution:

1. `Config/sites/{siteCode}/checkout-form.json`
2. `Config/checkout-form.json`
3. `404` if neither file exists

## Orders

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/orders` | Public | Lists all orders for the current site. |
| `GET` | `/api/orders/lookup?orderNumber=&email=` | Public | Looks up an order by number and matching customer email. |
| `GET` | `/api/orders/{orderNumber}` | Public | Gets one order by order number, or numeric legacy ID if parseable. |
| `POST` | `/api/orders` | Public | Places an order from a cart snapshot or legacy item list. |

Order creation supports two input styles:

1. Preferred cart snapshot:

```json
{
  "cart": {
    "code": "CART-XXXXXXXX",
    "entries": [],
    "appliedVouchers": [],
    "cartSummary": []
  },
  "checkoutData": {
    "customer": {
      "firstName": "Juan",
      "lastName": "Dela Cruz",
      "email": "juan@example.com"
    },
    "delivery": {
      "addressLine1": "123 Orange Avenue",
      "city": "Manila",
      "postalCode": "1000",
      "country": "Philippines"
    },
    "payment": {
      "paymentMethod": "card"
    },
    "shipping": {
      "shippingMethod": "standard"
    }
  }
}
```

2. Legacy item list:

```json
{
  "customerName": "Juan Dela Cruz",
  "customerEmail": "juan@example.com",
  "items": [
    {
      "productId": 1,
      "quantity": 1
    }
  ]
}
```

Order rules:

- At least one item is required.
- Quantity must be greater than zero.
- Product IDs must exist in the current site.
- Stock is validated and decremented during order placement.
- Order creation runs in a database transaction.
- Order numbers are generated as `OR-yyyyMMdd-random4`, with a GUID fallback after repeated collisions.
- `cod` payment method yields `paymentStatus = pending` and `orderStatus = pending_payment`.
- Other payment methods yield `paymentStatus = paid` and `orderStatus = confirmed`.
- Delivery estimates are derived from the shipping method:
  - `express`: `1-2 business days`
  - `free`: `5-7 business days`
  - default: `3-5 business days`

## Authentication

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `POST` | `/api/auth/register` | Public | Creates a user and assigns the `customer` role. |
| `POST` | `/api/auth/login` | Public | Validates credentials, creates site-scoped auth session, writes session cookie. |
| `POST` | `/api/auth/forgot-password` | Public | Creates a password reset token if user exists, but always returns a generic message. |
| `POST` | `/api/auth/reset-password` | Public | Resets password and revokes active sessions. |
| `GET` | `/api/auth/session` | Required | Returns the active session profile. |
| `POST` | `/api/auth/logout` | Cookie-aware | Revokes the current session if present and clears cookie. |
| `GET` | `/api/auth/me` | Required | Returns the current user profile. |

Register request:

```json
{
  "fullName": "Juan Dela Cruz",
  "email": "juan@example.com",
  "password": "Passw0rd!"
}
```

Login request:

```json
{
  "email": "juan@example.com",
  "password": "Passw0rd!"
}
```

Auth response:

```json
{
  "user": {
    "id": "<identity-user-id>",
    "email": "juan@example.com",
    "fullName": "Juan Dela Cruz",
    "roles": ["customer"],
    "permissions": ["orders.cancel", "orders.read", "products.read"]
  },
  "session": {
    "id": "<session-id>",
    "createdAtUtc": "2026-06-20T00:00:00+00:00",
    "expiresAtUtc": "2026-06-20T02:00:00+00:00"
  }
}
```

## Trade-Ins

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/trade-ins/config` | Public | Returns trade-in config if enabled for the site. |
| `GET` | `/api/trade-ins/categories` | Public | Returns trade-in categories if enabled. |
| `GET` | `/api/trade-ins/brands?categoryCode=` | Public | Returns trade-in brands. |
| `GET` | `/api/trade-ins/devices?categoryCode=&brandCode=` | Public | Returns trade-in devices. |
| `GET` | `/api/trade-ins/storages?deviceCode=` | Public | Returns storage options. |
| `POST` | `/api/trade-in-sessions` | Public | Creates an in-memory trade-in session. |
| `GET` | `/api/trade-in-sessions/{sessionId}` | Public | Gets a site-matching session. |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-one` | Public | Updates step one data and summary. |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-two` | Public | Updates step two data. |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-three` | Public | Updates step three answers. |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/confirm` | Public | Marks the session confirmed. |

Trade-in behavior:

- Disabled sites return `404` for all trade-in endpoints.
- `fr` has trade-ins disabled in seed data.
- Sessions are stored in memory by the singleton `TradeInSessionService`.
- Sessions are lost when the process restarts.
- Sessions are site-scoped. A session created for `ph` cannot be read or attached from `jp`.
- A trade-in add-on can only be added to cart after the session is confirmed and has a positive final amount.

## Analytics

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `POST` | `/api/analytics/events` | Public | Accepts analytics event payloads and returns the dashboard snapshot. |
| `GET` | `/api/admin/analytics/dashboard?site=&period=` | Admin role | Returns analytics dashboard for the selected site and period. |

Supported event types:

```text
visitor
product_view
add_to_cart
checkout_start
purchase
payment_failure
```

Supported dashboard periods:

```text
last-7-days
past-month
past-year
from-start
```

If an unknown period is supplied, the service normalizes to `last-7-days`.

Example event payload:

```json
{
  "type": "purchase",
  "id": "event-123",
  "occurredAt": "2026-06-20T00:00:00Z",
  "visitorId": "visitor-123",
  "sessionId": "session-123",
  "orderNumber": "OR-20260620-1234",
  "value": 59999,
  "items": [
    {
      "productId": 1,
      "productName": "iPhone 15",
      "categoryName": "Phones",
      "price": 59999,
      "quantity": 1
    }
  ]
}
```

Analytics ingestion accepts either a single event object or a payload containing events, depending on the normalization helper inside `AnalyticsService`. Invalid event types are ignored. Duplicate event IDs are ignored. Duplicate purchase events for the same site and order number are also ignored.

Dashboard response includes:

- Visitor count
- Product views
- Add-to-cart count
- Checkout starts
- Purchase count
- Revenue
- Average order value
- Add-to-cart rate
- Checkout-start rate
- Purchase conversion rate
- Cart abandonment rate
- Payment failure count and rate
- Units sold
- Daily or monthly trend points
- Funnel steps
- Top products
- Top categories
- Purchase order summaries
- Payment failure summaries

## Geolocation

| Method | Route | Auth | Description |
| --- | --- | --- | --- |
| `GET` | `/api/geo/country` | Public | Returns a two-letter country code if it can be inferred. |

Country detection order:

1. Edge/provider country headers such as `CF-IPCountry`, `X-Vercel-IP-Country`, `CloudFront-Viewer-Country`, and similar.
2. Public client IP from forwarding headers.
3. Public remote IP address.
4. External lookup through `https://ipapi.co/{ip}/country/`.

Private, loopback, unknown, invalid, or unparseable IP values are ignored. Lookup failures return `null` rather than failing the request.
