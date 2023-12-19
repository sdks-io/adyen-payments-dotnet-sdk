// <copyright file="SessionResultResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SessionResultResponse.
    /// </summary>
    public class SessionResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResultResponse"/> class.
        /// </summary>
        public SessionResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionResultResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        public SessionResultResponse(
            string id = null,
            Models.Status2Enum? status = null)
        {
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// A unique identifier of the session.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.
        /// Possible values:
        ///          * **completed** – The shopper completed the payment. This means that the payment was authorized.
        ///          * **paymentPending** – The shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow.
        ///          * **refused** – The session has been refused, due to too many refused payment attempts. Shoppers can no longer complete the payment with this session.
        ///          * **canceled** – The shopper canceled the payment.
        ///          * **active** – The session is still active and can be paid.
        ///          * **expired** – The session expired (default: 1 hour after session creation). Shoppers can no longer complete the payment with this session.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Status2Enum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionResultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SessionResultResponse other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}