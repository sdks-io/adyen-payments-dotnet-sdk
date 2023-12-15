
# Three DS2 Result Request

## Structure

`ThreeDS2ResultRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `PspReference` | `string` | Required | The pspReference returned in the /authorise call. |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount2",
  "pspReference": "pspReference8"
}
```

