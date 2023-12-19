// <copyright file="IndustryUsage1Enum.cs" company="APIMatic">
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
    /// IndustryUsage1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndustryUsage1Enum
    {
        /// <summary>
        /// DelayedCharge.
        /// </summary>
        [EnumMember(Value = "delayedCharge")]
        DelayedCharge,

        /// <summary>
        /// Installment.
        /// </summary>
        [EnumMember(Value = "installment")]
        Installment,

        /// <summary>
        /// NoShow.
        /// </summary>
        [EnumMember(Value = "noShow")]
        NoShow
    }
}