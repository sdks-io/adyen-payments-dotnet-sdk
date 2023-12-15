// <copyright file="DirectoryResponseEnum.cs" company="APIMatic">
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
    /// DirectoryResponseEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectoryResponseEnum
    {
        /// <summary>
        /// A.
        /// </summary>
        [EnumMember(Value = "A")]
        A,

        /// <summary>
        /// C.
        /// </summary>
        [EnumMember(Value = "C")]
        C,

        /// <summary>
        /// D.
        /// </summary>
        [EnumMember(Value = "D")]
        D,

        /// <summary>
        /// I.
        /// </summary>
        [EnumMember(Value = "I")]
        I,

        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// R.
        /// </summary>
        [EnumMember(Value = "R")]
        R,

        /// <summary>
        /// U.
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// Y.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y
    }
}