
# Store Detail Response

## Structure

`StoreDetailResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be returned in a particular response. |
| `PspReference` | `string` | Required | A new reference to uniquely identify this request. |
| `RecurringDetailReference` | `string` | Required | The token which you can use later on for submitting the payout. |
| `ResultCode` | `string` | Required | The result code of the transaction. `Success` indicates that the details were stored successfully. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData8",
    "key1": "additionalData9"
  },
  "pspReference": "pspReference0",
  "recurringDetailReference": "recurringDetailReference8",
  "resultCode": "resultCode6"
}
```

