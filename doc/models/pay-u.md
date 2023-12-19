
# Pay U

## Structure

`PayU`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **payu_IN_upi**<br>**Default**: `"payu_IN_upi"` |
| `VirtualPaymentAddress` | `string` | Optional | The virtual payment address for UPI. |

## Example (as JSON)

```json
{
  "type": "payu_IN_upi",
  "checkoutAttemptId": "checkoutAttemptId8",
  "recurringDetailReference": "recurringDetailReference2",
  "shopperNotificationReference": "shopperNotificationReference2",
  "storedPaymentMethodId": "storedPaymentMethodId6",
  "virtualPaymentAddress": "virtualPaymentAddress8"
}
```

