
# BLIK

## Structure

`BLIK`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BlikCode` | `string` | Optional | BLIK code consisting of 6 digits. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type8Enum?`](../../doc/models/type-8-enum.md) | Optional | **blik** |

## Example (as JSON)

```json
{
  "blikCode": "blikCode4",
  "checkoutAttemptId": "checkoutAttemptId2",
  "recurringDetailReference": "recurringDetailReference6",
  "storedPaymentMethodId": "storedPaymentMethodId0",
  "type": "blik"
}
```

