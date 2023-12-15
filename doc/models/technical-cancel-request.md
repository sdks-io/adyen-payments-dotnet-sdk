
# Technical Cancel Request

## Structure

`TechnicalCancelRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular modification request.<br><br>The additionalData object consists of entries, each of which includes the key and value. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `ModificationAmount` | [`Amount17`](../../doc/models/amount-17.md) | Optional | The amount that needs to be captured/refunded. Required for `/capture` and `/refund`, not allowed for `/cancel`. The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount. |
| `MpiData` | [`ThreeDSecureData1`](../../doc/models/three-d-secure-data-1.md) | Optional | Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires). |
| `OriginalMerchantReference` | `string` | Required | The original merchant reference to cancel. |
| `PlatformChargebackLogic` | [`PlatformChargebackLogic1`](../../doc/models/platform-chargeback-logic-1.md) | Optional | Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes). |
| `Reference` | `string` | Optional | Your reference for the payment modification. This reference is visible in Customer Area and in reports.<br>Maximum length: 80 characters. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information). |
| `TenderReference` | `string` | Optional | The transaction reference provided by the PED. For point-of-sale integrations only. |
| `UniqueTerminalId` | `string` | Optional | Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData4",
    "key1": "additionalData5",
    "key2": "additionalData6"
  },
  "merchantAccount": "merchantAccount6",
  "modificationAmount": {
    "currency": "currency6",
    "value": 92
  },
  "mpiData": {
    "authenticationResponse": "U",
    "cavv": "cavv0",
    "cavvAlgorithm": "cavvAlgorithm0",
    "challengeCancel": "07",
    "directoryResponse": "U"
  },
  "originalMerchantReference": "originalMerchantReference8",
  "platformChargebackLogic": {
    "behavior": "deductAccordingToSplitRatio",
    "costAllocationAccount": "costAllocationAccount8",
    "targetAccount": "targetAccount6"
  },
  "reference": "reference0"
}
```

