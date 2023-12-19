// <copyright file="Plan1Enum.cs" company="APIMatic">
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
    /// Plan1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Plan1Enum
    {
        /// <summary>
        /// Regular.
        /// </summary>
        [EnumMember(Value = "regular")]
        Regular,

        /// <summary>
        /// Revolving.
        /// </summary>
        [EnumMember(Value = "revolving")]
        Revolving
    }
}