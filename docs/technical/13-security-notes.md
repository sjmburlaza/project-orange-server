# 13. Security Notes

## Current Strengths

- HttpOnly secure session cookie.
- Server-side auth session validation.
- Session revocation support.
- Site-code claim binding to current request site.
- Password reset token expiry.
- Generic forgot-password response.
- CORS limited to `http://localhost:4200` in current configuration.
- SQL queries go through EF Core LINQ rather than raw SQL.

## Review Before Production

Review these areas before production deployment:

- Ensure `Jwt:Key` is high entropy and never committed.
- Ensure HTTPS termination is enforced end to end.
- Configure production CORS origins.
- Add authorization to currently public write endpoints if admin/customer separation is required.
- Move `TradeInSessionService` state to durable/shared storage if running more than one instance.
- Add email delivery for password reset outside development.
- Consider request rate limiting for auth, voucher, analytics, and order endpoints.
- Add observability for auth failures, order placement, stock conflicts, and analytics ingestion drops.
- Decide whether `GET /api/orders` and `GET /api/orders/{orderNumber}` should require auth or support-only access.
- Decide whether `POST /api/categories` should require an admin or inventory permission.
