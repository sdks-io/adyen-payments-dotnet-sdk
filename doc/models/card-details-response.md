
# Card Details Response

## Structure

`CardDetailsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Brands` | [`List<CardBrandDetails>`](../../doc/models/card-brand-details.md) | Optional | The list of brands identified for the card. |

## Example (as JSON)

```json
{
  "brands": [
    {
      "supported": false,
      "type": "type6"
    },
    {
      "supported": false,
      "type": "type6"
    },
    {
      "supported": false,
      "type": "type6"
    }
  ]
}
```

