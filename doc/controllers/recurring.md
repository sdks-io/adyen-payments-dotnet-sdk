# Recurring

```csharp
RecurringController recurringController = client.RecurringController;
```

## Class Name

`RecurringController`

## Methods

* [Get-Stored Payment Methods](../../doc/controllers/recurring.md#get-stored-payment-methods)
* [Delete-Stored Payment Methods-Stored Payment Method Id](../../doc/controllers/recurring.md#delete-stored-payment-methods-stored-payment-method-id)


# Get-Stored Payment Methods

Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.

```csharp
GetStoredPaymentMethodsAsync(
    string shopperReference = null,
    string merchantAccount = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `shopperReference` | `string` | Query, Optional | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `merchantAccount` | `string` | Query, Optional | Your merchant account. |

## Response Type

[`Task<Models.ListStoredPaymentMethodsResponse>`](../../doc/models/list-stored-payment-methods-response.md)

## Example Usage

```csharp
try
{
    ListStoredPaymentMethodsResponse result = await recurringController.GetStoredPaymentMethodsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "shopperReference": "YOUR_SHOPPER_REFERENCE",
  "storedPaymentMethods": [
    {
      "brand": "visa",
      "expiryMonth": "10",
      "expiryYear": "30",
      "holderName": "John Smith",
      "id": "7219687191761347",
      "issuerName": "ISSUER_NAME",
      "lastFour": "1111",
      "name": "VISA",
      "shopperEmail": "john.smith@example.com",
      "shopperReference": "YOUR_SHOPPER_REFERENCE",
      "supportedRecurringProcessingModels": [
        "CardOnFile",
        "Subscription",
        "UnscheduledCardOnFile"
      ],
      "type": "scheme"
    }
  ]
}
```


# Delete-Stored Payment Methods-Stored Payment Method Id

Deletes the token identified in the path. The token can no longer be used with payment requests.

```csharp
DeleteStoredPaymentMethodsStoredPaymentMethodIdAsync(
    string storedPaymentMethodId,
    string shopperReference,
    string merchantAccount)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `storedPaymentMethodId` | `string` | Template, Required | The unique identifier of the token. |
| `shopperReference` | `string` | Query, Required | Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters.<br><br>> Your reference must not include personally identifiable information (PII), for example name or email address. |
| `merchantAccount` | `string` | Query, Required | Your merchant account. |

## Response Type

`Task`

## Example Usage

```csharp
string storedPaymentMethodId = "storedPaymentMethodId4";
string shopperReference = "shopperReference8";
string merchantAccount = "merchantAccount8";
try
{
    await recurringController.DeleteStoredPaymentMethodsStoredPaymentMethodIdAsync(
        storedPaymentMethodId,
        shopperReference,
        merchantAccount
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

