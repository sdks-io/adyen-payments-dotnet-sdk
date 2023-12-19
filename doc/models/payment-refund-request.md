
# Payment Refund Request

## Structure

`PaymentRefundRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount33`](../../doc/models/amount-33.md) | Required | The amount that you want to refund. The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount. |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).<br><br>> This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `MerchantRefundReason` | [`MerchantRefundReasonEnum?`](../../doc/models/merchant-refund-reason-enum.md) | Optional | Your reason for the refund request |
| `Reference` | `string` | Optional | Your reference for the refund request. Maximum length: 80 characters. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information). |
| `Store` | `string` | Optional | The online store or [physical store](https://docs.adyen.com/point-of-sale/design-your-integration/determine-account-structure/#create-stores) that is processing the refund. This must be the same as the store name configured in your Customer Area.  Otherwise, you get an error and the refund fails. |

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
  "merchantRefundReason": "DUPLICATE",
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

