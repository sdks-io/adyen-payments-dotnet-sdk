// <copyright file="ContractEnum.cs" company="APIMatic">
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
    /// ContractEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContractEnum
    {
        /// <summary>
        /// ONECLICK.
        /// </summary>
        [EnumMember(Value = "ONECLICK")]
        ONECLICK,

        /// <summary>
        /// RECURRING.
        /// </summary>
        [EnumMember(Value = "RECURRING")]
        RECURRING,

        /// <summary>
        /// PAYOUT.
        /// </summary>
        [EnumMember(Value = "PAYOUT")]
        PAYOUT
    }
}