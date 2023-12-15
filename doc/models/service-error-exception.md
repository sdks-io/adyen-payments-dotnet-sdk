
# Service Error Exception

## Structure

`ServiceErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | Contains additional information about the payment. Some data fields are included only if you select them first. Go to **Customer Area** > **Developers** > **Additional data**. |
| `ErrorCode` | `string` | Optional | The error code mapped to the error message. |
| `ErrorType` | `string` | Optional | The category of the error. |
| `Message` | `string` | Optional | A short explanation of the issue. |
| `PspReference` | `string` | Optional | The PSP reference of the payment. |
| `Status` | `int?` | Optional | The HTTP response status. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData0"
  },
  "errorCode": "errorCode6",
  "errorType": "errorType0",
  "message": "message0",
  "pspReference": "pspReference8"
}
```

