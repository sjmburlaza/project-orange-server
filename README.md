# Project Orange Server

Project Orange Server is an ASP.NET Core Web API for a multi-site ecommerce checkout flow. It provides site-aware product browsing, categories, cart management, vouchers, shipping options, checkout form configuration, orders, authentication, and trade-in session endpoints for a frontend client.

## Tech Stack

- ASP.NET Core Web API
- .NET 10
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- Secure cookie-backed JWT sessions
- Swagger/OpenAPI via Swashbuckle

## Features

- Multi-site storefront support for the Philippines, France, China, and Japan
- Site resolution by `/api/{siteCode}/...` route prefix, `X-Site-Code` header, `siteCode` query parameter, or default site fallback
- Site-scoped product catalog, categories, carts, orders, auth sessions, and checkout forms
- Localized seeded product data with site currencies
- Product catalog with category, price filtering, sorting, and product specs
- Category management
- Cart creation and cart lookup by cart code
- Authenticated user cart lookup
- Cart item quantity updates and removal
- Product add-ons, insurance plans, mobile plans, and trade-in selections with site feature flags
- Voucher application and voucher removal with site feature flags
- Site-specific shipping-price lookup by postal code
- Country detection from edge provider headers or client IP lookup
- Checkout form configuration loaded from site-specific JSON files
- Site-specific postal-code serviceability validation
- Basic site-scoped order creation with stock validation
- Trade-in configuration and in-memory site-scoped trade-in session flow
- User registration and login with secure cookie-backed, site-scoped sessions

## Project Structure

```text
.
├── Config/                  # Default and site-specific checkout form configuration
├── Contracts/               # Service interfaces
├── Controllers/             # API controllers and routes
├── DTOs/                    # Request and response DTOs
├── Data/                    # EF Core DbContext, design-time factory, and seed data
├── Migrations/              # EF Core database migrations
├── Models/                  # Entity models
├── Services/                # Business logic for carts, checkout, shipping, trade-ins
├── Program.cs               # Application startup and dependency registration
├── ProjectOrangeApi.csproj  # Project dependencies and target framework
└── ProjectOrangeApi.sln     # Visual Studio solution
```

## Prerequisites

- .NET 10 SDK
- SQL Server running locally or remotely
- EF Core CLI tools, if you need to run migrations:

```bash
dotnet tool install --global dotnet-ef
```

## Configuration

The API reads configuration from `appsettings.json`, `appsettings.Development.json`, environment variables, and the usual ASP.NET Core configuration providers.

Required configuration:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=ProjectOrangeDb;User Id=sa;Password=<password>;TrustServerCertificate=True"
  },
  "Jwt": {
    "Issuer": "ProjectOrangeApi",
    "Audience": "ProjectOrangeClient",
    "Key": "<at-least-32-character-secret-key>"
  }
}
```

For local development, prefer user secrets or environment variables for real credentials:

```bash
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost,1433;Database=ProjectOrangeDb;User Id=sa;Password=<password>;TrustServerCertificate=True"
dotnet user-secrets set "Jwt:Issuer" "ProjectOrangeApi"
dotnet user-secrets set "Jwt:Audience" "ProjectOrangeClient"
dotnet user-secrets set "Jwt:Key" "<at-least-32-character-secret-key>"
```

Equivalent environment variable names:

```bash
ConnectionStrings__DefaultConnection
Jwt__Issuer
Jwt__Audience
Jwt__Key
```

Optional password reset link configuration:

```bash
PasswordReset__ClientResetUrl
```

If omitted, development reset links default to `http://localhost:4200/reset-password`.

## Multi-Site Support

The API seeds and serves four active sites:

| Code | Country     | Locale  | Currency | Default language | Insurance | Trade-ins | Vouchers |
| ---- | ----------- | ------- | -------- | ---------------- | --------- | --------- | -------- |
| `ph` | Philippines | `en-PH` | `PHP`    | `en`             | Yes       | Yes       | Yes      |
| `fr` | France      | `fr-FR` | `EUR`    | `fr`             | Yes       | No        | Yes      |
| `cn` | China       | `zh-CN` | `CNY`    | `zh`             | Yes       | Yes       | Yes      |
| `jp` | Japan       | `ja-JP` | `JPY`    | `ja`             | Yes       | Yes       | Yes      |

`ph` is the default site. Site-scoped API requests can select a site in any of these ways:

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

