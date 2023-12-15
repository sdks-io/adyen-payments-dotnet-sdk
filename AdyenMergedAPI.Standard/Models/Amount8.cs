// <copyright file="Amount8.cs" company="APIMatic">
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
    /// Amount8.
    /// </summary>
    public class Amount8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount8"/> class.
        /// </summary>
        public Amount8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount8"/> class.
        /// </summary>
        /// <param name="currency">currency.</param>
        /// <param name="mValue">value.</param>
        public Amount8(
            string currency,
            long mValue)
        {
            this.Currency = currency;
            this.MValue = mValue;
        }

        /// <summary>
        /// The three-character [ISO currency code](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the transaction, in [minor units](https://docs.adyen.com/development-resources/currency-codes).
        /// </summary>
        [JsonProperty("value")]
        public long MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Amount8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Amount8 other &&                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
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