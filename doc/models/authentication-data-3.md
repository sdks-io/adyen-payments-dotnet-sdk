
# Authentication Data 3

Data for 3DS authentication.

## Structure

`AuthenticationData3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AttemptAuthentication` | [`AttemptAuthenticationEnum?`](../../doc/models/attempt-authentication-enum.md) | Optional | Indicates when 3D Secure authentication should be attempted. This overrides all other rules, including [Dynamic 3D Secure settings](https://docs.adyen.com/risk-management/dynamic-3d-secure).<br><br>Possible values:<br><br>* **always**: Perform 3D Secure authentication.<br>* **never**: Don't perform 3D Secure authentication. If PSD2 SCA or other national regulations require authentication, the transaction gets declined. |
| `AuthenticationOnly` | `bool?` | Optional | If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.<br>Default: **false**.<br>**Default**: `false` |
| `ThreeDSRequestData` | [`ThreeDSRequestData2`](../../doc/models/three-ds-request-data-2.md) | Optional | Object with additional parameters for the 3D Secure authentication flow. |

## Example (as JSON)

```json
{
  "authenticationOnly": false,
  "attemptAuthentication": "always",
  "threeDSRequestData": {
    "challengeWindowSize": "03",
    "dataOnly": "false",
    "nativeThreeDS": "preferred",
    "threeDSVersion": "2.1.0"
  }
}
```

