// <copyright file="Dotpay.cs" company="APIMatic">
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
    /// Dotpay.
    /// </summary>
    public class Dotpay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dotpay"/> class.
        /// </summary>
        public Dotpay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dotpay"/> class.
        /// </summary>
        /// <param name="issuer">issuer.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="type">type.</param>
        public Dotpay(
            string issuer,
            string checkoutAttemptId = null,
            Models.Type16Enum? type = Models.Type16Enum.Dotpay)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Issuer = issuer;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The Dotpay issuer value of the shopper's selected bank. Set this to an **id** of a Dotpay issuer to preselect it.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("issuer")]
        [JsonRequired]
        public string Issuer { get; set; }

        /// <summary>
        /// **dotpay**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type16Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Dotpay : ({string.Join(", ", toStringOutput)})";
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
            return obj is Dotpay other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}