
# Google Pay

## Structure

`GooglePay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `GooglePayToken` | `string` | Required | The `token` that you obtained from the [Google Pay API](https://developers.google.com/pay/api/web/reference/response-objects#PaymentData) `PaymentData` response. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type15Enum?`](../../doc/models/type-15-enum.md) | Optional | **paywithgoogle**<br>**Default**: `Type15Enum.paywithgoogle` |

## Example (as JSON)

```json
{
  "googlePayToken": "googlePayToken4",
  "type": "paywithgoogle",
  "checkoutAttemptId": "checkoutAttemptId8",
  "fundingSource": "credit",
  "recurringDetailReference": "recurringDetailReference2",
  "storedPaymentMethodId": "storedPaymentMethodId6"
}
```

