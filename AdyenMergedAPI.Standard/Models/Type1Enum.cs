// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// AfterpayDefault.
        /// </summary>
        [EnumMember(Value = "afterpay_default")]
        AfterpayDefault,

        /// <summary>
        /// Afterpaytouch.
        /// </summary>
        [EnumMember(Value = "afterpaytouch")]
        Afterpaytouch,

        /// <summary>
        /// AfterpayB2b.
        /// </summary>
        [EnumMember(Value = "afterpay_b2b")]
        AfterpayB2b,

        /// <summary>
        /// Clearpay.
        /// </summary>
        [EnumMember(Value = "clearpay")]
        Clearpay
    }
}