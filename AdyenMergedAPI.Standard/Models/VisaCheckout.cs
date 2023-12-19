// <copyright file="VisaCheckout.cs" company="APIMatic">
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
    /// VisaCheckout.
    /// </summary>
    public class VisaCheckout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisaCheckout"/> class.
        /// </summary>
        public VisaCheckout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisaCheckout"/> class.
        /// </summary>
        /// <param name="visaCheckoutCallId">visaCheckoutCallId.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="type">type.</param>
        public VisaCheckout(
            string visaCheckoutCallId,
            string checkoutAttemptId = null,
            Models.FundingSourceEnum? fundingSource = null,
            Models.Type33Enum? type = Models.Type33Enum.Visacheckout)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.FundingSource = fundingSource;
            this.Type = type;
            this.VisaCheckoutCallId = visaCheckoutCallId;
        }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to **debit**.
        /// </summary>
        [JsonProperty("fundingSource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FundingSourceEnum? FundingSource { get; set; }

        /// <summary>
        /// **visacheckout**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type33Enum? Type { get; set; }

        /// <summary>
        /// The Visa Click to Pay Call ID value. When your shopper selects a payment and/or a shipping address from Visa Click to Pay, you will receive a Visa Click to Pay Call ID.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("visaCheckoutCallId")]
        [JsonRequired]
        public string VisaCheckoutCallId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VisaCheckout : ({string.Join(", ", toStringOutput)})";
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
            return obj is VisaCheckout other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.FundingSource == null && other.FundingSource == null) || (this.FundingSource?.Equals(other.FundingSource) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.VisaCheckoutCallId == null && other.VisaCheckoutCallId == null) || (this.VisaCheckoutCallId?.Equals(other.VisaCheckoutCallId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.FundingSource = {(this.FundingSource == null ? "null" : this.FundingSource.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.VisaCheckoutCallId = {(this.VisaCheckoutCallId == null ? "null" : this.VisaCheckoutCallId)}");
        }
    }
}