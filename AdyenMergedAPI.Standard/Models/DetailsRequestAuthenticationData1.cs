// <copyright file="DetailsRequestAuthenticationData1.cs" company="APIMatic">
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
    /// DetailsRequestAuthenticationData1.
    /// </summary>
    public class DetailsRequestAuthenticationData1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequestAuthenticationData1"/> class.
        /// </summary>
        public DetailsRequestAuthenticationData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequestAuthenticationData1"/> class.
        /// </summary>
        /// <param name="authenticationOnly">authenticationOnly.</param>
        public DetailsRequestAuthenticationData1(
            bool? authenticationOnly = false)
        {
            this.AuthenticationOnly = authenticationOnly;
        }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// Default: *false**.
        /// </summary>
        [JsonProperty("authenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthenticationOnly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DetailsRequestAuthenticationData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DetailsRequestAuthenticationData1 other &&                ((this.AuthenticationOnly == null && other.AuthenticationOnly == null) || (this.AuthenticationOnly?.Equals(other.AuthenticationOnly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AuthenticationOnly = {(this.AuthenticationOnly == null ? "null" : this.AuthenticationOnly.ToString())}");
        }
    }
}