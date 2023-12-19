// <copyright file="ThreeDSVersionEnum.cs" company="APIMatic">
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
    /// ThreeDSVersionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDSVersionEnum
    {
        /// <summary>
        /// Enum210.
        /// </summary>
        [EnumMember(Value = "2.1.0")]
        Enum210,

        /// <summary>
        /// Enum220.
        /// </summary>
        [EnumMember(Value = "2.2.0")]
        Enum220
    }
}