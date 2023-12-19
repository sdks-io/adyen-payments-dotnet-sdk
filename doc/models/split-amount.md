
# Split Amount

The amount of the split item.

* Required for all split types in the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).
* Required if `type` is **BalanceAccount**, **Commission**, **Default**, or **VAT** in your [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms) integration.

## Structure

`SplitAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Optional | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). By default, this is the original payment currency.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `MValue` | `long` | Required | The value of the split amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes). |

## Example (as JSON)

```json
{
  "currency": "currency8",
  "value": 54
}
```

