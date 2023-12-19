// <copyright file="CancelOrderResponse.cs" company="APIMatic">
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
    /// CancelOrderResponse.
    /// </summary>
    public class CancelOrderResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse"/> class.
        /// </summary>
        public CancelOrderResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrderResponse"/> class.
        /// </summary>
        /// <param name="pspReference">pspReference.</param>
        /// <param name="resultCode">resultCode.</param>
        public CancelOrderResponse(
            string pspReference,
            string resultCode)
        {
            this.PspReference = pspReference;
            this.ResultCode = resultCode;
        }

        /// <summary>
        /// A unique reference of the cancellation request.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <summary>
        /// The result of the cancellation request.
        /// Possible values:
        /// * **Received** – Indicates the cancellation has successfully been received by Adyen, and will be processed.
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancelOrderResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CancelOrderResponse other &&                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode)}");
        }
    }
}