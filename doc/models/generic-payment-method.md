
# Generic Payment Method

## Structure

`GenericPaymentMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The issuer id of the shopper's selected bank. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type19Enum`](../../doc/models/type-19-enum.md) | Required | **genericissuer** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId4",
  "issuer": "issuer8",
  "recurringDetailReference": "recurringDetailReference8",
  "storedPaymentMethodId": "storedPaymentMethodId2",
  "type": "onlineBanking_PL"
}
```

