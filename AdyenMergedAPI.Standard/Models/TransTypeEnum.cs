// <copyright file="TransTypeEnum.cs" company="APIMatic">
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
    /// TransTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransTypeEnum
    {
        /// <summary>
        /// Enum01.
        /// </summary>
        [EnumMember(Value = "01")]
        Enum01,

        /// <summary>
        /// Enum03.
        /// </summary>
        [EnumMember(Value = "03")]
        Enum03,

        /// <summary>
        /// Enum10.
        /// </summary>
        [EnumMember(Value = "10")]
        Enum10,

        /// <summary>
        /// Enum11.
        /// </summary>
        [EnumMember(Value = "11")]
        Enum11,

        /// <summary>
        /// Enum28.
        /// </summary>
        [EnumMember(Value = "28")]
        Enum28
    }
}