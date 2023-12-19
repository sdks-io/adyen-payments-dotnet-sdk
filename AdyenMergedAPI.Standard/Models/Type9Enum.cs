// <copyright file="Type9Enum.cs" company="APIMatic">
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
    /// Type9Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type9Enum
    {
        /// <summary>
        /// Scheme.
        /// </summary>
        [EnumMember(Value = "scheme")]
        Scheme,

        /// <summary>
        /// NetworkToken.
        /// </summary>
        [EnumMember(Value = "networkToken")]
        NetworkToken,

        /// <summary>
        /// Card.
        /// </summary>
        [EnumMember(Value = "card")]
        Card
    }
}