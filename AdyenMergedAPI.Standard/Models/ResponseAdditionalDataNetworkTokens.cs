// <copyright file="ResponseAdditionalDataNetworkTokens.cs" company="APIMatic">
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
    /// ResponseAdditionalDataNetworkTokens.
    /// </summary>
    public class ResponseAdditionalDataNetworkTokens
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataNetworkTokens"/> class.
        /// </summary>
        public ResponseAdditionalDataNetworkTokens()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataNetworkTokens"/> class.
        /// </summary>
        /// <param name="networkTokenAvailable">networkToken.available.</param>
        /// <param name="networkTokenBin">networkToken.bin.</param>
        /// <param name="networkTokenTokenSummary">networkToken.tokenSummary.</param>
        public ResponseAdditionalDataNetworkTokens(
            string networkTokenAvailable = null,
            string networkTokenBin = null,
            string networkTokenTokenSummary = null)
        {
            this.NetworkTokenAvailable = networkTokenAvailable;
            this.NetworkTokenBin = networkTokenBin;
            this.NetworkTokenTokenSummary = networkTokenTokenSummary;
        }

        /// <summary>
        /// Indicates whether a network token is available for the specified card.
        /// </summary>
        [JsonProperty("networkToken.available", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTokenAvailable { get; set; }

        /// <summary>
        /// The Bank Identification Number of a tokenized card, which is the first six digits of a card number.
        /// </summary>
        [JsonProperty("networkToken.bin", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTokenBin { get; set; }

        /// <summary>
        /// The last four digits of a network token.
        /// </summary>
        [JsonProperty("networkToken.tokenSummary", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkTokenTokenSummary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataNetworkTokens : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataNetworkTokens other &&                ((this.NetworkTokenAvailable == null && other.NetworkTokenAvailable == null) || (this.NetworkTokenAvailable?.Equals(other.NetworkTokenAvailable) == true)) &&
                ((this.NetworkTokenBin == null && other.NetworkTokenBin == null) || (this.NetworkTokenBin?.Equals(other.NetworkTokenBin) == true)) &&
                ((this.NetworkTokenTokenSummary == null && other.NetworkTokenTokenSummary == null) || (this.NetworkTokenTokenSummary?.Equals(other.NetworkTokenTokenSummary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NetworkTokenAvailable = {(this.NetworkTokenAvailable == null ? "null" : this.NetworkTokenAvailable)}");
            toStringOutput.Add($"this.NetworkTokenBin = {(this.NetworkTokenBin == null ? "null" : this.NetworkTokenBin)}");
            toStringOutput.Add($"this.NetworkTokenTokenSummary = {(this.NetworkTokenTokenSummary == null ? "null" : this.NetworkTokenTokenSummary)}");
        }
    }
}