// <copyright file="PersonalDetailsEnum.cs" company="APIMatic">
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
    /// PersonalDetailsEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonalDetailsEnum
    {
        /// <summary>
        /// Editable.
        /// </summary>
        [EnumMember(Value = "editable")]
        Editable,

        /// <summary>
        /// Hidden.
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden,

        /// <summary>
        /// ReadOnly.
        /// </summary>
        [EnumMember(Value = "readOnly")]
        ReadOnly
    }
}