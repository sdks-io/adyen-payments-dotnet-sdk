// <copyright file="WeChatPayMiniProgram.cs" company="APIMatic">
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
    /// WeChatPayMiniProgram.
    /// </summary>
    public class WeChatPayMiniProgram
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeChatPayMiniProgram"/> class.
        /// </summary>
        public WeChatPayMiniProgram()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeChatPayMiniProgram"/> class.
        /// </summary>
        /// <param name="appId">appId.</param>
        /// <param name="checkoutAttemptId">checkoutAttemptId.</param>
        /// <param name="openid">openid.</param>
        /// <param name="type">type.</param>
        public WeChatPayMiniProgram(
            string appId = null,
            string checkoutAttemptId = null,
            string openid = null,
            Models.Type35Enum? type = Models.Type35Enum.WechatpayMiniProgram)
        {
            this.AppId = appId;
            this.CheckoutAttemptId = checkoutAttemptId;
            this.Openid = openid;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets AppId.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// The checkout attempt identifier.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("checkoutAttemptId", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckoutAttemptId { get; set; }

        /// <summary>
        /// Gets or sets Openid.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("openid", NullValueHandling = NullValueHandling.Ignore)]
        public string Openid { get; set; }

        /// <summary>
        /// **wechatpayMiniProgram**
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Type35Enum? Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WeChatPayMiniProgram : ({string.Join(", ", toStringOutput)})";
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
            return obj is WeChatPayMiniProgram other &&                ((this.AppId == null && other.AppId == null) || (this.AppId?.Equals(other.AppId) == true)) &&
                ((this.CheckoutAttemptId == null && other.CheckoutAttemptId == null) || (this.CheckoutAttemptId?.Equals(other.CheckoutAttemptId) == true)) &&
                ((this.Openid == null && other.Openid == null) || (this.Openid?.Equals(other.Openid) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AppId = {(this.AppId == null ? "null" : this.AppId)}");
            toStringOutput.Add($"this.CheckoutAttemptId = {(this.CheckoutAttemptId == null ? "null" : this.CheckoutAttemptId)}");
            toStringOutput.Add($"this.Openid = {(this.Openid == null ? "null" : this.Openid)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}