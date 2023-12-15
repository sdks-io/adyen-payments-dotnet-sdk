// <copyright file="IndustryUsageEnum.cs" company="APIMatic">
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
    /// IndustryUsageEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndustryUsageEnum
    {
        /// <summary>
        /// NoShow.
        /// </summary>
        [EnumMember(Value = "NoShow")]
        NoShow,

        /// <summary>
        /// DelayedCharge.
        /// </summary>
        [EnumMember(Value = "DelayedCharge")]
        DelayedCharge
    }
}