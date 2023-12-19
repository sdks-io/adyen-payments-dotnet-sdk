
# Cancel or Refund Request

## Structure

`CancelOrRefundRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular modification request.<br><br>The additionalData object consists of entries, each of which includes the key and value. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `MpiData` | [`ThreeDSecureData`](../../doc/models/three-d-secure-data.md) | Optional | Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires). |
| `OriginalMerchantReference` | `string` | Optional | The original merchant reference to cancel. |
| `OriginalReference` | `string` | Required | The original pspReference of the payment to modify.<br>This reference is returned in:<br><br>* authorisation response<br>* authorisation notification |
| `PlatformChargebackLogic` | [`PlatformChargebackLogic`](../../doc/models/platform-chargeback-logic.md) | Optional | Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes). |
| `Reference` | `string` | Optional | Your reference for the payment modification. This reference is visible in Customer Area and in reports.<br>Maximum length: 80 characters. |
| `TenderReference` | `string` | Optional | The transaction reference provided by the PED. For point-of-sale integrations only. |
| `UniqueTerminalId` | `string` | Optional | Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData8",
    "key1": "additionalData9",
    "key2": "additionalData0"
  },
  "merchantAccount": "merchantAccount0",
  "mpiData": {
    "authenticationResponse": "U",
    "cavv": "cavv0",
    "cavvAlgorithm": "cavvAlgorithm0",
    "challengeCancel": "07",
    "directoryResponse": "U"
  },
  "originalMerchantReference": "originalMerchantReference2",
  "originalReference": "originalReference8",
  "platformChargebackLogic": {
    "behavior": "deductAccordingToSplitRatio",
    "costAllocationAccount": "costAllocationAccount8",
    "targetAccount": "targetAccount6"
  },
  "reference": "reference6"
}
```

