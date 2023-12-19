
# Masterpass

## Structure

`Masterpass`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `FundingSource` | [`FundingSourceEnum?`](../../doc/models/funding-source-enum.md) | Optional | The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**. |
| `MasterpassTransactionId` | `string` | Required | The Masterpass transaction ID. |
| `Type` | [`Type22Enum?`](../../doc/models/type-22-enum.md) | Optional | **masterpass**<br>**Default**: `Type22Enum.masterpass` |

## Example (as JSON)

```json
{
  "masterpassTransactionId": "masterpassTransactionId0",
  "type": "masterpass",
  "checkoutAttemptId": "checkoutAttemptId4",
  "fundingSource": "credit"
}
```

