// <copyright file="ApplicationInfo1.cs" company="APIMatic">
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
    /// ApplicationInfo1.
    /// </summary>
    public class ApplicationInfo1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInfo1"/> class.
        /// </summary>
        public ApplicationInfo1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInfo1"/> class.
        /// </summary>
        /// <param name="adyenLibrary">adyenLibrary.</param>
        /// <param name="adyenPaymentSource">adyenPaymentSource.</param>
        /// <param name="externalPlatform">externalPlatform.</param>
        /// <param name="merchantApplication">merchantApplication.</param>
        /// <param name="merchantDevice">merchantDevice.</param>
        /// <param name="shopperInteractionDevice">shopperInteractionDevice.</param>
        public ApplicationInfo1(
            Models.CommonField4 adyenLibrary = null,
            Models.CommonField1 adyenPaymentSource = null,
            Models.ExternalPlatform2 externalPlatform = null,
            Models.CommonField2 merchantApplication = null,
            Models.MerchantDevice2 merchantDevice = null,
            Models.ShopperInteractionDevice2 shopperInteractionDevice = null)
        {
            this.AdyenLibrary = adyenLibrary;
            this.AdyenPaymentSource = adyenPaymentSource;
            this.ExternalPlatform = externalPlatform;
            this.MerchantApplication = merchantApplication;
            this.MerchantDevice = merchantDevice;
            this.ShopperInteractionDevice = shopperInteractionDevice;
        }

        /// <summary>
        /// Adyen-developed software, such as libraries and plugins, used to interact with the Adyen API. For example, Magento plugin, Java API library, etc.
        /// </summary>
        [JsonProperty("adyenLibrary", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CommonField4 AdyenLibrary { get; set; }

        /// <summary>
        /// Adyen-developed software to get payment details. For example, Checkout SDK, Secured Fields SDK, etc.
        /// </summary>
        [JsonProperty("adyenPaymentSource", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CommonField1 AdyenPaymentSource { get; set; }

        /// <summary>
        /// Third-party developed platform used to initiate payment requests. For example, Magento, Zuora, etc.
        /// </summary>
        [JsonProperty("externalPlatform", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExternalPlatform2 ExternalPlatform { get; set; }

        /// <summary>
        /// Merchant developed software, such as cashier application, used to interact with the Adyen API.
        /// </summary>
        [JsonProperty("merchantApplication", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CommonField2 MerchantApplication { get; set; }

        /// <summary>
        /// Merchant device information.
        /// </summary>
        [JsonProperty("merchantDevice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MerchantDevice2 MerchantDevice { get; set; }

        /// <summary>
        /// Shopper interaction device, such as terminal, mobile device or web browser, to initiate payment requests.
        /// </summary>
        [JsonProperty("shopperInteractionDevice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ShopperInteractionDevice2 ShopperInteractionDevice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplicationInfo1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplicationInfo1 other &&                ((this.AdyenLibrary == null && other.AdyenLibrary == null) || (this.AdyenLibrary?.Equals(other.AdyenLibrary) == true)) &&
                ((this.AdyenPaymentSource == null && other.AdyenPaymentSource == null) || (this.AdyenPaymentSource?.Equals(other.AdyenPaymentSource) == true)) &&
                ((this.ExternalPlatform == null && other.ExternalPlatform == null) || (this.ExternalPlatform?.Equals(other.ExternalPlatform) == true)) &&
                ((this.MerchantApplication == null && other.MerchantApplication == null) || (this.MerchantApplication?.Equals(other.MerchantApplication) == true)) &&
                ((this.MerchantDevice == null && other.MerchantDevice == null) || (this.MerchantDevice?.Equals(other.MerchantDevice) == true)) &&
                ((this.ShopperInteractionDevice == null && other.ShopperInteractionDevice == null) || (this.ShopperInteractionDevice?.Equals(other.ShopperInteractionDevice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdyenLibrary = {(this.AdyenLibrary == null ? "null" : this.AdyenLibrary.ToString())}");
            toStringOutput.Add($"this.AdyenPaymentSource = {(this.AdyenPaymentSource == null ? "null" : this.AdyenPaymentSource.ToString())}");
            toStringOutput.Add($"this.ExternalPlatform = {(this.ExternalPlatform == null ? "null" : this.ExternalPlatform.ToString())}");
            toStringOutput.Add($"this.MerchantApplication = {(this.MerchantApplication == null ? "null" : this.MerchantApplication.ToString())}");
            toStringOutput.Add($"this.MerchantDevice = {(this.MerchantDevice == null ? "null" : this.MerchantDevice.ToString())}");
            toStringOutput.Add($"this.ShopperInteractionDevice = {(this.ShopperInteractionDevice == null ? "null" : this.ShopperInteractionDevice.ToString())}");
        }
    }
}