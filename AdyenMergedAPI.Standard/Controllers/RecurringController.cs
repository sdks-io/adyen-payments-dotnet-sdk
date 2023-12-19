// <copyright file="RecurringController.cs" company="APIMatic">
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
    using AdyenMergedAPI.Standard.Http.Client;
    using AdyenMergedAPI.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// RecurringController.
    /// </summary>
    public class RecurringController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringController"/> class.
        /// </summary>
        internal RecurringController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.
        /// </summary>
        /// <param name="shopperReference">Optional parameter: Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. > Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="merchantAccount">Optional parameter: Your merchant account..</param>
        /// <returns>Returns the Models.ListStoredPaymentMethodsResponse response from the API call.</returns>
        public Models.ListStoredPaymentMethodsResponse GetStoredPaymentMethods(
                string shopperReference = null,
                string merchantAccount = null)
            => CoreHelper.RunTask(GetStoredPaymentMethodsAsync(shopperReference, merchantAccount));

        /// <summary>
        /// Lists the tokens for stored payment details for the shopper identified in the path, if there are any available. The token ID can be used with payment requests for the shopper's payment. A summary of the stored details is included.
        /// </summary>
        /// <param name="shopperReference">Optional parameter: Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. > Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="merchantAccount">Optional parameter: Your merchant account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListStoredPaymentMethodsResponse response from the API call.</returns>
        public async Task<Models.ListStoredPaymentMethodsResponse> GetStoredPaymentMethodsAsync(
                string shopperReference = null,
                string merchantAccount = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListStoredPaymentMethodsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/storedPaymentMethods")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("shopperReference", shopperReference))
                      .Query(_query => _query.Setup("merchantAccount", merchantAccount))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Deletes the token identified in the path. The token can no longer be used with payment requests.
        /// </summary>
        /// <param name="storedPaymentMethodId">Required parameter: The unique identifier of the token..</param>
        /// <param name="shopperReference">Required parameter: Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. > Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="merchantAccount">Required parameter: Your merchant account..</param>
        public void DeleteStoredPaymentMethodsStoredPaymentMethodId(
                string storedPaymentMethodId,
                string shopperReference,
                string merchantAccount)
            => CoreHelper.RunVoidTask(DeleteStoredPaymentMethodsStoredPaymentMethodIdAsync(storedPaymentMethodId, shopperReference, merchantAccount));

        /// <summary>
        /// Deletes the token identified in the path. The token can no longer be used with payment requests.
        /// </summary>
        /// <param name="storedPaymentMethodId">Required parameter: The unique identifier of the token..</param>
        /// <param name="shopperReference">Required parameter: Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. > Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="merchantAccount">Required parameter: Your merchant account..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteStoredPaymentMethodsStoredPaymentMethodIdAsync(
                string storedPaymentMethodId,
                string shopperReference,
                string merchantAccount,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/storedPaymentMethods/{storedPaymentMethodId}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("storedPaymentMethodId", storedPaymentMethodId))
                      .Query(_query => _query.Setup("shopperReference", shopperReference))
                      .Query(_query => _query.Setup("merchantAccount", merchantAccount))))
              .ExecuteAsync(cancellationToken);
    }
}