// <copyright file="DeliveryAddressUsageIndicatorEnum.cs" company="APIMatic">
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
    /// DeliveryAddressUsageIndicatorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryAddressUsageIndicatorEnum
    {
        /// <summary>
        /// ThisTransaction.
        /// </summary>
        [EnumMember(Value = "thisTransaction")]
        ThisTransaction,

        /// <summary>
        /// LessThan30Days.
        /// </summary>
        [EnumMember(Value = "lessThan30Days")]
        LessThan30Days,

        /// <summary>
        /// From30To60Days.
        /// </summary>
        [EnumMember(Value = "from30To60Days")]
        From30To60Days,

        /// <summary>
        /// MoreThan60Days.
        /// </summary>
        [EnumMember(Value = "moreThan60Days")]
        MoreThan60Days
    }
}