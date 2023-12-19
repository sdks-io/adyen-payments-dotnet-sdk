
# Recurring Detail

## Structure

`RecurringDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brand` | `string` | Optional | Brand for the selected gift card. For example: plastix, hmclub. |
| `Brands` | `List<string>` | Optional | List of possible brands. For example: visa, mc. |
| `Configuration` | `Dictionary<string, string>` | Optional | The configuration of the payment method. |
| `FundingSource` | [`FundingSource5Enum?`](../../doc/models/funding-source-5-enum.md) | Optional | The funding source of the payment method. |
| `Group` | [`PaymentMethodGroup2`](../../doc/models/payment-method-group-2.md) | Optional | The group where this payment method belongs to. |
| `InputDetails` | [`List<InputDetail>`](../../doc/models/input-detail.md) | Optional | All input details to be provided to complete the payment with this payment method. |
| `Issuers` | [`List<PaymentMethodIssuer>`](../../doc/models/payment-method-issuer.md) | Optional | A list of issuers for this payment method. |
| `Name` | `string` | Optional | The displayable name of this payment method. |
| `RecurringDetailReference` | `string` | Optional | The reference that uniquely identifies the recurring detail. |
| `StoredDetails` | [`StoredDetails2`](../../doc/models/stored-details-2.md) | Optional | Contains information on previously stored payment details. |
| `Type` | `string` | Optional | The unique payment method code. |

## Example (as JSON)

```json
{
  "brand": "brand6",
  "brands": [
    "brands3",
    "brands4"
  ],
  "configuration": {
    "key0": "configuration8"
  },
  "fundingSource": "credit",
  "group": {
    "name": "name8",
    "paymentMethodData": "paymentMethodData8",
    "type": "type2"
  }
}
```

