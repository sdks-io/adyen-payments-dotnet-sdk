// <copyright file="ThreeDSRequestorAuthenticationInfo2.cs" company="APIMatic">
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
    /// ThreeDSRequestorAuthenticationInfo2.
    /// </summary>
    public class ThreeDSRequestorAuthenticationInfo2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorAuthenticationInfo2"/> class.
        /// </summary>
        public ThreeDSRequestorAuthenticationInfo2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorAuthenticationInfo2"/> class.
        /// </summary>
        /// <param name="threeDSReqAuthData">threeDSReqAuthData.</param>
        /// <param name="threeDSReqAuthMethod">threeDSReqAuthMethod.</param>
        /// <param name="threeDSReqAuthTimestamp">threeDSReqAuthTimestamp.</param>
        public ThreeDSRequestorAuthenticationInfo2(
            string threeDSReqAuthData = null,
            Models.ThreeDSReqAuthMethodEnum? threeDSReqAuthMethod = null,
            string threeDSReqAuthTimestamp = null)
        {
            this.ThreeDSReqAuthData = threeDSReqAuthData;
            this.ThreeDSReqAuthMethod = threeDSReqAuthMethod;
            this.ThreeDSReqAuthTimestamp = threeDSReqAuthTimestamp;
        }

        /// <summary>
        /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
        /// </summary>
        [JsonProperty("threeDSReqAuthData", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSReqAuthData { get; set; }

        /// <summary>
        /// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values:
        /// * **01** — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest).
        /// * **02** — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials.
        /// * **03** — Login to the cardholder account at the 3DS Requestor system using federated ID.
        /// * **04** — Login to the cardholder account at the 3DS Requestor system using issuer credentials.
        /// * **05** — Login to the cardholder account at the 3DS Requestor system using third-party authentication.
        /// * **06** — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.
        /// </summary>
        [JsonProperty("threeDSReqAuthMethod", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSReqAuthMethodEnum? ThreeDSReqAuthMethod { get; set; }

        /// <summary>
        /// Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM
        /// </summary>
        [JsonProperty("threeDSReqAuthTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSReqAuthTimestamp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDSRequestorAuthenticationInfo2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDSRequestorAuthenticationInfo2 other &&                ((this.ThreeDSReqAuthData == null && other.ThreeDSReqAuthData == null) || (this.ThreeDSReqAuthData?.Equals(other.ThreeDSReqAuthData) == true)) &&
                ((this.ThreeDSReqAuthMethod == null && other.ThreeDSReqAuthMethod == null) || (this.ThreeDSReqAuthMethod?.Equals(other.ThreeDSReqAuthMethod) == true)) &&
                ((this.ThreeDSReqAuthTimestamp == null && other.ThreeDSReqAuthTimestamp == null) || (this.ThreeDSReqAuthTimestamp?.Equals(other.ThreeDSReqAuthTimestamp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ThreeDSReqAuthData = {(this.ThreeDSReqAuthData == null ? "null" : this.ThreeDSReqAuthData)}");
            toStringOutput.Add($"this.ThreeDSReqAuthMethod = {(this.ThreeDSReqAuthMethod == null ? "null" : this.ThreeDSReqAuthMethod.ToString())}");
            toStringOutput.Add($"this.ThreeDSReqAuthTimestamp = {(this.ThreeDSReqAuthTimestamp == null ? "null" : this.ThreeDSReqAuthTimestamp)}");
        }
    }
}