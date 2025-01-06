
# Order Error Type Exception

## Structure

`OrderErrorTypeException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderNumber` | `string` | Optional | Order Number. |
| `OrderError` | [`OrderError`](../../doc/models/order-error.md) | Optional | - |

## Example (as JSON)

```json
{
  "orderNumber": "S12345",
  "orderError": {
    "code": "code4",
    "message": "message6"
  }
}
```

