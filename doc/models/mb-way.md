
# MB Way

## Structure

`MBWay`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `ShopperEmail` | `string` | Required | - |
| `TelephoneNumber` | `string` | Required | - |
| `Type` | [`Type23Enum?`](../../doc/models/type-23-enum.md) | Optional | **mbway**<br>**Default**: `Type23Enum.mbway` |

## Example (as JSON)

```json
{
  "shopperEmail": "shopperEmail4",
  "telephoneNumber": "telephoneNumber4",
  "type": "mbway",
  "checkoutAttemptId": "checkoutAttemptId8"
}
```

