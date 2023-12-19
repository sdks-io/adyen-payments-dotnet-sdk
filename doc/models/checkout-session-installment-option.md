
# Checkout Session Installment Option

## Structure

`CheckoutSessionInstallmentOption`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Plans` | [`List<Plan1Enum>`](../../doc/models/plan-1-enum.md) | Optional | Defines the type of installment plan. If not set, defaults to **regular**.<br><br>Possible values:<br><br>* **regular**<br>* **revolving** |
| `PreselectedValue` | `int?` | Optional | Preselected number of installments offered for this payment method. |
| `Values` | `List<int>` | Optional | An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with `maxValue`. |

## Example (as JSON)

```json
{
  "plans": [
    "revolving",
    "regular"
  ],
  "preselectedValue": 78,
  "values": [
    244,
    245
  ]
}
```

