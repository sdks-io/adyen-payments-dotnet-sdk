
# Fund Recipient

## Structure

`FundRecipient`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | The address where to send the invoice. |
| `PaymentMethod` | [`Card2`](../../doc/models/card-2.md) | Optional | the used paymentMetohd |
| `ShopperEmail` | `string` | Optional | the email address of the person |
| `ShopperName` | [`Name2`](../../doc/models/name-2.md) | Optional | the name of the person |
| `ShopperReference` | `string` | Optional | Required for recurring payments.<br>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address.<br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `256` |
| `StoredPaymentMethodId` | `string` | Optional | This is the `recurringDetailReference` returned in the response when you created the token.<br>**Constraints**: *Maximum Length*: `64` |
| `SubMerchant` | [`SubMerchant`](../../doc/models/sub-merchant.md) | Optional | Required for Back-to-Back/ purchase driven load in Wallet transactions.<br>Contains the final merchant who will be receiving the money, also known as subMerchant, information. |
| `TelephoneNumber` | `string` | Optional | the telephone number of the person |
| `WalletIdentifier` | `string` | Optional | indicates where the money is going |
| `WalletOwnerTaxId` | `string` | Optional | indicates the tax identifier of the fund recepient |

## Example (as JSON)

```json
{
  "billingAddress": {
    "city": "city8",
    "country": "country6",
    "houseNumberOrName": "houseNumberOrName0",
    "postalCode": "postalCode6",
    "stateOrProvince": "stateOrProvince0",
    "street": "street2"
  },
  "paymentMethod": {
    "brand": "brand6",
    "checkoutAttemptId": "checkoutAttemptId8",
    "cupsecureplus.smscode": "cupsecureplus.smscode0",
    "cvc": "cvc6",
    "encryptedCardNumber": "encryptedCardNumber0"
  },
  "shopperEmail": "shopperEmail8",
  "shopperName": {
    "firstName": "firstName2",
    "lastName": "lastName6"
  },
  "shopperReference": "shopperReference2"
}
```

