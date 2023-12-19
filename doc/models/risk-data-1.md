
# Risk Data 1

Any risk-related settings to apply to the payment.

## Structure

`RiskData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientData` | `string` | Optional | Contains client-side data, like the device fingerprint, cookies, and specific browser settings. |
| `CustomFields` | `Dictionary<string, string>` | Optional | Any custom fields used as part of the input to configured risk rules. |
| `FraudOffset` | `int?` | Optional | An integer value that is added to the normal fraud score. The value can be either positive or negative. |
| `ProfileReference` | `string` | Optional | The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied. |

## Example (as JSON)

```json
{
  "clientData": "clientData4",
  "customFields": {
    "key0": "customFields2",
    "key1": "customFields3",
    "key2": "customFields4"
  },
  "fraudOffset": 110,
  "profileReference": "profileReference2"
}
```

