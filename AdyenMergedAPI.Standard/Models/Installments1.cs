// <copyright file="Installments1.cs" company="APIMatic">
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
    /// Installments1.
    /// </summary>
    public class Installments1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Installments1"/> class.
        /// </summary>
        public Installments1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Installments1"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="plan">plan.</param>
        public Installments1(
            int mValue,
            Models.PlanEnum? plan = null)
        {
            this.Plan = plan;
            this.MValue = mValue;
        }

        /// <summary>
        /// The installment plan, used for [card installments in Japan](https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan). By default, this is set to **regular**. Possible values:
        /// * **regular**
        /// * **revolving**
        /// </summary>
        [JsonProperty("plan", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PlanEnum? Plan { get; set; }

        /// <summary>
        /// Defines the number of installments. Its value needs to be greater than zero.
        /// Usually, the maximum allowed number of installments is capped. For example, it may not be possible to split a payment in more than 24 installments. The acquirer sets this upper limit, so its value may vary.
        /// </summary>
        [JsonProperty("value")]
        public int MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Installments1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Installments1 other &&                ((this.Plan == null && other.Plan == null) || (this.Plan?.Equals(other.Plan) == true)) &&
                this.MValue.Equals(other.MValue);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Plan = {(this.Plan == null ? "null" : this.Plan.ToString())}");
            toStringOutput.Add($"this.MValue = {this.MValue}");
        }
    }
}