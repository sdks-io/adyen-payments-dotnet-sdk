
# Cellulant

## Structure

`Cellulant`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CheckoutAttemptId` | `string` | Optional | The checkout attempt identifier. |
| `Issuer` | `string` | Optional | The Cellulant issuer. |
| `Type` | [`Type10Enum?`](../../doc/models/type-10-enum.md) | Optional | **Cellulant**<br>**Default**: `Type10Enum.cellulant` |

## Example (as JSON)

```json
{
  "type": "cellulant",
  "checkoutAttemptId": "checkoutAttemptId0",
  "issuer": "issuer4"
}
```

