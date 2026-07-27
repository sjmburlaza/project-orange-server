# 12. Error Handling

Cart, voucher, add-on, and order domain failures are represented by `ApiErrorException` subclasses. Controllers translate these exceptions into `ProblemDetails`.

Common problem response shape:

```json
{
  "type": "https://project-orange-api/errors/CODE",
  "title": "Error title",
  "status": 400,
  "detail": "Human-readable detail.",
  "code": "ERROR_CODE"
}
```

Known domain error codes:

| Code | Typical status | Meaning |
| --- | --- | --- |
| `ADDON_LIMIT_REACHED` | `400` | Attempted unsupported add-on combination or duplicate behavior. |
| `ADDON_NOT_AVAILABLE` | `400` | Selected add-on or option is unavailable for product/site. |
| `CART_ITEM_NOT_FOUND` | `404` | Product line does not exist in the cart. |
| `CART_NOT_FOUND` | `404` | Cart does not exist, belongs to another site, or belongs to another user. |
| `ORDER_INSUFFICIENT_STOCK` | `409` | Product stock is lower than requested quantity. |
| `ORDER_INVALID_REQUEST` | `400` | Order payload is invalid. |
| `ORDER_PRODUCT_NOT_FOUND` | `404` | Order references a product unavailable for the current site. |
| `VOUCHER_ALREADY_APPLIED` | `409` | Voucher is already on the cart. |
| `VOUCHER_CODE_INVALID_FORMAT` | `400` | Voucher code failed format validation. |
| `VOUCHER_LIMIT_REACHED` | `409` | Cart already has a voucher. |
| `VOUCHER_MINIMUM_SUBTOTAL_NOT_MET` | `400` | Cart subtotal is below voucher minimum. |
| `VOUCHER_NOT_APPLICABLE` | `400` | Voucher is unavailable, disabled, expired, scheduled, or otherwise invalid. |

Automatic model-state validation failures return:

- `REQUEST_VALIDATION_FAILED` for most endpoints.
- `VOUCHER_CODE_INVALID_FORMAT` for cart voucher endpoints.
