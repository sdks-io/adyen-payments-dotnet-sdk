// <copyright file="Type11Enum.cs" company="APIMatic">
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
    /// Type11Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type11Enum
    {
        /// <summary>
        /// Sdk.
        /// </summary>
        [EnumMember(Value = "sdk")]
        Sdk,

        /// <summary>
        /// WechatpaySDK.
        /// </summary>
        [EnumMember(Value = "wechatpaySDK")]
        WechatpaySDK
    }
}