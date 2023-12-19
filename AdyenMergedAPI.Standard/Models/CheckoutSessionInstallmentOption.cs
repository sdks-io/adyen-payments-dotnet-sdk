// <copyright file="CheckoutSessionInstallmentOption.cs" company="APIMatic">
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
    /// CheckoutSessionInstallmentOption.
    /// </summary>
    public class CheckoutSessionInstallmentOption
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSessionInstallmentOption"/> class.
        /// </summary>
        public CheckoutSessionInstallmentOption()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutSessionInstallmentOption"/> class.
        /// </summary>
        /// <param name="plans">plans.</param>
        /// <param name="preselectedValue">preselectedValue.</param>
        /// <param name="values">values.</param>
        public CheckoutSessionInstallmentOption(
            List<Models.Plan1Enum> plans = null,
            int? preselectedValue = null,
            List<int> values = null)
        {
            this.Plans = plans;
            this.PreselectedValue = preselectedValue;
            this.Values = values;
        }

        /// <summary>
        /// Defines the type of installment plan. If not set, defaults to **regular**.
        /// Possible values:
        /// * **regular**
        /// * **revolving**
        /// </summary>
        [JsonProperty("plans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Plan1Enum> Plans { get; set; }

        /// <summary>
        /// Preselected number of installments offered for this payment method.
        /// </summary>
        [JsonProperty("preselectedValue", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreselectedValue { get; set; }

        /// <summary>
        /// An array of the number of installments that the shopper can choose from. For example, **[2,3,5]**. This cannot be specified simultaneously with `maxValue`.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Values { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CheckoutSessionInstallmentOption : ({string.Join(", ", toStringOutput)})";
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
            return obj is CheckoutSessionInstallmentOption other &&                ((this.Plans == null && other.Plans == null) || (this.Plans?.Equals(other.Plans) == true)) &&
                ((this.PreselectedValue == null && other.PreselectedValue == null) || (this.PreselectedValue?.Equals(other.PreselectedValue) == true)) &&
                ((this.Values == null && other.Values == null) || (this.Values?.Equals(other.Values) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Plans = {(this.Plans == null ? "null" : $"[{string.Join(", ", this.Plans)} ]")}");
            toStringOutput.Add($"this.PreselectedValue = {(this.PreselectedValue == null ? "null" : this.PreselectedValue.ToString())}");
            toStringOutput.Add($"this.Values = {(this.Values == null ? "null" : $"[{string.Join(", ", this.Values)} ]")}");
        }
    }
}