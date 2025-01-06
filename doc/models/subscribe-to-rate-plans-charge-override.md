
# Subscribe to Rate Plans Charge Override

## Structure

`SubscribeToRatePlansChargeOverride`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductRatePlanChargeId` | `string` | Optional | This is unique rate plan charge id respective to rate plan id. It signifies the subscription type,entitlementLevel,maxEntitlements,numEntitlements etc.<br>**Constraints**: *Minimum Length*: `1` |
| `CustomerFacingCustomFields` | [`CustomerFacingCustomFields`](../../doc/models/customer-facing-custom-fields.md) | Optional | - |
| `RatePlanPricing` | [`RatePlanPricing`](../../doc/models/rate-plan-pricing.md) | Optional | - |
| `RatePlanEndDate` | [`RatePlanEndDate`](../../doc/models/rate-plan-end-date.md) | Optional | - |

## Example (as JSON)

```json
{
  "productRatePlanChargeId": "productRatePlanChargeId0",
  "customerFacingCustomFields": {
    "customerFacing__c": "customerFacing__c0"
  },
  "ratePlanPricing": {
    "discount": {
      "discountAmount": 252.52,
      "discountPercentage": 13.42
    },
    "recurringFlatFee": {
      "listPrice": 233.52
    }
  },
  "ratePlanEndDate": {
    "endDateCondition": "Specific_End_Date",
    "specificEndDate": "2016-03-13",
    "upToPeriods": 187.74,
    "upToPeriodsType": "Billing_Periods"
  }
}
```

