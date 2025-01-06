
# Order Resp Type Error Exception

## Structure

`OrderRespTypeErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderNumber` | `string` | Optional | Order Number. |
| `SubscriptionId` | `string` | Optional | Pearson subscription id. |
| `OrderRespError` | [`OrderRespError`](../../doc/models/order-resp-error.md) | Optional | - |

## Example (as JSON)

```json
{
  "orderNumber": "S12345",
  "subscriptionId": "S12345",
  "orderRespError": {
    "code": "E40",
    "message": "message6"
  }
}
```

