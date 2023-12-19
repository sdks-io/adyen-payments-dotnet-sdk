
# UPI Intent

## Structure

`UPIIntent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **upi_intent**<br>**Default**: `"upi_intent"` |

## Example (as JSON)

```json
{
  "type": "upi_intent",
  "checkoutAttemptId": "checkoutAttemptId2",
  "recurringDetailReference": "recurringDetailReference6",
  "shopperNotificationReference": "shopperNotificationReference6",
  "storedPaymentMethodId": "storedPaymentMethodId0"
}
```

