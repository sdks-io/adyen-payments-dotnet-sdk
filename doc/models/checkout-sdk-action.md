
# Checkout SDK Action

## Structure

`CheckoutSDKAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentData` | `string` | Optional | Encoded payment data. |
| `PaymentMethodType` | `string` | Optional | Specifies the payment method. |
| `SdkData` | `Dictionary<string, string>` | Optional | The data to pass to the SDK. |
| `Type` | [`Type11Enum`](../../doc/models/type-11-enum.md) | Required | The type of the action. |
| `Url` | `string` | Optional | Specifies the URL to redirect to. |

## Example (as JSON)

```json
{
  "paymentData": "paymentData4",
  "paymentMethodType": "paymentMethodType4",
  "sdkData": {
    "key0": "sdkData3",
    "key1": "sdkData4"
  },
  "type": "sdk",
  "url": "url6"
}
```

