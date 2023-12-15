// <copyright file="ResponseAdditionalDataOpi.cs" company="APIMatic">
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
    /// ResponseAdditionalDataOpi.
    /// </summary>
    public class ResponseAdditionalDataOpi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataOpi"/> class.
        /// </summary>
        public ResponseAdditionalDataOpi()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataOpi"/> class.
        /// </summary>
        /// <param name="opiTransToken">opi.transToken.</param>
        public ResponseAdditionalDataOpi(
            string opiTransToken = null)
        {
            this.OpiTransToken = opiTransToken;
        }

        /// <summary>
        /// Returned in the response if you included `opi.includeTransToken: true` in an ecommerce payment request. This contains an Oracle Payment Interface token that you can store in your Oracle Opera database to identify tokenized ecommerce transactions. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
        /// </summary>
        [JsonProperty("opi.transToken", NullValueHandling = NullValueHandling.Ignore)]
        public string OpiTransToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataOpi : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataOpi other &&                ((this.OpiTransToken == null && other.OpiTransToken == null) || (this.OpiTransToken?.Equals(other.OpiTransToken) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OpiTransToken = {(this.OpiTransToken == null ? "null" : this.OpiTransToken)}");
        }
    }
}