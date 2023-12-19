
# Payment Reversal Request

## Structure

`PaymentReversalRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `Reference` | `string` | Optional | Your reference for the reversal request. Maximum length: 80 characters. |

## Example (as JSON)

```json
{
  "applicationInfo": {
    "adyenLibrary": {
      "name": "name8",
      "version": "version4"
    },
    "adyenPaymentSource": {
      "name": "name2",
      "version": "version8"
    },
    "externalPlatform": {
      "integrator": "integrator0",
      "name": "name4",
      "version": "version0"
    },
    "merchantApplication": {
      "name": "name2",
      "version": "version8"
    },
    "merchantDevice": {
      "os": "os4",
      "osVersion": "osVersion6",
      "reference": "reference8"
    }
  },
  "merchantAccount": "merchantAccount4",
  "reference": "reference2"
}
```

