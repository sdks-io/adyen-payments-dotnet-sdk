
# Store Detail Request

## Structure

`StoreDetailRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AdditionalData` | `Dictionary<string, string>` | Optional | This field contains additional data, which may be required for a particular request. |
| `Bank` | [`BankAccount`](../../doc/models/bank-account.md) | Optional | A container for bank account data.<br><br>> This field is mandatory if `card` is not provided. |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The billing address.<br><br>> The `billingAddress` object is required for cross-border payouts to and from Canada. Include all of the fields within this object. |
| `Card` | [`Card`](../../doc/models/card.md) | Optional | A container for card data.<br><br>> This field is mandatory if `bank` is not provided. |
| `DateOfBirth` | `DateTime` | Required | The date of birth.<br>Format: [ISO-8601](https://www.w3.org/TR/NOTE-datetime); example: YYYY-MM-DD<br>For Paysafecard it must be the same as used when registering the Paysafecard account.<br><br>> This field is mandatory for natural persons. |
| `EntityType` | [`EntityType1Enum`](../../doc/models/entity-type-1-enum.md) | Required | The type of the entity the payout is processed for. |
| `FraudOffset` | `int?` | Optional | An integer value that is added to the normal fraud score. The value can be either positive or negative. |
| `MerchantAccount` | `string` | Required | The merchant account identifier, with which you want to process the transaction. |
| `Nationality` | `string` | Required | The shopper's nationality.<br><br>A valid value is an ISO 2-character country code (e.g. 'NL').<br>**Constraints**: *Maximum Length*: `2` |
| `Recurring` | [`Recurring`](../../doc/models/recurring.md) | Required | A container for the type of recurring contract to be retrieved.<br><br>The recurring.contract must be set to `PAYOUT` |
| `SelectedBrand` | `string` | Optional | The name of the brand to make a payout to.<br><br>For Paysafecard it must be set to `paysafecard`. |
| `ShopperEmail` | `string` | Required | The shopper's email address. |
| `ShopperName` | [`Name`](../../doc/models/name.md) | Optional | The shopper's name.<br><br>When the `entityType` is `Company`, the `shopperName.lastName` must contain the company name. |
| `ShopperReference` | `string` | Required | The shopper's reference for the payment transaction. |
| `SocialSecurityNumber` | `string` | Optional | The shopper's social security number. |
| `TelephoneNumber` | `string` | Optional | The shopper's phone number. |

## Example (as JSON)

```json
{
  "additionalData": {
    "key0": "additionalData6",
    "key1": "additionalData5",
    "key2": "additionalData4"
  },
  "bank": {
    "bankAccountNumber": "bankAccountNumber8",
    "bankCity": "bankCity0",
    "bankLocationId": "bankLocationId2",
    "bankName": "bankName4",
    "bic": "bic0"
  },
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "card": {
    "cvc": "cvc0",
    "expiryMonth": "expiryMonth0",
    "expiryYear": "expiryYear0",
    "holderName": "holderName2",
    "issueNumber": "issueNumber8"
  },
  "dateOfBirth": "2016-03-13",
  "entityType": "NaturalPerson",
  "fraudOffset": 114,
  "merchantAccount": "merchantAccount2",
  "nationality": "nationality4",
  "recurring": {
    "contract": "RECURRING",
    "recurringDetailName": "recurringDetailName2",
    "recurringExpiry": "2016-03-13T12:52:32.123Z",
    "recurringFrequency": "recurringFrequency0",
    "tokenService": "VISATOKENSERVICE"
  },
  "shopperEmail": "shopperEmail0",
  "shopperReference": "shopperReference4"
}
```

