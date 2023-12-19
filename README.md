
# Getting Started with Adyen Merged API

## Introduction

Adyen Checkout API provides a simple and flexible way to initiate and authorise online payments. You can use the same integration for payments made with cards (including 3D Secure), mobile wallets, and local payment methods (for example, iDEAL and Sofort).

This API reference provides information on available endpoints and how to interact with them. To learn more about the API, visit [online payments documentation](https://docs.adyen.com/online-payments).

### Authentication

Each request to Checkout API must be signed with an API key. For this, [get your API key](https://docs.adyen.com/development-resources/api-credentials#generate-api-key) from your Customer Area, and set this key to the `X-API-Key` header value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

### Versioning

Checkout API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:

```
https://checkout-test.adyen.com/v71/payments
```

### Going live

To access the live endpoints, you need an API key from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account, for example:

```
https://{PREFIX}-checkout-live.adyenpayments.com/checkout/v71/payments
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**.

When preparing to do live transactions with Checkout API, follow the [go-live checklist](https://docs.adyen.com/online-payments/go-live-checklist) to make sure you've got all the required configuration in place.

### Release notes

Have a look at the [release notes](https://docs.adyen.com/online-payments/release-notes?integration_type=api&version=71) to find out what changed in this version!

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.AdyenPaymentsSDK --version 1.0.1
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.AdyenPaymentsSDK/1.0.1

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `XAPIKey` | `string` | API Key |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Live`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthUserName` | `string` | The username to use with basic authentication |
| `BasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
AdyenMergedAPI.Standard.AdyenMergedAPIClient client = new AdyenMergedAPI.Standard.AdyenMergedAPIClient.Builder()
    .BasicAuthCredentials("BasicAuthUserName", "BasicAuthPassword")
    .XAPIKey("X-API-Key")
    .Environment(AdyenMergedAPI.Standard.Environment.Live)
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Live | **Default** |
| Test | - |

## Authorization

This API uses `Basic Authentication`.

## List of APIs

* [Paymentlinks](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/paymentlinks.md)
* [Classic Checkout SDK](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/classic-checkout-sdk.md)
* [Instantpayouts](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/instantpayouts.md)
* [Payments](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/payments.md)
* [Modifications](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/modifications.md)
* [Recurring](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/recurring.md)
* [Orders](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/orders.md)
* [Utility](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/utility.md)
* [Initialization](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/initialization.md)
* [Reviewing](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/controllers/reviewing.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.1/doc/api-exception.md)

