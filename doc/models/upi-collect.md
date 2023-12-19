
# UPI Collect

## Structure

`UPICollect`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingSequenceNumber` | `string` | Required | The sequence number for the debit. For example, send **2** if this is the second debit for the subscription. The sequence number is included in the notification sent to the shopper. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used for recurring payment only. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | `string` | Required, Constant | **upi_collect**<br>**Default**: `"upi_collect"` |
| `VirtualPaymentAddress` | `string` | Optional | The virtual payment address for UPI. |

## Example (as JSON)

```json
{
  "billingSequenceNumber": "billingSequenceNumber8",
  "type": "upi_collect",
  "checkoutAttemptId": "checkoutAttemptId4",
  "recurringDetailReference": "recurringDetailReference8",
  "shopperNotificationReference": "shopperNotificationReference8",
  "storedPaymentMethodId": "storedPaymentMethodId2",
  "virtualPaymentAddress": "virtualPaymentAddress4"
}
```

