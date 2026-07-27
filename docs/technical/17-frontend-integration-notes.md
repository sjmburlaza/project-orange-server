# 17. Frontend Integration Notes

## Always Pass Site Context

Prefer site-prefixed URLs for clarity:

```text
/api/ph/products
/api/fr/products
/api/cn/products
/api/jp/products
```

This is safer than relying on query strings or headers because routes make site context visible in logs, browser tools, and copied URLs.

## Use Credentialed Requests for Auth

The backend stores the JWT in an HttpOnly cookie. Browser clients should make credentialed requests when using auth endpoints:

```ts
fetch("/api/ph/auth/session", {
  credentials: "include"
});
```

Because the cookie is `Secure` and `SameSite=None`, HTTPS should be used for browser testing of cookie auth flows.

## Cart Flow

Recommended frontend cart sequence:

1. Fetch product and optional add-ons/plans.
2. If trade-in is selected, complete and confirm a trade-in session.
3. Add product with selected add-on codes.
4. Store returned cart code.
5. Validate postal code.
6. Fetch shipping options.
7. Save selected shipping option on the cart.
8. Apply voucher if desired.
9. Submit order with the final cart snapshot and checkout data.

## Checkout Form

The frontend should treat checkout form JSON as configuration, not as server-side validation guarantees. Server-side order placement still performs product, stock, and site validation, but field-level checkout validation mostly lives in the client-rendered form definition.
