# Classic Checkout SDK

```csharp
ClassicCheckoutSDKController classicCheckoutSDKController = client.ClassicCheckoutSDKController;
```

## Class Name

`ClassicCheckoutSDKController`

## Methods

* [Post-Payment Session](../../doc/controllers/classic-checkout-sdk.md#post-payment-session)
* [Post-Payments-Result](../../doc/controllers/classic-checkout-sdk.md#post-payments-result)


# Post-Payment Session

**This endpoint is deprecated.**

Provides the data object that can be used to start the Checkout SDK. To set up the payment, pass its amount, currency, and other required parameters. We use this to optimise the payment flow and perform better risk assessment of the transaction.

For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).

```csharp
PostPaymentSessionAsync(
    string idempotencyKey = null,
    Models.PaymentSetupRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentSetupRequest`](../../doc/models/payment-setup-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentSetupResponse>`](../../doc/models/payment-setup-response.md)

## Example Usage

```csharp
PaymentSetupRequest body = new PaymentSetupRequest
{
    Amount = new Amount2
    {
        Currency = "EUR",
        MValue = 17408L,
    },
    CountryCode = "NL",
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "Your order number",
    ReturnUrl = "app://",
    Channel = Channel2Enum.Android,
    SessionValidity = "2017-04-06T13:09:13Z",
    ShopperLocale = "nl_NL",
    ShopperReference = "YOUR_SHOPPER_REFERENCE",
    Token = "TOKEN_YOU_GET_FROM_CHECKOUT_SDK",
};

try
{
    PaymentSetupResponse result = await classicCheckoutSDKController.PostPaymentSessionAsync(
        null,
        body
    );
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
  "paymentSession": "eyJjaGVja291dHNob3BwZXJCYXN..."
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


# Post-Payments-Result

**This endpoint is deprecated.**

Verifies the payment result using the payload returned from the Checkout SDK.

For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).

```csharp
PostPaymentsResultAsync(
    string idempotencyKey = null,
    Models.PaymentVerificationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentVerificationRequest`](../../doc/models/payment-verification-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentVerificationResponse>`](../../doc/models/payment-verification-response.md)

## Example Usage

```csharp
PaymentVerificationRequest body = new PaymentVerificationRequest
{
    Payload = "VALUE_YOU_GET_FROM_CHECKOUT_SDK",
};

try
{
    PaymentVerificationResponse result = await classicCheckoutSDKController.PostPaymentsResultAsync(
        null,
        body
    );
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
  "authResponse": "Authorised",
  "pspReference": "V4HZ4RBFJGXXGN82",
  "merchantReference": "Your order number",
  "shopperLocale": "nl_NL",
  "paymentMethod": "ideal"
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

