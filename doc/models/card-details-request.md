
# Card Details Request

## Structure

`CardDetailsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardNumber` | `string` | Required | A minimum of the first 8 digits of the card number and a maximum of the full card number. 11 digits gives the best result.<br><br>You must be [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide) to collect raw card data. |
| `CountryCode` | `string` | Optional | The shopper country.<br><br>Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)<br>Example: NL or DE |
| `EncryptedCardNumber` | `string` | Optional | The encrypted card number. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `SupportedBrands` | `List<string>` | Optional | The card brands you support. This is the [`brands`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods__resParam_paymentMethods-brands) array from your [`/paymentMethods`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods) response.<br><br>If not included, our API uses the ones configured for your merchant account and, if provided, the country code. |

## Example (as JSON)

```json
{
  "cardNumber": "cardNumber2",
  "countryCode": "countryCode8",
  "encryptedCardNumber": "encryptedCardNumber4",
  "merchantAccount": "merchantAccount8",
  "supportedBrands": [
    "supportedBrands5",
    "supportedBrands4"
  ]
}
```

