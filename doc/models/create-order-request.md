
# Create Order Request

## Structure

`CreateOrderRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount19`](../../doc/models/amount-19.md) | Required | The total amount of the order. |
| `ExpiresAt` | `string` | Optional | The date that order expires; e.g. 2019-03-23T12:25:28Z. If not provided, the default expiry duration is 1 day. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the order. |
| `Reference` | `string` | Required | A custom reference identifying the order. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "expiresAt": "expiresAt4",
  "merchantAccount": "merchantAccount0",
  "reference": "reference4"
}
```

