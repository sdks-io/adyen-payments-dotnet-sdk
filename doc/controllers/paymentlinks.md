# Paymentlinks

```csharp
PaymentlinksController paymentlinksController = client.PaymentlinksController;
```

## Class Name

`PaymentlinksController`

## Methods

* [Post-Payment Links](../../doc/controllers/paymentlinks.md#post-payment-links)
* [Get-Payment Links-Link Id](../../doc/controllers/paymentlinks.md#get-payment-links-link-id)
* [Patch-Payment Links-Link Id](../../doc/controllers/paymentlinks.md#patch-payment-links-link-id)


# Post-Payment Links

Creates a payment link to our hosted payment form where shoppers can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.

For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).

```csharp
PostPaymentLinksAsync(
    string idempotencyKey = null,
    Models.PaymentLinkRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentLinkRequest`](../../doc/models/payment-link-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentLinkResponse>`](../../doc/models/payment-link-response.md)

## Example Usage

```csharp
PaymentLinkRequest body = new PaymentLinkRequest
{
    Amount = new Amount30
    {
        Currency = "BRL",
        MValue = 1250L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_ORDER_NUMBER",
    BillingAddress = new Address
    {
        City = "São Paulo",
        Country = "BR",
        HouseNumberOrName = "999",
        PostalCode = "59000060",
        Street = "Roque Petroni Jr",
        StateOrProvince = "SP",
    },
    CountryCode = "BR",
    DeliveryAddress = new Address2
    {
        City = "São Paulo",
        Country = "BR",
        HouseNumberOrName = "999",
        PostalCode = "59000060",
        Street = "Roque Petroni Jr",
        StateOrProvince = "SP",
    },
    ShopperEmail = "test@email.com",
    ShopperLocale = "pt-BR",
    ShopperReference = "YOUR_SHOPPER_REFERENCE",
};

try
{
    PaymentLinkResponse result = await paymentLinksController.PostPaymentLinksAsync(
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
  "amount": {
    "currency": "BRL",
    "value": 1250
  },
  "billingAddress": {
    "city": "São Paulo",
    "country": "BR",
    "houseNumberOrName": "999",
    "postalCode": "59000060",
    "stateOrProvince": "SP",
    "street": "Roque Petroni Jr"
  },
  "countryCode": "BR",
  "deliveryAddress": {
    "city": "São Paulo",
    "country": "BR",
    "houseNumberOrName": "999",
    "postalCode": "59000060",
    "stateOrProvince": "SP",
    "street": "Roque Petroni Jr"
  },
  "expiresAt": "2022-10-28T09:16:22Z",
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "reference": "YOUR_ORDER_NUMBER",
  "reusable": false,
  "shopperEmail": "test@email.com",
  "shopperLocale": "pt-BR",
  "shopperReference": "YOUR_SHOPPER_REFERENCE",
  "id": "PLE83C39B0A0DE0C1E",
  "status": "active",
  "url": "https://test.adyen.link/PLE83C39B0A0DE0C1E"
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


# Get-Payment Links-Link Id

Retrieves the payment link details using the payment link `id`.

```csharp
GetPaymentLinksLinkIdAsync(
    string linkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `linkId` | `string` | Template, Required | Unique identifier of the payment link. |

## Response Type

[`Task<Models.PaymentLinkResponse>`](../../doc/models/payment-link-response.md)

## Example Usage

```csharp
string linkId = "linkId6";
try
{
    PaymentLinkResponse result = await paymentLinksController.GetPaymentLinksLinkIdAsync(linkId);
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
  "amount": {
    "currency": "EUR",
    "value": 8700
  },
  "countryCode": "NL",
  "expiresAt": "2021-04-08T14:06:39Z",
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "reference": "shopper-reference-ekvL83",
  "shopperLocale": "hu-HU",
  "shopperReference": "shopper-reference-LZfdWZ",
  "status": "active",
  "url": "https://test.adyen.link/PL61C53A8B97E6915A",
  "id": "PL61C53A8B97E6915A"
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


# Patch-Payment Links-Link Id

Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).

```csharp
PatchPaymentLinksLinkIdAsync(
    string linkId,
    Models.UpdatePaymentLinkRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `linkId` | `string` | Template, Required | Unique identifier of the payment link. |
| `body` | [`UpdatePaymentLinkRequest`](../../doc/models/update-payment-link-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentLinkResponse>`](../../doc/models/payment-link-response.md)

## Example Usage

```csharp
string linkId = "linkId6";
UpdatePaymentLinkRequest body = new UpdatePaymentLinkRequest
{
    Status = "expired",
};

try
{
    PaymentLinkResponse result = await paymentLinksController.PatchPaymentLinksLinkIdAsync(
        linkId,
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
  "amount": {
    "currency": "EUR",
    "value": 8700
  },
  "countryCode": "NL",
  "expiresAt": "2021-04-08T14:06:39Z",
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "reference": "shopper-reference-ekvL83",
  "shopperLocale": "hu-HU",
  "shopperReference": "shopper-reference-LZfdWZ",
  "status": "expired",
  "url": "https://test.adyen.link/PL61C53A8B97E6915A",
  "id": "PL61C53A8B97E6915A"
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

