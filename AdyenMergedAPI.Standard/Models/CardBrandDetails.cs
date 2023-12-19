// <copyright file="CardBrandDetails.cs" company="APIMatic">
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
    /// CardBrandDetails.
    /// </summary>
    public class CardBrandDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardBrandDetails"/> class.
        /// </summary>
        public CardBrandDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardBrandDetails"/> class.
        /// </summary>
        /// <param name="supported">supported.</param>
        /// <param name="type">type.</param>
        public CardBrandDetails(
            bool? supported = null,
            string type = null)
        {
            this.Supported = supported;
            this.Type = type;
        }

        /// <summary>
        /// Indicates if you support the card brand.
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// The name of the card brand.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardBrandDetails : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardBrandDetails other &&                ((this.Supported == null && other.Supported == null) || (this.Supported?.Equals(other.Supported) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Supported = {(this.Supported == null ? "null" : this.Supported.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}