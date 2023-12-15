// <copyright file="AuthenticationResultResponse.cs" company="APIMatic">
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
    /// AuthenticationResultResponse.
    /// </summary>
    public class AuthenticationResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResultResponse"/> class.
        /// </summary>
        public AuthenticationResultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationResultResponse"/> class.
        /// </summary>
        /// <param name="threeDS1Result">threeDS1Result.</param>
        /// <param name="threeDS2Result">threeDS2Result.</param>
        public AuthenticationResultResponse(
            Models.ThreeDS1Result2 threeDS1Result = null,
            Models.ThreeDS2Result3 threeDS2Result = null)
        {
            this.ThreeDS1Result = threeDS1Result;
            this.ThreeDS2Result = threeDS2Result;
        }

        /// <summary>
        /// The result of the 3D Secure authentication.
        /// </summary>
        [JsonProperty("threeDS1Result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS1Result2 ThreeDS1Result { get; set; }

        /// <summary>
        /// The result of the 3D Secure 2 authentication.
        /// </summary>
        [JsonProperty("threeDS2Result", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDS2Result3 ThreeDS2Result { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthenticationResultResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthenticationResultResponse other &&                ((this.ThreeDS1Result == null && other.ThreeDS1Result == null) || (this.ThreeDS1Result?.Equals(other.ThreeDS1Result) == true)) &&
                ((this.ThreeDS2Result == null && other.ThreeDS2Result == null) || (this.ThreeDS2Result?.Equals(other.ThreeDS2Result) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ThreeDS1Result = {(this.ThreeDS1Result == null ? "null" : this.ThreeDS1Result.ToString())}");
            toStringOutput.Add($"this.ThreeDS2Result = {(this.ThreeDS2Result == null ? "null" : this.ThreeDS2Result.ToString())}");
        }
    }
}