
# Installments

Contains installment settings. For more information, refer to [Installments](https://docs.adyen.com/payment-methods/cards/credit-card-installments).

## Structure

`Installments`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Plan` | [`PlanEnum?`](../../doc/models/plan-enum.md) | Optional | The installment plan, used for [card installments in Japan](https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan). By default, this is set to **regular**. Possible values:<br><br>* **regular**<br>* **revolving** |
| `MValue` | `int` | Required | Defines the number of installments. Its value needs to be greater than zero.<br><br>Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary. |

## Example (as JSON)

```json
{
  "plan": "regular",
  "value": 180
}
```