Resolution order is route value, `X-Site-Code` header, `siteCode` query parameter, then the default `ph` site. Unsupported site codes return:

```json
{
  "code": "SITE_NOT_FOUND",
  "message": "Site '<site-code>' is not supported."
}
```

Site-scoped controllers support both legacy routes such as `/api/products` and prefixed routes such as `/api/fr/products`. `GET /api/sites` and `GET /api/sites/{code}` are not site-prefixed.

Site selection affects:

- Products and categories returned by catalog endpoints
- Cart lookup and cart creation
- Order lookup and order creation
- Auth session creation, validation, and logout
- Checkout form JSON, loaded from `Config/sites/{siteCode}/checkout-form.json` with fallback to `Config/checkout-form.json`
- Shipping and postal-code validation
- Feature availability for insurance, trade-ins, and vouchers
- Display amounts for insurance, mobile plans, trade-in credits, and voucher minimums

## Getting Started

Restore dependencies:

```bash
dotnet restore
```

Apply database migrations:

```bash
dotnet ef database update
```

Run the API:

```bash
dotnet run
```

The development launch profiles expose:

- HTTP: `http://localhost:5175`
- HTTPS: `https://localhost:7196`

Swagger UI is enabled in development:

- `http://localhost:5175/swagger`
- `https://localhost:7196/swagger`

The API currently allows CORS requests from:

```text
http://localhost:4200
```

## Authentication

Register a user:

```http
POST /api/auth/register
Content-Type: application/json

{
  "fullName": "Juan Dela Cruz",
  "email": "juan@example.com",
  "password": "Passw0rd!"
}
```

Login:

```http
POST /api/auth/login
Content-Type: application/json

{
  "email": "juan@example.com",
  "password": "Passw0rd!"
}
```

Registered users are assigned the `customer` role by default.

Request a password reset:

```http
POST /api/auth/forgot-password
Content-Type: application/json

{
  "email": "juan@example.com"
}
```

The response is intentionally generic so callers cannot discover whether an email address is registered. In development, the response also includes a URL-safe `resetToken` and `resetUrl` for local testing.

Complete a password reset:

```http
POST /api/auth/reset-password
Content-Type: application/json

{
  "email": "juan@example.com",
  "token": "<reset-token>",
  "newPassword": "NewPassw0rd!"
}
```

Password reset tokens expire after two hours. A successful reset revokes existing auth sessions for the user.

The login endpoint validates the credentials, creates a server-side session for the current site, and sets a secure HttpOnly session cookie. The response returns the user access profile and a session summary:

```json
{
  "user": {
    "id": "<user-id>",
    "email": "juan@example.com",
    "fullName": "Juan Dela Cruz",
    "roles": ["customer"],
    "permissions": ["products.read"]
  },
  "session": {
    "id": "<session-id>",
    "createdAtUtc": "2026-06-13T00:00:00+00:00",
    "expiresAtUtc": "2026-06-13T02:00:00+00:00"
  }
}
```

Fetch the current session:

```http
GET /api/auth/session
```

Logout revokes the current server-side session and clears the session cookie:

```http
POST /api/auth/logout
```

Auth sessions are site-scoped. A session cookie created under one site code is rejected if it is used with another site code.

Development sample accounts are created automatically when the API starts in the `Development` environment:

| Role                | Email                   | Password        |
| ------------------- | ----------------------- | --------------- |
| `admin`             | `admin@example.com`     | `Admin123!`     |
| `customer`          | `customer@example.com`  | `Customer123!`  |
| `support-agent`     | `support@example.com`   | `Support123!`   |
| `inventory-manager` | `inventory@example.com` | `Inventory123!` |

Built-in roles:

```text
admin
customer
support-agent
inventory-manager
```

Built-in permissions:

```text
products.read
products.create
products.update
products.delete
orders.read
orders.update
orders.cancel
users.read
users.manage
inventory.read
inventory.update
```

## API Overview

Unless noted otherwise, endpoint tables show the non-prefixed route. Site-scoped controllers also support `/api/{siteCode}/...` routes, for example `/api/fr/products`, `/api/cn/carts/items`, and `/api/jp/checkout/form`.

### Sites

| Method | Endpoint            | Description                                  |
| ------ | ------------------- | -------------------------------------------- |
| `GET`  | `/api/sites`        | Get active supported sites and feature flags |
| `GET`  | `/api/sites/{code}` | Get one active site by code                  |

