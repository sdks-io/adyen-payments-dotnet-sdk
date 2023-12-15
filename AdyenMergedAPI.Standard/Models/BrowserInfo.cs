// <copyright file="BrowserInfo.cs" company="APIMatic">
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
    /// BrowserInfo.
    /// </summary>
    public class BrowserInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo"/> class.
        /// </summary>
        public BrowserInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserInfo"/> class.
        /// </summary>
        /// <param name="acceptHeader">acceptHeader.</param>
        /// <param name="colorDepth">colorDepth.</param>
        /// <param name="javaEnabled">javaEnabled.</param>
        /// <param name="language">language.</param>
        /// <param name="screenHeight">screenHeight.</param>
        /// <param name="screenWidth">screenWidth.</param>
        /// <param name="timeZoneOffset">timeZoneOffset.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="javaScriptEnabled">javaScriptEnabled.</param>
        public BrowserInfo(
            string acceptHeader,
            int colorDepth,
            bool javaEnabled,
            string language,
            int screenHeight,
            int screenWidth,
            int timeZoneOffset,
            string userAgent,
            bool? javaScriptEnabled = true)
        {
            this.AcceptHeader = acceptHeader;
            this.ColorDepth = colorDepth;
            this.JavaEnabled = javaEnabled;
            this.JavaScriptEnabled = javaScriptEnabled;
            this.Language = language;
            this.ScreenHeight = screenHeight;
            this.ScreenWidth = screenWidth;
            this.TimeZoneOffset = timeZoneOffset;
            this.UserAgent = userAgent;
        }

        /// <summary>
        /// The accept header value of the shopper's browser.
        /// </summary>
        [JsonProperty("acceptHeader")]
        public string AcceptHeader { get; set; }

        /// <summary>
        /// The color depth of the shopper's browser in bits per pixel. This should be obtained by using the browser's `screen.colorDepth` property. Accepted values: 1, 4, 8, 15, 16, 24, 30, 32 or 48 bit color depth.
        /// </summary>
        [JsonProperty("colorDepth")]
        public int ColorDepth { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper's browser is able to execute Java.
        /// </summary>
        [JsonProperty("javaEnabled")]
        public bool JavaEnabled { get; set; }

        /// <summary>
        /// Boolean value indicating if the shopper's browser is able to execute JavaScript. A default 'true' value is assumed if the field is not present.
        /// </summary>
        [JsonProperty("javaScriptEnabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? JavaScriptEnabled { get; set; }

        /// <summary>
        /// The `navigator.language` value of the shopper's browser (as defined in IETF BCP 47).
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// The total height of the shopper's device screen in pixels.
        /// </summary>
        [JsonProperty("screenHeight")]
        public int ScreenHeight { get; set; }

        /// <summary>
        /// The total width of the shopper's device screen in pixels.
        /// </summary>
        [JsonProperty("screenWidth")]
        public int ScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the shopper's browser local time, in minutes.
        /// </summary>
        [JsonProperty("timeZoneOffset")]
        public int TimeZoneOffset { get; set; }

        /// <summary>
        /// The user agent value of the shopper's browser.
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BrowserInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is BrowserInfo other &&                ((this.AcceptHeader == null && other.AcceptHeader == null) || (this.AcceptHeader?.Equals(other.AcceptHeader) == true)) &&
                this.ColorDepth.Equals(other.ColorDepth) &&
                this.JavaEnabled.Equals(other.JavaEnabled) &&
                ((this.JavaScriptEnabled == null && other.JavaScriptEnabled == null) || (this.JavaScriptEnabled?.Equals(other.JavaScriptEnabled) == true)) &&
                ((this.Language == null && other.Language == null) || (this.Language?.Equals(other.Language) == true)) &&
                this.ScreenHeight.Equals(other.ScreenHeight) &&
                this.ScreenWidth.Equals(other.ScreenWidth) &&
                this.TimeZoneOffset.Equals(other.TimeZoneOffset) &&
                ((this.UserAgent == null && other.UserAgent == null) || (this.UserAgent?.Equals(other.UserAgent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AcceptHeader = {(this.AcceptHeader == null ? "null" : this.AcceptHeader)}");
            toStringOutput.Add($"this.ColorDepth = {this.ColorDepth}");
            toStringOutput.Add($"this.JavaEnabled = {this.JavaEnabled}");
            toStringOutput.Add($"this.JavaScriptEnabled = {(this.JavaScriptEnabled == null ? "null" : this.JavaScriptEnabled.ToString())}");
            toStringOutput.Add($"this.Language = {(this.Language == null ? "null" : this.Language)}");
            toStringOutput.Add($"this.ScreenHeight = {this.ScreenHeight}");
            toStringOutput.Add($"this.ScreenWidth = {this.ScreenWidth}");
            toStringOutput.Add($"this.TimeZoneOffset = {this.TimeZoneOffset}");
            toStringOutput.Add($"this.UserAgent = {(this.UserAgent == null ? "null" : this.UserAgent)}");
        }
    }
}