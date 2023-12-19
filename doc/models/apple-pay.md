
# Apple Pay

## Structure

`ApplePay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ApplePayToken` | `string` | Required | The stringified and base64 encoded `paymentData` you retrieved from the Apple framework.<br>**Constraints**: *Maximum Length*: `10000` |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type4Enum?`](../../doc/models/type-4-enum.md) | Optional | **applepay**<br>**Default**: `Type4Enum.applepay` |

## Example (as JSON)

```json
{
  "applePayToken": "applePayToken6",
  "type": "applepay",
  "checkoutAttemptId": "checkoutAttemptId0",
  "fundingSource": "credit",
  "recurringDetailReference": "recurringDetailReference4",
  "storedPaymentMethodId": "storedPaymentMethodId8"
}
```

