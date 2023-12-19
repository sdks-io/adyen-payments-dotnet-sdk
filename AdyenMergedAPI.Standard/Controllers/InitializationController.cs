// <copyright file="InitializationController.cs" company="APIMatic">
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
    /// InitializationController.
    /// </summary>
    public class InitializationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitializationController"/> class.
        /// </summary>
        internal InitializationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.StoreDetailResponse response from the API call.</returns>
        public Models.StoreDetailResponse PostStoreDetail(
                Models.StoreDetailRequest body = null)
            => CoreHelper.RunTask(PostStoreDetailAsync(body));

        /// <summary>
        /// Stores payment details under the `PAYOUT` recurring contract. These payment details can be used later to submit a payout via the `/submitThirdParty` call.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StoreDetailResponse response from the API call.</returns>
        public async Task<Models.StoreDetailResponse> PostStoreDetailAsync(
                Models.StoreDetailRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StoreDetailResponse>()
              .Server(Server.Payout)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/storeDetail")
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
        /// Submits a payout and stores its details for subsequent payouts.
        /// The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.StoreDetailAndSubmitResponse response from the API call.</returns>
        public Models.StoreDetailAndSubmitResponse PostStoreDetailAndSubmitThirdParty(
                Models.StoreDetailAndSubmitRequest body = null)
            => CoreHelper.RunTask(PostStoreDetailAndSubmitThirdPartyAsync(body));

        /// <summary>
        /// Submits a payout and stores its details for subsequent payouts.
        /// The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StoreDetailAndSubmitResponse response from the API call.</returns>
        public async Task<Models.StoreDetailAndSubmitResponse> PostStoreDetailAndSubmitThirdPartyAsync(
                Models.StoreDetailAndSubmitRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StoreDetailAndSubmitResponse>()
              .Server(Server.Payout)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/storeDetailAndSubmitThirdParty")
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
        /// Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.
        /// The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubmitResponse response from the API call.</returns>
        public Models.SubmitResponse PostSubmitThirdParty(
                Models.SubmitRequest body = null)
            => CoreHelper.RunTask(PostSubmitThirdPartyAsync(body));

        /// <summary>
        /// Submits a payout using the previously stored payment details. To store payment details, use the `/storeDetail` API call.
        /// The submitted payout must be confirmed or declined either by a reviewer or via `/confirmThirdParty` or `/declineThirdParty` calls.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubmitResponse response from the API call.</returns>
        public async Task<Models.SubmitResponse> PostSubmitThirdPartyAsync(
                Models.SubmitRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubmitResponse>()
              .Server(Server.Payout)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/submitThirdParty")
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