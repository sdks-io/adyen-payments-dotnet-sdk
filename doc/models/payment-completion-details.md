
# Payment Completion Details

## Structure

`PaymentCompletionDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MD` | `string` | Optional | A payment session identifier returned by the card issuer.<br>**Constraints**: *Maximum Length*: `20000` |
| `PaReq` | `string` | Optional | (3D) Payment Authentication Request data for the card issuer. |
| `PaRes` | `string` | Optional | (3D) Payment Authentication Response data by the card issuer.<br>**Constraints**: *Maximum Length*: `20000` |
| `AuthorizationToken` | `string` | Optional | - |
| `BillingToken` | `string` | Optional | PayPal-generated token for recurring payments. |
| `CupsecureplusSmscode` | `string` | Optional | The SMS verification code collected from the shopper. |
| `FacilitatorAccessToken` | `string` | Optional | PayPal-generated third party access token. |
| `OneTimePasscode` | `string` | Optional | A random number sent to the mobile phone number of the shopper to verify the payment. |
| `OrderID` | `string` | Optional | PayPal-assigned ID for the order. |
| `PayerID` | `string` | Optional | PayPal-assigned ID for the payer (shopper). |
| `Payload` | `string` | Optional | Payload appended to the `returnURL` as a result of the redirect.<br>**Constraints**: *Maximum Length*: `20000` |
| `PaymentID` | `string` | Optional | PayPal-generated ID for the payment. |
| `PaymentStatus` | `string` | Optional | Value passed from the WeChat MiniProgram `wx.requestPayment` **complete** callback. Possible values: any value starting with `requestPayment:`. |
| `RedirectResult` | `string` | Optional | The result of the redirect as appended to the `returnURL`.<br>**Constraints**: *Maximum Length*: `20000` |
| `ResultCode` | `string` | Optional | Value you received from the WeChat Pay SDK. |
| `ThreeDSResult` | `string` | Optional | Base64-encoded string returned by the Component after the challenge flow. It contains the following parameters: `transStatus`, `authorisationToken`.<br>**Constraints**: *Maximum Length*: `50000` |
| `Threeds2ChallengeResult` | `string` | Optional | Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `transStatus`.<br>**Constraints**: *Maximum Length*: `50000` |
| `Threeds2Fingerprint` | `string` | Optional | Base64-encoded string returned by the Component after the challenge flow. It contains the following parameter: `threeDSCompInd`.<br>**Constraints**: *Maximum Length*: `100000` |

## Example (as JSON)

```json
{
  "MD": "MD4",
  "PaReq": "PaReq2",
  "PaRes": "PaRes2",
  "authorization_token": "authorization_token4",
  "billingToken": "billingToken4"
}
```

