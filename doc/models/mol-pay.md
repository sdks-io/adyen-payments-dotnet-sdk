
# MOL Pay

## Structure

`MOLPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The shopper's bank. Specify this with the issuer value that corresponds to this bank. |
| `Type` | [`Type25Enum`](../../doc/models/type-25-enum.md) | Required | **molpay** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId6",
  "issuer": "issuer0",
  "type": "molpay_ebanking_fpx_MY"
}
```

