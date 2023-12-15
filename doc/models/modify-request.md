
# Modify Request

## Structure

`ModifyRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular payout request. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `OriginalReference` | `string` | Required | The PSP reference received in the `/submitThirdParty` response. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData8"
  },
  "merchantAccount": "merchantAccount0",
  "originalReference": "originalReference8"
}
```

