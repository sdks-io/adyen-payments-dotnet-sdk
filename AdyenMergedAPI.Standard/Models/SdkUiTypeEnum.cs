// <copyright file="SdkUiTypeEnum.cs" company="APIMatic">
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
    /// SdkUiTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SdkUiTypeEnum
    {
        /// <summary>
        /// MultiSelect.
        /// </summary>
        [EnumMember(Value = "multiSelect")]
        MultiSelect,

        /// <summary>
        /// OtherHtml.
        /// </summary>
        [EnumMember(Value = "otherHtml")]
        OtherHtml,

        /// <summary>
        /// OutOfBand.
        /// </summary>
        [EnumMember(Value = "outOfBand")]
        OutOfBand,

        /// <summary>
        /// SingleSelect.
        /// </summary>
        [EnumMember(Value = "singleSelect")]
        SingleSelect,

        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text
    }
}