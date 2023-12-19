
# Payment Amount Update Request

## Structure

`PaymentAmountUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount25`](../../doc/models/amount-25.md) | Required | The updated amount. The `currency` must match the currency used in authorisation. |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `IndustryUsage` | [`IndustryUsage1Enum?`](../../doc/models/industry-usage-1-enum.md) | Optional | The reason for the amount update. Possible values:<br><br>* **delayedCharge**<br>* **noShow**<br>* **installment** |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).<br><br>> This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `Reference` | `string` | Optional | Your reference for the amount update request. Maximum length: 80 characters. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information). |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
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
  "industryUsage": "installment",
  "lineItems": [
    {
      "amountExcludingTax": 38,
      "amountIncludingTax": 148,
      "brand": "brand6",
      "color": "color6",
      "description": "description2"
    },
    {
      "amountExcludingTax": 38,
      "amountIncludingTax": 148,
      "brand": "brand6",
      "color": "color6",
      "description": "description2"
    }
  ],
  "merchantAccount": "merchantAccount0",
  "reference": "reference6",
  "splits": [
    {
      "account": "account2",
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description2",
      "reference": "reference2",
      "type": "Commission"
    },
    {
      "account": "account2",
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description2",
      "reference": "reference2",
      "type": "Commission"
    },
    {
      "account": "account2",
      "amount": {
        "currency": "currency2",
        "value": 110
      },
      "description": "description2",
      "reference": "reference2",
      "type": "Commission"
    }
  ]
}
```

