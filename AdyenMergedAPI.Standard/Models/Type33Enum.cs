// <copyright file="Type33Enum.cs" company="APIMatic">
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
    /// Type33Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type33Enum
    {
        /// <summary>
        /// Visacheckout.
        /// </summary>
        [EnumMember(Value = "visacheckout")]
        Visacheckout
    }
}