
# Pay Pal

## Structure

`PayPal`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `OrderID` | `string` | Optional | The unique ID associated with the order. |
| `PayeePreferred` | `string` | Optional | IMMEDIATE_PAYMENT_REQUIRED or UNRESTRICTED |
| `PayerID` | `string` | Optional | The unique ID associated with the payer. |
| `PayerSelected` | `string` | Optional | PAYPAL or PAYPAL_CREDIT |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Subtype` | [`SubtypeEnum?`](../../doc/models/subtype-enum.md) | Optional | The type of flow to initiate. |
| `Type` | `string` | Required, Constant | **paypal**<br>**Default**: `"paypal"` |

## Example (as JSON)

```json
{
  "type": "paypal",
  "checkoutAttemptId": "checkoutAttemptId2",
  "orderID": "orderID0",
  "payeePreferred": "payeePreferred6",
  "payerID": "payerID2",
  "payerSelected": "payerSelected2"
}
```

