
# Dotpay

## Structure

`Dotpay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The Dotpay issuer value of the shopper's selected bank. Set this to an **id** of a Dotpay issuer to preselect it. |
| `Type` | [`Type16Enum?`](../../doc/models/type-16-enum.md) | Optional | **dotpay**<br>**Default**: `Type16Enum.dotpay` |

## Example (as JSON)

```json
{
  "issuer": "issuer6",
  "type": "dotpay",
  "checkoutAttemptId": "checkoutAttemptId2"
}
```

