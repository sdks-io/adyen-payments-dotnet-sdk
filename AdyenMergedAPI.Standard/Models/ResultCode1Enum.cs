// <copyright file="ResultCode1Enum.cs" company="APIMatic">
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
    /// ResultCode1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResultCode1Enum
    {
        /// <summary>
        /// AuthenticationFinished.
        /// </summary>
        [EnumMember(Value = "AuthenticationFinished")]
        AuthenticationFinished,

        /// <summary>
        /// AuthenticationNotRequired.
        /// </summary>
        [EnumMember(Value = "AuthenticationNotRequired")]
        AuthenticationNotRequired,

        /// <summary>
        /// Authorised.
        /// </summary>
        [EnumMember(Value = "Authorised")]
        Authorised,

        /// <summary>
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,

        /// <summary>
        /// ChallengeShopper.
        /// </summary>
        [EnumMember(Value = "ChallengeShopper")]
        ChallengeShopper,

        /// <summary>
        /// Error.
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// IdentifyShopper.
        /// </summary>
        [EnumMember(Value = "IdentifyShopper")]
        IdentifyShopper,

        /// <summary>
        /// PartiallyAuthorised.
        /// </summary>
        [EnumMember(Value = "PartiallyAuthorised")]
        PartiallyAuthorised,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// PresentToShopper.
        /// </summary>
        [EnumMember(Value = "PresentToShopper")]
        PresentToShopper,

        /// <summary>
        /// Received.
        /// </summary>
        [EnumMember(Value = "Received")]
        Received,

        /// <summary>
        /// RedirectShopper.
        /// </summary>
        [EnumMember(Value = "RedirectShopper")]
        RedirectShopper,

        /// <summary>
        /// Refused.
        /// </summary>
        [EnumMember(Value = "Refused")]
        Refused,

        /// <summary>
        /// Success.
        /// </summary>
        [EnumMember(Value = "Success")]
        Success
    }
}