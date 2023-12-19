
# Samsung Pay

## Structure

`SamsungPay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `SamsungPayToken` | `string` | Required | The payload you received from the Samsung Pay SDK response. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type29Enum?`](../../doc/models/type-29-enum.md) | Optional | **samsungpay**<br>**Default**: `Type29Enum.samsungpay` |

## Example (as JSON)

```json
{
  "samsungPayToken": "samsungPayToken6",
  "type": "samsungpay",
  "checkoutAttemptId": "checkoutAttemptId4",
  "fundingSource": "credit",
  "recurringDetailReference": "recurringDetailReference8",
  "storedPaymentMethodId": "storedPaymentMethodId2"
}
```

