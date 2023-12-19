// <copyright file="ModificationsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Authentication;
    using AdyenMergedAPI.Standard.Exceptions;
    using AdyenMergedAPI.Standard.Http.Client;
    using AdyenMergedAPI.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ModificationsController.
    /// </summary>
    public class ModificationsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationsController"/> class.
        /// </summary>
        internal ModificationsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).
        /// If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.
        /// If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.StandalonePaymentCancelResponse response from the API call.</returns>
        public Models.StandalonePaymentCancelResponse PostCancels(
                string idempotencyKey = null,
                Models.StandalonePaymentCancelRequest body = null)
            => CoreHelper.RunTask(PostCancelsAsync(idempotencyKey, body));

        /// <summary>
        /// Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**TECHNICAL_CANCEL** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).
        /// If you want to cancel a payment using the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) endpoint instead.
        /// If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StandalonePaymentCancelResponse response from the API call.</returns>
        public async Task<Models.StandalonePaymentCancelResponse> PostCancelsAsync(
                string idempotencyKey = null,
                Models.StandalonePaymentCancelRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StandalonePaymentCancelResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cancels")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes).
        /// You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).
        /// The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.
        /// For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentAmountUpdateResponse response from the API call.</returns>
        public Models.PaymentAmountUpdateResponse PostPaymentsPaymentPspReferenceAmountUpdates(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentAmountUpdateRequest body = null)
            => CoreHelper.RunTask(PostPaymentsPaymentPspReferenceAmountUpdatesAsync(paymentPspReference, idempotencyKey, body));

        /// <summary>
        /// Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an [**AUTHORISATION_ADJUSTMENT** webhook](https://docs.adyen.com/development-resources/webhooks/understand-notifications#event-codes).
        /// You can only update authorised amounts that have not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures).
        /// The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.
        /// For more information, refer to [Authorisation adjustment](https://docs.adyen.com/online-payments/adjust-authorisation#use-cases).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentAmountUpdateResponse response from the API call.</returns>
        public async Task<Models.PaymentAmountUpdateResponse> PostPaymentsPaymentPspReferenceAmountUpdatesAsync(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentAmountUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentAmountUpdateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{paymentPspReference}/amountUpdates")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("paymentPspReference", paymentPspReference))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/paymentPspReference/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).
        /// If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.
        /// If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentCancelResponse response from the API call.</returns>
        public Models.PaymentCancelResponse PostPaymentsPaymentPspReferenceCancels(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentCancelRequest body = null)
            => CoreHelper.RunTask(PostPaymentsPaymentPspReferenceCancelsAsync(paymentPspReference, idempotencyKey, body));

        /// <summary>
        /// Cancels the authorisation on a payment that has not yet been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/paymentPspReference/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCELLATION** webhook](https://docs.adyen.com/online-payments/cancel#cancellation-webhook).
        /// If you want to cancel a payment but don't have the [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels) endpoint instead.
        /// If you want to cancel a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/cancel).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentCancelResponse response from the API call.</returns>
        public async Task<Models.PaymentCancelResponse> PostPaymentsPaymentPspReferenceCancelsAsync(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentCancelRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentCancelResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{paymentPspReference}/cancels")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("paymentPspReference", paymentPspReference))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        ///  Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).
        /// You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures. .
        /// [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.
        /// For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentCaptureResponse response from the API call.</returns>
        public Models.PaymentCaptureResponse PostPaymentsPaymentPspReferenceCaptures(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentCaptureRequest body = null)
            => CoreHelper.RunTask(PostPaymentsPaymentPspReferenceCapturesAsync(paymentPspReference, idempotencyKey, body));

        /// <summary>
        ///  Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CAPTURE** webhook](https://docs.adyen.com/online-payments/capture#capture-notification).
        /// You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures. .
        /// [Automatic capture](https://docs.adyen.com/online-payments/capture#automatic-capture) is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.
        /// For more information, refer to [Capture](https://docs.adyen.com/online-payments/capture).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentCaptureResponse response from the API call.</returns>
        public async Task<Models.PaymentCaptureResponse> PostPaymentsPaymentPspReferenceCapturesAsync(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentCaptureRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentCaptureResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{paymentPspReference}/captures")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("paymentPspReference", paymentPspReference))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).
        /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
        /// > Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna). .
        /// If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentRefundResponse response from the API call.</returns>
        public Models.PaymentRefundResponse PostPaymentsPaymentPspReferenceRefunds(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentRefundRequest body = null)
            => CoreHelper.RunTask(PostPaymentsPaymentPspReferenceRefundsAsync(paymentPspReference, idempotencyKey, body));

        /// <summary>
        /// Refunds a payment that has been [captured](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures), and returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**REFUND** webhook](https://docs.adyen.com/online-payments/refund#refund-webhook).
        /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
        /// > Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as [cards](https://docs.adyen.com/payment-methods/cards#supported-cards), [iDEAL](https://docs.adyen.com/payment-methods/ideal), or [Klarna](https://docs.adyen.com/payment-methods/klarna). .
        /// If you want to refund a payment but are not sure whether it has been captured, use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals) endpoint instead.
        /// For more information, refer to [Refund](https://docs.adyen.com/online-payments/refund).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentRefundResponse response from the API call.</returns>
        public async Task<Models.PaymentRefundResponse> PostPaymentsPaymentPspReferenceRefundsAsync(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentRefundRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentRefundResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{paymentPspReference}/refunds")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("paymentPspReference", paymentPspReference))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// [Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reverse#cancel-or-refund-webhook).
        /// The reversed amount is always the full payment amount.
        /// > Do not use this request for payments that involve multiple partial captures.
        /// For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentReversalResponse response from the API call.</returns>
        public Models.PaymentReversalResponse PostPaymentsPaymentPspReferenceReversals(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentReversalRequest body = null)
            => CoreHelper.RunTask(PostPaymentsPaymentPspReferenceReversalsAsync(paymentPspReference, idempotencyKey, body));

        /// <summary>
        /// [Refunds](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds) a payment if it has already been captured, and [cancels](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels) a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a [**CANCEL_OR_REFUND** webhook](https://docs.adyen.com/online-payments/reverse#cancel-or-refund-webhook).
        /// The reversed amount is always the full payment amount.
        /// > Do not use this request for payments that involve multiple partial captures.
        /// For more information, refer to [Reversal](https://docs.adyen.com/online-payments/reversal).
        /// </summary>
        /// <param name="paymentPspReference">Required parameter: The [`pspReference`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse..</param>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentReversalResponse response from the API call.</returns>
        public async Task<Models.PaymentReversalResponse> PostPaymentsPaymentPspReferenceReversalsAsync(
                string paymentPspReference,
                string idempotencyKey = null,
                Models.PaymentReversalRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentReversalResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/{paymentPspReference}/reversals")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("paymentPspReference", paymentPspReference))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce).
        /// > If you have a [newer integration](https://docs.adyen.com/online-payments), and are doing:.
        /// > * [Asynchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use the [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/amountUpdates) endpoint on Checkout API.
        /// > * [Synchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use this endpoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostAdjustAuthorisation(
                Models.AdjustAuthorisationRequest body = null)
            => CoreHelper.RunTask(PostAdjustAuthorisationAsync(body));

        /// <summary>
        /// Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce).
        /// > If you have a [newer integration](https://docs.adyen.com/online-payments), and are doing:.
        /// > * [Asynchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use the [`/payments/{paymentPspReference}/amountUpdates`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/amountUpdates) endpoint on Checkout API.
        /// > * [Synchronous adjustments](https://docs.adyen.com/online-payments/adjust-authorisation#asynchronous-or-synchronous-adjustment), use this endpoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostAdjustAuthorisationAsync(
                Models.AdjustAuthorisationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/adjustAuthorisation")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/cancels) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostCancel(
                Models.CancelRequest body = null)
            => CoreHelper.RunTask(PostCancelAsync(body));

        /// <summary>
        /// Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.
        /// For more information, refer to [Cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/cancels) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostCancelAsync(
                Models.CancelRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cancel")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).
        /// Do not use this endpoint for payments that involve:.
        ///  * [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
        ///  * [Split data](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.
        ///  Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.
        /// For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/reversals) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostCancelOrRefund(
                Models.CancelOrRefundRequest body = null)
            => CoreHelper.RunTask(PostCancelOrRefundAsync(body));

        /// <summary>
        /// Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).
        /// Do not use this endpoint for payments that involve:.
        ///  * [Multiple partial captures](https://docs.adyen.com/online-payments/capture).
        ///  * [Split data](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information) either at time of payment or capture for Adyen for Platforms.
        ///  Instead, check if the payment has been captured and make a corresponding [`/refund`](https://docs.adyen.com/api-explorer/#/Payment/refund) or [`/cancel`](https://docs.adyen.com/api-explorer/#/Payment/cancel) call.
        /// For more information, refer to [Cancel or refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/reversals`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/reversals) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostCancelOrRefundAsync(
                Models.CancelOrRefundRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/cancelOrRefund")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.
        /// Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not neccessary.
        /// For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/captures) endpoint on Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostCapture(
                Models.CaptureRequest body = null)
            => CoreHelper.RunTask(PostCaptureAsync(body));

        /// <summary>
        /// Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.
        /// Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not neccessary.
        /// For more information refer to [Capture](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/captures`](https://docs.adyen.com/api-explorer/#/CheckoutService/v67/post/payments/{paymentPspReference}/captures) endpoint on Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostCaptureAsync(
                Models.CaptureRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/capture")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/donations`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/donations) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostDonate(
                Models.DonationRequest body = null)
            => CoreHelper.RunTask(PostDonateAsync(body));

        /// <summary>
        /// Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/donations`](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/donations) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostDonateAsync(
                Models.DonationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/donate")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.
        /// Some payment methods/gateways do not support partial/multiple refunds.
        /// A margin above the captured limit can be configured to cover shipping/handling costs.
        /// For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/refunds) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostRefund(
                Models.RefundRequest body = null)
            => CoreHelper.RunTask(PostRefundAsync(body));

        /// <summary>
        /// Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.
        /// Some payment methods/gateways do not support partial/multiple refunds.
        /// A margin above the captured limit can be configured to cover shipping/handling costs.
        /// For more information, refer to [Refund](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund).
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/payments/{paymentPspReference}/refunds`](https://docs.adyen.com/api-explorer/#/CheckoutService/payments/{paymentPspReference}/refunds) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostRefundAsync(
                Models.RefundRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/refund")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.
        /// In your call, refer to the original payment by using the `reference` that you specified in your payment request.
        /// For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel). .
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/cancels) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostTechnicalCancel(
                Models.TechnicalCancelRequest body = null)
            => CoreHelper.RunTask(PostTechnicalCancelAsync(body));

        /// <summary>
        /// This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.
        /// In your call, refer to the original payment by using the `reference` that you specified in your payment request.
        /// For more information, see [Technical cancel](https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel). .
        /// > This endpoint is part of our [classic API integration](https://docs.adyen.com/online-payments/classic-integrations/api-integration-ecommerce). If using a [newer integration](https://docs.adyen.com/online-payments), use the [`/cancels`](https://docs.adyen.com/api-explorer/#/CheckoutService/cancels) endpoint under Checkout API instead.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostTechnicalCancelAsync(
                Models.TechnicalCancelRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/technicalCancel")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This endpoint allows you to cancel an unreferenced refund request before it has been completed.
        /// In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.
        /// For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/refund-payment/cancel-unreferenced).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public Models.ModificationResult PostVoidPendingRefund(
                Models.VoidPendingRefundRequest body = null)
            => CoreHelper.RunTask(PostVoidPendingRefundAsync(body));

        /// <summary>
        /// This endpoint allows you to cancel an unreferenced refund request before it has been completed.
        /// In your call, you can refer to the original refund request either by using the `tenderReference`, or the `pspReference`. We recommend implementing based on the `tenderReference`, as this is generated for both offline and online transactions.
        /// For more information, refer to [Cancel an unreferenced refund](https://docs.adyen.com/point-of-sale/refund-payment/cancel-unreferenced).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ModificationResult response from the API call.</returns>
        public async Task<Models.ModificationResult> PostVoidPendingRefundAsync(
                Models.VoidPendingRefundRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ModificationResult>()
              .Server(Server.Payment)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/voidPendingRefund")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}