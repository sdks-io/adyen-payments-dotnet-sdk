// <copyright file="AuthenticationData1.cs" company="APIMatic">
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
    /// AuthenticationData1.
    /// </summary>
    public class AuthenticationData1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationData1"/> class.
        /// </summary>
        public AuthenticationData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationData1"/> class.
        /// </summary>
        /// <param name="attemptAuthentication">attemptAuthentication.</param>
        /// <param name="authenticationOnly">authenticationOnly.</param>
        /// <param name="threeDSRequestData">threeDSRequestData.</param>
        public AuthenticationData1(
            Models.AttemptAuthenticationEnum? attemptAuthentication = null,
            bool? authenticationOnly = false,
            Models.ThreeDSRequestData2 threeDSRequestData = null)
        {
            this.AttemptAuthentication = attemptAuthentication;
            this.AuthenticationOnly = authenticationOnly;
            this.ThreeDSRequestData = threeDSRequestData;
        }

        /// <summary>
        /// Indicates when 3D Secure authentication should be attempted. This overrides all other rules, including [Dynamic 3D Secure settings](https://docs.adyen.com/risk-management/dynamic-3d-secure).
        /// Possible values:
        /// * **always**: Perform 3D Secure authentication.
        /// * **never**: Don't perform 3D Secure authentication. If PSD2 SCA or other national regulations require authentication, the transaction gets declined.
        /// </summary>
        [JsonProperty("attemptAuthentication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AttemptAuthenticationEnum? AttemptAuthentication { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// Default: **false**.
        /// </summary>
        [JsonProperty("authenticationOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthenticationOnly { get; set; }

        /// <summary>
        /// Object with additional parameters for the 3D Secure authentication flow.
        /// </summary>
        [JsonProperty("threeDSRequestData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSRequestData2 ThreeDSRequestData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthenticationData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthenticationData1 other &&                ((this.AttemptAuthentication == null && other.AttemptAuthentication == null) || (this.AttemptAuthentication?.Equals(other.AttemptAuthentication) == true)) &&
                ((this.AuthenticationOnly == null && other.AuthenticationOnly == null) || (this.AuthenticationOnly?.Equals(other.AuthenticationOnly) == true)) &&
                ((this.ThreeDSRequestData == null && other.ThreeDSRequestData == null) || (this.ThreeDSRequestData?.Equals(other.ThreeDSRequestData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AttemptAuthentication = {(this.AttemptAuthentication == null ? "null" : this.AttemptAuthentication.ToString())}");
            toStringOutput.Add($"this.AuthenticationOnly = {(this.AuthenticationOnly == null ? "null" : this.AuthenticationOnly.ToString())}");
            toStringOutput.Add($"this.ThreeDSRequestData = {(this.ThreeDSRequestData == null ? "null" : this.ThreeDSRequestData.ToString())}");
        }
    }
}