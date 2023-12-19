
# Payment Response 4

## Structure

`PaymentResponse4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | The card brand that the shopper used to pay. Only returned if `paymentMethod.type` is **scheme**. |
| `Type` | `string` | Optional | The `paymentMethod.type` value used in the request. |

## Example (as JSON)

```json
{
  "brand": "brand4",
  "type": "type0"
}
```

