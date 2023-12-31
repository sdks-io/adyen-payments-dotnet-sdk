// <copyright file="FraudResult.cs" company="APIMatic">
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
    /// FraudResult.
    /// </summary>
    public class FraudResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudResult"/> class.
        /// </summary>
        public FraudResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FraudResult"/> class.
        /// </summary>
        /// <param name="accountScore">accountScore.</param>
        /// <param name="results">results.</param>
        public FraudResult(
            int accountScore,
            List<Models.FraudCheckResult> results = null)
        {
            this.AccountScore = accountScore;
            this.Results = results;
        }

        /// <summary>
        /// The total fraud score generated by the risk checks.
        /// </summary>
        [JsonProperty("accountScore")]
        public int AccountScore { get; set; }

        /// <summary>
        /// The result of the individual risk checks.
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FraudCheckResult> Results { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FraudResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is FraudResult other &&                this.AccountScore.Equals(other.AccountScore) &&
                ((this.Results == null && other.Results == null) || (this.Results?.Equals(other.Results) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountScore = {this.AccountScore}");
            toStringOutput.Add($"this.Results = {(this.Results == null ? "null" : $"[{string.Join(", ", this.Results)} ]")}");
        }
    }
}