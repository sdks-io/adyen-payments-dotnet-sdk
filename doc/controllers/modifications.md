# Modifications

```csharp
ModificationsController modificationsController = client.ModificationsController;
```

## Class Name

`ModificationsController`

## Methods

* [Post-Cancels](../../doc/controllers/modifications.md#post-cancels)
* [Post-Payments-Payment Psp Reference-Amount Updates](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-amount-updates)
* [Post-Payments-Payment Psp Reference-Cancels](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-cancels)
* [Post-Payments-Payment Psp Reference-Captures](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-captures)
* [Post-Payments-Payment Psp Reference-Refunds](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-refunds)
* [Post-Payments-Payment Psp Reference-Reversals](../../doc/controllers/modifications.md#post-payments-payment-psp-reference-reversals)
* [Post-Adjust Authorisation](../../doc/controllers/modifications.md#post-adjust-authorisation)
* [Post-Cancel](../../doc/controllers/modifications.md#post-cancel)
* [Post-Cancel or Refund](../../doc/controllers/modifications.md#post-cancel-or-refund)
* [Post-Capture](../../doc/controllers/modifications.md#post-capture)
* [Post-Donate](../../doc/controllers/modifications.md#post-donate)
* [Post-Refund](../../doc/controllers/modifications.md#post-refund)
* [Post-Technical Cancel](../../doc/controllers/modifications.md#post-technical-cancel)
* [Post-Void Pending Refund](../../doc/controllers/modifications.md#post-void-pending-refund)


# Post-Cancels

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

```csharp
PostCancelsAsync(
    string idempotencyKey = null,
    Models.StandalonePaymentCancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`StandalonePaymentCancelRequest`](../../doc/models/standalone-payment-cancel-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.StandalonePaymentCancelResponse>`](../../doc/models/standalone-payment-cancel-response.md)

## Example Usage

```csharp
StandalonePaymentCancelRequest body = new StandalonePaymentCancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PaymentReference = "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
    Reference = "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
};

try
{
    StandalonePaymentCancelResponse result = await modificationsController.PostCancelsAsync(
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentReference": "YOUR_UNIQUE_REFERENCE_FOR_THE_PAYMENT",
  "reference": "YOUR_UNIQUE_REFERENCE_FOR_THE_CANCELLATION",
  "pspReference": "993617894906488A",
  "status": "received"
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


# Post-Payments-Payment Psp Reference-Amount Updates

Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes).

You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).

The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.

For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).

```csharp
PostPaymentsPaymentPspReferenceAmountUpdatesAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentAmountUpdateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentAmountUpdateRequest`](../../doc/models/payment-amount-update-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentAmountUpdateResponse>`](../../doc/models/payment-amount-update-response.md)

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentAmountUpdateRequest body = new PaymentAmountUpdateRequest
{
    Amount = new Amount25
    {
        Currency = "EUR",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    PaymentAmountUpdateResponse result = await modificationsController.PostPaymentsPaymentPspReferenceAmountUpdatesAsync(
        paymentPspReference,
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "currency": "EUR",
    "value": 2500
  },
  "reason": "delayedCharge"
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


# Post-Payments-Payment Psp Reference-Cancels

Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/paymentPspReference/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).

If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.

If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).

```csharp
PostPaymentsPaymentPspReferenceCancelsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentCancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentCancelRequest`](../../doc/models/payment-cancel-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentCancelResponse>`](../../doc/models/payment-cancel-response.md)

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentCancelRequest body = new PaymentCancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    PaymentCancelResponse result = await modificationsController.PostPaymentsPaymentPspReferenceCancelsAsync(
        paymentPspReference,
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received"
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


# Post-Payments-Payment Psp Reference-Captures

Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).

You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures.

[Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.

For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).

```csharp
PostPaymentsPaymentPspReferenceCapturesAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentCaptureRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentCaptureRequest`](../../doc/models/payment-capture-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentCaptureResponse>`](../../doc/models/payment-capture-response.md)

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentCaptureRequest body = new PaymentCaptureRequest
{
    Amount = new Amount27
    {
        Currency = "EUR",
        MValue = 2000L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    PlatformChargebackLogic = new PlatformChargebackLogic
    {
        Behavior = BehaviorEnum.DeductFromOneBalanceAccount,
        CostAllocationAccount = "BA00000000000000000000001",
        TargetAccount = "BA00000000000000000000001",
    },
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    PaymentCaptureResponse result = await modificationsController.PostPaymentsPaymentPspReferenceCapturesAsync(
        paymentPspReference,
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "value": 2000,
    "currency": "EUR"
  },
  "platformChargebackLogic": {
    "behavior": "deductFromOneBalanceAccount",
    "targetAccount": "BA00000000000000000000001",
    "costAllocationAccount": "BA00000000000000000000001"
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


# Post-Payments-Payment Psp Reference-Refunds

Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

> Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna).

If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).

```csharp
PostPaymentsPaymentPspReferenceRefundsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentRefundRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentRefundRequest`](../../doc/models/payment-refund-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentRefundResponse>`](../../doc/models/payment-refund-response.md)

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentRefundRequest body = new PaymentRefundRequest
{
    Amount = new Amount33
    {
        Currency = "EUR",
        MValue = 2500L,
    },
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    PaymentRefundResponse result = await modificationsController.PostPaymentsPaymentPspReferenceRefundsAsync(
        paymentPspReference,
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received",
  "amount": {
    "currency": "EUR",
    "value": 2500
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


# Post-Payments-Payment Psp Reference-Reversals

[Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reverse#cancel-or-refund-webhook).

The reversed amount is always the full payment amount.

> Do not use this request for payments that involve multiple partial captures.

For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).

```csharp
PostPaymentsPaymentPspReferenceReversalsAsync(
    string paymentPspReference,
    string idempotencyKey = null,
    Models.PaymentReversalRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `paymentPspReference` | `string` | Template, Required | The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`PaymentReversalRequest`](../../doc/models/payment-reversal-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.PaymentReversalResponse>`](../../doc/models/payment-reversal-response.md)

## Example Usage

```csharp
string paymentPspReference = "paymentPspReference2";
PaymentReversalRequest body = new PaymentReversalRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    Reference = "YOUR_UNIQUE_REFERENCE",
};

try
{
    PaymentReversalResponse result = await modificationsController.PostPaymentsPaymentPspReferenceReversalsAsync(
        paymentPspReference,
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
  "merchantAccount": "YOUR_MERCHANT_ACCOUNT",
  "paymentPspReference": "993617894903480A",
  "reference": "YOUR_UNIQUE_REFERENCE",
  "pspReference": "993617894906488A",
  "status": "received"
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


# Post-Adjust Authorisation

Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce).
> If you have a [newer integration](https://docs.adyen.com/online-payments), and are doing:
> 
> * [Asynchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use the [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/amountUpdates) endpoint on Checkout API.
> * [Synchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use this endpoint.

```csharp
PostAdjustAuthorisationAsync(
    Models.AdjustAuthorisationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AdjustAuthorisationRequest`](../../doc/models/adjust-authorisation-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
AdjustAuthorisationRequest body = new AdjustAuthorisationRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    ModificationAmount = new Amount
    {
        Currency = "USD",
        MValue = 1700L,
    },
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YourModificationReference",
};

try
{
    ModificationResult result = await modificationsController.PostAdjustAuthorisationAsync(body);
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
  "pspReference": "851617892360718D",
  "response": "[adjustAuthorisation-received]"
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


# Post-Cancel

Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.

For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/cancels) endpoint under Checkout API instead.

```csharp
PostCancelAsync(
    Models.CancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CancelRequest`](../../doc/models/cancel-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
CancelRequest body = new CancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YourModificationReference",
};

try
{
    ModificationResult result = await modificationsController.PostCancelAsync(body);
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


# Post-Cancel or Refund

Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).

Do not use this endpoint for payments that involve:

* [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
* [Split data](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.

Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.

For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/reversals) endpoint under Checkout API instead.

```csharp
PostCancelOrRefundAsync(
    Models.CancelOrRefundRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CancelOrRefundRequest`](../../doc/models/cancel-or-refund-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
CancelOrRefundRequest body = new CancelOrRefundRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YourModificationReference",
};

try
{
    ModificationResult result = await modificationsController.PostCancelOrRefundAsync(body);
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
  "pspReference": "851617892359708H",
  "response": "[cancelOrRefund-received]"
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


# Post-Capture

Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.

Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not neccessary.

For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/captures) endpoint on Checkout API instead.

```csharp
PostCaptureAsync(
    Models.CaptureRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CaptureRequest`](../../doc/models/capture-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
CaptureRequest body = new CaptureRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    ModificationAmount = new Amount
    {
        Currency = "EUR",
        MValue = 500L,
    },
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YOUR_REFERENCE",
};

try
{
    ModificationResult result = await modificationsController.PostCaptureAsync(body);
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
  "pspReference": "861617892359057J",
  "response": "[capture-received]"
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


# Post-Donate

Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/donations`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/donations) endpoint under Checkout API instead.

```csharp
PostDonateAsync(
    Models.DonationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DonationRequest`](../../doc/models/donation-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
DonationRequest body = new DonationRequest
{
    DonationAccount = "AdyenGivingDemo",
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    ModificationAmount = new Amount
    {
        Currency = "EUR",
        MValue = 500L,
    },
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YOUR_DONATION_REFERENCE",
};

try
{
    ModificationResult result = await modificationsController.PostDonateAsync(body);
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


# Post-Refund

Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.

Some payment methods/gateways do not support partial/multiple refunds.
A margin above the captured limit can be configured to cover shipping/handling costs.

For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/refunds) endpoint under Checkout API instead.

```csharp
PostRefundAsync(
    Models.RefundRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RefundRequest`](../../doc/models/refund-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
RefundRequest body = new RefundRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    ModificationAmount = new Amount
    {
        Currency = "EUR",
        MValue = 500L,
    },
    OriginalReference = "COPY_PSP_REFERENCE_FROM_AUTHORISE_RESPONSE",
    Reference = "YOUR_REFERENCE",
};

try
{
    ModificationResult result = await modificationsController.PostRefundAsync(body);
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
  "pspReference": "861617892360059B",
  "response": "[refund-received]"
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


# Post-Technical Cancel

This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.

In your call, refer to the original payment by using the `reference` that you specified in your payment request.

For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel).

> This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/cancels) endpoint under Checkout API instead.

```csharp
PostTechnicalCancelAsync(
    Models.TechnicalCancelRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`TechnicalCancelRequest`](../../doc/models/technical-cancel-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
TechnicalCancelRequest body = new TechnicalCancelRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalMerchantReference = "YOUR_MERCHANT_REFERENCE",
    Reference = "YOUR_MODIFICATION_REFERENCE",
};

try
{
    ModificationResult result = await modificationsController.PostTechnicalCancelAsync(body);
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
  "pspReference": "881617892361436J",
  "response": "[technical-cancel-received]"
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


# Post-Void Pending Refund

This endpoint allows you to cancel an unreferenced refund request before it has been completed.

In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.

For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/refund-payment/cancel-unreferenced).

```csharp
PostVoidPendingRefundAsync(
    Models.VoidPendingRefundRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`VoidPendingRefundRequest`](../../doc/models/void-pending-refund-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ModificationResult>`](../../doc/models/modification-result.md)

## Example Usage

```csharp
VoidPendingRefundRequest body = new VoidPendingRefundRequest
{
    MerchantAccount = "YOUR_MERCHANT_ACCOUNT",
    OriginalReference = "9914748988390044",
};

try
{
    ModificationResult result = await modificationsController.PostVoidPendingRefundAsync(body);
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
  "pspReference": "861617892360062F",
  "response": "[voidPendingRefund-received]"
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

