
# Ratepay

## Structure

`Ratepay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | `string` | Optional | The address where to send the invoice. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `DeliveryAddress` | `string` | Optional | The address where the goods should be delivered. |
| `PersonalDetails` | `string` | Optional | Shopper name, date of birth, phone number, and email address. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type28Enum`](../../doc/models/type-28-enum.md) | Required | **ratepay**<br>**Default**: `Type28Enum.ratepay` |

## Example (as JSON)

```json
{
  "type": "ratepay",
  "billingAddress": "billingAddress6",
  "checkoutAttemptId": "checkoutAttemptId4",
  "deliveryAddress": "deliveryAddress4",
  "personalDetails": "personalDetails6",
  "recurringDetailReference": "recurringDetailReference8"
}
```

