// <copyright file="MerchantRiskIndicator1.cs" company="APIMatic">
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
    /// MerchantRiskIndicator1.
    /// </summary>
    public class MerchantRiskIndicator1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRiskIndicator1"/> class.
        /// </summary>
        public MerchantRiskIndicator1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRiskIndicator1"/> class.
        /// </summary>
        /// <param name="addressMatch">addressMatch.</param>
        /// <param name="deliveryAddressIndicator">deliveryAddressIndicator.</param>
        /// <param name="deliveryEmail">deliveryEmail.</param>
        /// <param name="deliveryEmailAddress">deliveryEmailAddress.</param>
        /// <param name="deliveryTimeframe">deliveryTimeframe.</param>
        /// <param name="giftCardAmount">giftCardAmount.</param>
        /// <param name="giftCardCount">giftCardCount.</param>
        /// <param name="giftCardCurr">giftCardCurr.</param>
        /// <param name="preOrderDate">preOrderDate.</param>
        /// <param name="preOrderPurchase">preOrderPurchase.</param>
        /// <param name="preOrderPurchaseInd">preOrderPurchaseInd.</param>
        /// <param name="reorderItems">reorderItems.</param>
        /// <param name="reorderItemsInd">reorderItemsInd.</param>
        /// <param name="shipIndicator">shipIndicator.</param>
        public MerchantRiskIndicator1(
            bool? addressMatch = null,
            Models.DeliveryAddressIndicatorEnum? deliveryAddressIndicator = null,
            string deliveryEmail = null,
            string deliveryEmailAddress = null,
            Models.DeliveryTimeframeEnum? deliveryTimeframe = null,
            Models.Amount8 giftCardAmount = null,
            int? giftCardCount = null,
            string giftCardCurr = null,
            DateTime? preOrderDate = null,
            bool? preOrderPurchase = null,
            string preOrderPurchaseInd = null,
            bool? reorderItems = null,
            string reorderItemsInd = null,
            string shipIndicator = null)
        {
            this.AddressMatch = addressMatch;
            this.DeliveryAddressIndicator = deliveryAddressIndicator;
            this.DeliveryEmail = deliveryEmail;
            this.DeliveryEmailAddress = deliveryEmailAddress;
            this.DeliveryTimeframe = deliveryTimeframe;
            this.GiftCardAmount = giftCardAmount;
            this.GiftCardCount = giftCardCount;
            this.GiftCardCurr = giftCardCurr;
            this.PreOrderDate = preOrderDate;
            this.PreOrderPurchase = preOrderPurchase;
            this.PreOrderPurchaseInd = preOrderPurchaseInd;
            this.ReorderItems = reorderItems;
            this.ReorderItemsInd = reorderItemsInd;
            this.ShipIndicator = shipIndicator;
        }

        /// <summary>
        /// Whether the chosen delivery address is identical to the billing address.
        /// </summary>
        [JsonProperty("addressMatch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddressMatch { get; set; }

        /// <summary>
        /// Indicator regarding the delivery address.
        /// Allowed values:
        /// * `shipToBillingAddress`
        /// * `shipToVerifiedAddress`
        /// * `shipToNewAddress`
        /// * `shipToStore`
        /// * `digitalGoods`
        /// * `goodsNotShipped`
        /// * `other`
        /// </summary>
        [JsonProperty("deliveryAddressIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryAddressIndicatorEnum? DeliveryAddressIndicator { get; set; }

        /// <summary>
        /// The delivery email address (for digital goods).
        /// </summary>
        [JsonProperty("deliveryEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// For Electronic delivery, the email address to which the merchandise was delivered. Maximum length: 254 characters.
        /// </summary>
        [JsonProperty("deliveryEmailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryEmailAddress { get; set; }

        /// <summary>
        /// The estimated delivery time for the shopper to receive the goods.
        /// Allowed values:
        /// * `electronicDelivery`
        /// * `sameDayShipping`
        /// * `overnightShipping`
        /// * `twoOrMoreDaysShipping`
        /// </summary>
        [JsonProperty("deliveryTimeframe", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeliveryTimeframeEnum? DeliveryTimeframe { get; set; }

        /// <summary>
        /// For prepaid or gift card purchase, the purchase amount total of prepaid or gift card(s).
        /// </summary>
        [JsonProperty("giftCardAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount8 GiftCardAmount { get; set; }

        /// <summary>
        /// For prepaid or gift card purchase, total count of individual prepaid or gift cards/codes purchased.
        /// </summary>
        [JsonProperty("giftCardCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? GiftCardCount { get; set; }

        /// <summary>
        /// For prepaid or gift card purchase, [ISO 4217](https://www.iso.org/iso-4217-currency-codes.html) three-digit currency code of the gift card, other than those listed in Table A.5 of the EMVCo 3D Secure Protocol and Core Functions Specification.
        /// </summary>
        [JsonProperty("giftCardCurr", NullValueHandling = NullValueHandling.Ignore)]
        public string GiftCardCurr { get; set; }

        /// <summary>
        /// For pre-order purchases, the expected date this product will be available to the shopper.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("preOrderDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PreOrderDate { get; set; }

        /// <summary>
        /// Indicator for whether this transaction is for pre-ordering a product.
        /// </summary>
        [JsonProperty("preOrderPurchase", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreOrderPurchase { get; set; }

        /// <summary>
        /// Indicates whether Cardholder is placing an order for merchandise with a future availability or release date.
        /// </summary>
        [JsonProperty("preOrderPurchaseInd", NullValueHandling = NullValueHandling.Ignore)]
        public string PreOrderPurchaseInd { get; set; }

        /// <summary>
        /// Indicator for whether the shopper has already purchased the same items in the past.
        /// </summary>
        [JsonProperty("reorderItems", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReorderItems { get; set; }

        /// <summary>
        /// Indicates whether the cardholder is reordering previously purchased merchandise.
        /// </summary>
        [JsonProperty("reorderItemsInd", NullValueHandling = NullValueHandling.Ignore)]
        public string ReorderItemsInd { get; set; }

        /// <summary>
        /// Indicates shipping method chosen for the transaction.
        /// </summary>
        [JsonProperty("shipIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public string ShipIndicator { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MerchantRiskIndicator1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is MerchantRiskIndicator1 other &&                ((this.AddressMatch == null && other.AddressMatch == null) || (this.AddressMatch?.Equals(other.AddressMatch) == true)) &&
                ((this.DeliveryAddressIndicator == null && other.DeliveryAddressIndicator == null) || (this.DeliveryAddressIndicator?.Equals(other.DeliveryAddressIndicator) == true)) &&
                ((this.DeliveryEmail == null && other.DeliveryEmail == null) || (this.DeliveryEmail?.Equals(other.DeliveryEmail) == true)) &&
                ((this.DeliveryEmailAddress == null && other.DeliveryEmailAddress == null) || (this.DeliveryEmailAddress?.Equals(other.DeliveryEmailAddress) == true)) &&
                ((this.DeliveryTimeframe == null && other.DeliveryTimeframe == null) || (this.DeliveryTimeframe?.Equals(other.DeliveryTimeframe) == true)) &&
                ((this.GiftCardAmount == null && other.GiftCardAmount == null) || (this.GiftCardAmount?.Equals(other.GiftCardAmount) == true)) &&
                ((this.GiftCardCount == null && other.GiftCardCount == null) || (this.GiftCardCount?.Equals(other.GiftCardCount) == true)) &&
                ((this.GiftCardCurr == null && other.GiftCardCurr == null) || (this.GiftCardCurr?.Equals(other.GiftCardCurr) == true)) &&
                ((this.PreOrderDate == null && other.PreOrderDate == null) || (this.PreOrderDate?.Equals(other.PreOrderDate) == true)) &&
                ((this.PreOrderPurchase == null && other.PreOrderPurchase == null) || (this.PreOrderPurchase?.Equals(other.PreOrderPurchase) == true)) &&
                ((this.PreOrderPurchaseInd == null && other.PreOrderPurchaseInd == null) || (this.PreOrderPurchaseInd?.Equals(other.PreOrderPurchaseInd) == true)) &&
                ((this.ReorderItems == null && other.ReorderItems == null) || (this.ReorderItems?.Equals(other.ReorderItems) == true)) &&
                ((this.ReorderItemsInd == null && other.ReorderItemsInd == null) || (this.ReorderItemsInd?.Equals(other.ReorderItemsInd) == true)) &&
                ((this.ShipIndicator == null && other.ShipIndicator == null) || (this.ShipIndicator?.Equals(other.ShipIndicator) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressMatch = {(this.AddressMatch == null ? "null" : this.AddressMatch.ToString())}");
            toStringOutput.Add($"this.DeliveryAddressIndicator = {(this.DeliveryAddressIndicator == null ? "null" : this.DeliveryAddressIndicator.ToString())}");
            toStringOutput.Add($"this.DeliveryEmail = {(this.DeliveryEmail == null ? "null" : this.DeliveryEmail)}");
            toStringOutput.Add($"this.DeliveryEmailAddress = {(this.DeliveryEmailAddress == null ? "null" : this.DeliveryEmailAddress)}");
            toStringOutput.Add($"this.DeliveryTimeframe = {(this.DeliveryTimeframe == null ? "null" : this.DeliveryTimeframe.ToString())}");
            toStringOutput.Add($"this.GiftCardAmount = {(this.GiftCardAmount == null ? "null" : this.GiftCardAmount.ToString())}");
            toStringOutput.Add($"this.GiftCardCount = {(this.GiftCardCount == null ? "null" : this.GiftCardCount.ToString())}");
            toStringOutput.Add($"this.GiftCardCurr = {(this.GiftCardCurr == null ? "null" : this.GiftCardCurr)}");
            toStringOutput.Add($"this.PreOrderDate = {(this.PreOrderDate == null ? "null" : this.PreOrderDate.ToString())}");
            toStringOutput.Add($"this.PreOrderPurchase = {(this.PreOrderPurchase == null ? "null" : this.PreOrderPurchase.ToString())}");
            toStringOutput.Add($"this.PreOrderPurchaseInd = {(this.PreOrderPurchaseInd == null ? "null" : this.PreOrderPurchaseInd)}");
            toStringOutput.Add($"this.ReorderItems = {(this.ReorderItems == null ? "null" : this.ReorderItems.ToString())}");
            toStringOutput.Add($"this.ReorderItemsInd = {(this.ReorderItemsInd == null ? "null" : this.ReorderItemsInd)}");
            toStringOutput.Add($"this.ShipIndicator = {(this.ShipIndicator == null ? "null" : this.ShipIndicator)}");
        }
    }
}