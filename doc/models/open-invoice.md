
# Open Invoice

## Structure

`OpenInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | `string` | Optional | The address where to send the invoice. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `DeliveryAddress` | `string` | Optional | The address where the goods should be delivered. |
| `PersonalDetails` | `string` | Optional | Shopper name, date of birth, phone number, and email address. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type26Enum?`](../../doc/models/type-26-enum.md) | Optional | **openinvoice**<br>**Default**: `Type26Enum.openinvoice` |

## Example (as JSON)

```json
{
  "type": "openinvoice",
  "billingAddress": "billingAddress2",
  "checkoutAttemptId": "checkoutAttemptId0",
  "deliveryAddress": "deliveryAddress0",
  "personalDetails": "personalDetails2",
  "recurringDetailReference": "recurringDetailReference4"
}
```

