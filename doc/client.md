
# Client Class Documentation

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

## Adyen Merged APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| PaymentsController | Gets PaymentsController controller. |
| PaymentLinksController | Gets PaymentLinksController controller. |
| ModificationsController | Gets ModificationsController controller. |
| RecurringController | Gets RecurringController controller. |
| OrdersController | Gets OrdersController controller. |
| UtilityController | Gets UtilityController controller. |
| ClassicCheckoutSDKController | Gets ClassicCheckoutSDKController controller. |
| InitializationController | Gets InitializationController controller. |
| ReviewingController | Gets ReviewingController controller. |
| InstantPayoutsController | Gets InstantPayoutsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| XAPIKey | API Key | `string` |
| Environment | Current API environment. | `Environment` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Checkout)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Adyen Merged APIClient using the values provided for the builder. | `Builder` |

## Adyen Merged APIClient Builder Class

Class to build instances of Adyen Merged APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `XAPIKey(string xAPIKey)` | API Key | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

