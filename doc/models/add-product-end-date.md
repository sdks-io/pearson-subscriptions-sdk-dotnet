
# Add Product End Date

## Structure

`AddProductEndDate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndDateCondition` | [`EndDateConditionEnum?`](../../doc/models/end-date-condition-enum.md) | Optional | enum values are "Subscription_End" "Fixed_Period" "Specific_End_Date" |
| `SpecificEndDate` | `string` | Optional | - |
| `UpToPeriods` | `double?` | Optional | - |
| `UpToPeriodsType` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "endDateCondition": "Fixed_Period",
  "specificEndDate": "specificEndDate8",
  "upToPeriods": 47.48,
  "upToPeriodsType": "upToPeriodsType2"
}
```

