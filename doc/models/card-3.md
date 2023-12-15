
# Card 3

A container for card data.

> Either `bankAccount` or `card` field must be provided in a payment request.

## Structure

`Card3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cvc` | `string` | Optional | The [card verification code](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid) (1-20 characters). Depending on the card brand, it is known also as:<br><br>* CVV2/CVC2 – length: 3 digits<br>* CID – length: 4 digits<br><br>> If you are using [Client-Side Encryption](https://docs.adyen.com/classic-integration/cse-integration-ecommerce), the CVC code is present in the encrypted data. You must never post the card details to the server.<br>> This field must be always present in a [one-click payment request](https://docs.adyen.com/classic-integration/recurring-payments).<br>> When this value is returned in a response, it is always empty because it is not stored.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `20` |
| `ExpiryMonth` | `string` | Optional | The card expiry month.<br>Format: 2 digits, zero-padded for single digits. For example:<br><br>* 03 = March<br>* 11 = November<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2` |
| `ExpiryYear` | `string` | Optional | The card expiry year.<br>Format: 4 digits. For example: 2020<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4` |
| `HolderName` | `string` | Optional | The name of the cardholder, as printed on the card.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `IssueNumber` | `string` | Optional | The issue number of the card (for some UK debit cards only).<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2` |
| `Number` | `string` | Optional | The card number (4-19 characters). Do not use any separators.<br>When this value is returned in a response, only the last 4 digits of the card number are returned.<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `19` |
| `StartMonth` | `string` | Optional | The month component of the start date (for some UK debit cards only).<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2` |
| `StartYear` | `string` | Optional | The year component of the start date (for some UK debit cards only).<br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4` |

## Example (as JSON)

```json
{
  "cvc": "cvc8",
  "expiryMonth": "expiryMonth8",
  "expiryYear": "expiryYear2",
  "holderName": "holderName0",
  "issueNumber": "issueNumber4"
}
```

