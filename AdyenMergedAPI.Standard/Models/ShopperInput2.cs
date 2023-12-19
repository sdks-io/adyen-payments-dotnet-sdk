// <copyright file="ShopperInput2.cs" company="APIMatic">
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
    /// ShopperInput2.
    /// </summary>
    public class ShopperInput2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInput2"/> class.
        /// </summary>
        public ShopperInput2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInput2"/> class.
        /// </summary>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="personalDetails">personalDetails.</param>
        public ShopperInput2(
            Models.BillingAddress1Enum? billingAddress = null,
            Models.DeliveryAddress6Enum? deliveryAddress = null,
            Models.PersonalDetailsEnum? personalDetails = null)
        {
            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.PersonalDetails = personalDetails;
        }

        /// <summary>
        /// Specifies visibility of billing address fields.
        /// Permitted values:
        /// * editable
        /// * hidden
        /// * readOnly
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress1Enum? BillingAddress { get; set; }

        /// <summary>
        /// Specifies visibility of delivery address fields.
        /// Permitted values:
        /// * editable
        /// * hidden
        /// * readOnly
        /// </summary>
        [JsonProperty("deliveryAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryAddress6Enum? DeliveryAddress { get; set; }

        /// <summary>
        /// Specifies visibility of personal details.
        /// Permitted values:
        /// * editable
        /// * hidden
        /// * readOnly
        /// </summary>
        [JsonProperty("personalDetails", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PersonalDetailsEnum? PersonalDetails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ShopperInput2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ShopperInput2 other &&                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.DeliveryAddress == null && other.DeliveryAddress == null) || (this.DeliveryAddress?.Equals(other.DeliveryAddress) == true)) &&
                ((this.PersonalDetails == null && other.PersonalDetails == null) || (this.PersonalDetails?.Equals(other.PersonalDetails) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.DeliveryAddress = {(this.DeliveryAddress == null ? "null" : this.DeliveryAddress.ToString())}");
            toStringOutput.Add($"this.PersonalDetails = {(this.PersonalDetails == null ? "null" : this.PersonalDetails.ToString())}");
        }
    }
}