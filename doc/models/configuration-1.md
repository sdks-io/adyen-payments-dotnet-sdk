
# Configuration 1

Specify configurations to enable additional features.

## Structure

`Configuration1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Avs` | [`Avs1`](../../doc/models/avs-1.md) | Optional | Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System)). |
| `CardHolderName` | [`CardHolderNameEnum?`](../../doc/models/card-holder-name-enum.md) | Optional | Determines whether the cardholder name should be provided or not.<br><br>Permitted values:<br><br>* NONE<br>* OPTIONAL<br>* REQUIRED |
| `Installments` | [`InstallmentsNumber2`](../../doc/models/installments-number-2.md) | Optional | Describes the configuration for [installment payments](https://docs.adyen.com/payment-methods/cards/credit-card-installments). |
| `ShopperInput` | [`ShopperInput2`](../../doc/models/shopper-input-2.md) | Optional | Determines how to display the details fields. |

## Example (as JSON)

```json
{
  "avs": {
    "addressEditable": false,
    "enabled": "yes"
  },
  "cardHolderName": "OPTIONAL",
  "installments": {
    "maxNumberOfInstallments": 48
  },
  "shopperInput": {
    "billingAddress": "editable",
    "deliveryAddress": "readOnly",
    "personalDetails": "hidden"
  }
}
```

