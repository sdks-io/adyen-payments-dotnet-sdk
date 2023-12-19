// <copyright file="Type16Enum.cs" company="APIMatic">
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
    /// Type16Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type16Enum
    {
        /// <summary>
        /// Dotpay.
        /// </summary>
        [EnumMember(Value = "dotpay")]
        Dotpay
    }
}