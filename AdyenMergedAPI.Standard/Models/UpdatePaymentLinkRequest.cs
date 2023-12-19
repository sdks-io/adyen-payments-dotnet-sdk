// <copyright file="UpdatePaymentLinkRequest.cs" company="APIMatic">
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
    /// UpdatePaymentLinkRequest.
    /// </summary>
    public class UpdatePaymentLinkRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentLinkRequest"/> class.
        /// </summary>
        public UpdatePaymentLinkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePaymentLinkRequest"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public UpdatePaymentLinkRequest(
            string status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Status of the payment link. Possible values:
        /// * **expired**
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdatePaymentLinkRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdatePaymentLinkRequest other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
        }
    }
}