# Payments

```csharp
PaymentsController paymentsController = client.PaymentsController;
```

## Class Name

`PaymentsController`

## Methods

* [Post-Authorise](../../doc/controllers/payments.md#post-authorise)
* [Post-Authorise 3 D](../../doc/controllers/payments.md#post-authorise-3-d)
* [Post-Authorise 3 Ds 2](../../doc/controllers/payments.md#post-authorise-3-ds-2)
* [Post-Get Authentication Result](../../doc/controllers/payments.md#post-get-authentication-result)
* [Post-Retrieve 3 Ds 2 Result](../../doc/controllers/payments.md#post-retrieve-3-ds-2-result)


# Post-Authorise

Creates a payment with a unique reference (`pspReference`) and attempts to obtain an authorisation hold. For cards, this amount can be captured or cancelled later. Non-card payment methods typically don't support this and will automatically capture as part of the authorisation.

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments) endpoint under Checkout API instead.

```csharp
PostAuthoriseAsync(
    Models.PaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PaymentRequest`](../../doc/models/payment-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentResult>`](../../doc/models/payment-result.md)

## Example Usage

```csharp
PaymentRequest body = new PaymentRequest
{
    Amount = new Amount
    {
        Currency = "USD",
        MValue = 1500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_REFERENCE_NUMBER",
    AccountInfo = new AccountInfo1
    {
        AccountCreationDate = DateTime.ParseExact("2019-01-17T13:42:40+01:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
    BillingAddress = new Address3
    {
        City = "New York",
        Country = "US",
        HouseNumberOrName = "37C",
        PostalCode = "10039",
        Street = "Redwood Block",
        StateOrProvince = "NY",
    },
    BrowserInfo = new BrowserInfo1
    {
        AcceptHeader = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8",
        ColorDepth = 24,
        JavaEnabled = false,
        Language = "en",
        ScreenHeight = 723,
        ScreenWidth = 1536,
        TimeZoneOffset = 0,
        UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36",
    },
    Card = new Card3
    {
        Cvc = "737",
        ExpiryMonth = "03",
        ExpiryYear = "2030",
        HolderName = "John Smith",
        Number = "4917610000000000",
    },
    ShopperEmail = "s.hopper@test.com",
    ShopperIP = "192.0.2.1",
    ThreeDS2RequestData = new ThreeDS2RequestData1
    {
        DeviceChannel = "browser",
        NotificationURL = "https://www.example.com/YOUR_3DS_NOTIFICATION_URL",
    },
};

try
{
    PaymentResult result = await paymentsController.PostAuthoriseAsync(body);
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


# Post-Authorise 3 D

For an authenticated 3D Secure session, completes the payment authorisation. This endpoint must receive the `md` and `paResponse` parameters that you get from the card issuer after a shopper pays via 3D Secure.

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce/3d-secure). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/details`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/details) endpoint under Checkout API instead.

```csharp
PostAuthorise3dAsync(
    Models.PaymentRequest3d body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PaymentRequest3d`](../../doc/models/payment-request-3-d.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentResult>`](../../doc/models/payment-result.md)

## Example Usage

```csharp
PaymentRequest3d body = new PaymentRequest3d
{
    Md = "31h..........vOXek7w",
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaResponse = "eNqtmF........wGVA4Ch",
    ShopperIP = "61.294.12.12",
};

try
{
    PaymentResult result = await paymentsController.PostAuthorise3dAsync(body);
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


# Post-Authorise 3 Ds 2

For an authenticated 3D Secure 2 session, completes the payment authorisation. This endpoint must receive the `threeDS2Token` and `threeDS2Result` parameters.

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce/3d-secure). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/details`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/details) endpoint under Checkout API instead.

```csharp
PostAuthorise3ds2Async(
    Models.PaymentRequest3ds2 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PaymentRequest3ds2`](../../doc/models/payment-request-3-ds-2.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentResult>`](../../doc/models/payment-result.md)

## Example Usage

```csharp
PaymentRequest3ds2 body = new PaymentRequest3ds2
{
    Amount = new Amount
    {
        Currency = "EUR",
        MValue = 1000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_ORDER_NUMBER",
    ThreeDS2RequestData = new ThreeDS2RequestData1
    {
        DeviceChannel = "app",
        ThreeDSCompInd = "Y",
    },
    ThreeDS2Token = "— - BINARY DATA - -",
};

try
{
    PaymentResult result = await paymentsController.PostAuthorise3ds2Async(body);
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


# Post-Get Authentication Result

Return the authentication result after doing a 3D Secure authentication only.

```csharp
PostGetAuthenticationResultAsync(
    Models.AuthenticationResultRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AuthenticationResultRequest`](../../doc/models/authentication-result-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.AuthenticationResultResponse>`](../../doc/models/authentication-result-response.md)

## Example Usage

```csharp
AuthenticationResultRequest body = new AuthenticationResultRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PspReference = "9935272408535455",
};

try
{
    AuthenticationResultResponse result = await paymentsController.PostGetAuthenticationResultAsync(body);
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


# Post-Retrieve 3 Ds 2 Result

Retrieves the `threeDS2Result` after doing a 3D Secure 2 authentication only.

```csharp
PostRetrieve3ds2ResultAsync(
    Models.ThreeDS2ResultRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ThreeDS2ResultRequest`](../../doc/models/three-ds2-result-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ThreeDS2ResultResponse>`](../../doc/models/three-ds2-result-response.md)

## Example Usage

```csharp
ThreeDS2ResultRequest body = new ThreeDS2ResultRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PspReference = "9935272408535455",
};

try
{
    ThreeDS2ResultResponse result = await paymentsController.PostRetrieve3ds2ResultAsync(body);
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

