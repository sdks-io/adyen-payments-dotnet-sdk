
# ACH Direct Debit

## Structure

`ACHDirectDebit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BankAccountNumber` | `string` | Required | The bank account number (without separators). |
| `BankAccountType` | [`BankAccountTypeEnum?`](../../doc/models/bank-account-type-enum.md) | Optional | The bank account type (checking, savings...). |
| `BankLocationId` | `string` | Optional | The bank routing number of the account. The field value is `nil` in most cases. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `EncryptedBankAccountNumber` | `string` | Optional | Encrypted bank account number. The bank account number (without separators). |
| `EncryptedBankLocationId` | `string` | Optional | Encrypted location id. The bank routing number of the account. The field value is `nil` in most cases. |
| `OwnerName` | `string` | Optional | The name of the bank account holder.<br>If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:<br><br>* χ12 is converted to ch12.<br>* üA is converted to euA.<br>* Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.<br>  After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:<br>* John17 - allowed.<br>* J17 - allowed.<br>* 171 - not allowed.<br>* John-7 - allowed.<br><br>> If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`TypeEnum?`](../../doc/models/type-enum.md) | Optional | **ach**<br>**Default**: `TypeEnum.ach` |

## Example (as JSON)

```json
{
  "bankAccountNumber": "bankAccountNumber8",
  "type": "ach",
  "bankAccountType": "checking",
  "bankLocationId": "bankLocationId2",
  "checkoutAttemptId": "checkoutAttemptId4",
  "encryptedBankAccountNumber": "encryptedBankAccountNumber4",
  "encryptedBankLocationId": "encryptedBankLocationId0"
}
```

