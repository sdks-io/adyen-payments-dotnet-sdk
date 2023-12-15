
# Submit Request

## Structure

`SubmitRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular request. |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Required | A container object for the payable amount information of the transaction. |
| `DateOfBirth` | `DateTime?` | Optional | The date of birth.<br>Format: ISO-8601; example: YYYY-MM-DD<br><br>For Paysafecard it must be the same as used when registering the Paysafecard account.<br><br>> This field is mandatory for natural persons.<br>> This field is required to update the existing `dateOfBirth` that is associated with this recurring contract. |
| `EntityType` | [`EntityType2Enum?`](../../doc/models/entity-type-2-enum.md) | Optional | The type of the entity the payout is processed for.<br><br>Allowed values:<br><br>* NaturalPerson<br>* Company<br><br>> This field is required to update the existing `entityType` that is associated with this recurring contract. |
| `FraudOffset` | `int?` | Optional | An integer value that is added to the normal fraud score. The value can be either positive or negative. |
| `MerchantAccount` | `string` | Required | The merchant account identifier you want to process the transaction request with. |
| `Nationality` | `string` | Optional | The shopper's nationality.<br><br>A valid value is an ISO 2-character country code (e.g. 'NL').<br><br>> This field is required to update the existing nationality that is associated with this recurring contract. |
| `Recurring` | [`Recurring`](../../doc/models/recurring.md) | Required | A container for the type of recurring contract to be retrieved.<br><br>The `recurring.contract` must be set to "PAYOUT". |
| `Reference` | `string` | Required | The merchant reference for this payout. This reference will be used in all communication to the merchant about the status of the payout. Although it is a good idea to make sure it is unique, this is not a requirement. |
| `SelectedRecurringDetailReference` | `string` | Required | This is the `recurringDetailReference` you want to use for this payout.<br><br>You can use the value LATEST to select the most recently used recurring detail. |
| `ShopperEmail` | `string` | Required | The shopper's email address. |
| `ShopperName` | [`Name`](../../doc/models/name.md) | Optional | The shopper's name.<br><br>In case the `entityType` is `Company`, the `shopperName.lastName` must contain the company name.<br><br>> This field is required to update the existing `shopperName` associated with a recurring contract. |
| `ShopperReference` | `string` | Required | The shopper's reference for the payout transaction. |
| `ShopperStatement` | `string` | Optional | The description of this payout. This description is shown on the bank statement of the shopper (if this is supported by the chosen payment method). |
| `SocialSecurityNumber` | `string` | Optional | The shopper's social security number. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData2"
  },
  "amount": {
    "currency": "currency2",
    "value": 110
  },
  "dateOfBirth": "2016-03-13",
  "entityType": "NaturalPerson",
  "fraudOffset": 192,
  "merchantAccount": "merchantAccount4",
  "nationality": "nationality0",
  "recurring": {
    "contract": "RECURRING",
    "recurringDetailName": "recurringDetailName2",
    "recurringExpiry": "2016-03-13T12:52:32.123Z",
    "recurringFrequency": "recurringFrequency0",
    "tokenService": "VISATOKENSERVICE"
  },
  "reference": "reference8",
  "selectedRecurringDetailReference": "selectedRecurringDetailReference2",
  "shopperEmail": "shopperEmail6",
  "shopperReference": "shopperReference0"
}
```

