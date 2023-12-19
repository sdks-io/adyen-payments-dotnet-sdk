
# Stored Details 2

Contains information on previously stored payment details.

## Structure

`StoredDetails2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Bank` | [`BankAccount1`](../../doc/models/bank-account-1.md) | Optional | The stored bank account. |
| `Card` | [`Card3`](../../doc/models/card-3.md) | Optional | The stored card information. |
| `EmailAddress` | `string` | Optional | The email associated with stored payment details. |

## Example (as JSON)

```json
{
  "bank": {
    "bankAccountNumber": "bankAccountNumber8",
    "bankCity": "bankCity0",
    "bankLocationId": "bankLocationId2",
    "bankName": "bankName4",
    "bic": "bic0"
  },
  "card": {
    "cvc": "cvc0",
    "expiryMonth": "expiryMonth0",
    "expiryYear": "expiryYear0",
    "holderName": "holderName2",
    "issueNumber": "issueNumber8"
  },
  "emailAddress": "emailAddress8"
}
```

