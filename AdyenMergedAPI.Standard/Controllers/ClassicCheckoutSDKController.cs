// <copyright file="ClassicCheckoutSDKController.cs" company="APIMatic">
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
    /// ClassicCheckoutSDKController.
    /// </summary>
    public class ClassicCheckoutSDKController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassicCheckoutSDKController"/> class.
        /// </summary>
        internal ClassicCheckoutSDKController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Provides the data object that can be used to start the Checkout SDK. To set up the payment, pass its amount, currency, and other required parameters. We use this to optimise the payment flow and perform better risk assessment of the transaction.
        /// For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentSetupResponse response from the API call.</returns>
        [Obsolete]
        public Models.PaymentSetupResponse PostPaymentSession(
                string idempotencyKey = null,
                Models.PaymentSetupRequest body = null)
            => CoreHelper.RunTask(PostPaymentSessionAsync(idempotencyKey, body));

        /// <summary>
        /// Provides the data object that can be used to start the Checkout SDK. To set up the payment, pass its amount, currency, and other required parameters. We use this to optimise the payment flow and perform better risk assessment of the transaction.
        /// For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentSetupResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.PaymentSetupResponse> PostPaymentSessionAsync(
                string idempotencyKey = null,
                Models.PaymentSetupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentSetupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/paymentSession")
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
        /// Verifies the payment result using the payload returned from the Checkout SDK.
        /// For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentVerificationResponse response from the API call.</returns>
        [Obsolete]
        public Models.PaymentVerificationResponse PostPaymentsResult(
                string idempotencyKey = null,
                Models.PaymentVerificationRequest body = null)
            => CoreHelper.RunTask(PostPaymentsResultAsync(idempotencyKey, body));

        /// <summary>
        /// Verifies the payment result using the payload returned from the Checkout SDK.
        /// For more information, refer to [How it works](https://docs.adyen.com/online-payments#howitworks).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentVerificationResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.PaymentVerificationResponse> PostPaymentsResultAsync(
                string idempotencyKey = null,
                Models.PaymentVerificationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentVerificationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payments/result")
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