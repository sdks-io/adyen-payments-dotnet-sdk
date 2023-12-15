# Instantpayouts

```csharp
InstantpayoutsController instantpayoutsController = client.InstantpayoutsController;
```

## Class Name

`InstantpayoutsController`


# Post-Payout

With this call, you can pay out to your customers, and funds will be made available within 30 minutes on the cardholder's bank account (this is dependent on whether the issuer supports this functionality). Instant card payouts are only supported for Visa and Mastercard cards.

```csharp
PostPayoutAsync(
    Models.PayoutRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PayoutRequest`](../../doc/models/payout-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PayoutResponse>`](../../doc/models/payout-response.md)

## Example Usage

```csharp
PayoutRequest body = new PayoutRequest
{
    Amount = new Amount
    {
        Currency = "USD",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "P9999999999999999",
    BillingAddress = new Address
    {
        City = "Beverly Hills",
        Country = "US",
        HouseNumberOrName = "121",
        PostalCode = "90210",
        Street = "Brannan Street",
        StateOrProvince = "CA",
    },
    Card = new Card
    {
        ExpiryMonth = "03",
        ExpiryYear = "2030",
        HolderName = "John Smith",
        Number = "4111111111111111",
    },
    ShopperName = new Name
    {
        FirstName = "John",
        LastName = "Smith",
    },
};

try
{
    PayoutResponse result = await instantPayoutsController.PostPayoutAsync(body);
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

