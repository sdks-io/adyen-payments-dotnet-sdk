
# Three DS Request Data

## Structure

`ThreeDSRequestData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChallengeWindowSize` | [`ChallengeWindowSizeEnum?`](../../doc/models/challenge-window-size-enum.md) | Optional | Dimensions of the 3DS2 challenge window to be displayed to the cardholder.<br><br>Possible values:<br><br>* **01** - size of 250x400<br>* **02** - size of 390x400<br>* **03** - size of 500x600<br>* **04** - size of 600x400<br>* **05** - Fullscreen |
| `DataOnly` | [`DataOnlyEnum?`](../../doc/models/data-only-enum.md) | Optional | Flag for data only flow. |
| `NativeThreeDS` | [`NativeThreeDSEnum?`](../../doc/models/native-three-ds-enum.md) | Optional | Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.<br><br>Possible values:<br><br>* **preferred**: Use native 3D Secure authentication when available. |
| `ThreeDSVersion` | [`ThreeDSVersionEnum?`](../../doc/models/three-ds-version-enum.md) | Optional | The version of 3D Secure to use.<br><br>Possible values:<br><br>* **2.1.0**<br>* **2.2.0** |

## Example (as JSON)

```json
{
  "challengeWindowSize": "02",
  "dataOnly": "false",
  "nativeThreeDS": "preferred",
  "threeDSVersion": "2.1.0"
}
```