### Auth

| Method | Endpoint             | Description                                                          |
| ------ | -------------------- | -------------------------------------------------------------------- |
| `POST` | `/api/auth/register` | Register a new user                                                  |
| `POST` | `/api/auth/login`    | Login, set the secure session cookie, and return the session summary |
| `GET`  | `/api/auth/session`  | Get the current user, roles, permissions, and session summary        |
| `POST` | `/api/auth/logout`   | Revoke the current session and clear the session cookie              |
| `GET`  | `/api/auth/me`       | Get the authenticated user profile                                   |

### Products

| Method | Endpoint                             | Description                         |
| ------ | ------------------------------------ | ----------------------------------- |
| `GET`  | `/api/products`                      | Get products                        |
| `GET`  | `/api/products/{id}`                 | Get one product                     |
| `GET`  | `/api/products/{id}/addons`          | Get add-ons available for a product |
| `GET`  | `/api/products/{id}/insurance-plans` | Get available insurance plans       |
| `GET`  | `/api/products/{id}/mobile-plans`    | Get available mobile plans          |

Product list query parameters:

| Parameter    | Type      | Description                                           |
| ------------ | --------- | ----------------------------------------------------- |
| `categoryId` | `int`     | Filter by category                                    |
| `sortBy`     | `string`  | `price-asc`, `price-desc`, `name-asc`, or `name-desc` |
| `minPrice`   | `decimal` | Minimum price                                         |
| `maxPrice`   | `decimal` | Maximum price                                         |

Example:

```http
GET /api/products?categoryId=1&sortBy=price-asc&minPrice=1000&maxPrice=50000
```

Product and category IDs are scoped to the current site. Prices are stored in the site's seeded currency.

### Categories

| Method | Endpoint          | Description        |
| ------ | ----------------- | ------------------ |
| `GET`  | `/api/categories` | Get all categories |
| `POST` | `/api/categories` | Create a category  |

Created categories are assigned to the current site.

### Carts

| Method   | Endpoint                                                   | Description                       |
| -------- | ---------------------------------------------------------- | --------------------------------- |
| `GET`    | `/api/carts/{cartCode}`                                    | Get a cart by code                |
| `GET`    | `/api/carts/{cartCode}/recommended-products`               | Get accessory recommendations     |
| `GET`    | `/api/carts/me`                                            | Get the authenticated user's cart |
| `POST`   | `/api/carts/items`                                         | Add an item to a new cart         |
| `POST`   | `/api/carts/{cartCode}/items`                              | Add an item to an existing cart   |
| `PUT`    | `/api/carts/{cartCode}/items/{productId}`                  | Update item quantity              |
| `DELETE` | `/api/carts/{cartCode}/items/{productId}`                  | Remove an item                    |
| `PUT`    | `/api/carts/{cartCode}/items/{productId}/addons/{addonId}` | Add or update an item add-on      |
| `DELETE` | `/api/carts/{cartCode}/items/{productId}/addons/{addonId}` | Remove an item add-on             |
| `POST`   | `/api/carts/{cartCode}/vouchers`                           | Apply a voucher                   |
| `DELETE` | `/api/carts/{cartCode}/vouchers/{voucherCode}`             | Remove a voucher                  |
| `PUT`    | `/api/carts/{cartCode}/shipping`                           | Update selected shipping method   |

Add an item:

```http
POST /api/carts/items
Content-Type: application/json

{
  "productId": 1,
  "quantity": 1,
  "insurancePlanCode": null,
  "mobilePlanCode": null,
  "tradeInSessionId": null,
  "addons": []
}
```

Update quantity:

```http
PUT /api/carts/CART-12345678/items/1
Content-Type: application/json

{
  "quantity": 2
}
```

Apply a voucher:

```http
POST /api/carts/CART-12345678/vouchers
Content-Type: application/json

{
  "code": "SAVE10"
}
```

Update shipping:

```http
PUT /api/carts/CART-12345678/shipping
Content-Type: application/json

{
  "postalCode": "1000",
  "shippingMethodCode": "jnt-standard"
}
```

Carts are scoped to the current site. A cart code can only be fetched or updated from the same site where it was created. Voucher, insurance, and trade-in add-ons follow the current site's feature flags.

### Checkout

| Method | Endpoint             | Description                                          |
| ------ | -------------------- | ---------------------------------------------------- |
| `GET`  | `/api/checkout/form` | Get checkout form configuration for the current site |

