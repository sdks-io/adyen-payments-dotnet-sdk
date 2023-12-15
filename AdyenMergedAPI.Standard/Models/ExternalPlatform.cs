// <copyright file="ExternalPlatform.cs" company="APIMatic">
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
    /// ExternalPlatform.
    /// </summary>
    public class ExternalPlatform
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPlatform"/> class.
        /// </summary>
        public ExternalPlatform()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPlatform"/> class.
        /// </summary>
        /// <param name="integrator">integrator.</param>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        public ExternalPlatform(
            string integrator = null,
            string name = null,
            string version = null)
        {
            this.Integrator = integrator;
            this.Name = name;
            this.Version = version;
        }

        /// <summary>
        /// External platform integrator.
        /// </summary>
        [JsonProperty("integrator", NullValueHandling = NullValueHandling.Ignore)]
        public string Integrator { get; set; }

        /// <summary>
        /// Name of the field. For example, Name of External Platform.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Version of the field. For example, Version of External Platform.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExternalPlatform : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExternalPlatform other &&                ((this.Integrator == null && other.Integrator == null) || (this.Integrator?.Equals(other.Integrator) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Integrator = {(this.Integrator == null ? "null" : this.Integrator)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
        }
    }
}