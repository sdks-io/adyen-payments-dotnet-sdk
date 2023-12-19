// <copyright file="SubInputDetail.cs" company="APIMatic">
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
    /// SubInputDetail.
    /// </summary>
    public class SubInputDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubInputDetail"/> class.
        /// </summary>
        public SubInputDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubInputDetail"/> class.
        /// </summary>
        /// <param name="configuration">configuration.</param>
        /// <param name="items">items.</param>
        /// <param name="key">key.</param>
        /// <param name="optional">optional.</param>
        /// <param name="type">type.</param>
        /// <param name="mValue">value.</param>
        public SubInputDetail(
            Dictionary<string, string> configuration = null,
            List<Models.Item> items = null,
            string key = null,
            bool? optional = null,
            string type = null,
            string mValue = null)
        {
            this.Configuration = configuration;
            this.Items = items;
            this.Key = key;
            this.Optional = optional;
            this.Type = type;
            this.MValue = mValue;
        }

        /// <summary>
        /// Configuration parameters for the required input.
        /// </summary>
        [JsonProperty("configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Configuration { get; set; }

        /// <summary>
        /// In case of a select, the items to choose from.
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Item> Items { get; set; }

        /// <summary>
        /// The value to provide in the result.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// True if this input is optional to provide.
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; }

        /// <summary>
        /// The type of the required input.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// The value can be pre-filled, if available.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubInputDetail : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubInputDetail other &&                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true)) &&
                ((this.Items == null && other.Items == null) || (this.Items?.Equals(other.Items) == true)) &&
                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true)) &&
                ((this.Optional == null && other.Optional == null) || (this.Optional?.Equals(other.Optional) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Configuration = {(this.Configuration == null ? "null" : this.Configuration.ToString())}");
            toStringOutput.Add($"this.Items = {(this.Items == null ? "null" : $"[{string.Join(", ", this.Items)} ]")}");
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
            toStringOutput.Add($"this.Optional = {(this.Optional == null ? "null" : this.Optional.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
        }
    }
}