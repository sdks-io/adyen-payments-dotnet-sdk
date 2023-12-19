
# Stored Payment Method 1

## Structure

`StoredPaymentMethod1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type31Enum?`](../../doc/models/type-31-enum.md) | Optional | The payment method type. |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId4",
  "recurringDetailReference": "recurringDetailReference8",
  "storedPaymentMethodId": "storedPaymentMethodId2",
  "type": "momo_wallet_app"
}
```

