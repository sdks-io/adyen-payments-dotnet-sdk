// <copyright file="DeliveryAddressIndicatorEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// DeliveryAddressIndicatorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryAddressIndicatorEnum
    {
        /// <summary>
        /// ShipToBillingAddress.
        /// </summary>
        [EnumMember(Value = "shipToBillingAddress")]
        ShipToBillingAddress,

        /// <summary>
        /// ShipToVerifiedAddress.
        /// </summary>
        [EnumMember(Value = "shipToVerifiedAddress")]
        ShipToVerifiedAddress,

        /// <summary>
        /// ShipToNewAddress.
        /// </summary>
        [EnumMember(Value = "shipToNewAddress")]
        ShipToNewAddress,

        /// <summary>
        /// ShipToStore.
        /// </summary>
        [EnumMember(Value = "shipToStore")]
        ShipToStore,

        /// <summary>
        /// DigitalGoods.
        /// </summary>
        [EnumMember(Value = "digitalGoods")]
        DigitalGoods,

        /// <summary>
        /// GoodsNotShipped.
        /// </summary>
        [EnumMember(Value = "goodsNotShipped")]
        GoodsNotShipped,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}