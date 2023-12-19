// <copyright file="DataOnlyEnum.cs" company="APIMatic">
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
    /// DataOnlyEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataOnlyEnum
    {
        /// <summary>
        /// False.
        /// </summary>
        [EnumMember(Value = "false")]
        False,

        /// <summary>
        /// True.
        /// </summary>
        [EnumMember(Value = "true")]
        True
    }
}