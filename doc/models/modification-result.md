
# Modification Result

## Structure

`ModificationResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be returned in a particular modification response. |
| `PspReference` | `string` | Required | Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request. |
| `Response` | [`ResponseEnum`](../../doc/models/response-enum.md) | Required | Indicates if the modification request has been received for processing. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData2",
    "key1": "additionalData3",
    "key2": "additionalData4"
  },
  "pspReference": "pspReference4",
  "response": "[capture-received]"
}
```

