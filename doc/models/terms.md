
# Terms

Container for the terms and renewal settings of the subscription.

## Structure

`Terms`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InitialTerm` | [`InitialTerm`](../../doc/models/initial-term.md) | Optional | Information about the first term of the subscription. |
| `RenewalTerms` | [`List<RenewalTerm>`](../../doc/models/renewal-term.md) | Optional | List of renewal terms of the subscription. Only applicable if the type of the first term is `TERMED` and the value of the `renewalSetting` field is `RENEW_WITH_SPECIFIC_TERM`. |
| `RenewalSetting` | [`RenewalSettingEnum?`](../../doc/models/renewal-setting-enum.md) | Optional | Specifies the type of the terms that follow the first term if the subscription is renewed. Only applicable if the type of the first term is `TERMED`.<br><br>* `RENEW_WITH_SPECIFIC_TERM` - Each renewal term has a predefined duration. The first entry in `renewalTerms` specifies the duration of the second term of the subscription, the second entry in `renewalTerms` specifies the duration of the third term of the subscription, and so on. The last entry in `renewalTerms` specifies the ultimate duration of each renewal term.<br>* `RENEW_TO_EVERGREEN` - The second term of the subscription does not have a predefined duration. |
| `AutoRenew` | `bool?` | Optional | Specifies whether the subscription automatically renews at the end of the each term. For REDEMPTION, default it to false. |

## Example (as JSON)

```json
{
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
    },
    {
      "period": 126,
      "periodType": "Day"
    }
  ],
  "renewalSetting": "RENEW_WITH_SPECIFIC_TERM",
  "autoRenew": false
}
```

