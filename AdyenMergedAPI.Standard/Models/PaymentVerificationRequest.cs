// <copyright file="PaymentVerificationRequest.cs" company="APIMatic">
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
    /// PaymentVerificationRequest.
    /// </summary>
    public class PaymentVerificationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest"/> class.
        /// </summary>
        public PaymentVerificationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVerificationRequest"/> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        public PaymentVerificationRequest(
            string payload)
        {
            this.Payload = payload;
        }

        /// <summary>
        /// Encrypted and signed payment result data. You should receive this value from the Checkout SDK after the shopper completes the payment.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentVerificationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentVerificationRequest other &&                ((this.Payload == null && other.Payload == null) || (this.Payload?.Equals(other.Payload) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Payload = {(this.Payload == null ? "null" : this.Payload)}");
        }
    }
}