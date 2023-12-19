
# Store Payment Method Mode Enum

Indicates if the details of the payment method will be stored for the shopper. Possible values:

* **disabled** – No details will be stored (default).
* **askForConsent** – If the `shopperReference` is provided, the UI lets the shopper choose if they want their payment details to be stored.
* **enabled** – If the `shopperReference` is provided, the details will be stored without asking the shopper for consent.

## Enumeration

`StorePaymentMethodModeEnum`

## Fields

| Name |
|  --- |
| `AskForConsent` |
| `Disabled` |
| `Enabled` |

