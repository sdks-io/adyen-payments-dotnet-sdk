// <copyright file="ShopperInteractionEnum.cs" company="APIMatic">
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
    /// ShopperInteractionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShopperInteractionEnum
    {
        /// <summary>
        /// Ecommerce.
        /// </summary>
        [EnumMember(Value = "Ecommerce")]
        Ecommerce,

        /// <summary>
        /// ContAuth.
        /// </summary>
        [EnumMember(Value = "ContAuth")]
        ContAuth,

        /// <summary>
        /// Moto.
        /// </summary>
        [EnumMember(Value = "Moto")]
        Moto,

        /// <summary>
        /// POS.
        /// </summary>
        [EnumMember(Value = "POS")]
        POS
    }
}