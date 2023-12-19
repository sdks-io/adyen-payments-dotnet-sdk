
# Visa Checkout

## Structure

`VisaCheckout`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `Type` | [`Type33Enum?`](../../doc/models/type-33-enum.md) | Optional | **visacheckout**<br>**Default**: `Type33Enum.visacheckout` |
| `VisaCheckoutCallId` | `string` | Required | The Visa Click to Pay Call ID value. When your shopper selects a payment and/or a shipping address from Visa Click to Pay, you will receive a Visa Click to Pay Call ID. |

## Example (as JSON)

```json
{
  "type": "visacheckout",
  "visaCheckoutCallId": "visaCheckoutCallId0",
  "checkoutAttemptId": "checkoutAttemptId8",
  "fundingSource": "credit"
}
```

