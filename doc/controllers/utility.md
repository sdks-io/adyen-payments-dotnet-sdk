# Utility

```csharp
UtilityController utilityController = client.UtilityController;
```

## Class Name

`UtilityController`

## Methods

* [Post-Apple Pay-Sessions](../../doc/controllers/utility.md#post-apple-pay-sessions)
* [Post-Origin Keys](../../doc/controllers/utility.md#post-origin-keys)


# Post-Apple Pay-Sessions

You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.

The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).

```csharp
PostApplePaySessionsAsync(
    string idempotencyKey = null,
    Models.ApplePaySessionRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`ApplePaySessionRequest`](../../doc/models/apple-pay-session-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ApplePaySessionResponse>`](../../doc/models/apple-pay-session-response.md)

## Example Usage

```csharp
ApplePaySessionRequest body = new ApplePaySessionRequest
{
    DisplayName = "YOUR_MERCHANT_NAME",
    DomainName = "YOUR_DOMAIN_NAME",
    MerchantIdentifier = "YOUR_MERCHANT_ID",
};

try
{
    ApplePaySessionResponse result = await utilityController.PostApplePaySessionsAsync(
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
  "data": "eyJ2Z..."
}
```


# Post-Origin Keys

**This endpoint is deprecated.**

This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains.

> If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.

```csharp
PostOriginKeysAsync(
    string idempotencyKey = null,
    Models.UtilityRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`UtilityRequest`](../../doc/models/utility-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.UtilityResponse>`](../../doc/models/utility-response.md)

## Example Usage

```csharp
UtilityRequest body = new UtilityRequest
{
    OriginDomains = new List<string>
    {
        "https://www.your-domain1.com",
        "https://www.your-domain2.com",
        "https://www.your-domain3.com",
    },
};

try
{
    UtilityResponse result = await utilityController.PostOriginKeysAsync(
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
  "originKeys": {
    "https://www.your-domain1.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4xLmNvbQ.pvbYlrXz0ICP4kwMJXDGDLVMqALhwXr1MSRjT-fkhvw",
    "https://www.your-domain3.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4zLmNvbQ.FrTpVz7_RzAywKasM0kXCRoMfoMkKIKaxjFymRGORIc",
    "https://www.your-domain2.com": "pub.v2.8116178901076090.aHR0cHM6Ly93d3cueW91ci1kb21haW4yLmNvbQ.LdN9kvJ35fYFFiBSJA4idMnwwxJ5_yXpeNS__Ap5wkg"
  }
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

