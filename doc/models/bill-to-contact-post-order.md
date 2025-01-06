
# Bill to Contact Post Order

Contact details associated with an account.

## Structure

`BillToContactPostOrder`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Address1` | `string` | Optional | First line of the contact's address. This is often a street address or a business name.<br>**Constraints**: *Maximum Length*: `255` |
| `Address2` | `string` | Optional | Second line of the contact's address.<br>**Constraints**: *Maximum Length*: `255` |
| `City` | `string` | Optional | City of the contact's address.<br>**Constraints**: *Maximum Length*: `40` |
| `Country` | `string` | Optional | Country; must be a valid country name or abbreviation. If using Zuora Tax, you must specify a country in the bill-to contact to calculate tax.<br>**Constraints**: *Maximum Length*: `64` |
| `County` | `string` | Optional | County of the contact's address.<br>**Constraints**: *Maximum Length*: `32` |
| `FirstName` | `string` | Optional | First name of the contact.<br>**Constraints**: *Maximum Length*: `100` |
| `LastName` | `string` | Optional | Last name of the contact.<br>**Constraints**: *Maximum Length*: `100` |
| `MobilePhone` | `string` | Optional | Mobile phone number of the contact.<br>**Constraints**: *Maximum Length*: `40` |
| `PersonalEmail` | `string` | Optional | Personal email address of the contact.<br>**Constraints**: *Maximum Length*: `80` |
| `PostalCode` | `string` | Optional | ZIP code or other postal code of the contact's address.<br>**Constraints**: *Maximum Length*: `20` |
| `State` | `string` | Optional | State or province of the contact's address.<br>**Constraints**: *Maximum Length*: `40` |
| `WorkEmail` | `string` | Optional | Business email address of the contact.<br>**Constraints**: *Maximum Length*: `80` |
| `WorkPhone` | `string` | Optional | Business phone number of the contact.<br>**Constraints**: *Maximum Length*: `40` |

## Example (as JSON)

```json
{
  "address1": "1051 E Hillsdale Blvd",
  "address2": "Santon street main",
  "city": "Durham",
  "country": "United States",
  "county": "Durham",
  "firstName": "Alex",
  "lastName": "Matthew",
  "mobilePhone": "1234567890",
  "personalEmail": "personal@email.com",
  "postalCode": "27703",
  "state": "NC",
  "workPhone": "1234567890"
}
```

