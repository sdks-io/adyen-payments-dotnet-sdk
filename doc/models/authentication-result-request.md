
# Authentication Result Request

## Structure

`AuthenticationResultRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which the authentication was processed. |
| `PspReference` | `string` | Required | The pspReference identifier for the transaction. |

## Example (as JSON)

```json
{
  "merchantAccount": "merchantAccount8",
  "pspReference": "pspReference8"
}
```

