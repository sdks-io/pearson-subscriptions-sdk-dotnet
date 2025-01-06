
# Order Request Type Subscription

## Structure

`OrderRequestTypeSubscription`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderActions` | [`List<CreateOrderOrderAction>`](../../doc/models/create-order-order-action.md) | Optional | The actions to be applied to the subscription. Order actions will be stored with the sequence when it was provided in the request. |

## Example (as JSON)

```json
{
  "orderActions": [
    {
      "type": "RenewSubscription",
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
    },
    {
      "type": "RenewSubscription",
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
    },
    {
      "type": "RenewSubscription",
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
  ]
}
```

