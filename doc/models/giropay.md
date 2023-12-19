
# Giropay

## Structure

`Giropay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type20Enum?`](../../doc/models/type-20-enum.md) | Optional | **giropay**<br>**Default**: `Type20Enum.giropay` |

## Example (as JSON)

```json
{
  "type": "giropay",
  "checkoutAttemptId": "checkoutAttemptId0",
  "recurringDetailReference": "recurringDetailReference4",
  "storedPaymentMethodId": "storedPaymentMethodId8"
}
```

