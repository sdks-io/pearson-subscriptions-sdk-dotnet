
# Update Subscription Subscription

## Structure

`UpdateSubscriptionSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionNumber` | `string` | Required | Subscription number or ID. Subscription status must be active for the same.<br>**Constraints**: *Minimum Length*: `1` |
| `OrderActions` | [`List<UpdateOrderOrderAction>`](../../doc/models/update-order-order-action.md) | Optional | The actions to be applied to the subscription. Order actions will be stored with the sequence when it was provided in the request. |

## Example (as JSON)

```json
{
  "subscriptionNumber": "A-S00000001",
  "orderActions": [
    {
      "triggerDates": [
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        },
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        },
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        }
      ],
      "addProduct": {
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
      },
      "removeProduct": {
        "productRatePlanId": "productRatePlanId8"
      },
      "termsAndConditions": {
        "autorenew": false
      }
    },
    {
      "triggerDates": [
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        },
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        },
        {
          "name": "name6",
          "triggerDate": "triggerDate6"
        }
      ],
      "addProduct": {
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
      },
      "removeProduct": {
        "productRatePlanId": "productRatePlanId8"
      },
      "termsAndConditions": {
        "autorenew": false
      }
    }
  ]
}
```

