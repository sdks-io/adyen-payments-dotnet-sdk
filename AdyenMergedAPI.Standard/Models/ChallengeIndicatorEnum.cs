// <copyright file="ChallengeIndicatorEnum.cs" company="APIMatic">
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
    /// ChallengeIndicatorEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChallengeIndicatorEnum
    {
        /// <summary>
        /// NoPreference.
        /// </summary>
        [EnumMember(Value = "noPreference")]
        NoPreference,

        /// <summary>
        /// RequestNoChallenge.
        /// </summary>
        [EnumMember(Value = "requestNoChallenge")]
        RequestNoChallenge,

        /// <summary>
        /// RequestChallenge.
        /// </summary>
        [EnumMember(Value = "requestChallenge")]
        RequestChallenge,

        /// <summary>
        /// RequestChallengeAsMandate.
        /// </summary>
        [EnumMember(Value = "requestChallengeAsMandate")]
        RequestChallengeAsMandate
    }
}