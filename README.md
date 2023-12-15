
# Getting Started with Adyen Merged API

## Introduction

A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods.

To learn more about the API, visit [Classic integration](https://docs.adyen.com/classic-integration).

### Authentication

You need an [API credential](https://docs.adyen.com/development-resources/api-credentials) to authenticate to the API.

If using an API key, add an `X-API-Key` header with the API key as the value, for example:

```
curl
-H "Content-Type: application/json" \
-H "X-API-Key: YOUR_API_KEY" \
...
```

Alternatively, you can use the username and password to connect to the API using basic authentication, for example:

```
curl
-U "ws@Company.YOUR_COMPANY_ACCOUNT":"YOUR_BASIC_AUTHENTICATION_PASSWORD" \
-H "Content-Type: application/json" \
...
```

### Versioning

Payments API supports [versioning](https://docs.adyen.com/development-resources/versioning) using a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number.

For example:

```
https://pal-test.adyen.com/pal/servlet/Payment/v68/authorise
```

### Going live

To authenticate to the live endpoints, you need an [API credential](https://docs.adyen.com/development-resources/api-credentials) from your live Customer Area.

The live endpoint URLs contain a prefix which is unique to your company account:

```

https://{PREFIX}-pal-live.adyenpayments.com/pal/servlet/Payment/v68/authorise
```

Get your `{PREFIX}` from your live Customer Area under **Developers** > **API URLs** > **Prefix**.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package sdksio.AdyenPaymentsSDK --version 1.0.0
```

You can also view the package at:
https://www.nuget.org/packages/sdksio.AdyenPaymentsSDK/1.0.0

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `XAPIKey` | `string` | API Key |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthUserName` | `string` | The username to use with basic authentication |
| `BasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
AdyenMergedAPI.Standard.AdyenMergedAPIClient client = new AdyenMergedAPI.Standard.AdyenMergedAPIClient.Builder()
    .BasicAuthCredentials("BasicAuthUserName", "BasicAuthPassword")
    .XAPIKey("X-API-Key")
    .Environment(AdyenMergedAPI.Standard.Environment.Production)
    .Build();
```

## Authorization

This API uses `Basic Authentication`.

## List of APIs

* [Instantpayouts](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/controllers/instantpayouts.md)
* [Payments](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/controllers/payments.md)
* [Modifications](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/controllers/modifications.md)
* [Initialization](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/controllers/initialization.md)
* [Reviewing](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/controllers/reviewing.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-string-response.md)
* [HttpContext](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/sdks-io/adyen-payments-dotnet-sdk/tree/1.0.0/doc/api-exception.md)

