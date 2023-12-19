
# Line Item

## Structure

`LineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmountExcludingTax` | `long?` | Optional | Item amount excluding the tax, in minor units. |
| `AmountIncludingTax` | `long?` | Optional | Item amount including the tax, in minor units. |
| `Brand` | `string` | Optional | Brand of the item. |
| `Color` | `string` | Optional | Color of the item. |
| `Description` | `string` | Optional | Description of the line item. |
| `Id` | `string` | Optional | ID of the line item. |
| `ImageUrl` | `string` | Optional | Link to the picture of the purchased item. |
| `ItemCategory` | `string` | Optional | Item category, used by the payment methods PayPal and Ratepay. |
| `Manufacturer` | `string` | Optional | Manufacturer of the item. |
| `ProductUrl` | `string` | Optional | Link to the purchased item. |
| `Quantity` | `long?` | Optional | Number of items. |
| `ReceiverEmail` | `string` | Optional | Email associated with the given product in the basket (usually in electronic gift cards). |
| `Size` | `string` | Optional | Size of the item. |
| `Sku` | `string` | Optional | Stock keeping unit. |
| `TaxAmount` | `long?` | Optional | Tax amount, in minor units. |
| `TaxPercentage` | `long?` | Optional | Tax percentage, in minor units. |
| `Upc` | `string` | Optional | Universal Product Code. |

## Example (as JSON)

```json
{
  "amountExcludingTax": 36,
  "amountIncludingTax": 146,
  "brand": "brand0",
  "color": "color0",
  "description": "description6"
}
```

