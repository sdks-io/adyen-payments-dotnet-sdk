
# Installment Option

## Structure

`InstallmentOption`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxValue` | `int?` | Optional | The maximum number of installments offered for this payment method. |
| `Plans` | [`List<Plan1Enum>`](../../doc/models/plan-1-enum.md) | Optional | Defines the type of installment plan. If not set, defaults to **regular**.<br><br>Possible values:<br><br>* **regular**<br>* **revolving** |
| `PreselectedValue` | `int?` | Optional | Preselected number of installments offered for this payment method. |
| `Values` | `List<int>` | Optional | An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with `maxValue`. |

## Example (as JSON)

```json
{
  "maxValue": 0,
  "plans": [
    "revolving",
    "regular",
    "revolving"
  ],
  "preselectedValue": 100,
  "values": [
    222
  ]
}
```

