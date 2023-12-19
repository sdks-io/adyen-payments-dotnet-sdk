
# Donation Request

## Structure

`DonationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DonationAccount` | `string` | Required | The Adyen account name of the charity. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `ModificationAmount` | [`Amount`](../../doc/models/amount.md) | Required | The amount to be donated.The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount. |
| `OriginalReference` | `string` | Optional | The original pspReference of the payment to modify.<br>This reference is returned in:<br><br>* authorisation response<br>* authorisation notification |
| `PlatformChargebackLogic` | [`PlatformChargebackLogic`](../../doc/models/platform-chargeback-logic.md) | Optional | Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes). |
| `Reference` | `string` | Optional | Your reference for the payment modification. This reference is visible in Customer Area and in reports.<br>Maximum length: 80 characters. |

## Example (as JSON)

```json
{
  "donationAccount": "donationAccount6",
  "merchantAccount": "merchantAccount4",
  "modificationAmount": {
    "currency": "currency6",
    "value": 92
  },
  "originalReference": "originalReference4",
  "platformChargebackLogic": {
    "behavior": "deductAccordingToSplitRatio",
    "costAllocationAccount": "costAllocationAccount8",
    "targetAccount": "targetAccount6"
  },
  "reference": "reference2"
}
```

