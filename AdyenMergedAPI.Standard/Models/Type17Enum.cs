// <copyright file="Type17Enum.cs" company="APIMatic">
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
    /// Type17Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type17Enum
    {
        /// <summary>
        /// DragonpayEbanking.
        /// </summary>
        [EnumMember(Value = "dragonpay_ebanking")]
        DragonpayEbanking,

        /// <summary>
        /// DragonpayOtcBanking.
        /// </summary>
        [EnumMember(Value = "dragonpay_otc_banking")]
        DragonpayOtcBanking,

        /// <summary>
        /// DragonpayOtcNonBanking.
        /// </summary>
        [EnumMember(Value = "dragonpay_otc_non_banking")]
        DragonpayOtcNonBanking,

        /// <summary>
        /// DragonpayOtcPhilippines.
        /// </summary>
        [EnumMember(Value = "dragonpay_otc_philippines")]
        DragonpayOtcPhilippines
    }
}