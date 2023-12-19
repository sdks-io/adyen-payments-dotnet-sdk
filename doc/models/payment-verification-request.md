
# Payment Verification Request

## Structure

`PaymentVerificationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payload` | `string` | Required | Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.<br>**Constraints**: *Maximum Length*: `40000` |

## Example (as JSON)

```json
{
  "payload": "payload6"
}
```

