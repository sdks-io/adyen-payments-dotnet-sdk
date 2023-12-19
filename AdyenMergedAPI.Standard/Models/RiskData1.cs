// <copyright file="RiskData1.cs" company="APIMatic">
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
    /// RiskData1.
    /// </summary>
    public class RiskData1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskData1"/> class.
        /// </summary>
        public RiskData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RiskData1"/> class.
        /// </summary>
        /// <param name="clientData">clientData.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="fraudOffset">fraudOffset.</param>
        /// <param name="profileReference">profileReference.</param>
        public RiskData1(
            string clientData = null,
            Dictionary<string, string> customFields = null,
            int? fraudOffset = null,
            string profileReference = null)
        {
            this.ClientData = clientData;
            this.CustomFields = customFields;
            this.FraudOffset = fraudOffset;
            this.ProfileReference = profileReference;
        }

        /// <summary>
        /// Contains client-side data, like the device fingerprint, cookies, and specific browser settings.
        /// </summary>
        [JsonProperty("clientData", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientData { get; set; }

        /// <summary>
        /// Any custom fields used as part of the input to configured risk rules.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CustomFields { get; set; }

        /// <summary>
        /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
        /// </summary>
        [JsonProperty("fraudOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? FraudOffset { get; set; }

        /// <summary>
        /// The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied.
        /// </summary>
        [JsonProperty("profileReference", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RiskData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is RiskData1 other &&                ((this.ClientData == null && other.ClientData == null) || (this.ClientData?.Equals(other.ClientData) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.FraudOffset == null && other.FraudOffset == null) || (this.FraudOffset?.Equals(other.FraudOffset) == true)) &&
                ((this.ProfileReference == null && other.ProfileReference == null) || (this.ProfileReference?.Equals(other.ProfileReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientData = {(this.ClientData == null ? "null" : this.ClientData)}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");
            toStringOutput.Add($"this.FraudOffset = {(this.FraudOffset == null ? "null" : this.FraudOffset.ToString())}");
            toStringOutput.Add($"this.ProfileReference = {(this.ProfileReference == null ? "null" : this.ProfileReference)}");
        }
    }
}