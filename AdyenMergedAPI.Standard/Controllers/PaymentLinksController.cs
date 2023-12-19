// <copyright file="PaymentLinksController.cs" company="APIMatic">
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
    /// PaymentLinksController.
    /// </summary>
    public class PaymentLinksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentLinksController"/> class.
        /// </summary>
        internal PaymentLinksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a payment link to our hosted payment form where shoppers can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.
        /// For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public Models.PaymentLinkResponse PostPaymentLinks(
                string idempotencyKey = null,
                Models.PaymentLinkRequest body = null)
            => CoreHelper.RunTask(PostPaymentLinksAsync(idempotencyKey, body));

        /// <summary>
        /// Creates a payment link to our hosted payment form where shoppers can pay. The list of payment methods presented to the shopper depends on the `currency` and `country` parameters sent in the request.
        /// For more information, refer to [Pay by Link documentation](https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public async Task<Models.PaymentLinkResponse> PostPaymentLinksAsync(
                string idempotencyKey = null,
                Models.PaymentLinkRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentLinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/paymentLinks")
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
        /// Retrieves the payment link details using the payment link `id`.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier of the payment link..</param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public Models.PaymentLinkResponse GetPaymentLinksLinkId(
                string linkId)
            => CoreHelper.RunTask(GetPaymentLinksLinkIdAsync(linkId));

        /// <summary>
        /// Retrieves the payment link details using the payment link `id`.
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier of the payment link..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public async Task<Models.PaymentLinkResponse> GetPaymentLinksLinkIdAsync(
                string linkId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentLinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/paymentLinks/{linkId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("linkId", linkId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request - a problem reading or understanding the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized - authentication required.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden - insufficient permissions to process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity - a request validation error.", (_reason, _context) => new ServiceErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal Server Error - the server could not process the request.", (_reason, _context) => new ServiceErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier of the payment link..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public Models.PaymentLinkResponse PatchPaymentLinksLinkId(
                string linkId,
                Models.UpdatePaymentLinkRequest body = null)
            => CoreHelper.RunTask(PatchPaymentLinksLinkIdAsync(linkId, body));

        /// <summary>
        /// Updates the status of a payment link. Use this endpoint to [force the expiry of a payment link](https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status).
        /// </summary>
        /// <param name="linkId">Required parameter: Unique identifier of the payment link..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentLinkResponse response from the API call.</returns>
        public async Task<Models.PaymentLinkResponse> PatchPaymentLinksLinkIdAsync(
                string linkId,
                Models.UpdatePaymentLinkRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentLinkResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/paymentLinks/{linkId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("linkId", linkId))
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