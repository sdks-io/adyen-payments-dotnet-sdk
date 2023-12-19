// <copyright file="EncryptedOrderData.cs" company="APIMatic">
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
    /// EncryptedOrderData.
    /// </summary>
    public class EncryptedOrderData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedOrderData"/> class.
        /// </summary>
        public EncryptedOrderData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptedOrderData"/> class.
        /// </summary>
        /// <param name="orderData">orderData.</param>
        /// <param name="pspReference">pspReference.</param>
        public EncryptedOrderData(
            string orderData,
            string pspReference)
        {
            this.OrderData = orderData;
            this.PspReference = pspReference;
        }

        /// <summary>
        /// The encrypted order data.
        /// </summary>
        [JsonProperty("orderData")]
        public string OrderData { get; set; }

        /// <summary>
        /// The `pspReference` that belongs to the order.
        /// </summary>
        [JsonProperty("pspReference")]
        public string PspReference { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EncryptedOrderData : ({string.Join(", ", toStringOutput)})";
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
            return obj is EncryptedOrderData other &&                ((this.OrderData == null && other.OrderData == null) || (this.OrderData?.Equals(other.OrderData) == true)) &&
                ((this.PspReference == null && other.PspReference == null) || (this.PspReference?.Equals(other.PspReference) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OrderData = {(this.OrderData == null ? "null" : this.OrderData)}");
            toStringOutput.Add($"this.PspReference = {(this.PspReference == null ? "null" : this.PspReference)}");
        }
    }
}