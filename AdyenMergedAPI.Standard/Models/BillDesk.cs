// <copyright file="BillDesk.cs" company="APIMatic">
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
    /// BillDesk.
    /// </summary>
    public class BillDesk
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillDesk"/> class.
        /// </summary>
        public BillDesk()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillDesk"/> class.
        /// </summary>
        /// <param name="issuer">issuer.</param>
        /// <param name="type">type.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        public BillDesk(
            string issuer,
            Models.Type7Enum type,
            string checkoutAttemptId = null)
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
        /// The issuer id of the shopper's selected bank.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("issuer")]
        [JsonRequired]
        public string Issuer { get; set; }

        /// <summary>
        /// **billdesk**
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.Type7Enum Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillDesk : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillDesk other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Issuer == null && other.Issuer == null) || (this.Issuer?.Equals(other.Issuer) == true)) &&
                this.Type.Equals(other.Type);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Issuer = {(this.Issuer == null ? "null" : this.Issuer)}");
            toStringOutput.Add($"this.Type = {this.Type}");
        }
    }
}