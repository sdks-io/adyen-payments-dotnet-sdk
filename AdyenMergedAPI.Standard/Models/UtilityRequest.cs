// <copyright file="UtilityRequest.cs" company="APIMatic">
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
    /// UtilityRequest.
    /// </summary>
    public class UtilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityRequest"/> class.
        /// </summary>
        public UtilityRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityRequest"/> class.
        /// </summary>
        /// <param name="originDomains">originDomains.</param>
        public UtilityRequest(
            List<string> originDomains)
        {
            this.OriginDomains = originDomains;
        }

        /// <summary>
        /// The list of origin domains, for which origin keys are requested.
        /// </summary>
        [JsonProperty("originDomains")]
        public List<string> OriginDomains { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UtilityRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UtilityRequest other &&                ((this.OriginDomains == null && other.OriginDomains == null) || (this.OriginDomains?.Equals(other.OriginDomains) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OriginDomains = {(this.OriginDomains == null ? "null" : $"[{string.Join(", ", this.OriginDomains)} ]")}");
        }
    }
}