
# Recurring

A container for the type of recurring contract to be retrieved.

The recurring.contract must be set to `PAYOUT`

## Structure

`Recurring`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Contract` | [`ContractEnum?`](../../doc/models/contract-enum.md) | Optional | The type of recurring contract to be used.<br>Possible values:<br><br>* `ONECLICK` – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid).<br>* `RECURRING` – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp).<br>* `ONECLICK,RECURRING` – Payment details can be used regardless of whether the shopper is on your site or not.<br>* `PAYOUT` – Payment details can be used to [make a payout](https://docs.adyen.com/online-payments/online-payouts). |
| `RecurringDetailName` | `string` | Optional | A descriptive name for this detail. |
| `RecurringExpiry` | `DateTime?` | Optional | Date after which no further authorisations shall be performed. Only for 3D Secure 2. |
| `RecurringFrequency` | `string` | Optional | Minimum number of days between authorisations. Only for 3D Secure 2. |
| `TokenService` | [`TokenServiceEnum?`](../../doc/models/token-service-enum.md) | Optional | The name of the token service. |

## Example (as JSON)

```json
{
  "contract": "RECURRING",
  "recurringDetailName": "recurringDetailName6",
  "recurringExpiry": "2016-03-13T12:52:32.123Z",
  "recurringFrequency": "recurringFrequency4",
  "tokenService": "VISATOKENSERVICE"
}
```

