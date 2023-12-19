// <copyright file="Channel3Enum.cs" company="APIMatic">
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
    /// Channel3Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Channel3Enum
    {
        /// <summary>
        /// IOS.
        /// </summary>
        [EnumMember(Value = "iOS")]
        IOS,

        /// <summary>
        /// Android.
        /// </summary>
        [EnumMember(Value = "Android")]
        Android,

        /// <summary>
        /// Web.
        /// </summary>
        [EnumMember(Value = "Web")]
        Web
    }
}