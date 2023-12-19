
# Avs 1

Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System)).

## Structure

`Avs1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressEditable` | `bool?` | Optional | Indicates whether the shopper is allowed to modify the billing address for the current payment request. |
| `Enabled` | [`EnabledEnum?`](../../doc/models/enabled-enum.md) | Optional | Specifies whether the shopper should enter their billing address during checkout.<br><br>Allowed values:<br><br>* yes — Perform AVS checks for every card payment.<br>* automatic — Perform AVS checks only when required to optimize the conversion rate.<br>* no — Do not perform AVS checks. |

## Example (as JSON)

```json
{
  "addressEditable": false,
  "enabled": "yes"
}
```

