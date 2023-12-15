
# Three D Secure Data

## Structure

`ThreeDSecureData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthenticationResponse` | [`AuthenticationResponseEnum?`](../../doc/models/authentication-response-enum.md) | Optional | In 3D Secure 1, the authentication response if the shopper was redirected.<br><br>In 3D Secure 2, this is the `transStatus` from the challenge result. If the transaction was frictionless, omit this parameter. |
| `Cavv` | `string` | Optional | The cardholder authentication value (base64 encoded, 20 bytes in a decoded form). |
| `CavvAlgorithm` | `string` | Optional | The CAVV algorithm used. Include this only for 3D Secure 1. |
| `ChallengeCancel` | [`ChallengeCancelEnum?`](../../doc/models/challenge-cancel-enum.md) | Optional | Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to [3D Secure API reference](https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata). |
| `DirectoryResponse` | [`DirectoryResponseEnum?`](../../doc/models/directory-response-enum.md) | Optional | In 3D Secure 1, this is the enrollment response from the 3D directory server.<br><br>In 3D Secure 2, this is the `transStatus` from the `ARes`. |
| `DsTransID` | `string` | Optional | Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction. |
| `Eci` | `string` | Optional | The electronic commerce indicator. |
| `RiskScore` | `string` | Optional | Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations. |
| `ThreeDSVersion` | `string` | Optional | The version of the 3D Secure protocol. |
| `TokenAuthenticationVerificationValue` | `string` | Optional | Network token authentication verification value (TAVV). The network token cryptogram. |
| `TransStatusReason` | `string` | Optional | Provides information on why the `transStatus` field has the specified value. For possible values, refer to [our docs](https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values). |
| `Xid` | `string` | Optional | Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form). |

## Example (as JSON)

```json
{
  "authenticationResponse": "Y",
  "cavv": "cavv6",
  "cavvAlgorithm": "cavvAlgorithm4",
  "challengeCancel": "02",
  "directoryResponse": "N"
}
```

