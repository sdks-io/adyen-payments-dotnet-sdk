// <copyright file="FraudCheckResultWrapper.cs" company="APIMatic">
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
    /// FraudCheckResultWrapper.
    /// </summary>
    public class FraudCheckResultWrapper
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResultWrapper"/> class.
        /// </summary>
        public FraudCheckResultWrapper()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FraudCheckResultWrapper"/> class.
        /// </summary>
        /// <param name="fraudCheckResult">FraudCheckResult.</param>
        public FraudCheckResultWrapper(
            Models.FraudCheckResult fraudCheckResult = null)
        {
            this.FraudCheckResult = fraudCheckResult;
        }

        /// <summary>
        /// Gets or sets FraudCheckResult.
        /// </summary>
        [JsonProperty("FraudCheckResult", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FraudCheckResult FraudCheckResult { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FraudCheckResultWrapper : ({string.Join(", ", toStringOutput)})";
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
            return obj is FraudCheckResultWrapper other &&                ((this.FraudCheckResult == null && other.FraudCheckResult == null) || (this.FraudCheckResult?.Equals(other.FraudCheckResult) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FraudCheckResult = {(this.FraudCheckResult == null ? "null" : this.FraudCheckResult.ToString())}");
        }
    }
}