Checkout forms are loaded from `Config/sites/{siteCode}/checkout-form.json` when available, then fall back to `Config/checkout-form.json`.

### Fulfillment and Postal Codes

| Method | Endpoint                                             | Description                                   |
| ------ | ---------------------------------------------------- | --------------------------------------------- |
| `GET`  | `/api/fulfillment/options?postalCode={postalCode}`   | Get postal-code-priced delivery and pickup options |
| `GET`  | `/api/postal-codes/validate?postalCode={postalCode}` | Validate whether a postal code is serviceable |

Postal-code validation is site-specific:

| Site | Rule                                                                 |
| ---- | -------------------------------------------------------------------- |
| `ph` | Must match seeded Philippine serviceable postal codes                |
| `fr` | Must be 5 digits                                                     |
| `cn` | Must be 6 digits                                                     |
| `jp` | Must be 7 digits, with an optional hyphen accepted before validation |

Fulfillment options include delivery courier metadata and pickup location metadata. When a postal code is supplied, delivery prices and estimates come from the matched site/country area rule and pickup options are filtered to nearby stores. Unserviceable postal codes return no fulfillment options.

### Geo

| Method | Endpoint           | Description                                                                                                 |
| ------ | ------------------ | ----------------------------------------------------------------------------------------------------------- |
| `GET`  | `/api/geo/country` | Detect the request country code from Cloudflare, Vercel, CloudFront, other geo headers, or client IP lookup |

### Address Options

| Method | Endpoint                                   | Description                  |
| ------ | ------------------------------------------ | ---------------------------- |
| `GET`  | `/api/options/regions`                     | Get region options           |
| `GET`  | `/api/options/cities?parent={regionCode}`  | Get city options by region   |
| `GET`  | `/api/options/barangays?parent={cityCode}` | Get barangay options by city |

All address option endpoints accept an optional `search` query parameter.

Address options currently return Philippine region, city, and barangay data only. Non-`ph` sites return empty option lists.

### Orders

| Method | Endpoint                                                           | Description                         |
| ------ | ------------------------------------------------------------------ | ----------------------------------- |
| `GET`  | `/api/orders`                                                      | Get all order confirmations         |
| `GET`  | `/api/orders/lookup?orderNumber={orderNumber}&email={customerEmail}` | Look up an order confirmation by number and customer email |
| `GET`  | `/api/orders/{orderNumber}`                                        | Get an order confirmation by number |
| `POST` | `/api/orders`                                                      | Place an order                      |

Place an order from the checkout/cart flow:

```http
POST /api/orders
Content-Type: application/json

{
  "cart": {
    "code": "CART-ABC12345",
    "entries": [
      {
        "productId": 1,
        "productName": "iPhone 15",
        "price": 59999,
        "quantity": 1,
        "imageUrl": "",
        "categoryName": "Phones",
        "itemSpecs": [
          { "name": "Storage", "value": "128GB" },
          { "name": "Color", "value": "Black" }
        ]
      }
    ],
    "cartSummary": [
      { "name": "Total", "amount": 59999 }
    ]
  },
  "checkoutData": {
    "customer": {
      "firstName": "Juan",
      "lastName": "Dela Cruz",
      "email": "juan@example.com",
      "mobileNumber": "09171234567",
      "deliveryAddress": {
        "addressLine1": "123 Orange Avenue",
        "city": "Manila",
        "postalCode": "1000"
      }
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

The response is an order confirmation with an order number, payment/order status, item snapshots, shipping address, delivery estimate, total, next steps, and placement timestamp.

Checkout data is accepted as dynamic step-keyed field data. Known confirmation fields such as customer name, email, delivery address, shipping method, and payment method are resolved by field name from the dynamic payload, and the raw checkout data is stored with the order for future form fields.

The legacy item-only body is still accepted:

```http
POST /api/orders
Content-Type: application/json

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

Order listing and creation are scoped to the current site. Products from another site are rejected as missing.

Customer order lookup uses a dedicated verification route:

```http
GET /api/orders/lookup?orderNumber=OR-20260619-1234&email=juan@example.com
```

The `orderNumber` and `email` query parameters are both required. The email address must match the order's customer email address case-insensitively. Missing orders and email mismatches both return `404 Not Found`.

The lookup response uses the order confirmation shape:

