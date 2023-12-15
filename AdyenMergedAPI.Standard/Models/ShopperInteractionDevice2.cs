// <copyright file="ShopperInteractionDevice2.cs" company="APIMatic">
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
    /// ShopperInteractionDevice2.
    /// </summary>
    public class ShopperInteractionDevice2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInteractionDevice2"/> class.
        /// </summary>
        public ShopperInteractionDevice2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInteractionDevice2"/> class.
        /// </summary>
        /// <param name="locale">locale.</param>
        /// <param name="os">os.</param>
        /// <param name="osVersion">osVersion.</param>
        public ShopperInteractionDevice2(
            string locale = null,
            string os = null,
            string osVersion = null)
        {
            this.Locale = locale;
            this.Os = os;
            this.OsVersion = osVersion;
        }

        /// <summary>
        /// Locale on the shopper interaction device.
        /// </summary>
        [JsonProperty("locale", NullValueHandling = NullValueHandling.Ignore)]
        public string Locale { get; set; }

        /// <summary>
        /// Operating system running on the shopper interaction device.
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// Version of the operating system on the shopper interaction device.
        /// </summary>
        [JsonProperty("osVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShopperInteractionDevice2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShopperInteractionDevice2 other &&                ((this.Locale == null && other.Locale == null) || (this.Locale?.Equals(other.Locale) == true)) &&
                ((this.Os == null && other.Os == null) || (this.Os?.Equals(other.Os) == true)) &&
                ((this.OsVersion == null && other.OsVersion == null) || (this.OsVersion?.Equals(other.OsVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Locale = {(this.Locale == null ? "null" : this.Locale)}");
            toStringOutput.Add($"this.Os = {(this.Os == null ? "null" : this.Os)}");
            toStringOutput.Add($"this.OsVersion = {(this.OsVersion == null ? "null" : this.OsVersion)}");
        }
    }
}