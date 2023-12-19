// <copyright file="FundingSource5Enum.cs" company="APIMatic">
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
    /// FundingSource5Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FundingSource5Enum
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "debit")]
        Debit
    }
}