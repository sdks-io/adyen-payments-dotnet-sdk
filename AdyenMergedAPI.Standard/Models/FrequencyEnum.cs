// <copyright file="FrequencyEnum.cs" company="APIMatic">
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
    /// FrequencyEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyEnum
    {
        /// <summary>
        /// Adhoc.
        /// </summary>
        [EnumMember(Value = "adhoc")]
        Adhoc,

        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily,

        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,

        /// <summary>
        /// BiWeekly.
        /// </summary>
        [EnumMember(Value = "biWeekly")]
        BiWeekly,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,

        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,

        /// <summary>
        /// HalfYearly.
        /// </summary>
        [EnumMember(Value = "halfYearly")]
        HalfYearly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly
    }
}