
# Payment Link Response

## Structure

`PaymentLinkResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowedPaymentMethods` | `List<string>` | Optional | List of payment methods to be presented to the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"allowedPaymentMethods":["ideal","giropay"]` |
| `Amount` | [`Amount30`](../../doc/models/amount-30.md) | Required | The payment amount and currency. |
| `ApplicationInfo` | [`ApplicationInfo`](../../doc/models/application-info.md) | Optional | Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions). |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The address where to send the invoice. |
| `BlockedPaymentMethods` | `List<string>` | Optional | List of payment methods to be hidden from the shopper. To refer to payment methods, use their [payment method type](https://docs.adyen.com/payment-methods/payment-method-types).<br><br>Example: `"blockedPaymentMethods":["ideal","giropay"]` |
| `CaptureDelayHours` | `int?` | Optional | The delay between the authorisation and scheduled auto-capture, specified in hours. |
| `CountryCode` | `string` | Optional | The shopper's two-letter country code. |
| `DateOfBirth` | `DateTime?` | Optional | The shopper's date of birth.<br><br>Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD |
| `DeliverAt` | `DateTime?` | Optional | The date and time when the purchased goods should be delivered.<br><br>[ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**. |
| `DeliveryAddress` | [`Address2`](../../doc/models/address-2.md) | Optional | The address where the purchased goods should be delivered. |
| `Description` | `string` | Optional | A short description visible on the payment page.<br>Maximum length: 280 characters. |
| `ExpiresAt` | `DateTime?` | Optional | The date when the payment link expires.<br><br>[ISO 8601](https://www.w3.org/TR/NOTE-datetime) format with time zone offset: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**.<br><br>The maximum expiry date is 70 days after the payment link is created.<br><br>If not provided, the payment link expires 24 hours after it was created. |
| `Id` | `string` | Required | A unique identifier of the payment link. |
| `InstallmentOptions` | [`Dictionary<string, InstallmentOption>`](../../doc/models/installment-option.md) | Optional | A set of key-value pairs that specifies the installment options available per payment method. The key must be a payment method name in lowercase. For example, **card** to specify installment options for all cards, or **visa** or **mc**. The value must be an object containing the installment options. |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information about the purchased items, to be included on the invoice sent to the shopper.<br>This parameter is required for open invoice (_buy now, pay later_) payment methods such Afterpay, Clearpay, Klarna, RatePay, and Zip. |
| `ManualCapture` | `bool?` | Optional | Indicates if the payment must be [captured manually](https://docs.adyen.com/online-payments/capture). |
| `Mcc` | `string` | Optional | The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant. |
| `MerchantAccount` | `string` | Required | The merchant account identifier for which the payment link is created. |
| `MerchantOrderReference` | `string` | Optional | This reference allows linking multiple transactions to each other for reporting purposes (for example, order auth-rate). The reference should be unique per billing cycle. |
| `Metadata` | `Dictionary<string, string>` | Optional | Metadata consists of entries, each of which includes a key and a value.<br>Limitations:<br><br>* Maximum 20 key-value pairs per request. Otherwise, error "177" occurs: "Metadata size exceeds limit"<br>* Maximum 20 characters per key. Otherwise, error "178" occurs: "Metadata key size exceeds limit"<br>* A key cannot have the name `checkout.linkId`. Any value that you provide with this key is going to be replaced by the real payment link ID. |
| `RecurringProcessingModel` | [`RecurringProcessingModel4Enum?`](../../doc/models/recurring-processing-model-4-enum.md) | Optional | Defines a recurring payment type. Required when `storePaymentMethodMode` is set to **askForConsent** or **enabled**.<br>Possible values:<br><br>* **Subscription** – A transaction for a fixed or variable amount, which follows a fixed schedule.<br>* **CardOnFile** – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction.<br>* **UnscheduledCardOnFile** – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or has variable amounts. For example, automatic top-ups when a cardholder's balance drops below a certain amount. |
| `Reference` | `string` | Required | A reference that is used to uniquely identify the payment in future communications about the payment status. |
| `RequiredShopperFields` | [`List<RequiredShopperFieldEnum>`](../../doc/models/required-shopper-field-enum.md) | Optional | List of fields that the shopper has to provide on the payment page before completing the payment. For more information, refer to [Provide shopper information](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#shopper-information).<br><br>Possible values:<br><br>* **billingAddress** – The address where to send the invoice.<br>* **deliveryAddress** – The address where the purchased goods should be delivered.<br>* **shopperEmail** – The shopper's email address.<br>* **shopperName** – The shopper's full name.<br>* **telephoneNumber** – The shopper's phone number. |
| `ReturnUrl` | `string` | Optional | Website URL used for redirection after payment is completed.<br>If provided, a **Continue** button will be shown on the payment page. If shoppers select the button, they are redirected to the specified URL. |
| `Reusable` | `bool?` | Optional | Indicates whether the payment link can be reused for multiple payments. If not provided, this defaults to **false** which means the link can be used for one successful payment only. |
| `RiskData` | [`RiskData1`](../../doc/models/risk-data-1.md) | Optional | Any risk-related settings to apply to the payment. |
| `ShopperEmail` | `string` | Optional | The shopper's email address. |
| `ShopperLocale` | `string` | Optional | The language to be used in the payment page, specified by a combination of a language and country code. For example, `en-US`.<br><br>For a list of shopper locales that Pay by Link supports, refer to [Language and localization](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#language). |
| `ShopperName` | [`Name3`](../../doc/models/name-3.md) | Optional | The shopper's full name. This object is required for some payment methods such as AfterPay, Klarna, or if you're enrolled in the PayPal Seller Protection program. |
| `ShopperReference` | `string` | Optional | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `256` |
| `ShopperStatement` | `string` | Optional | The text to be shown on the shopper's bank statement.<br>We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.<br>Allowed characters: **a-z**, **A-Z**, **0-9**, spaces, and special characters **. , ' _ - ? + * /**. |
| `ShowRemovePaymentMethodButton` | `bool?` | Optional | Set to **false** to hide the button that lets the shopper remove a stored payment method.<br>**Default**: `true` |
| `SocialSecurityNumber` | `string` | Optional | The shopper's social security number. |
| `SplitCardFundingSources` | `bool?` | Optional | Boolean value indicating whether the card payment method should be split into separate debit and credit options.<br>**Default**: `false` |
| `Splits` | [`List<Split>`](../../doc/models/split.md) | Optional | An array of objects specifying how to split a payment when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information), [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic/processing-payments#providing-split-information), or [Issuing](https://docs.adyen.com/issuing/manage-funds#split). |
| `Status` | [`Status1Enum`](../../doc/models/status-1-enum.md) | Required | Status of the payment link. Possible values:<br><br>* **active**: The link can be used to make payments.<br>* **expired**: The expiry date for the payment link has passed. Shoppers can no longer use the link to make payments.<br>* **completed**: The shopper completed the payment.<br>* **paymentPending**: The shopper is in the process of making the payment. Applies to payment methods with an asynchronous flow. |
| `Store` | `string` | Optional | The physical store, for which this payment is processed. |
| `StorePaymentMethodMode` | [`StorePaymentMethodMode2Enum?`](../../doc/models/store-payment-method-mode-2-enum.md) | Optional | Indicates if the details of the payment method will be stored for the shopper. Possible values:<br><br>* **disabled** – No details will be stored (default).<br>* **askForConsent** – If the `shopperReference` is provided, the UI lets the shopper choose if they want their payment details to be stored.<br>* **enabled** – If the `shopperReference` is provided, the details will be stored without asking the shopper for consent.<br>  When set to **askForConsent** or **enabled**, you must also include the `recurringProcessingModel` parameter. |
| `TelephoneNumber` | `string` | Optional | The shopper's telephone number. |
| `ThemeId` | `string` | Optional | A [theme](https://docs.adyen.com/unified-commerce/pay-by-link/payment-links/api#themes) to customize the appearance of the payment page. If not specified, the payment page is rendered according to the theme set as default in your Customer Area. |
| `UpdatedAt` | `DateTime?` | Optional | The date when the payment link status was updated.<br><br>[ISO 8601](https://www.w3.org/TR/NOTE-datetime) format: YYYY-MM-DDThh:mm:ss+TZD, for example, **2020-12-18T10:15:30+01:00**. |
| `Url` | `string` | Required | The URL at which the shopper can complete the payment. |

## Example (as JSON)

```json
{
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "id": "id6",
  "merchantAccount": "merchantAccount8",
  "reference": "reference2",
  "showRemovePaymentMethodButton": true,
  "splitCardFundingSources": false,
  "status": "paid",
  "url": "url0",
  "allowedPaymentMethods": [
    "allowedPaymentMethods1",
    "allowedPaymentMethods2",
    "allowedPaymentMethods3"
  ],
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
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "blockedPaymentMethods": [
    "blockedPaymentMethods0",
    "blockedPaymentMethods1",
    "blockedPaymentMethods2"
  ],
  "captureDelayHours": 106
}
```

