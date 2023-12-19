// <copyright file="MobilePay.cs" company="APIMatic">
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
    /// MobilePay.
    /// </summary>
    public class MobilePay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePay"/> class.
        /// </summary>
        public MobilePay()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobilePay"/> class.
        /// </summary>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="type">type.</param>
        public MobilePay(
            string checkoutAttemptId = null,
            Models.Type24Enum? type = Models.Type24Enum.Mobilepay)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Type = type;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// **mobilepay**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type24Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MobilePay : ({string.Join(", ", toStringOutput)})";
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
            return obj is MobilePay other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}