
# Create Order Order Action

## Structure

`CreateOrderOrderAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`TypeEnum?`](../../doc/models/type-enum.md) | Optional | - |
| `TriggerDates` | [`List<TriggerDate>`](../../doc/models/trigger-date.md) | Optional | - |
| `CreateSubscription` | [`CreateSubscription`](../../doc/models/create-subscription.md) | Optional | Information about an order action of type `CreateSubscription`. |

## Example (as JSON)

```json
{
  "type": "AddProduct",
  "triggerDates": [
    {
      "name": "name6",
      "triggerDate": "triggerDate6"
    }
  ],
  "createSubscription": {
    "terms": {
      "initialTerm": {
        "startDate": "startDate4",
        "endDate": "endDate6",
        "period": 96,
        "periodType": "Month",
        "termType": "TERMED"
      },
      "renewalTerms": [
        {
          "period": 126,
          "periodType": "Day"
        },
        {
          "period": 126,
          "periodType": "Day"
        }
      ],
      "renewalSetting": "RENEW_WITH_SPECIFIC_TERM",
      "autoRenew": false
    },
    "subscribeToRatePlans": [
      {
        "productRatePlanId": "productRatePlanId6",
        "subscribeToRatePlansChargeOverrides": [
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
          },
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
          },
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
        ]
      },
      {
        "productRatePlanId": "productRatePlanId6",
        "subscribeToRatePlansChargeOverrides": [
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
          },
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
          },
          {
            "productRatePlanChargeId": "productRatePlanChargeId8",
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
        ]
      }
    ]
  }
}
```

