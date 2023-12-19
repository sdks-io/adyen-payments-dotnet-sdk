// <copyright file="Avs.cs" company="APIMatic">
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
    /// Avs.
    /// </summary>
    public class Avs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Avs"/> class.
        /// </summary>
        public Avs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Avs"/> class.
        /// </summary>
        /// <param name="addressEditable">addressEditable.</param>
        /// <param name="enabled">enabled.</param>
        public Avs(
            bool? addressEditable = null,
            Models.EnabledEnum? enabled = null)
        {
            this.AddressEditable = addressEditable;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Indicates whether the shopper is allowed to modify the billing address for the current payment request.
        /// </summary>
        [JsonProperty("addressEditable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddressEditable { get; set; }

        /// <summary>
        /// Specifies whether the shopper should enter their billing address during checkout.
        /// Allowed values:
        /// * yes — Perform AVS checks for every card payment.
        /// * automatic — Perform AVS checks only when required to optimize the conversion rate.
        /// * no — Do not perform AVS checks.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EnabledEnum? Enabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Avs : ({string.Join(", ", toStringOutput)})";
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
            return obj is Avs other &&                ((this.AddressEditable == null && other.AddressEditable == null) || (this.AddressEditable?.Equals(other.AddressEditable) == true)) &&
                ((this.Enabled == null && other.Enabled == null) || (this.Enabled?.Equals(other.Enabled) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressEditable = {(this.AddressEditable == null ? "null" : this.AddressEditable.ToString())}");
            toStringOutput.Add($"this.Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
        }
    }
}