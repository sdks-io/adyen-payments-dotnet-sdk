// <copyright file="Type34Enum.cs" company="APIMatic">
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
    /// Type34Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type34Enum
    {
        /// <summary>
        /// Wechatpay.
        /// </summary>
        [EnumMember(Value = "wechatpay")]
        Wechatpay,

        /// <summary>
        /// WechatpayPos.
        /// </summary>
        [EnumMember(Value = "wechatpay_pos")]
        WechatpayPos
    }
}