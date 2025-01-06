
# Product

## Structure

`Product`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Isbn` | `string` | Optional | product isbn number |
| `Ppid` | `string` | Optional | product ppid number |
| `Duration` | `double?` | Optional | Duration of the entitlement in days for this product |
| `EndDate` | `string` | Optional | end date for the entitlement. in yyyy-MM-dd'T'HH:mm:ss.SSSZ format. |
| `Tax` | `double?` | Optional | Cost of tax on the product |
| `Price` | `double?` | Optional | Cost of the product |

## Example (as JSON)

```json
{
  "isbn": "isbn8",
  "ppid": "ppid0",
  "duration": 117.0,
  "endDate": "endDate6",
  "tax": 72.48
}
```

