
# Cancel Order Response

## Structure

`CancelOrderResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PspReference` | `string` | Required | A unique reference of the cancellation request. |
| `ResultCode` | `string` | Required, Constant | The result of the cancellation request.<br><br>Possible values:<br><br>* **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.<br>**Default**: `"Received"` |

## Example (as JSON)

```json
{
  "pspReference": "pspReference2",
  "resultCode": "Received"
}
```

