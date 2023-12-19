
# Amount 14

The total amount (initial plus surcharge amount).

## Structure

`Amount14`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `MValue` | `long` | Required | The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes). |

## Example (as JSON)

```json
{
  "currency": "currency4",
  "value": 18
}
```