```json
{
  "id": "OR-20260619-1234",
  "orderNumber": "OR-20260619-1234",
  "customerEmail": "juan@example.com",
  "paymentStatus": "paid",
  "orderStatus": "confirmed",
  "items": [
    {
      "productId": 1,
      "productName": "iPhone 15",
      "price": 59999,
      "quantity": 1,
      "imageUrl": "",
      "categoryName": "Phones",
      "itemSpecs": [
        { "name": "Storage", "value": "128GB" },
        { "name": "Color", "value": "Black" }
      ],
      "addons": [
        {
          "id": "insurance",
          "name": "Device insurance",
          "title": "Device insurance",
          "description": "Protect your device from accidental damage.",
          "imageUrl": "",
          "amount": 499,
          "billingFrequency": "",
          "selectedOptionCode": "basic",
          "selectedOptionName": "Basic",
          "isAdded": true
        }
      ]
    }
  ],
  "shippingAddress": {},
  "deliveryEstimate": "3-5 business days",
  "subtotalAmount": 59999,
  "totalAmount": 59999,
  "nextSteps": [],
  "placedAt": "2026-06-19T00:00:00Z"
}
```

Optional fields such as `deliveredAt`, `trackingNumber`, `courier`, `invoiceUrl`, `shippingAmount`, and `discountAmount` are omitted until the order has those values.

### Trade-ins

| Method  | Endpoint                                                                   | Description                        |
| ------- | -------------------------------------------------------------------------- | ---------------------------------- |
| `GET`   | `/api/trade-ins/config`                                                    | Get trade-in UI/configuration data |
| `GET`   | `/api/trade-ins/categories`                                                | Get trade-in categories            |
| `GET`   | `/api/trade-ins/brands?categoryCode={categoryCode}`                        | Get brands by category             |
| `GET`   | `/api/trade-ins/devices?categoryCode={categoryCode}&brandCode={brandCode}` | Get devices                        |
| `GET`   | `/api/trade-ins/storages?deviceCode={deviceCode}`                          | Get storage options                |
| `POST`  | `/api/trade-in-sessions`                                                   | Create a trade-in session          |
| `GET`   | `/api/trade-in-sessions/{sessionId}`                                       | Get a trade-in session             |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-one`                              | Update trade-in step one           |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-two`                              | Update trade-in step two           |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/step-three`                            | Update trade-in step three         |
| `PATCH` | `/api/trade-in-sessions/{sessionId}/confirm`                               | Confirm a trade-in session         |

Create a trade-in session:

```http
POST /api/trade-in-sessions
Content-Type: application/json

{
  "cartCode": "CART-12345678",
  "productId": 1
}
```

Trade-in endpoints return `404` when trade-ins are disabled for the current site. Trade-in sessions include a `siteCode` and can only be retrieved or updated from the same site.

## Error Responses

Cart and voucher validation errors are returned as `ProblemDetails` responses. These responses include a machine-readable `code` field.

Example:

```json
{
  "type": "https://project-orange-api/errors/voucher_not_applicable",
  "title": "Voucher not applicable.",
  "status": 400,
  "detail": "Voucher cannot be applied to this cart.",
  "code": "VOUCHER_NOT_APPLICABLE"
}
```

General model validation errors return:

```json
{
  "title": "Invalid request.",
  "status": 400,
  "detail": "Request validation failed.",
  "code": "REQUEST_VALIDATION_FAILED"
}
```

## Database Notes

The app registers `AppDbContext` with SQL Server in `Program.cs`.

Seed data is configured for:

- Sites
- Categories
- Products
- Product specs
- Address options
- Postal codes
- Shipping rates
- Vouchers
- Add-ons
- Insurance plans
- Mobile plans
- Trade-in options

Categories, products, carts, orders, and auth sessions are site-scoped. The current migrations seed distinct category and product rows per site.

Run migrations after changing entities or seed data:

```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```

## Useful Commands

Build the project:

```bash
dotnet build
```

Run the project:

```bash
dotnet run
```

Run with the HTTP launch profile:

```bash
dotnet run --launch-profile http
```

Run with the HTTPS launch profile:

```bash
dotnet run --launch-profile https
```

## Security Notes

- Do not commit real database passwords or production JWT keys.
- Use strong JWT keys with at least 32 characters.
- Keep production connection strings in environment variables or a secure secret store.
- Review CORS origins before deploying outside local development.
