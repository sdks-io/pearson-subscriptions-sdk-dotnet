
# Order Request Processing Options

Invoice or Payment.

## Structure

`OrderRequestProcessingOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RunBilling` | `bool?` | Optional | Indicates if the current request needs to generate an invoice. The invoice will be generated against all subscriptions included in this order. For REDEMPTION, default it to true. |
| `BillingOptions` | [`BillingOptions`](../../doc/models/billing-options.md) | Optional | - |
| `CollectPayment` | `bool?` | Optional | Indicates if the current request needs to collect payments. This value can not be 'true' when 'runBilling' flag is 'false'. |

## Example (as JSON)

```json
{
  "runBilling": false,
  "billingOptions": {
    "documentDate": "2016-03-13",
    "targetDate": "2016-03-13"
  },
  "collectPayment": false
}
```

