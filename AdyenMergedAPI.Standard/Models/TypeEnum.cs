// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Ach.
        /// </summary>
        [EnumMember(Value = "ach")]
        Ach,

        /// <summary>
        /// AchPlaid.
        /// </summary>
        [EnumMember(Value = "ach_plaid")]
        AchPlaid
    }
}