
# Phone 3

The home phone number provided by the Cardholder.

## Structure

`Phone3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cc` | `string` | Optional | Country code. Length: 1–3 characters.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `3` |
| `Subscriber` | `string` | Optional | Subscriber number. Maximum length: 15 characters.<br>**Constraints**: *Maximum Length*: `15` |

## Example (as JSON)

```json
{
  "cc": "cc0",
  "subscriber": "subscriber2"
}
```

