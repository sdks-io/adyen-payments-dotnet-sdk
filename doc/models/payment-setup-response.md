
# Payment Setup Response

## Structure

`PaymentSetupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentSession` | `string` | Optional | The encoded payment session that you need to pass to the SDK. |
| `RecurringDetails` | [`List<RecurringDetail>`](../../doc/models/recurring-detail.md) | Optional | The detailed list of stored payment details required to generate payment forms. Will be empty if oneClick is set to false in the request. |

## Example (as JSON)

```json
{
  "paymentSession": "paymentSession0",
  "recurringDetails": [
    {
      "brand": "brand4",
      "brands": [
        "brands1",
        "brands2"
      ],
      "configuration": {
        "key0": "configuration6"
      },
      "fundingSource": "credit",
      "group": {
        "name": "name8",
        "paymentMethodData": "paymentMethodData8",
        "type": "type2"
      }
    },
    {
      "brand": "brand4",
      "brands": [
        "brands1",
        "brands2"
      ],
      "configuration": {
        "key0": "configuration6"
      },
      "fundingSource": "credit",
      "group": {
        "name": "name8",
        "paymentMethodData": "paymentMethodData8",
        "type": "type2"
      }
    }
  ]
}
```

