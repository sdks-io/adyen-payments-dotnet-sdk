// <copyright file="ResponseAdditionalDataDomesticError.cs" company="APIMatic">
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
    /// ResponseAdditionalDataDomesticError.
    /// </summary>
    public class ResponseAdditionalDataDomesticError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataDomesticError"/> class.
        /// </summary>
        public ResponseAdditionalDataDomesticError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataDomesticError"/> class.
        /// </summary>
        /// <param name="domesticRefusalReasonRaw">domesticRefusalReasonRaw.</param>
        /// <param name="domesticShopperAdvice">domesticShopperAdvice.</param>
        public ResponseAdditionalDataDomesticError(
            string domesticRefusalReasonRaw = null,
            string domesticShopperAdvice = null)
        {
            this.DomesticRefusalReasonRaw = domesticRefusalReasonRaw;
            this.DomesticShopperAdvice = domesticShopperAdvice;
        }

        /// <summary>
        /// The reason the transaction was declined, given by the local issuer.
        /// Currently available for merchants in Japan.
        /// </summary>
        [JsonProperty("domesticRefusalReasonRaw", NullValueHandling = NullValueHandling.Ignore)]
        public string DomesticRefusalReasonRaw { get; set; }

        /// <summary>
        /// The action the shopper should take, in a local language.
        /// Currently available in Japanese, for merchants in Japan.
        /// </summary>
        [JsonProperty("domesticShopperAdvice", NullValueHandling = NullValueHandling.Ignore)]
        public string DomesticShopperAdvice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataDomesticError : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataDomesticError other &&                ((this.DomesticRefusalReasonRaw == null && other.DomesticRefusalReasonRaw == null) || (this.DomesticRefusalReasonRaw?.Equals(other.DomesticRefusalReasonRaw) == true)) &&
                ((this.DomesticShopperAdvice == null && other.DomesticShopperAdvice == null) || (this.DomesticShopperAdvice?.Equals(other.DomesticShopperAdvice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DomesticRefusalReasonRaw = {(this.DomesticRefusalReasonRaw == null ? "null" : this.DomesticRefusalReasonRaw)}");
            toStringOutput.Add($"this.DomesticShopperAdvice = {(this.DomesticShopperAdvice == null ? "null" : this.DomesticShopperAdvice)}");
        }
    }
}