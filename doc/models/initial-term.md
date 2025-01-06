
# Initial Term

Information about the first term of the subscription.

## Structure

`InitialTerm`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StartDate` | `string` | Optional | Start date of the first term, in yyyy-MM-dd'T'HH:mm:ss.SSSZ.<br>**Constraints**: *Minimum Length*: `1` |
| `EndDate` | `string` | Optional | End data of a subscription. in yyyy-MM-dd'T'HH:mm:ss.SSSZ.<br>**Constraints**: *Minimum Length*: `1` |
| `Period` | `int?` | Optional | Duration of the first term in months, years, days, or weeks, depending on the value of the `periodType` field. Only applicable if the value of the `termType` field is `TERMED`. |
| `PeriodType` | [`PeriodTypeEnum?`](../../doc/models/period-type-enum.md) | Optional | Unit of time that the renewal term is measured in. |
| `TermType` | [`TermTypeEnum?`](../../doc/models/term-type-enum.md) | Optional | Type of the first term. If the value of this field is `TERMED`, the first term has a predefined duration based on the value of the `period` field. If the value of this field is `EVERGREEN`, the first term does not have a predefined duration. |

## Example (as JSON)

```json
{
  "startDate": "05/14/2021 12:12:27",
  "endDate": "09/14/2021 12:12:27",
  "period": 4,
  "periodType": "Month",
  "termType": "TERMED"
}
```

