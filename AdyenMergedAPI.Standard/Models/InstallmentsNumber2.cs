// <copyright file="InstallmentsNumber2.cs" company="APIMatic">
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
    /// InstallmentsNumber2.
    /// </summary>
    public class InstallmentsNumber2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentsNumber2"/> class.
        /// </summary>
        public InstallmentsNumber2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentsNumber2"/> class.
        /// </summary>
        /// <param name="maxNumberOfInstallments">maxNumberOfInstallments.</param>
        public InstallmentsNumber2(
            int maxNumberOfInstallments)
        {
            this.MaxNumberOfInstallments = maxNumberOfInstallments;
        }

        /// <summary>
        /// Maximum number of installments
        /// </summary>
        [JsonProperty("maxNumberOfInstallments")]
        public int MaxNumberOfInstallments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstallmentsNumber2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstallmentsNumber2 other &&                this.MaxNumberOfInstallments.Equals(other.MaxNumberOfInstallments);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MaxNumberOfInstallments = {this.MaxNumberOfInstallments}");
        }
    }
}