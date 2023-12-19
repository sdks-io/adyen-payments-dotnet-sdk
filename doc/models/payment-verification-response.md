
# Payment Verification Response

## Structure

`PaymentVerificationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | Contains additional information about the payment. Some data fields are included only if you select them first: Go to **Customer Area** > **Developers** > **Additional data**. |
| `FraudResult` | [`FraudResult1`](../../doc/models/fraud-result-1.md) | Optional | The fraud result properties of the payment. |
| `MerchantReference` | `string` | Required | A unique value that you provided in the initial `/paymentSession` request as a `reference` field. |
| `Order` | [`CheckoutOrderResponse1`](../../doc/models/checkout-order-response-1.md) | Optional | Contains updated information regarding the order in case order information was provided in the request. |
| `PspReference` | `string` | Optional | Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request. |
| `RefusalReason` | `string` | Optional | If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes `resultCode` and `refusalReason` values.<br><br>For more information, see [Refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons). |
| `RefusalReasonCode` | `string` | Optional | Code that specifies the refusal reason. For more information, see [Authorisation refusal reasons](https://docs.adyen.com/development-resources/refusal-reasons). |
| `ResultCode` | [`ResultCode1Enum?`](../../doc/models/result-code-1-enum.md) | Optional | The result of the payment. For more information, see [Result codes](https://docs.adyen.com/online-payments/payment-result-codes).<br><br>Possible values:<br><br>* **AuthenticationFinished** – The payment has been successfully authenticated with 3D Secure 2. Returned for 3D Secure 2 authentication-only transactions.<br>* **AuthenticationNotRequired** – The transaction does not require 3D Secure authentication. Returned for [standalone authentication-only integrations](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only).<br>* **Authorised** – The payment was successfully authorised. This state serves as an indicator to proceed with the delivery of goods and services. This is a final state.<br>* **Cancelled** – Indicates the payment has been cancelled (either by the shopper or the merchant) before processing was completed. This is a final state.<br>* **ChallengeShopper** – The issuer requires further shopper interaction before the payment can be authenticated. Returned for 3D Secure 2 transactions.<br>* **Error** – There was an error when the payment was being processed. The reason is given in the `refusalReason` field. This is a final state.<br>* **IdentifyShopper** – The issuer requires the shopper's device fingerprint before the payment can be authenticated. Returned for 3D Secure 2 transactions.<br>* **PartiallyAuthorised** – The payment has been authorised for a partial amount.<br>  This happens for card payments when the merchant supports Partial Authorisations and the cardholder has insufficient funds.<br>* **Pending** – Indicates that it is not possible to obtain the final status of the payment. This can happen if the systems providing final status information for the payment are unavailable, or if the shopper needs to take further action to complete the payment.<br>* **PresentToShopper** – Indicates that the response contains additional information that you need to present to a shopper, so that they can use it to complete a payment.<br>* **Received** – Indicates the payment has successfully been received by Adyen, and will be processed. This is the initial state for all payments.<br>* **RedirectShopper** – Indicates the shopper should be redirected to an external web page or app to complete the authorisation.<br>* **Refused** – Indicates the payment was refused. The reason is given in the `refusalReason` field. This is a final state. |
| `ServiceError` | [`ServiceErrorDetails2`](../../doc/models/service-error-details-2.md) | Optional | The type of the error. |
| `ShopperLocale` | `string` | Required | The shopperLocale value provided in the payment request. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData0",
    "key1": "additionalData1"
  },
  "fraudResult": {
    "accountScore": 232,
    "results": [
      {
        "accountScore": 102,
        "checkId": 246,
        "name": "name6"
      },
      {
        "accountScore": 102,
        "checkId": 246,
        "name": "name6"
      }
    ]
  },
  "merchantReference": "merchantReference6",
  "order": {
    "amount": {
      "currency": "currency2",
      "value": 110
    },
    "expiresAt": "expiresAt2",
    "orderData": "orderData8",
    "pspReference": "pspReference8",
    "reference": "reference2",
    "remainingAmount": {
      "currency": "currency6",
      "value": 156
    }
  },
  "pspReference": "pspReference8",
  "refusalReason": "refusalReason0",
  "shopperLocale": "shopperLocale0"
}
```

