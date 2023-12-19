// <copyright file="UtilityController.cs" company="APIMatic">
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
    /// UtilityController.
    /// </summary>
    public class UtilityController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityController"/> class.
        /// </summary>
        internal UtilityController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.
        /// The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ApplePaySessionResponse response from the API call.</returns>
        public Models.ApplePaySessionResponse PostApplePaySessions(
                string idempotencyKey = null,
                Models.ApplePaySessionRequest body = null)
            => CoreHelper.RunTask(PostApplePaySessionsAsync(idempotencyKey, body));

        /// <summary>
        /// You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.
        /// The endpoint returns the Apple Pay session data which you need to complete the [Apple Pay session validation](https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation).
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ApplePaySessionResponse response from the API call.</returns>
        public async Task<Models.ApplePaySessionResponse> PostApplePaySessionsAsync(
                string idempotencyKey = null,
                Models.ApplePaySessionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ApplePaySessionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/applePay/sessions")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("Idempotency-Key", idempotencyKey))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. .
        /// > If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form. .
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.UtilityResponse response from the API call.</returns>
        [Obsolete]
        public Models.UtilityResponse PostOriginKeys(
                string idempotencyKey = null,
                Models.UtilityRequest body = null)
            => CoreHelper.RunTask(PostOriginKeysAsync(idempotencyKey, body));

        /// <summary>
        /// This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains. .
        /// > If you're still using origin key for your Web Drop-in or Components integration, we recommend [switching to client key](https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key). This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form. .
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UtilityResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.UtilityResponse> PostOriginKeysAsync(
                string idempotencyKey = null,
                Models.UtilityRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UtilityResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/originKeys")
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