// <copyright file="SDKEphemPubKey1.cs" company="APIMatic">
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
    /// SDKEphemPubKey1.
    /// </summary>
    public class SDKEphemPubKey1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey1"/> class.
        /// </summary>
        public SDKEphemPubKey1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SDKEphemPubKey1"/> class.
        /// </summary>
        /// <param name="crv">crv.</param>
        /// <param name="kty">kty.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        public SDKEphemPubKey1(
            string crv = null,
            string kty = null,
            string x = null,
            string y = null)
        {
            this.Crv = crv;
            this.Kty = kty;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// The `crv` value as received from the 3D Secure 2 SDK.
        /// </summary>
        [JsonProperty("crv", NullValueHandling = NullValueHandling.Ignore)]
        public string Crv { get; set; }

        /// <summary>
        /// The `kty` value as received from the 3D Secure 2 SDK.
        /// </summary>
        [JsonProperty("kty", NullValueHandling = NullValueHandling.Ignore)]
        public string Kty { get; set; }

        /// <summary>
        /// The `x` value as received from the 3D Secure 2 SDK.
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public string X { get; set; }

        /// <summary>
        /// The `y` value as received from the 3D Secure 2 SDK.
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public string Y { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SDKEphemPubKey1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is SDKEphemPubKey1 other &&                ((this.Crv == null && other.Crv == null) || (this.Crv?.Equals(other.Crv) == true)) &&
                ((this.Kty == null && other.Kty == null) || (this.Kty?.Equals(other.Kty) == true)) &&
                ((this.X == null && other.X == null) || (this.X?.Equals(other.X) == true)) &&
                ((this.Y == null && other.Y == null) || (this.Y?.Equals(other.Y) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Crv = {(this.Crv == null ? "null" : this.Crv)}");
            toStringOutput.Add($"this.Kty = {(this.Kty == null ? "null" : this.Kty)}");
            toStringOutput.Add($"this.X = {(this.X == null ? "null" : this.X)}");
            toStringOutput.Add($"this.Y = {(this.Y == null ? "null" : this.Y)}");
        }
    }
}