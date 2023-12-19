// <copyright file="ResultCodeEnum.cs" company="APIMatic">
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
    /// ResultCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultCodeEnum
    {
        /// <summary>
        /// Success.
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// NotEnoughBalance.
        /// </summary>
        [EnumMember(Value = "NotEnoughBalance")]
        NotEnoughBalance,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
}