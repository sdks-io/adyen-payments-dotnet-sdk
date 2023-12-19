// <copyright file="UtilityResponse.cs" company="APIMatic">
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
    /// UtilityResponse.
    /// </summary>
    public class UtilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityResponse"/> class.
        /// </summary>
        public UtilityResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityResponse"/> class.
        /// </summary>
        /// <param name="originKeys">originKeys.</param>
        public UtilityResponse(
            Dictionary<string, string> originKeys = null)
        {
            this.OriginKeys = originKeys;
        }

        /// <summary>
        /// The list of origin keys for all requested domains. For each list item, the key is the domain and the value is the origin key.
        /// </summary>
        [JsonProperty("originKeys", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> OriginKeys { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UtilityResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UtilityResponse other &&                ((this.OriginKeys == null && other.OriginKeys == null) || (this.OriginKeys?.Equals(other.OriginKeys) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"OriginKeys = {(this.OriginKeys == null ? "null" : this.OriginKeys.ToString())}");
        }
    }
}