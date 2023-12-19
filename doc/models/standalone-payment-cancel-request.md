
# Standalone Payment Cancel Request

## Structure

`StandalonePaymentCancelRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `PaymentReference` | `string` | Required | The [`reference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__reqParam_reference) of the payment that you want to cancel. |
| `Reference` | `string` | Optional | Your reference for the cancel request. Maximum length: 80 characters. |

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
  "paymentReference": "paymentReference2",
  "reference": "reference2"
}
```

