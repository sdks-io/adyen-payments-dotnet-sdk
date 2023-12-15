
# Payout Request

## Structure

`PayoutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Required | The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero). |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The address where to send the invoice.<br><br>> The `billingAddress` object is required in the following scenarios. Include all of the fields within this object.<br>> <br>> * For 3D Secure 2 transactions in all browser-based and mobile implementations.<br>> * For cross-border payouts to and from Canada. |
| `Card` | [`Card`](../../doc/models/card.md) | Optional | A container for card data.<br><br>> Either `bankAccount` or `card` field must be provided in a payment request. |
| `FraudOffset` | `int?` | Optional | An integer value that is added to the normal fraud score. The value can be either positive or negative. |
| `FundSource` | [`FundSource11`](../../doc/models/fund-source-11.md) | Optional | The person or entity funding the money. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `Recurring` | [`Recurring`](../../doc/models/recurring.md) | Optional | The recurring settings for the payment. Use this property when you want to enable [recurring payments](https://docs.adyen.com/classic-integration/recurring-payments). |
| `Reference` | `string` | Required | The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.<br>If you need to provide multiple references for a transaction, separate them with hyphens ("-").<br>Maximum length: 80 characters. |
| `SelectedRecurringDetailReference` | `string` | Optional | The `recurringDetailReference` you want to use for this payment. The value `LATEST` can be used to select the most recently stored recurring detail. |
| `ShopperEmail` | `string` | Optional | The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks.<br><br>> For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations. |
| `ShopperInteraction` | [`ShopperInteractionEnum?`](../../doc/models/shopper-interaction-enum.md) | Optional | Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.<br>For the web service API, Adyen assumes Ecommerce shopper interaction by default.<br><br>This field has the following possible values:<br><br>* `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.<br>* `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).<br>* `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.<br>* `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal. |
| `ShopperName` | [`Name`](../../doc/models/name.md) | Optional | The shopper's full name. |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `TelephoneNumber` | `string` | Optional | The shopper's telephone number. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "card": {
    "cvc": "cvc0",
    "expiryMonth": "expiryMonth0",
    "expiryYear": "expiryYear0",
    "holderName": "holderName2",
    "issueNumber": "issueNumber8"
  },
  "fraudOffset": 86,
  "fundSource": {
    "additionalData": {
      "key0": "additionalData8"
    },
    "billingAddress": {
      "city": "city8",
      "country": "country6",
      "houseNumberOrName": "houseNumberOrName0",
      "postalCode": "postalCode6",
      "stateOrProvince": "stateOrProvince0",
      "street": "street2"
    },
    "card": {
      "cvc": "cvc0",
      "expiryMonth": "expiryMonth0",
      "expiryYear": "expiryYear0",
      "holderName": "holderName2",
      "issueNumber": "issueNumber8"
    },
    "shopperEmail": "shopperEmail4",
    "shopperName": {
      "firstName": "firstName2",
      "lastName": "lastName6"
    }
  },
  "merchantAccount": "merchantAccount6",
  "recurring": {
    "contract": "RECURRING",
    "recurringDetailName": "recurringDetailName2",
    "recurringExpiry": "2016-03-13T12:52:32.123Z",
    "recurringFrequency": "recurringFrequency0",
    "tokenService": "VISATOKENSERVICE"
  },
  "reference": "reference0"
}
```

