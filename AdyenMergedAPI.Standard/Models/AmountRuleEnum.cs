// <copyright file="AmountRuleEnum.cs" company="APIMatic">
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
    /// AmountRuleEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AmountRuleEnum
    {
        /// <summary>
        /// Max.
        /// </summary>
        [EnumMember(Value = "max")]
        Max,

        /// <summary>
        /// Exact.
        /// </summary>
        [EnumMember(Value = "exact")]
        Exact
    }
}