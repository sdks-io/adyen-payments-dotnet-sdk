// <copyright file="AttemptAuthenticationEnum.cs" company="APIMatic">
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
    /// AttemptAuthenticationEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttemptAuthenticationEnum
    {
        /// <summary>
        /// Always.
        /// </summary>
        [EnumMember(Value = "always")]
        Always,

        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never
    }
}