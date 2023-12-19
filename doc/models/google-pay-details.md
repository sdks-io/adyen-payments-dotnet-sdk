
# Google Pay Details

## Structure

`GooglePayDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `GooglePayToken` | `string` | Required | The `token` that you obtained from the [Google Pay API](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) `PaymentData` response. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type13Enum?`](../../doc/models/type-13-enum.md) | Optional | **googlepay**, **paywithgoogle**<br>**Default**: `Type13Enum.googlepay` |

## Example (as JSON)

```json
{
  "googlePayToken": "googlePayToken8",
  "type": "googlepay",
  "checkoutAttemptId": "checkoutAttemptId2",
  "fundingSource": "credit",
  "recurringDetailReference": "recurringDetailReference6",
  "storedPaymentMethodId": "storedPaymentMethodId0"
}
```

