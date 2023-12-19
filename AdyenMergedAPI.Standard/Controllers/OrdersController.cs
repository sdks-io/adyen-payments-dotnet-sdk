// <copyright file="OrdersController.cs" company="APIMatic">
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
    /// OrdersController.
    /// </summary>
    public class OrdersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersController"/> class.
        /// </summary>
        internal OrdersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CreateOrderResponse response from the API call.</returns>
        public Models.CreateOrderResponse PostOrders(
                string idempotencyKey = null,
                Models.CreateOrderRequest body = null)
            => CoreHelper.RunTask(PostOrdersAsync(idempotencyKey, body));

        /// <summary>
        /// Creates an order to be used for partial payments. Make a POST `/orders` call before making a `/payments` call when processing payments with different payment methods.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreateOrderResponse response from the API call.</returns>
        public async Task<Models.CreateOrderResponse> PostOrdersAsync(
                string idempotencyKey = null,
                Models.CreateOrderRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/orders")
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
        /// Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CancelOrderResponse response from the API call.</returns>
        public Models.CancelOrderResponse PostOrdersCancel(
                string idempotencyKey = null,
                Models.CancelOrderRequest body = null)
            => CoreHelper.RunTask(PostOrdersCancelAsync(idempotencyKey, body));

        /// <summary>
        /// Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CancelOrderResponse response from the API call.</returns>
        public async Task<Models.CancelOrderResponse> PostOrdersCancelAsync(
                string idempotencyKey = null,
                Models.CancelOrderRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelOrderResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/orders/cancel")
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
        /// Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.BalanceCheckResponse response from the API call.</returns>
        public Models.BalanceCheckResponse PostPaymentMethodsBalance(
                string idempotencyKey = null,
                Models.BalanceCheckRequest body = null)
            => CoreHelper.RunTask(PostPaymentMethodsBalanceAsync(idempotencyKey, body));

        /// <summary>
        /// Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST `/paymentMethods/balance` call and include the gift card's details inside a `paymentMethod` object.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BalanceCheckResponse response from the API call.</returns>
        public async Task<Models.BalanceCheckResponse> PostPaymentMethodsBalanceAsync(
                string idempotencyKey = null,
                Models.BalanceCheckRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BalanceCheckResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/paymentMethods/balance")
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
    }
}