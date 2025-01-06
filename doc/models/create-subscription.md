
# Create Subscription

Information about an order action of type `CreateSubscription`.

## Structure

`CreateSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Terms` | [`Terms`](../../doc/models/terms.md) | Optional | Container for the terms and renewal settings of the subscription. |
| `SubscribeToRatePlans` | [`List<SubscribeToRatePlan>`](../../doc/models/subscribe-to-rate-plan.md) | Optional | - |

## Example (as JSON)

```json
{
  "subscribeToRatePlans": [
    {
      "chargeOverrides": [
        {
          "productRatePlanChargeId": "8adc9dee78677aca017869995efb2006",
          "customFields": {
            "customerFacing__c": "Mojo Basic"
          }
        }
      ],
      "productRatePlanId": "8adc9dee78677aca017869995ede2004",
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
      "chargeOverrides": [
        {
          "productRatePlanChargeId": "8adce42177dd81290177de95f16f46ac",
          "customFields": {
            "customerFacing__c": "Mojo Promotion"
          },
          "pricing": {
            "discount": {
              "discountAmount": 2
            },
            "recurringFlatFee": {
              "listPrice": 9.99
            }
          },
          "endDate": {
            "endDateCondition": "Fixed_Period",
            "upToPeriods": 3,
            "upToPeriodsType": "Months"
          }
        }
      ],
      "productRatePlanId": "8adcd9eb77dd81280177de95185e49e9",
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
  ],
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
  }
}
```

