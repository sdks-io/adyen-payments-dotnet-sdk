
# BACS Direct Debit

## Structure

`BACSDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountNumber` | `string` | Optional | The bank account number (without separators). |
| `BankLocationId` | `string` | Optional | The bank routing number of the account. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `HolderName` | `string` | Optional | The name of the bank account holder. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type5Enum?`](../../doc/models/type-5-enum.md) | Optional | **directdebit_GB**<br>**Default**: `Type5Enum.directdebit_GB` |

## Example (as JSON)

```json
{
  "type": "directdebit_GB",
  "bankAccountNumber": "bankAccountNumber8",
  "bankLocationId": "bankLocationId2",
  "checkoutAttemptId": "checkoutAttemptId4",
  "holderName": "holderName4",
  "recurringDetailReference": "recurringDetailReference8"
}
```

