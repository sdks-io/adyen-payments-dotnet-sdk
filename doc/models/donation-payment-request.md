
# Donation Payment Request

## Structure

`DonationPaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountInfo` | [`AccountInfo`](../../doc/models/account-info.md) | Optional | Shopper account information for 3D Secure 2.<br><br>> For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow. |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular payment request.<br><br>The `additionalData` object consists of entries, each of which includes the key and value. |
| `Amount` | [`Amount2`](../../doc/models/amount-2.md) | Required | The amount information for the transaction (in [minor units](https://docs.adyen.com/development-resources/currency-codes)). For [BIN or card verification](https://docs.adyen.com/payment-methods/cards/bin-data-and-card-verification) requests, set amount to 0 (zero). |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `AuthenticationData` | [`AuthenticationData3`](../../doc/models/authentication-data-3.md) | Optional | Data for 3DS authentication. |
| `BillingAddress` | [`BillingAddress4`](../../doc/models/billing-address-4.md) | Optional | The address where to send the invoice.<br><br>> The `billingAddress` object is required in the following scenarios. Include all of the fields within this object.<br>> <br>> * For 3D Secure 2 transactions in all browser-based and mobile implementations.<br>> * For cross-border payouts to and from Canada. |
| `BrowserInfo` | [`BrowserInfo`](../../doc/models/browser-info.md) | Optional | The shopper's browser information.<br><br>> For 3D Secure, the full object is required for web integrations. For mobile app integrations, include the `userAgent` and `acceptHeader` fields to indicate  that your integration can support a redirect in case a payment is routed to 3D Secure 1. |
| `Channel` | [`Channel2Enum?`](../../doc/models/channel-2-enum.md) | Optional | The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the `sdkVersion` or `token`.<br><br>Possible values:<br><br>* iOS<br>* Android<br>* Web |
| `CheckoutAttemptId` | `string` | Optional | Checkout attempt ID that corresponds to the Id generated by the client SDK for tracking user payment journey. |
| `ConversionId` | `string` | Optional | Conversion ID that corresponds to the Id generated by the client SDK for tracking user payment journey. |
| `CountryCode` | `string` | Optional | The shopper country.<br><br>Format: [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)<br>Example: NL or DE |
| `DateOfBirth` | `DateTime?` | Optional | The shopper's date of birth.<br><br>Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD |
| `DeliverAt` | `DateTime?` | Optional | The date and time the purchased goods should be delivered.<br><br>Format [ISO 8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DDThh:mm:ss.sssTZD<br><br>Example: 2017-07-17T13:42:40.428+01:00 |
| `DeliveryAddress` | [`DeliveryAddress1`](../../doc/models/delivery-address-1.md) | Optional | The address where the purchased goods should be delivered. |
| `DeviceFingerprint` | `string` | Optional | A string containing the shopper's device fingerprint. For more information, refer to [Device fingerprinting](https://docs.adyen.com/risk-management/device-fingerprinting).<br>**Constraints**: *Maximum Length*: `5000` |
| `DonationAccount` | `string` | Optional | Donation account to which the transaction is credited. |
| `DonationOriginalPspReference` | `string` | Optional | PSP reference of the transaction from which the donation token is generated. Required when `donationToken` is provided. |
| `DonationToken` | `string` | Optional | Donation token received in the `/payments` call. |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information about the purchased items, to be included on the invoice sent to the shopper.<br><br>> This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `MerchantRiskIndicator` | [`MerchantRiskIndicator1`](../../doc/models/merchant-risk-indicator-1.md) | Optional | Additional risk fields for 3D Secure 2.<br><br>> For 3D Secure 2 transactions, we recommend that you include this object to increase the chances of achieving a frictionless flow. |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata consists of entries, each of which includes a key and a value.<br>Limits:<br><br>* Maximum 20 key-value pairs per request. When exceeding, the "177" error occurs: "Metadata size exceeds limit".<br>* Maximum 20 characters per key.<br>* Maximum 80 characters per value. |
| `MpiData` | [`ThreeDSecureData`](../../doc/models/three-d-secure-data.md) | Optional | Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires). |
| `Origin` | `string` | Optional | Required for the 3D Secure 2 `channel` **Web** integration.<br><br>Set this parameter to the origin URL of the page that you are loading the 3D Secure Component from.<br>**Constraints**: *Maximum Length*: `80` |
| `PaymentMethod` | [`DonationPaymentRequestPaymentMethod`](../../doc/models/containers/donation-payment-request-payment-method.md) | Required | This is a container for one-of cases. |
| `RecurringProcessingModel` | [`RecurringProcessingModelEnum?`](../../doc/models/recurring-processing-model-enum.md) | Optional | Defines a recurring payment type. Required when creating a token to store payment details or using stored payment details.<br>Allowed values:<br><br>* `Subscription` – A transaction for a fixed or variable amount, which follows a fixed schedule.<br>* `CardOnFile` – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.<br>* `UnscheduledCardOnFile` – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. |
| `RedirectFromIssuerMethod` | `string` | Optional | Specifies the redirect method (GET or POST) when redirecting back from the issuer. |
| `RedirectToIssuerMethod` | `string` | Optional | Specifies the redirect method (GET or POST) when redirecting to the issuer. |
| `Reference` | `string` | Required | The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.<br>If you need to provide multiple references for a transaction, separate them with hyphens ("-").<br>Maximum length: 80 characters. |
| `ReturnUrl` | `string` | Required | The URL to return to in case of a redirection.<br>The format depends on the channel. This URL can have a maximum of 1024 characters.<br><br>* For web, include the protocol `http://` or `https://`. You can also include your own additional query parameters, for example, shopper ID or order reference number.<br>  Example: `https://your-company.com/checkout?shopperOrder=12xy`<br>* For iOS, use the custom URL for your app. To know more about setting custom URL schemes, refer to the [Apple Developer documentation](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app).<br>  Example: `my-app://`<br>* For Android, use a custom URL handled by an Activity on your app. You can configure it with an [intent filter](https://developer.android.com/guide/components/intents-filters).<br>  Example: `my-app://your.package.name`<br>**Constraints**: *Maximum Length*: `8000` |
| `SessionValidity` | `string` | Optional | The date and time until when the session remains valid, in [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.<br><br>For example: 2020-07-18T15:42:40.428+01:00 |
| `ShopperEmail` | `string` | Optional | The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks.<br><br>> For 3D Secure 2 transactions, schemes require `shopperEmail` for all browser-based and mobile implementations. |
| `ShopperIP` | `string` | Optional | The shopper's IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks).<br><br>> For 3D Secure 2 transactions, schemes require `shopperIP` for all browser-based implementations.<br>> This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://www.adyen.help/hc/en-us/requests/new). |
| `ShopperInteraction` | [`ShopperInteractionEnum?`](../../doc/models/shopper-interaction-enum.md) | Optional | Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.<br>For the web service API, Adyen assumes Ecommerce shopper interaction by default.<br><br>This field has the following possible values:<br><br>* `Ecommerce` - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.<br>* `ContAuth` - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).<br>* `Moto` - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.<br>* `POS` - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal. |
| `ShopperLocale` | `string` | Optional | The combination of a language code and a country code to specify the language to be used in the payment. |
| `ShopperName` | [`Name5`](../../doc/models/name-5.md) | Optional | The shopper's full name. |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `256` |
| `SocialSecurityNumber` | `string` | Optional | The shopper's social security number. |
| `TelephoneNumber` | `string` | Optional | The shopper's telephone number. |
| `ThreeDS2RequestData` | [`ThreeDS2RequestFields1`](../../doc/models/three-ds2-request-fields-1.md) | Optional | Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to [Online payments](https://docs.adyen.com/online-payments) or [Classic integration](https://docs.adyen.com/classic-integration) documentation. |
| `ThreeDSAuthenticationOnly` | `bool?` | Optional | If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.<br>**Default**: `false` |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "merchantAccount": "merchantAccount2",
  "paymentMethod": {
    "applePayToken": "applePayToken6",
    "type": "applepay",
    "checkoutAttemptId": "checkoutAttemptId0",
    "fundingSource": "credit",
    "recurringDetailReference": "recurringDetailReference4",
    "storedPaymentMethodId": "storedPaymentMethodId8"
  },
  "reference": "reference6",
  "returnUrl": "returnUrl8",
  "threeDSAuthenticationOnly": false,
  "accountInfo": {
    "accountAgeIndicator": "from30To60Days",
    "accountChangeDate": "2016-03-13T12:52:32.123Z",
    "accountChangeIndicator": "thisTransaction",
    "accountCreationDate": "2016-03-13T12:52:32.123Z",
    "accountType": "notApplicable"
  },
  "additionalData": {
    "key0": "additionalData0",
    "key1": "additionalData1"
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
  "authenticationData": {
    "attemptAuthentication": "always",
    "authenticationOnly": false,
    "threeDSRequestData": {
      "challengeWindowSize": "03",
      "dataOnly": "false",
      "nativeThreeDS": "preferred",
      "threeDSVersion": "2.1.0"
    }
  },
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  }
}
```
