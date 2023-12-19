
# Platform Chargeback Logic

Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes).

## Structure

`PlatformChargebackLogic`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Behavior` | [`BehaviorEnum?`](../../doc/models/behavior-enum.md) | Optional | The method of handling the chargeback.<br><br>Possible values: **deductFromLiableAccount**, **deductFromOneBalanceAccount**, **deductAccordingToSplitRatio**. |
| `CostAllocationAccount` | `string` | Optional | The unique identifier of the balance account to which the chargeback fees are booked. By default, the chargeback fees are booked to your liable balance account. |
| `TargetAccount` | `string` | Optional | The unique identifier of the balance account against which the disputed amount is booked.<br><br>Required if `behavior` is **deductFromOneBalanceAccount**. |

## Example (as JSON)

```json
{
  "behavior": "deductAccordingToSplitRatio",
  "costAllocationAccount": "costAllocationAccount8",
  "targetAccount": "targetAccount0"
}
```

