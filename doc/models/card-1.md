
# Card 1

## Structure

`Card1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | Secondary brand of the card. For example: **plastix**, **hmclub**. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `CupsecureplusSmscode` | `string` | Optional | - |
| `Cvc` | `string` | Optional | The card verification code. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `EncryptedCardNumber` | `string` | Optional | The encrypted card number.<br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryMonth` | `string` | Optional | The encrypted card expiry month.<br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedExpiryYear` | `string` | Optional | The encrypted card expiry year.<br>**Constraints**: *Maximum Length*: `15000` |
| `EncryptedSecurityCode` | `string` | Optional | The encrypted card verification code.<br>**Constraints**: *Maximum Length*: `15000` |
| `ExpiryMonth` | `string` | Optional | The card expiry month. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `ExpiryYear` | `string` | Optional | The card expiry year. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `HolderName` | `string` | Optional | The name of the card holder. |
| `NetworkPaymentReference` | `string` | Optional | The network token reference. This is the [`networkTxReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_additionalData-ResponseAdditionalDataCommon-networkTxReference) from the response to the first payment. |
| `Number` | `string` | Optional | The card number. Only collect raw card data if you are [fully PCI compliant](https://docs.adyen.com/development-resources/pci-dss-compliance-guide). |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `ShopperNotificationReference` | `string` | Optional | The `shopperNotificationReference` returned in the response when you requested to notify the shopper. Used only for recurring payments in India. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `ThreeDS2SdkVersion` | `string` | Optional | Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.<br>**Constraints**: *Maximum Length*: `12` |
| `Type` | [`Type9Enum?`](../../doc/models/type-9-enum.md) | Optional | Default payment method details. Common for scheme payment methods, and for simple payment method details.<br>**Default**: `Type9Enum.scheme` |

## Example (as JSON)

```json
{
  "type": "scheme",
  "brand": "brand8",
  "checkoutAttemptId": "checkoutAttemptId0",
  "cupsecureplus.smscode": "cupsecureplus.smscode2",
  "cvc": "cvc8",
  "encryptedCardNumber": "encryptedCardNumber2"
}
```

