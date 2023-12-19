// <copyright file="Type4Enum.cs" company="APIMatic">
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
    /// Type4Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type4Enum
    {
        /// <summary>
        /// Applepay.
        /// </summary>
        [EnumMember(Value = "applepay")]
        Applepay
    }
}