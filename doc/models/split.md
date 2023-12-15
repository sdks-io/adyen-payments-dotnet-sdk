
# Split

## Structure

`Split`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Account` | `string` | Optional | The unique identifier of the account to which the split amount is booked. Required if `type` is **MarketPlace** or **BalanceAccount**.<br><br>* [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic): The [`accountCode`](https://docs.adyen.com/api-explorer/Account/latest/post/updateAccount#request-accountCode) of the account to which the split amount is booked.<br>* [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms): The [`balanceAccountId`](https://docs.adyen.com/api-explorer/balanceplatform/latest/get/balanceAccounts/_id_#path-id) of the account to which the split amount is booked. |
| `Amount` | [`SplitAmount2`](../../doc/models/split-amount-2.md) | Optional | The amount of the split item.<br><br>* Required for all split types in the [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic).<br>* Required if `type` is **BalanceAccount**, **Commission**, **Default**, or **VAT** in your [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms) integration. |
| `Description` | `string` | Optional | Your description for the split item. |
| `Reference` | `string` | Optional | Your unique reference for the split item.<br><br>This is required if `type` is **MarketPlace** ([Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic)) or **BalanceAccount** ([Balance Platform](https://docs.adyen.com/marketplaces-and-platforms)).<br><br>For the other types, we also recommend providing a **unique** reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. |
| `Type` | [`TypeEnum`](../../doc/models/type-enum.md) | Required | The type of the split item.<br><br>Possible values:<br><br>* [Classic Platforms integration](https://docs.adyen.com/marketplaces-and-platforms/classic): **Commission**, **Default**, **Marketplace**, **PaymentFee**, **VAT**.<br>* [Balance Platform](https://docs.adyen.com/marketplaces-and-platforms): **BalanceAccount**, **Commission**, **Default**, **PaymentFee**, **Remainder**, **Surcharge**, **Tip**, **VAT**. |

## Example (as JSON)

```json
{
  "account": "account0",
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "description": "description0",
  "reference": "reference6",
  "type": "Tip"
}
```

