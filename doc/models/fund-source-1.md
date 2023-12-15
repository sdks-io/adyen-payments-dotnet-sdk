
# Fund Source 1

The person or entity funding the money.

## Structure

`FundSource1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | A map of name-value pairs for passing additional or industry-specific data. |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The address where to send the invoice. |
| `Card` | [`Card`](../../doc/models/card.md) | Optional | Credit card data.<br><br>Optional if `shopperReference` and `selectedRecurringDetailReference` are provided. |
| `ShopperEmail` | `string` | Optional | Email address of the person. |
| `ShopperName` | [`Name1`](../../doc/models/name-1.md) | Optional | Name of the person. |
| `TelephoneNumber` | `string` | Optional | Phone number of the person |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData8",
    "key1": "additionalData9"
  },
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "card": {
    "cvc": "cvc0",
    "expiryMonth": "expiryMonth0",
    "expiryYear": "expiryYear0",
    "holderName": "holderName2",
    "issueNumber": "issueNumber8"
  },
  "shopperEmail": "shopperEmail2",
  "shopperName": {
    "firstName": "firstName2",
    "lastName": "lastName6"
  }
}
```

