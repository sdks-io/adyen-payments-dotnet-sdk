
# Phone 2

The work phone number provided by the Cardholder.

## Structure

`Phone2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cc` | `string` | Optional | Country code. Length: 1–3 characters.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `3` |
| `Subscriber` | `string` | Optional | Subscriber number. Maximum length: 15 characters.<br>**Constraints**: *Maximum Length*: `15` |

## Example (as JSON)

```json
{
  "cc": "cc2",
  "subscriber": "subscriber4"
}
```

