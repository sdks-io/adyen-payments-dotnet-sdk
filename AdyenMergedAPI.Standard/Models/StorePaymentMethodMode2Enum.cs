// <copyright file="StorePaymentMethodMode2Enum.cs" company="APIMatic">
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
    /// StorePaymentMethodMode2Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorePaymentMethodMode2Enum
    {
        /// <summary>
        /// AskForConsent.
        /// </summary>
        [EnumMember(Value = "askForConsent")]
        AskForConsent,

        /// <summary>
        /// Disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,

        /// <summary>
        /// Enabled.
        /// </summary>
        [EnumMember(Value = "enabled")]
        Enabled
    }
}