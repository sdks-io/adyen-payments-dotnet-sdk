
# IDEAL

## Structure

`IDEAL`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The iDEAL issuer value of the shopper's selected bank. Set this to an **id** of an iDEAL issuer to preselect it. |
| `RecurringDetailReference` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token. |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `Type` | [`Type14Enum?`](../../doc/models/type-14-enum.md) | Optional | **ideal**<br>**Default**: `Type14Enum.ideal` |

## Example (as JSON)

```json
{
  "issuer": "issuer0",
  "type": "ideal",
  "checkoutAttemptId": "checkoutAttemptId6",
  "recurringDetailReference": "recurringDetailReference0",
  "storedPaymentMethodId": "storedPaymentMethodId4"
}
```

