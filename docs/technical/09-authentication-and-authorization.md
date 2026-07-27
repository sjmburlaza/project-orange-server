# 9. Authentication and Authorization

## Authentication Model

The login flow creates two artifacts:

1. A persisted `AuthSession` row scoped to the current site.
2. A JWT containing user, role, permission, session ID, and site-code claims.

The JWT is written to a secure cookie:

```text
__Host-project-orange-session
```

Cookie options:

- `HttpOnly = true`
- `Secure = true`
- `SameSite = None`
- `Path = /`
- Expiration matches the server-side auth session expiration.

The default session lifetime is two hours.

## JWT Validation

JWT bearer auth reads the token from the session cookie if no bearer token is present. During token validation, the API checks:

- The JWT has a session ID claim.
- The JWT has a user ID claim.
- The JWT has a `site_code` claim.
- The current request site matches the JWT site.
- The corresponding `AuthSession` exists.
- The session belongs to the current site.
- The session belongs to the user.
- The session is not revoked.
- The session has not expired.

This prevents a cookie issued on one site from being reused against another site route.

## Password Reset

Password reset uses ASP.NET Core Identity reset tokens.

- Token lifetime is configured to two hours through `DataProtectionTokenProviderOptions`.
- Tokens are Base64 URL encoded before returning to the client.
- In development, `forgot-password` returns the reset token and reset URL directly to simplify local testing.
- In non-development environments, the endpoint returns only a generic message.
- Successful password reset revokes all active sessions for the user.

## Roles

Known roles:

| Role | Purpose |
| --- | --- |
| `admin` | Full access to all known permissions. |
| `customer` | Default role for registered users. |
| `support-agent` | Support access to products, orders, users, and inventory read. |
| `inventory-manager` | Product and inventory management permissions. |

## Permissions

Known permission claims:

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

Policies are registered for every permission in `AppPermissions.All`; admin product management uses the product permission policies, while other controllers use public access, `[Authorize]`, or admin role checks as appropriate.

## Role Permission Mapping

| Role | Permissions |
| --- | --- |
| `admin` | All permissions. |
| `customer` | `products.read`, `orders.read`, `orders.cancel`. |
| `support-agent` | `products.read`, `orders.read`, `orders.update`, `orders.cancel`, `users.read`, `inventory.read`. |
| `inventory-manager` | `products.read`, `products.create`, `products.update`, `products.delete`, `orders.read`, `inventory.read`, `inventory.update`. |

Users with no known role are normalized to `customer`.
