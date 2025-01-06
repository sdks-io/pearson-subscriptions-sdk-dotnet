
# Cancel Req Type

## Structure

`CancelReqType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `string` | Required | Subscription id |
| `SubscriptionSource` | [`SubscriptionSourceEnum`](../../doc/models/subscription-source-enum.md) | Required | Internal or external |
| `CancelReason` | `string` | Required | Reason for subscription cancel |
| `CancelDate` | `string` | Required | cancellation date |

## Example (as JSON)

```json
{
  "subscriptionId": "urn:pearson:gps:subs:649e7109fc57341ba129e23",
  "subscriptionSource": "Internal",
  "cancelReason": "No longer need service",
  "cancelDate": "2023-06-30"
}
```

