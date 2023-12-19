// <copyright file="ThreeDSRequestData.cs" company="APIMatic">
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
    /// ThreeDSRequestData.
    /// </summary>
    public class ThreeDSRequestData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestData"/> class.
        /// </summary>
        public ThreeDSRequestData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDSRequestData"/> class.
        /// </summary>
        /// <param name="challengeWindowSize">challengeWindowSize.</param>
        /// <param name="dataOnly">dataOnly.</param>
        /// <param name="nativeThreeDS">nativeThreeDS.</param>
        /// <param name="threeDSVersion">threeDSVersion.</param>
        public ThreeDSRequestData(
            Models.ChallengeWindowSizeEnum? challengeWindowSize = null,
            Models.DataOnlyEnum? dataOnly = null,
            Models.NativeThreeDSEnum? nativeThreeDS = null,
            Models.ThreeDSVersionEnum? threeDSVersion = null)
        {
            this.ChallengeWindowSize = challengeWindowSize;
            this.DataOnly = dataOnly;
            this.NativeThreeDS = nativeThreeDS;
            this.ThreeDSVersion = threeDSVersion;
        }

        /// <summary>
        /// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
        /// Possible values:
        /// * **01** - size of 250x400
        /// * **02** - size of 390x400
        /// * **03** - size of 500x600
        /// * **04** - size of 600x400
        /// * **05** - Fullscreen
        /// </summary>
        [JsonProperty("challengeWindowSize", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ChallengeWindowSizeEnum? ChallengeWindowSize { get; set; }

        /// <summary>
        /// Flag for data only flow.
        /// </summary>
        [JsonProperty("dataOnly", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DataOnlyEnum? DataOnly { get; set; }

        /// <summary>
        /// Indicates if [native 3D Secure authentication](https://docs.adyen.com/online-payments/3d-secure/native-3ds2) should be used when available.
        /// Possible values:
        /// * **preferred**: Use native 3D Secure authentication when available.
        /// </summary>
        [JsonProperty("nativeThreeDS", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NativeThreeDSEnum? NativeThreeDS { get; set; }

        /// <summary>
        /// The version of 3D Secure to use.
        /// Possible values:
        /// * **2.1.0**
        /// * **2.2.0**
        /// </summary>
        [JsonProperty("threeDSVersion", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ThreeDSVersionEnum? ThreeDSVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ThreeDSRequestData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ThreeDSRequestData other &&                ((this.ChallengeWindowSize == null && other.ChallengeWindowSize == null) || (this.ChallengeWindowSize?.Equals(other.ChallengeWindowSize) == true)) &&
                ((this.DataOnly == null && other.DataOnly == null) || (this.DataOnly?.Equals(other.DataOnly) == true)) &&
                ((this.NativeThreeDS == null && other.NativeThreeDS == null) || (this.NativeThreeDS?.Equals(other.NativeThreeDS) == true)) &&
                ((this.ThreeDSVersion == null && other.ThreeDSVersion == null) || (this.ThreeDSVersion?.Equals(other.ThreeDSVersion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ChallengeWindowSize = {(this.ChallengeWindowSize == null ? "null" : this.ChallengeWindowSize.ToString())}");
            toStringOutput.Add($"this.DataOnly = {(this.DataOnly == null ? "null" : this.DataOnly.ToString())}");
            toStringOutput.Add($"this.NativeThreeDS = {(this.NativeThreeDS == null ? "null" : this.NativeThreeDS.ToString())}");
            toStringOutput.Add($"this.ThreeDSVersion = {(this.ThreeDSVersion == null ? "null" : this.ThreeDSVersion.ToString())}");
        }
    }
}