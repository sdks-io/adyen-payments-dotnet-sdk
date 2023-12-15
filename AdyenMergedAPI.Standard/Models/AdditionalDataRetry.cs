// <copyright file="AdditionalDataRetry.cs" company="APIMatic">
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
    /// AdditionalDataRetry.
    /// </summary>
    public class AdditionalDataRetry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRetry"/> class.
        /// </summary>
        public AdditionalDataRetry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRetry"/> class.
        /// </summary>
        /// <param name="retryChainAttemptNumber">retry.chainAttemptNumber.</param>
        /// <param name="retryOrderAttemptNumber">retry.orderAttemptNumber.</param>
        /// <param name="retrySkipRetry">retry.skipRetry.</param>
        public AdditionalDataRetry(
            string retryChainAttemptNumber = null,
            string retryOrderAttemptNumber = null,
            string retrySkipRetry = null)
        {
            this.RetryChainAttemptNumber = retryChainAttemptNumber;
            this.RetryOrderAttemptNumber = retryOrderAttemptNumber;
            this.RetrySkipRetry = retrySkipRetry;
        }

        /// <summary>
        /// The number of times the transaction (not order) has been retried between different payment service providers. For instance, the `chainAttemptNumber` set to 2 means that this transaction has been recently tried on another provider before being sent to Adyen.
        /// > If you submit `retry.chainAttemptNumber`, `retry.orderAttemptNumber`, and `retry.skipRetry` values, we also recommend you provide the `merchantOrderReference` to facilitate linking payment attempts together.
        /// </summary>
        [JsonProperty("retry.chainAttemptNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryChainAttemptNumber { get; set; }

        /// <summary>
        /// The index of the attempt to bill a particular order, which is identified by the `merchantOrderReference` field. For example, if a recurring transaction fails and is retried one day later, then the order number for these attempts would be 1 and 2, respectively.
        /// > If you submit `retry.chainAttemptNumber`, `retry.orderAttemptNumber`, and `retry.skipRetry` values, we also recommend you provide the `merchantOrderReference` to facilitate linking payment attempts together.
        /// </summary>
        [JsonProperty("retry.orderAttemptNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryOrderAttemptNumber { get; set; }

        /// <summary>
        /// The Boolean value indicating whether Adyen should skip or retry this transaction, if possible.
        /// > If you submit `retry.chainAttemptNumber`, `retry.orderAttemptNumber`, and `retry.skipRetry` values, we also recommend you provide the `merchantOrderReference` to facilitate linking payment attempts together.
        /// </summary>
        [JsonProperty("retry.skipRetry", NullValueHandling = NullValueHandling.Ignore)]
        public string RetrySkipRetry { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataRetry : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataRetry other &&                ((this.RetryChainAttemptNumber == null && other.RetryChainAttemptNumber == null) || (this.RetryChainAttemptNumber?.Equals(other.RetryChainAttemptNumber) == true)) &&
                ((this.RetryOrderAttemptNumber == null && other.RetryOrderAttemptNumber == null) || (this.RetryOrderAttemptNumber?.Equals(other.RetryOrderAttemptNumber) == true)) &&
                ((this.RetrySkipRetry == null && other.RetrySkipRetry == null) || (this.RetrySkipRetry?.Equals(other.RetrySkipRetry) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RetryChainAttemptNumber = {(this.RetryChainAttemptNumber == null ? "null" : this.RetryChainAttemptNumber)}");
            toStringOutput.Add($"this.RetryOrderAttemptNumber = {(this.RetryOrderAttemptNumber == null ? "null" : this.RetryOrderAttemptNumber)}");
            toStringOutput.Add($"this.RetrySkipRetry = {(this.RetrySkipRetry == null ? "null" : this.RetrySkipRetry)}");
        }
    }
}