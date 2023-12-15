# Reviewing

```csharp
ReviewingController reviewingController = client.ReviewingController;
```

## Class Name

`ReviewingController`

## Methods

* [Post-Confirm Third Party](../../doc/controllers/reviewing.md#post-confirm-third-party)
* [Post-Decline Third Party](../../doc/controllers/reviewing.md#post-decline-third-party)


# Post-Confirm Third Party

Confirms a previously submitted payout.

To cancel a payout, use the `/declineThirdParty` endpoint.

```csharp
PostConfirmThirdPartyAsync(
    Models.ModifyRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ModifyRequest`](../../doc/models/modify-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModifyResponse>`](../../doc/models/modify-response.md)

## Example Usage

```csharp
ModifyRequest body = new ModifyRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalReference = "9913140798220028",
};

try
{
    ModifyResponse result = await reviewingController.PostConfirmThirdPartyAsync(body);
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
  "pspReference": "991617894325358C",
  "response": "[payout-confirm-received]"
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


# Post-Decline Third Party

Cancels a previously submitted payout.

To confirm and send a payout, use the `/confirmThirdParty` endpoint.

```csharp
PostDeclineThirdPartyAsync(
    Models.ModifyRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ModifyRequest`](../../doc/models/modify-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModifyResponse>`](../../doc/models/modify-response.md)

## Example Usage

```csharp
ModifyRequest body = new ModifyRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalReference = "9913140798220028",
};

try
{
    ModifyResponse result = await reviewingController.PostDeclineThirdPartyAsync(body);
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
  "pspReference": "991617894325360J",
  "response": "[payout-decline-received]"
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

