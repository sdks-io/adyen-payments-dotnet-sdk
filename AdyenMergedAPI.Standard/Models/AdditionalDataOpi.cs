// <copyright file="AdditionalDataOpi.cs" company="APIMatic">
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
    /// AdditionalDataOpi.
    /// </summary>
    public class AdditionalDataOpi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpi"/> class.
        /// </summary>
        public AdditionalDataOpi()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataOpi"/> class.
        /// </summary>
        /// <param name="opiIncludeTransToken">opi.includeTransToken.</param>
        public AdditionalDataOpi(
            string opiIncludeTransToken = null)
        {
            this.OpiIncludeTransToken = opiIncludeTransToken;
        }

        /// <summary>
        /// Optional boolean indicator. Set to **true** if you want an ecommerce transaction to return an `opi.transToken` as additional data in the response.
        /// You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
        /// </summary>
        [JsonProperty("opi.includeTransToken", NullValueHandling = NullValueHandling.Ignore)]
        public string OpiIncludeTransToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdditionalDataOpi : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdditionalDataOpi other &&                ((this.OpiIncludeTransToken == null && other.OpiIncludeTransToken == null) || (this.OpiIncludeTransToken?.Equals(other.OpiIncludeTransToken) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OpiIncludeTransToken = {(this.OpiIncludeTransToken == null ? "null" : this.OpiIncludeTransToken)}");
        }
    }
}