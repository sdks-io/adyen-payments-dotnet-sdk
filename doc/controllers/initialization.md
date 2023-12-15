# Initialization

```csharp
InitializationController initializationController = client.InitializationController;
```

## Class Name

`InitializationController`

## Methods

* [Post-Store Detail](../../doc/controllers/initialization.md#post-store-detail)
* [Post-Store Detail and Submit Third Party](../../doc/controllers/initialization.md#post-store-detail-and-submit-third-party)
* [Post-Submit Third Party](../../doc/controllers/initialization.md#post-submit-third-party)


# Post-Store Detail

Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call.

```csharp
PostStoreDetailAsync(
    Models.StoreDetailRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`StoreDetailRequest`](../../doc/models/store-detail-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.StoreDetailResponse>`](../../doc/models/store-detail-response.md)

## Example Usage

```csharp
StoreDetailRequest body = new StoreDetailRequest
{
    DateOfBirth = DateTime.Parse("1990-01-01"),
    EntityType = EntityType1Enum.Company,
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Nationality = "NL",
    Recurring = new Recurring
    {
        Contract = ContractEnum.PAYOUT,
    },
    ShopperEmail = "shopper@email.com",
    ShopperReference = "YOUR_UNIQUE_SHOPPER_ID",
    Bank = new BankAccount
    {
        BankCity = "Amsterdam",
        BankName = "AbnAmro",
        Bic = "ABNANL2A",
        CountryCode = "NL",
        Iban = "NL32ABNA0515071439",
        OwnerName = "Adyen",
        TaxId = "bankTaxId",
    },
    BillingAddress = new Address
    {
        City = "Amsterdam",
        Country = "US",
        HouseNumberOrName = "17",
        PostalCode = "12345",
        Street = "Teststreet 1",
        StateOrProvince = "NY",
    },
    ShopperName = new Name
    {
        FirstName = "Adyen",
        LastName = "Test",
    },
};

try
{
    StoreDetailResponse result = await initializationController.PostStoreDetailAsync(body);
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
  "pspReference": "991617894326362D",
  "recurringDetailReference": "9916178936754752",
  "resultCode": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Store Detail and Submit Third Party

Submits a payout and stores its details for subsequent payouts.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

```csharp
PostStoreDetailAndSubmitThirdPartyAsync(
    Models.StoreDetailAndSubmitRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`StoreDetailAndSubmitRequest`](../../doc/models/store-detail-and-submit-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.StoreDetailAndSubmitResponse>`](../../doc/models/store-detail-and-submit-response.md)

## Example Usage

```csharp
StoreDetailAndSubmitRequest body = new StoreDetailAndSubmitRequest
{
    Amount = new Amount
    {
        Currency = "EUR",
        MValue = 2000L,
    },
    DateOfBirth = DateTime.Parse("1990-01-01"),
    EntityType = EntityType1Enum.Company,
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Nationality = "NL",
    Recurring = new Recurring
    {
        Contract = ContractEnum.PAYOUT,
    },
    Reference = "Your Reference Here",
    ShopperEmail = "s.hopper@test.com",
    ShopperReference = "YOUR_SHOPPER_REFERENCE",
    Bank = new BankAccount
    {
        BankName = "Commerzbank",
        CountryCode = "DE",
        Iban = "DE87123456781234567890",
        OwnerName = "Simon Hopper",
    },
    ShopperName = new Name
    {
        FirstName = "Adyen",
        LastName = "Test",
    },
};

try
{
    StoreDetailAndSubmitResponse result = await initializationController.PostStoreDetailAndSubmitThirdPartyAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |


# Post-Submit Third Party

Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.

The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.

```csharp
PostSubmitThirdPartyAsync(
    Models.SubmitRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubmitRequest`](../../doc/models/submit-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.SubmitResponse>`](../../doc/models/submit-response.md)

## Example Usage

```csharp
SubmitRequest body = new SubmitRequest
{
    Amount = new Amount
    {
        Currency = "EUR",
        MValue = 1000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Recurring = new Recurring
    {
        Contract = ContractEnum.PAYOUT,
    },
    Reference = "PayoutPayment-0001",
    SelectedRecurringDetailReference = "LATEST",
    ShopperEmail = "shopper@email.com",
    ShopperReference = "YOUR_UNIQUE_SHOPPER_ID",
    DateOfBirth = DateTime.Parse("1990-01-01"),
    EntityType = EntityType2Enum.Company,
    Nationality = "NL",
    ShopperName = new Name
    {
        FirstName = "Adyen",
        LastName = "Test",
    },
};

try
{
    SubmitResponse result = await initializationController.PostSubmitThirdPartyAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request - a problem reading or understanding the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 401 | Unauthorized - authentication required. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 403 | Forbidden - insufficient permissions to process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 422 | Unprocessable Entity - a request validation error. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |
| 500 | Internal Server Error - the server could not process the request. | [`ServiceErrorException`](../../doc/models/service-error-exception.md) |

