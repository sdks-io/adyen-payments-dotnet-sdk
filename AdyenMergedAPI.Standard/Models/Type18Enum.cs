// <copyright file="Type18Enum.cs" company="APIMatic">
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
    /// Type18Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type18Enum
    {
        /// <summary>
        /// EcontextSeveneleven.
        /// </summary>
        [EnumMember(Value = "econtext_seveneleven")]
        EcontextSeveneleven,

        /// <summary>
        /// EcontextStores.
        /// </summary>
        [EnumMember(Value = "econtext_stores")]
        EcontextStores
    }
}