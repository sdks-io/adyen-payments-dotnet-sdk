
# Dragonpay

## Structure

`Dragonpay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The Dragonpay issuer value of the shopper's selected bank. Set this to an **id** of a Dragonpay issuer to preselect it. |
| `ShopperEmail` | `string` | Optional | The shopper’s email address. |
| `Type` | [`Type17Enum`](../../doc/models/type-17-enum.md) | Required | **dragonpay** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId8",
  "issuer": "issuer2",
  "shopperEmail": "shopperEmail6",
  "type": "dragonpay_otc_non_banking"
}
```

