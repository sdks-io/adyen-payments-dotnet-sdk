
# Details Request Authentication Data 1

Data for 3DS authentication.

## Structure

`DetailsRequestAuthenticationData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthenticationOnly` | `bool?` | Optional | If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.<br>Default: *false**.<br>**Default**: `false` |

## Example (as JSON)

```json
{
  "authenticationOnly": false
}
```

