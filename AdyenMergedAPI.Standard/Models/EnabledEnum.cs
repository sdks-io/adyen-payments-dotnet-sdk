// <copyright file="EnabledEnum.cs" company="APIMatic">
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
    /// EnabledEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnabledEnum
    {
        /// <summary>
        /// Yes.
        /// </summary>
        [EnumMember(Value = "yes")]
        Yes,

        /// <summary>
        /// No.
        /// </summary>
        [EnumMember(Value = "no")]
        No,

        /// <summary>
        /// Automatic.
        /// </summary>
        [EnumMember(Value = "automatic")]
        Automatic
    }
}