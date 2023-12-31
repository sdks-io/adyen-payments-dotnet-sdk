
# Additional Data Common

## Structure

`AdditionalDataCommon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestedTestErrorResponseCode` | `string` | Optional | Triggers test scenarios that allow to replicate certain communication errors.<br><br>Allowed values:<br><br>* **NO_CONNECTION_AVAILABLE** – There wasn't a connection available to service the outgoing communication.<br>  This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request.<br>* **IOEXCEPTION_RECEIVED** – Something went wrong during transmission of the message or receiving the response.<br>  This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response. |
| `AllowPartialAuth` | `string` | Optional | Set to true to authorise a part of the requested amount in case the cardholder does not have enough funds on their account.<br>If a payment was partially authorised, the response includes resultCode: PartiallyAuthorised and the authorised amount in additionalData.authorisedAmountValue.<br>To enable this functionality, contact our Support Team. |
| `AuthorisationType` | `string` | Optional | Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to [Authorisation types](https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types).<br><br>Allowed values:<br><br>* **PreAuth** – flags the payment request to be handled as a pre-authorisation.<br>* **FinalAuth** – flags the payment request to be handled as a final authorisation. |
| `CustomRoutingFlag` | `string` | Optional | Allows you to determine or override the acquirer account that should be used for the transaction.<br><br>If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request's additional data to target a specific acquirer.<br><br>To enable this functionality, contact [Support](https://www.adyen.help/hc/en-us/requests/new). |
| `IndustryUsage` | [`IndustryUsageEnum?`](../../doc/models/industry-usage-enum.md) | Optional | In case of [asynchronous authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation), this field denotes why the additional payment is made.<br><br>Possible values:<br><br>* **NoShow**: An incremental charge is carried out because of a no-show for a guaranteed reservation.<br><br>* **DelayedCharge**: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed. |
| `ManualCapture` | `string` | Optional | Set to **true** to require [manual capture](https://docs.adyen.com/online-payments/capture) for the transaction. |
| `NetworkTxReference` | `string` | Optional | Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.<br><br>Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.<br><br>Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.<br><br>Make sure you are sending `shopperInteraction` **ContAuth** and `recurringProcessingModel` **Subscription** or **UnscheduledCardOnFile** to ensure that the transaction is classified as MIT. |
| `OverwriteBrand` | `string` | Optional | Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the `selectedBrand` value to specify how to process the transaction. |
| `SubMerchantCity` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant's address.<br><br>* Format: alpha-numeric.<br>* Maximum length: 13 characters. |
| `SubMerchantCountry` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant's address.<br><br>* Format: alpha-numeric.<br>* Fixed length: 3 characters. |
| `SubMerchantID` | `string` | Optional | This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.<br><br>A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator.<br><br>* Format: alpha-numeric.<br>* Fixed length: 15 characters. |
| `SubMerchantName` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant.<br><br>* Format: alpha-numeric.<br>* Maximum length: 22 characters. |
| `SubMerchantPostalCode` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant's address.<br><br>* Format: alpha-numeric.<br>* Maximum length: 10 characters. |
| `SubMerchantState` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant's address.<br><br>* Format: alpha-numeric.<br>* Maximum length: 3 characters. |
| `SubMerchantStreet` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant's address.<br><br>* Format: alpha-numeric.<br>* Maximum length: 60 characters. |
| `SubMerchantTaxId` | `string` | Optional | This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant.<br><br>* Format: alpha-numeric.<br>* Fixed length: 11 or 14 characters. |

## Example (as JSON)

```json
{
  "RequestedTestErrorResponseCode": "RequestedTestErrorResponseCode2",
  "allowPartialAuth": "allowPartialAuth2",
  "authorisationType": "authorisationType8",
  "customRoutingFlag": "customRoutingFlag0",
  "industryUsage": "NoShow"
}
```

