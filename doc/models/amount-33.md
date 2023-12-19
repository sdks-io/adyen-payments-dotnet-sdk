
# Amount 33

The amount that you want to refund. The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount.

## Structure

`Amount33`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currency` | `string` | Required | The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |
| `MValue` | `long` | Required | The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes). |

## Example (as JSON)

```json
{
  "currency": "currency8",
  "value": 124
}
```

