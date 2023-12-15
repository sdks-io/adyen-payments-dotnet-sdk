// <copyright file="BehaviorEnum.cs" company="APIMatic">
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
    /// BehaviorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BehaviorEnum
    {
        /// <summary>
        /// DeductAccordingToSplitRatio.
        /// </summary>
        [EnumMember(Value = "deductAccordingToSplitRatio")]
        DeductAccordingToSplitRatio,

        /// <summary>
        /// DeductFromLiableAccount.
        /// </summary>
        [EnumMember(Value = "deductFromLiableAccount")]
        DeductFromLiableAccount,

        /// <summary>
        /// DeductFromOneBalanceAccount.
        /// </summary>
        [EnumMember(Value = "deductFromOneBalanceAccount")]
        DeductFromOneBalanceAccount
    }
}