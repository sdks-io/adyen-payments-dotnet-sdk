
# Vipps

## Structure

`Vipps`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `TelephoneNumber` | `string` | Required | - |
| `Type` | [`Type32Enum?`](../../doc/models/type-32-enum.md) | Optional | **vipps**<br>**Default**: `Type32Enum.vipps` |

## Example (as JSON)

```json
{
  "telephoneNumber": "telephoneNumber0",
  "type": "vipps",
  "checkoutAttemptId": "checkoutAttemptId4",
  "recurringDetailReference": "recurringDetailReference8",
  "storedPaymentMethodId": "storedPaymentMethodId2"
}
```

