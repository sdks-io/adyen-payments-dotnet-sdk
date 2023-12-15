// <copyright file="DeliveryTimeframeEnum.cs" company="APIMatic">
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
    /// DeliveryTimeframeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryTimeframeEnum
    {
        /// <summary>
        /// ElectronicDelivery.
        /// </summary>
        [EnumMember(Value = "electronicDelivery")]
        ElectronicDelivery,

        /// <summary>
        /// SameDayShipping.
        /// </summary>
        [EnumMember(Value = "sameDayShipping")]
        SameDayShipping,

        /// <summary>
        /// OvernightShipping.
        /// </summary>
        [EnumMember(Value = "overnightShipping")]
        OvernightShipping,

        /// <summary>
        /// TwoOrMoreDaysShipping.
        /// </summary>
        [EnumMember(Value = "twoOrMoreDaysShipping")]
        TwoOrMoreDaysShipping
    }
}