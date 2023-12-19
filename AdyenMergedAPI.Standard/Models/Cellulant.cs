// <copyright file="Cellulant.cs" company="APIMatic">
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
    /// Cellulant.
    /// </summary>
    public class Cellulant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cellulant"/> class.
        /// </summary>
        public Cellulant()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cellulant"/> class.
        /// </summary>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="type">type.</param>
        public Cellulant(
            string checkoutAttemptId = null,
            string issuer = null,
            Models.Type10Enum? type = Models.Type10Enum.Cellulant)
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
        /// The Cellulant issuer.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("issuer", NullValueHandling = NullValueHandling.Ignore)]
        public string Issuer { get; set; }

        /// <summary>
        /// **Cellulant**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type10Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cellulant : ({string.Join(", ", toStringOutput)})";
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
            return obj is Cellulant other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
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