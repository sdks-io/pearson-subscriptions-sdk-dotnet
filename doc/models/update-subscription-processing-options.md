
# Update Subscription Processing Options

Invoice or Payment.

## Structure

`UpdateSubscriptionProcessingOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RunBilling` | `bool?` | Optional | Indicates if the current request needs to generate an invoice. The invoice will be generated against all subscriptions included in this order. |
| `CollectPayment` | `bool?` | Optional | Indicates if the current request needs to collect payments. This value can not be 'true' when 'runBilling' flag is 'false'. |

## Example (as JSON)

```json
{
  "runBilling": false,
  "collectPayment": false
}
```

