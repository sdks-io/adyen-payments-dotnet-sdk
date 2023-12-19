
# Bill Desk

## Structure

`BillDesk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Required | The issuer id of the shopper's selected bank. |
| `Type` | [`Type7Enum`](../../doc/models/type-7-enum.md) | Required | **billdesk** |

## Example (as JSON)

```json
{
  "checkoutAttemptId": "checkoutAttemptId6",
  "issuer": "issuer0",
  "type": "onlinebanking_IN"
}
```

