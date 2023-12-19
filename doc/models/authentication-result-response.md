
# Authentication Result Response

## Structure

`AuthenticationResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ThreeDS1Result` | [`ThreeDS1Result2`](../../doc/models/three-ds1-result-2.md) | Optional | The result of the 3D Secure authentication. |
| `ThreeDS2Result` | [`ThreeDS2Result`](../../doc/models/three-ds2-result.md) | Optional | The result of the 3D Secure 2 authentication. |

## Example (as JSON)

```json
{
  "threeDS1Result": {
    "cavv": "cavv2",
    "cavvAlgorithm": "cavvAlgorithm8",
    "eci": "eci6",
    "threeDAuthenticatedResponse": "threeDAuthenticatedResponse8",
    "threeDOfferedResponse": "threeDOfferedResponse2"
  },
  "threeDS2Result": {
    "authenticationValue": "authenticationValue8",
    "cavvAlgorithm": "cavvAlgorithm8",
    "challengeCancel": "06",
    "dsTransID": "dsTransID2",
    "eci": "eci6"
  }
}
```

