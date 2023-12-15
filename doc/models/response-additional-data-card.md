
# Response Additional Data Card

## Structure

`ResponseAdditionalDataCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardBin` | `string` | Optional | The first six digits of the card number.<br><br>This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with a six-digit BIN.<br><br>Example: 521234 |
| `CardHolderName` | `string` | Optional | The cardholder name passed in the payment request. |
| `CardIssuingBank` | `string` | Optional | The bank or the financial institution granting lines of credit through card association branded payment cards. This information can be included when available. |
| `CardIssuingCountry` | `string` | Optional | The country where the card was issued.<br><br>Example: US |
| `CardIssuingCurrency` | `string` | Optional | The currency in which the card is issued, if this information is available. Provided as the currency code or currency number from the ISO-4217 standard.<br><br>Example: USD |
| `CardPaymentMethod` | `string` | Optional | The card payment method used for the transaction.<br><br>Example: amex |
| `CardSummary` | `string` | Optional | The last four digits of a card number.<br><br>> Returned only in case of a card payment. |
| `IssuerBin` | `string` | Optional | The first eight digits of the card number. Only returned if the card number is 16 digits or more.<br><br>This is the [Bank Identification Number (BIN)](https://docs.adyen.com/get-started-with-adyen/payment-glossary#bank-identification-number-bin) for card numbers with an eight-digit BIN.<br><br>Example: 52123423 |

## Example (as JSON)

```json
{
  "cardBin": "cardBin4",
  "cardHolderName": "cardHolderName2",
  "cardIssuingBank": "cardIssuingBank4",
  "cardIssuingCountry": "cardIssuingCountry4",
  "cardIssuingCurrency": "cardIssuingCurrency2"
}
```

