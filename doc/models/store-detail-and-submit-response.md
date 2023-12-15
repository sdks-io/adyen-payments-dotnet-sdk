
# Store Detail and Submit Response

## Structure

`StoreDetailAndSubmitResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be returned in a particular response. |
| `PspReference` | `string` | Required | A new reference to uniquely identify this request. |
| `RefusalReason` | `string` | Optional | In case of refusal, an informational message for the reason. |
| `ResultCode` | `string` | Required | The response:<br><br>* In case of success is payout-submit-received.<br>* In case of an error, an informational message is returned. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData6",
    "key1": "additionalData7"
  },
  "pspReference": "pspReference8",
  "refusalReason": "refusalReason6",
  "resultCode": "resultCode8"
}
```

