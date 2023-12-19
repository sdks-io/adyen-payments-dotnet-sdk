
# Shopper Input 2

Determines how to display the details fields.

## Structure

`ShopperInput2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | [`BillingAddress1Enum?`](../../doc/models/billing-address-1-enum.md) | Optional | Specifies visibility of billing address fields.<br><br>Permitted values:<br><br>* editable<br>* hidden<br>* readOnly |
| `DeliveryAddress` | [`DeliveryAddress6Enum?`](../../doc/models/delivery-address-6-enum.md) | Optional | Specifies visibility of delivery address fields.<br><br>Permitted values:<br><br>* editable<br>* hidden<br>* readOnly |
| `PersonalDetails` | [`PersonalDetailsEnum?`](../../doc/models/personal-details-enum.md) | Optional | Specifies visibility of personal details.<br><br>Permitted values:<br><br>* editable<br>* hidden<br>* readOnly |

## Example (as JSON)

```json
{
  "billingAddress": "hidden",
  "deliveryAddress": "editable",
  "personalDetails": "readOnly"
}
```

