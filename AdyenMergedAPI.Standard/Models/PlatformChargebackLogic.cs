// <copyright file="PlatformChargebackLogic.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdyenMergedAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdyenMergedAPI.Standard;
    using AdyenMergedAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// PlatformChargebackLogic.
    /// </summary>
    public class PlatformChargebackLogic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformChargebackLogic"/> class.
        /// </summary>
        public PlatformChargebackLogic()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformChargebackLogic"/> class.
        /// </summary>
        /// <param name="behavior">behavior.</param>
        /// <param name="costAllocationAccount">costAllocationAccount.</param>
        /// <param name="targetAccount">targetAccount.</param>
        public PlatformChargebackLogic(
            Models.BehaviorEnum? behavior = null,
            string costAllocationAccount = null,
            string targetAccount = null)
        {
            this.Behavior = behavior;
            this.CostAllocationAccount = costAllocationAccount;
            this.TargetAccount = targetAccount;
        }

        /// <summary>
        /// The method of handling the chargeback.
        /// Possible values: **deductFromLiableAccount**, **deductFromOneBalanceAccount**, **deductAccordingToSplitRatio**.
        /// </summary>
        [JsonProperty("behavior", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BehaviorEnum? Behavior { get; set; }

        /// <summary>
        /// The unique identifier of the balance account to which the chargeback fees are booked. By default, the chargeback fees are booked to your liable balance account.
        /// </summary>
        [JsonProperty("costAllocationAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string CostAllocationAccount { get; set; }

        /// <summary>
        /// The unique identifier of the balance account against which the disputed amount is booked.
        /// Required if `behavior` is **deductFromOneBalanceAccount**.
        /// </summary>
        [JsonProperty("targetAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetAccount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PlatformChargebackLogic : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PlatformChargebackLogic other &&                ((this.Behavior == null && other.Behavior == null) || (this.Behavior?.Equals(other.Behavior) == true)) &&
                ((this.CostAllocationAccount == null && other.CostAllocationAccount == null) || (this.CostAllocationAccount?.Equals(other.CostAllocationAccount) == true)) &&
                ((this.TargetAccount == null && other.TargetAccount == null) || (this.TargetAccount?.Equals(other.TargetAccount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Behavior = {(this.Behavior == null ? "null" : this.Behavior.ToString())}");
            toStringOutput.Add($"this.CostAllocationAccount = {(this.CostAllocationAccount == null ? "null" : this.CostAllocationAccount)}");
            toStringOutput.Add($"this.TargetAccount = {(this.TargetAccount == null ? "null" : this.TargetAccount)}");
        }
    }
}