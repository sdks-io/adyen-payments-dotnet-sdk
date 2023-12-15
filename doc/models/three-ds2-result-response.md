
# Three DS2 Result Response

## Structure

`ThreeDS2ResultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ThreeDS2Result` | [`ThreeDS2Result3`](../../doc/models/three-ds2-result-3.md) | Optional | The result of the 3D Secure 2 authentication. |

## Example (as JSON)

```json
{
  "threeDS2Result": {
    "authenticationValue": "authenticationValue8",
    "cavvAlgorithm": "cavvAlgorithm8",
    "challengeCancel": "06",
    "dsTransID": "dsTransID2",
    "eci": "eci6"
  }
}
```

