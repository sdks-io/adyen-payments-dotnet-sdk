
# SEPA Direct Debit

## Structure

`SEPADirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Iban` | `string` | Required | The International Bank Account Number (IBAN). |
| `OwnerName` | `string` | Required | The name of the bank account holder. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type30Enum?`](../../doc/models/type-30-enum.md) | Optional | **sepadirectdebit**<br>**Default**: `Type30Enum.sepadirectdebit` |

## Example (as JSON)

```json
{
  "iban": "iban4",
  "ownerName": "ownerName4",
  "type": "sepadirectdebit",
  "checkoutAttemptId": "checkoutAttemptId6",
  "recurringDetailReference": "recurringDetailReference0",
  "storedPaymentMethodId": "storedPaymentMethodId4"
}
```

