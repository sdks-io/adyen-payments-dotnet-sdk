// <copyright file="TokenServiceEnum.cs" company="APIMatic">
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
    /// TokenServiceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenServiceEnum
    {
        /// <summary>
        /// VISATOKENSERVICE.
        /// </summary>
        [EnumMember(Value = "VISATOKENSERVICE")]
        VISATOKENSERVICE,

        /// <summary>
        /// MCTOKENSERVICE.
        /// </summary>
        [EnumMember(Value = "MCTOKENSERVICE")]
        MCTOKENSERVICE,

        /// <summary>
        /// AMEXTOKENSERVICE.
        /// </summary>
        [EnumMember(Value = "AMEXTOKENSERVICE")]
        AMEXTOKENSERVICE,

        /// <summary>
        /// TOKENSHARING.
        /// </summary>
        [EnumMember(Value = "TOKEN_SHARING")]
        TOKENSHARING
    }
}