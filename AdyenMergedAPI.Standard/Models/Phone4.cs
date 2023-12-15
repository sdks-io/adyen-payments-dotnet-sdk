// <copyright file="Phone4.cs" company="APIMatic">
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
    /// Phone4.
    /// </summary>
    public class Phone4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone4"/> class.
        /// </summary>
        public Phone4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Phone4"/> class.
        /// </summary>
        /// <param name="cc">cc.</param>
        /// <param name="subscriber">subscriber.</param>
        public Phone4(
            string cc = null,
            string subscriber = null)
        {
            this.Cc = cc;
            this.Subscriber = subscriber;
        }

        /// <summary>
        /// Country code. Length: 1–3 characters.
        /// </summary>
        [JsonProperty("cc", NullValueHandling = NullValueHandling.Ignore)]
        public string Cc { get; set; }

        /// <summary>
        /// Subscriber number. Maximum length: 15 characters.
        /// </summary>
        [JsonProperty("subscriber", NullValueHandling = NullValueHandling.Ignore)]
        public string Subscriber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Phone4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Phone4 other &&                ((this.Cc == null && other.Cc == null) || (this.Cc?.Equals(other.Cc) == true)) &&
                ((this.Subscriber == null && other.Subscriber == null) || (this.Subscriber?.Equals(other.Subscriber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cc = {(this.Cc == null ? "null" : this.Cc)}");
            toStringOutput.Add($"this.Subscriber = {(this.Subscriber == null ? "null" : this.Subscriber)}");
        }
    }
}