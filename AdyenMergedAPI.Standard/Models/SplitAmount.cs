// <copyright file="SplitAmount.cs" company="APIMatic">
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
    /// SplitAmount.
    /// </summary>
    public class SplitAmount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount"/> class.
        /// </summary>
        public SplitAmount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAmount"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="currency">currency.</param>
        public SplitAmount(
            long mValue,
            string currency = null)
        {
            this.Currency = currency;
            this.MValue = mValue;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes). By default, this is the original payment currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// The value of the split amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("value")]
        public long MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SplitAmount : ({string.Join(", ", toStringOutput)})";
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
            return obj is SplitAmount other &&                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                this.MValue.Equals(other.MValue);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.MValue = {this.MValue}");
        }
    }
}