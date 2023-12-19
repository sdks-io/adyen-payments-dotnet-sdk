
# Encrypted Order Data 2

The order information required for partial payments.

## Structure

`EncryptedOrderData2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OrderData` | `string` | Required | The encrypted order data. |
| `PspReference` | `string` | Required | The `pspReference` that belongs to the order. |

## Example (as JSON)

```json
{
  "orderData": "orderData8",
  "pspReference": "pspReference8"
}
```

