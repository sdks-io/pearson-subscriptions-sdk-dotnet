
# Order Request Type Product

## Structure

`OrderRequestTypeProduct`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Isbn` | `string` | Optional | product isbn value<br>**Constraints**: *Minimum Length*: `1` |
| `Ppid` | `string` | Optional | product ppid value<br>**Constraints**: *Minimum Length*: `1` |
| `Duration` | `double?` | Optional | Duration of the entitlement in days for this product |
| `Tax` | `double?` | Optional | Cost of tax on the product |
| `Price` | `double?` | Optional | Cost of the product |

## Example (as JSON)

```json
{
  "isbn": "isbn2",
  "ppid": "ppid6",
  "duration": 32.56,
  "tax": 244.04,
  "price": 147.92
}
```

