
# Zip

## Structure

`Zip`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `ClickAndCollect` | `string` | Optional | Set this to **true** if the shopper would like to pick up and collect their order, instead of having the goods delivered to them. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type36Enum?`](../../doc/models/type-36-enum.md) | Optional | **zip**<br>**Default**: `Type36Enum.zip` |

## Example (as JSON)

```json
{
  "type": "zip",
  "checkoutAttemptId": "checkoutAttemptId2",
  "clickAndCollect": "clickAndCollect6",
  "recurringDetailReference": "recurringDetailReference6",
  "storedPaymentMethodId": "storedPaymentMethodId0"
}
```

