// <copyright file="MerchantDevice.cs" company="APIMatic">
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
    /// MerchantDevice.
    /// </summary>
    public class MerchantDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantDevice"/> class.
        /// </summary>
        public MerchantDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantDevice"/> class.
        /// </summary>
        /// <param name="os">os.</param>
        /// <param name="osVersion">osVersion.</param>
        /// <param name="reference">reference.</param>
        public MerchantDevice(
            string os = null,
            string osVersion = null,
            string reference = null)
        {
            this.Os = os;
            this.OsVersion = osVersion;
            this.Reference = reference;
        }

        /// <summary>
        /// Operating system running on the merchant device.
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the merchant device.
        /// </summary>
        [JsonProperty("osVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Merchant device reference.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MerchantDevice : ({string.Join(", ", toStringOutput)})";
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
            return obj is MerchantDevice other &&                ((this.Os == null && other.Os == null) || (this.Os?.Equals(other.Os) == true)) &&
                ((this.OsVersion == null && other.OsVersion == null) || (this.OsVersion?.Equals(other.OsVersion) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Os = {(this.Os == null ? "null" : this.Os)}");
            toStringOutput.Add($"this.OsVersion = {(this.OsVersion == null ? "null" : this.OsVersion)}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
        }
    }
}