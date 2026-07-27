# 6. Multi-Site Architecture

The API supports the following active sites through `SiteSeed`:

| Code | Country | Locale | Currency | Default language | Insurance | Trade-ins | Vouchers | Active |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| `ph` | Philippines | `en-PH` | `PHP` | `en` | Yes | Yes | Yes | Yes |
| `fr` | France | `fr-FR` | `EUR` | `fr` | Yes | No | Yes | Yes |
| `cn` | China | `zh-CN` | `CNY` | `zh` | Yes | Yes | Yes | Yes |
| `jp` | Japan | `ja-JP` | `JPY` | `ja` | Yes | Yes | Yes | Yes |

The default site code is `ph`.

## Site Resolution

`SiteResolutionMiddleware` resolves site code for every `/api` request using this priority:

1. Route value: `/api/{siteCode}/...`
2. Header: `X-Site-Code`
3. Query string: `siteCode`
4. Default: `ph`

Examples:

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

If the resolved code does not match an active site, the middleware short-circuits with HTTP `404`:

```json
{
  "code": "SITE_NOT_FOUND",
  "message": "Site '<site-code>' is not supported."
}
```

## Site Context

`SiteContext` holds the resolved `Site` entity for the current scoped request and exposes:

- `SiteId`
- `SiteCode`
- `Currency`
- `InsuranceEnabled`
- `TradeInEnabled`
- `VouchersEnabled`
- `Current`

Controllers and services rely on this scoped context instead of repeatedly resolving site state.

## Site-Scoped Routes

Most controllers support both legacy unprefixed and site-prefixed routes:

```text
/api/products
/api/{siteCode}/products
```

`SitesController` is intentionally not site-prefixed:

```text
/api/sites
/api/sites/{code}
```

## Site-Scoped Data

The following persisted models include `SiteId`:

- `Product`
- `Category`
- `Cart`
- `Order`
- `AuthSession`
- `AnalyticsEvent`

Important unique indexes:

- `Site.Code`
- `Category` by `{ SiteId, Name }`
- `Cart` by `{ SiteId, Code }`
- `Order` by `{ SiteId, OrderNumber }`

This means the same cart code, order number, or category name can only collide within the same site.
