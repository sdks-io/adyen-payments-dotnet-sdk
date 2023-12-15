// <copyright file="BillingAttemptsRuleEnum.cs" company="APIMatic">
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
    /// BillingAttemptsRuleEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BillingAttemptsRuleEnum
    {
        /// <summary>
        /// On.
        /// </summary>
        [EnumMember(Value = "on")]
        On,

        /// <summary>
        /// Before.
        /// </summary>
        [EnumMember(Value = "before")]
        Before,

        /// <summary>
        /// After.
        /// </summary>
        [EnumMember(Value = "after")]
        After
    }
}