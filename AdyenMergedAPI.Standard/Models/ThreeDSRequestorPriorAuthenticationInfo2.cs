// <copyright file="ThreeDSRequestorPriorAuthenticationInfo2.cs" company="APIMatic">
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
    /// ThreeDSRequestorPriorAuthenticationInfo2.
    /// </summary>
    public class ThreeDSRequestorPriorAuthenticationInfo2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorPriorAuthenticationInfo2"/> class.
        /// </summary>
        public ThreeDSRequestorPriorAuthenticationInfo2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestorPriorAuthenticationInfo2"/> class.
        /// </summary>
        /// <param name="threeDSReqPriorAuthData">threeDSReqPriorAuthData.</param>
        /// <param name="threeDSReqPriorAuthMethod">threeDSReqPriorAuthMethod.</param>
        /// <param name="threeDSReqPriorAuthTimestamp">threeDSReqPriorAuthTimestamp.</param>
        /// <param name="threeDSReqPriorRef">threeDSReqPriorRef.</param>
        public ThreeDSRequestorPriorAuthenticationInfo2(
            string threeDSReqPriorAuthData = null,
            Models.ThreeDSReqPriorAuthMethodEnum? threeDSReqPriorAuthMethod = null,
            string threeDSReqPriorAuthTimestamp = null,
            string threeDSReqPriorRef = null)
        {
            this.ThreeDSReqPriorAuthData = threeDSReqPriorAuthData;
            this.ThreeDSReqPriorAuthMethod = threeDSReqPriorAuthMethod;
            this.ThreeDSReqPriorAuthTimestamp = threeDSReqPriorAuthTimestamp;
            this.ThreeDSReqPriorRef = threeDSReqPriorRef;
        }

        /// <summary>
        /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
        /// </summary>
        [JsonProperty("threeDSReqPriorAuthData", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSReqPriorAuthData { get; set; }

        /// <summary>
        /// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values:
        /// * **01** — Frictionless authentication occurred by ACS.
        /// * **02** — Cardholder challenge occurred by ACS.
        /// * **03** — AVS verified.
        /// * **04** — Other issuer methods.
        /// </summary>
        [JsonProperty("threeDSReqPriorAuthMethod", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSReqPriorAuthMethodEnum? ThreeDSReqPriorAuthMethod { get; set; }

        /// <summary>
        /// Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM
        /// </summary>
        [JsonProperty("threeDSReqPriorAuthTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSReqPriorAuthTimestamp { get; set; }

        /// <summary>
        /// This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters.
        /// </summary>
        [JsonProperty("threeDSReqPriorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreeDSReqPriorRef { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDSRequestorPriorAuthenticationInfo2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDSRequestorPriorAuthenticationInfo2 other &&                ((this.ThreeDSReqPriorAuthData == null && other.ThreeDSReqPriorAuthData == null) || (this.ThreeDSReqPriorAuthData?.Equals(other.ThreeDSReqPriorAuthData) == true)) &&
                ((this.ThreeDSReqPriorAuthMethod == null && other.ThreeDSReqPriorAuthMethod == null) || (this.ThreeDSReqPriorAuthMethod?.Equals(other.ThreeDSReqPriorAuthMethod) == true)) &&
                ((this.ThreeDSReqPriorAuthTimestamp == null && other.ThreeDSReqPriorAuthTimestamp == null) || (this.ThreeDSReqPriorAuthTimestamp?.Equals(other.ThreeDSReqPriorAuthTimestamp) == true)) &&
                ((this.ThreeDSReqPriorRef == null && other.ThreeDSReqPriorRef == null) || (this.ThreeDSReqPriorRef?.Equals(other.ThreeDSReqPriorRef) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ThreeDSReqPriorAuthData = {(this.ThreeDSReqPriorAuthData == null ? "null" : this.ThreeDSReqPriorAuthData)}");
            toStringOutput.Add($"this.ThreeDSReqPriorAuthMethod = {(this.ThreeDSReqPriorAuthMethod == null ? "null" : this.ThreeDSReqPriorAuthMethod.ToString())}");
            toStringOutput.Add($"this.ThreeDSReqPriorAuthTimestamp = {(this.ThreeDSReqPriorAuthTimestamp == null ? "null" : this.ThreeDSReqPriorAuthTimestamp)}");
            toStringOutput.Add($"this.ThreeDSReqPriorRef = {(this.ThreeDSReqPriorRef == null ? "null" : this.ThreeDSReqPriorRef)}");
        }
    }
}