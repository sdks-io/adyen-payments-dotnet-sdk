
# Amazon Pay

## Structure

`AmazonPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmazonPayToken` | `string` | Optional | This is the `amazonPayToken` that you obtained from the [Get Checkout Session](https://amazon-pay-acquirer-guide.s3-eu-west-1.amazonaws.com/v1/amazon-pay-api-v2/checkout-session.html#get-checkout-session) response. This token is used for API only integration specifically. |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `CheckoutSessionId` | `string` | Optional | The `checkoutSessionId` is used to identify the checkout session at the Amazon Pay side. This field is required only for drop-in and components integration, where it replaces the amazonPayToken. |
| `Type` | [`Type2Enum?`](../../doc/models/type-2-enum.md) | Optional | **amazonpay**<br>**Default**: `Type2Enum.amazonpay` |

## Example (as JSON)

```json
{
  "type": "amazonpay",
  "amazonPayToken": "amazonPayToken4",
  "checkoutAttemptId": "checkoutAttemptId2",
  "checkoutSessionId": "checkoutSessionId4"
}
```

