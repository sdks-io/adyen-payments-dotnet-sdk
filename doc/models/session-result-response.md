
# Session Result Response

## Structure

`SessionResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | A unique identifier of the session. |
| `Status` | [`Status2Enum?`](../../doc/models/status-2-enum.md) | Optional | The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.<br><br>Possible values:<br><br>         * **completed** – The shopper completed the payment. This means that the payment was authorized.<br>         * **paymentPending** – The shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow.<br>         * **refused** – The session has been refused, due to too many refused payment attempts. Shoppers can no longer complete the payment with this session.<br>         * **canceled** – The shopper canceled the payment.<br>         * **active** – The session is still active and can be paid.<br>         * **expired** – The session expired (default: 1 hour after session creation). Shoppers can no longer complete the payment with this session. |

## Example (as JSON)

```json
{
  "id": "id6",
  "status": "paymentPending"
}
```

