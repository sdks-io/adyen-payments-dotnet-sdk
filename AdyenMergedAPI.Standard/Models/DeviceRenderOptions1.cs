// <copyright file="DeviceRenderOptions1.cs" company="APIMatic">
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
    /// DeviceRenderOptions1.
    /// </summary>
    public class DeviceRenderOptions1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRenderOptions1"/> class.
        /// </summary>
        public DeviceRenderOptions1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRenderOptions1"/> class.
        /// </summary>
        /// <param name="sdkInterface">sdkInterface.</param>
        /// <param name="sdkUiType">sdkUiType.</param>
        public DeviceRenderOptions1(
            Models.SdkInterfaceEnum? sdkInterface = Models.SdkInterfaceEnum.Both,
            List<Models.SdkUiTypeEnum> sdkUiType = null)
        {
            this.SdkInterface = sdkInterface;
            this.SdkUiType = sdkUiType;
        }

        /// <summary>
        /// Supported SDK interface types.
        /// Allowed values:
        /// * native
        /// * html
        /// * both
        /// </summary>
        [JsonProperty("sdkInterface", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SdkInterfaceEnum? SdkInterface { get; set; }

        /// <summary>
        /// UI types supported for displaying specific challenges.
        /// Allowed values:
        /// * text
        /// * singleSelect
        /// * outOfBand
        /// * otherHtml
        /// * multiSelect
        /// </summary>
        [JsonProperty("sdkUiType", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SdkUiTypeEnum> SdkUiType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceRenderOptions1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceRenderOptions1 other &&                ((this.SdkInterface == null && other.SdkInterface == null) || (this.SdkInterface?.Equals(other.SdkInterface) == true)) &&
                ((this.SdkUiType == null && other.SdkUiType == null) || (this.SdkUiType?.Equals(other.SdkUiType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SdkInterface = {(this.SdkInterface == null ? "null" : this.SdkInterface.ToString())}");
            toStringOutput.Add($"this.SdkUiType = {(this.SdkUiType == null ? "null" : $"[{string.Join(", ", this.SdkUiType)} ]")}");
        }
    }
}