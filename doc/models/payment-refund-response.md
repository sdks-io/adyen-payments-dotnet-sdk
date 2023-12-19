
# Payment Refund Response

## Structure

`PaymentRefundResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount34`](../../doc/models/amount-34.md) | Required | The refund amount. |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).<br><br>> This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account that is used to process the payment. |
| `MerchantRefundReason` | [`MerchantRefundReason1Enum?`](../../doc/models/merchant-refund-reason-1-enum.md) | Optional | Your reason for the refund request. |
| `PaymentPspReference` | `string` | Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment to refund. |
| `PspReference` | `string` | Required | Adyen's 16-character reference associated with the refund request. |
| `Reference` | `string` | Optional | Your reference for the refund request. |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information). |
| `Status` | `string` | Required, Constant | The status of your request. This will always have the value **received**.<br>**Default**: `"received"` |
| `Store` | `string` | Optional | The online store or [physical store](https://docs.adyen.com/point-of-sale/design-your-integration/determine-account-structure/#create-stores) that is processing the refund. This must be the same as the store name configured in your Customer Area.  Otherwise, you get an error and the refund fails. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "merchantAccount": "merchantAccount8",
  "paymentPspReference": "paymentPspReference4",
  "pspReference": "pspReference8",
  "status": "received",
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
    },
    {
      "amountExcludingTax": 38,
      "amountIncludingTax": 148,
      "brand": "brand6",
      "color": "color6",
      "description": "description2"
    }
  ],
  "merchantRefundReason": "CUSTOMER REQUEST",
  "reference": "reference2",
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
  ],
  "store": "store6"
}
```

