// <copyright file="RequiredShopperFieldEnum.cs" company="APIMatic">
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
    /// RequiredShopperFieldEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequiredShopperFieldEnum
    {
        /// <summary>
        /// BillingAddress.
        /// </summary>
        [EnumMember(Value = "billingAddress")]
        BillingAddress,

        /// <summary>
        /// DeliveryAddress.
        /// </summary>
        [EnumMember(Value = "deliveryAddress")]
        DeliveryAddress,

        /// <summary>
        /// ShopperEmail.
        /// </summary>
        [EnumMember(Value = "shopperEmail")]
        ShopperEmail,

        /// <summary>
        /// ShopperName.
        /// </summary>
        [EnumMember(Value = "shopperName")]
        ShopperName,

        /// <summary>
        /// TelephoneNumber.
        /// </summary>
        [EnumMember(Value = "telephoneNumber")]
        TelephoneNumber
    }
}