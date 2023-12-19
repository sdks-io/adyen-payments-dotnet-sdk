// <copyright file="Type36Enum.cs" company="APIMatic">
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
    /// Type36Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type36Enum
    {
        /// <summary>
        /// Zip.
        /// </summary>
        [EnumMember(Value = "zip")]
        Zip,

        /// <summary>
        /// ZipPos.
        /// </summary>
        [EnumMember(Value = "zip_pos")]
        ZipPos
    }
}