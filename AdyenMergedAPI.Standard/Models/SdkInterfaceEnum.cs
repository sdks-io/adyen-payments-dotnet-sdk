// <copyright file="SdkInterfaceEnum.cs" company="APIMatic">
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
    /// SdkInterfaceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SdkInterfaceEnum
    {
        /// <summary>
        /// Native.
        /// </summary>
        [EnumMember(Value = "native")]
        Native,

        /// <summary>
        /// Html.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,

        /// <summary>
        /// Both.
        /// </summary>
        [EnumMember(Value = "both")]
        Both
    }
}