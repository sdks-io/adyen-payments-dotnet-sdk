// <copyright file="PaymentCaptureRequest.cs" company="APIMatic">
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
    /// PaymentCaptureRequest.
    /// </summary>
    public class PaymentCaptureRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCaptureRequest"/> class.
        /// </summary>
        public PaymentCaptureRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCaptureRequest"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="merchantAccount">merchantAccount.</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="lineItems">lineItems.</param>
        /// <param name="platformChargebackLogic">platformChargebackLogic.</param>
        /// <param name="reference">reference.</param>
        /// <param name="splits">splits.</param>
        /// <param name="subMerchants">subMerchants.</param>
        public PaymentCaptureRequest(
            Models.Amount27 amount,
            string merchantAccount,
            Models.ApplicationInfo applicationInfo = null,
            List<Models.LineItem> lineItems = null,
            Models.PlatformChargebackLogic platformChargebackLogic = null,
            string reference = null,
            List<Models.Split> splits = null,
            List<Models.SubMerchantInfo> subMerchants = null)
        {
            this.Amount = amount;
            this.ApplicationInfo = applicationInfo;
            this.LineItems = lineItems;
            this.MerchantAccount = merchantAccount;
            this.PlatformChargebackLogic = platformChargebackLogic;
            this.Reference = reference;
            this.Splits = splits;
            this.SubMerchants = subMerchants;
        }

        /// <summary>
        /// The amount that you want to capture. The `currency` must match the currency used in authorisation, the `value` must be smaller than or equal to the authorised amount.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount27 Amount { get; set; }

        /// <summary>
        /// Information about your application. For more details, see [Building Adyen solutions](https://docs.adyen.com/development-resources/building-adyen-solutions).
        /// </summary>
        [JsonProperty("applicationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Price and product information of the refunded items, required for [partial refunds](https://docs.adyen.com/online-payments/refund#refund-a-payment).
        /// > This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip.
        /// </summary>
        [JsonProperty("lineItems", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.LineItem> LineItems { get; set; }

        /// <summary>
        /// The merchant account that is used to process the payment.
        /// </summary>
        [JsonProperty("merchantAccount")]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Defines how to book chargebacks when using [Adyen for Platforms](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#chargebacks-and-disputes).
        /// </summary>
        [JsonProperty("platformChargebackLogic", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlatformChargebackLogic PlatformChargebackLogic { get; set; }

        /// <summary>
        /// Your reference for the capture request. Maximum length: 80 characters.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For details, refer to [Providing split information](https://docs.adyen.com/marketplaces-and-platforms/processing-payments#providing-split-information).
        /// </summary>
        [JsonProperty("splits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Split> Splits { get; set; }

        /// <summary>
        /// A List of sub-merchants.
        /// </summary>
        [JsonProperty("subMerchants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubMerchantInfo> SubMerchants { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentCaptureRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentCaptureRequest other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.ApplicationInfo == null && other.ApplicationInfo == null) || (this.ApplicationInfo?.Equals(other.ApplicationInfo) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                ((this.MerchantAccount == null && other.MerchantAccount == null) || (this.MerchantAccount?.Equals(other.MerchantAccount) == true)) &&
                ((this.PlatformChargebackLogic == null && other.PlatformChargebackLogic == null) || (this.PlatformChargebackLogic?.Equals(other.PlatformChargebackLogic) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Splits == null && other.Splits == null) || (this.Splits?.Equals(other.Splits) == true)) &&
                ((this.SubMerchants == null && other.SubMerchants == null) || (this.SubMerchants?.Equals(other.SubMerchants) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.ApplicationInfo = {(this.ApplicationInfo == null ? "null" : this.ApplicationInfo.ToString())}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"this.MerchantAccount = {(this.MerchantAccount == null ? "null" : this.MerchantAccount)}");
            toStringOutput.Add($"this.PlatformChargebackLogic = {(this.PlatformChargebackLogic == null ? "null" : this.PlatformChargebackLogic.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Splits = {(this.Splits == null ? "null" : $"[{string.Join(", ", this.Splits)} ]")}");
            toStringOutput.Add($"this.SubMerchants = {(this.SubMerchants == null ? "null" : $"[{string.Join(", ", this.SubMerchants)} ]")}");
        }
    }
}