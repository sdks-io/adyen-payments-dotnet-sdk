
# Three DS2 Response Data 1

Response of the 3D Secure 2 authentication.

## Structure

`ThreeDS2ResponseData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AcsChallengeMandated` | `string` | Optional | - |
| `AcsOperatorID` | `string` | Optional | - |
| `AcsReferenceNumber` | `string` | Optional | - |
| `AcsSignedContent` | `string` | Optional | - |
| `AcsTransID` | `string` | Optional | - |
| `AcsURL` | `string` | Optional | - |
| `AuthenticationType` | `string` | Optional | - |
| `CardHolderInfo` | `string` | Optional | - |
| `CavvAlgorithm` | `string` | Optional | - |
| `ChallengeIndicator` | `string` | Optional | - |
| `DsReferenceNumber` | `string` | Optional | - |
| `DsTransID` | `string` | Optional | - |
| `ExemptionIndicator` | `string` | Optional | - |
| `MessageVersion` | `string` | Optional | - |
| `RiskScore` | `string` | Optional | - |
| `SdkEphemPubKey` | `string` | Optional | - |
| `ThreeDSServerTransID` | `string` | Optional | - |
| `TransStatus` | `string` | Optional | - |
| `TransStatusReason` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "acsChallengeMandated": "acsChallengeMandated0",
  "acsOperatorID": "acsOperatorID0",
  "acsReferenceNumber": "acsReferenceNumber0",
  "acsSignedContent": "acsSignedContent6",
  "acsTransID": "acsTransID0"
}
```

