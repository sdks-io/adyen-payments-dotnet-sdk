// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "Live")]
        Live,

        /// <summary>
        /// Test.
        /// </summary>
        [EnumMember(Value = "Test")]
        Test,
    }
}
