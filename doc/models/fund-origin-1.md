
# Fund Origin 1

The person or entity funding the money.

## Structure

`FundOrigin1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The address where to send the invoice. |
| `ShopperName` | [`Name1`](../../doc/models/name-1.md) | Optional | The name of the person |

## Example (as JSON)

```json
{
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "shopperName": {
    "firstName": "firstName2",
    "lastName": "lastName6"
  }
}
```

