// <copyright file="CardDetailsResponse.cs" company="APIMatic">
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
    /// CardDetailsResponse.
    /// </summary>
    public class CardDetailsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponse"/> class.
        /// </summary>
        public CardDetailsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDetailsResponse"/> class.
        /// </summary>
        /// <param name="brands">brands.</param>
        public CardDetailsResponse(
            List<Models.CardBrandDetails> brands = null)
        {
            this.Brands = brands;
        }

        /// <summary>
        /// The list of brands identified for the card.
        /// </summary>
        [JsonProperty("brands", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardBrandDetails> Brands { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardDetailsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardDetailsResponse other &&                ((this.Brands == null && other.Brands == null) || (this.Brands?.Equals(other.Brands) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Brands = {(this.Brands == null ? "null" : $"[{string.Join(", ", this.Brands)} ]")}");
        }
    }
}