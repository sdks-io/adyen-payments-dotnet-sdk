// <copyright file="Masterpass.cs" company="APIMatic">
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
    /// Masterpass.
    /// </summary>
    public class Masterpass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Masterpass"/> class.
        /// </summary>
        public Masterpass()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Masterpass"/> class.
        /// </summary>
        /// <param name="masterpassTransactionId">masterpassTransactionId.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="fundingSource">fundingSource.</param>
        /// <param name="type">type.</param>
        public Masterpass(
            string masterpassTransactionId,
            string checkoutAttemptId = null,
            Models.FundingSourceEnum? fundingSource = null,
            Models.Type22Enum? type = Models.Type22Enum.Masterpass)
        {
            this.CheckoutAttemptId = checkoutAttemptId;
            this.FundingSource = fundingSource;
            this.MasterpassTransactionId = masterpassTransactionId;
            this.Type = type;
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
        /// The Masterpass transaction ID.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masterpassTransactionId")]
        [JsonRequired]
        public string MasterpassTransactionId { get; set; }

        /// <summary>
        /// **masterpass**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type22Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Masterpass : ({string.Join(", ", toStringOutput)})";
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
            return obj is Masterpass other &&                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.FundingSource == null && other.FundingSource == null) || (this.FundingSource?.Equals(other.FundingSource) == true)) &&
                ((this.MasterpassTransactionId == null && other.MasterpassTransactionId == null) || (this.MasterpassTransactionId?.Equals(other.MasterpassTransactionId) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.FundingSource = {(this.FundingSource == null ? "null" : this.FundingSource.ToString())}");
            toStringOutput.Add($"this.MasterpassTransactionId = {(this.MasterpassTransactionId == null ? "null" : this.MasterpassTransactionId)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}