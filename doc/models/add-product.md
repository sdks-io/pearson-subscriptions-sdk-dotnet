
# Add Product

Information about an order action of type `addProduct`.

If you want to create a pending order through the "Add product" order action, and if the charge's trigger condition is `Specific Date`, you must set a charge number in the `chargeNumber` field for the "Add product" order action.

## Structure

`AddProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductRatePlanId` | `string` | Optional | Internal identifier of the product rate plan that the rate plan is based on. |
| `UpdateOrAddProductChargeOverrides` | [`List<UpdateOrAddProductChargeOverride>`](../../doc/models/update-or-add-product-charge-override.md) | Optional | - |

## Example (as JSON)

```json
{
  "productRatePlanId": "productRatePlanId4",
  "updateOrAddProductChargeOverrides": [
    {
      "productRatePlanChargeId": "productRatePlanChargeId6",
      "customerFacingCustomFields": {
        "customerFacing__c": "customerFacing__c0"
      },
      "overridesPricing": {
        "discount": {
          "discountAmount": 252.52,
          "discountPercentage": 13.42
        }
      },
      "addProductEndDate": {
        "endDateCondition": "Specific_End_Date",
        "specificEndDate": "specificEndDate0",
        "upToPeriods": 155.16,
        "upToPeriodsType": "upToPeriodsType0"
      }
    },
    {
      "productRatePlanChargeId": "productRatePlanChargeId6",
      "customerFacingCustomFields": {
        "customerFacing__c": "customerFacing__c0"
      },
      "overridesPricing": {
        "discount": {
          "discountAmount": 252.52,
          "discountPercentage": 13.42
        }
      },
      "addProductEndDate": {
        "endDateCondition": "Specific_End_Date",
        "specificEndDate": "specificEndDate0",
        "upToPeriods": 155.16,
        "upToPeriodsType": "upToPeriodsType0"
      }
    }
  ]
}
```

