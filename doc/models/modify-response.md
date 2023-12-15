
# Modify Response

## Structure

`ModifyResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be returned in a particular response. |
| `PspReference` | `string` | Required | Adyen's 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response. |
| `Response` | `string` | Required | The response:<br><br>* In case of success, it is either `payout-confirm-received` or `payout-decline-received`.<br>* In case of an error, an informational message is returned. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData6",
    "key1": "additionalData7"
  },
  "pspReference": "pspReference8",
  "response": "response6"
}
```

