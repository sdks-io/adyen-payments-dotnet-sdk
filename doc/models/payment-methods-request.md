
# Payment Methods Request

## Structure

`PaymentMethodsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular payment request.<br><br>The `additionalData` object consists of entries, each of which includes the key and value. |
| `AllowedPaymentMethods` | `List<string>` | Optional | List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"allowedPaymentMethods":["ideal","giropay"]` |
| `Amount` | [`Amount2`](../../doc/models/amount-2.md) | Optional | The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero). |
| `BlockedPaymentMethods` | `List<string>` | Optional | List of payment methods to be hidden from the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"blockedPaymentMethods":["ideal","giropay"]` |
| `Channel` | [`Channel3Enum?`](../../doc/models/channel-3-enum.md) | Optional | The platform where a payment transaction takes place. This field can be used for filtering out payment methods that are only available on specific platforms. Possible values:<br><br>* iOS<br>* Android<br>* Web |
| `CountryCode` | `string` | Optional | The shopper's country code. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `Order` | [`EncryptedOrderData2`](../../doc/models/encrypted-order-data-2.md) | Optional | The order information required for partial payments. |
| `ShopperLocale` | `string` | Optional | The combination of a language code and a country code to specify the language to be used in the payment. |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `SplitCardFundingSources` | `bool?` | Optional | Boolean value indicating whether the card payment method should be split into separate debit and credit options.<br>**Default**: `false` |
| `Store` | `string` | Optional | The ecommerce or point-of-sale store that is processing the payment. Used in:<br><br>* [Partner platform integrations](https://docs.adyen.com/marketplaces-and-platforms/classic/platforms-for-partners#route-payments) for the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).<br>* [Platform setup integrations](https://docs.adyen.com/marketplaces-and-platforms/additional-for-platform-setup/route-payment-to-store) for the [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms).<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16` |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount2",
  "splitCardFundingSources": false,
  "additionalData": {
    "key0": "additionalData4",
    "key1": "additionalData3"
  },
  "allowedPaymentMethods": [
    "allowedPaymentMethods1",
    "allowedPaymentMethods2"
  ],
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "blockedPaymentMethods": [
    "blockedPaymentMethods6",
    "blockedPaymentMethods7",
    "blockedPaymentMethods8"
  ],
  "channel": "Web"
}
```

