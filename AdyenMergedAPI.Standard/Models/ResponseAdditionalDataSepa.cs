// <copyright file="ResponseAdditionalDataSepa.cs" company="APIMatic">
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
    /// ResponseAdditionalDataSepa.
    /// </summary>
    public class ResponseAdditionalDataSepa
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataSepa"/> class.
        /// </summary>
        public ResponseAdditionalDataSepa()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataSepa"/> class.
        /// </summary>
        /// <param name="sepadirectdebitDateOfSignature">sepadirectdebit.dateOfSignature.</param>
        /// <param name="sepadirectdebitMandateId">sepadirectdebit.mandateId.</param>
        /// <param name="sepadirectdebitSequenceType">sepadirectdebit.sequenceType.</param>
        public ResponseAdditionalDataSepa(
            string sepadirectdebitDateOfSignature = null,
            string sepadirectdebitMandateId = null,
            string sepadirectdebitSequenceType = null)
        {
            this.SepadirectdebitDateOfSignature = sepadirectdebitDateOfSignature;
            this.SepadirectdebitMandateId = sepadirectdebitMandateId;
            this.SepadirectdebitSequenceType = sepadirectdebitSequenceType;
        }

        /// <summary>
        /// The transaction signature date.
        /// Format: yyyy-MM-dd
        /// </summary>
        [JsonProperty("sepadirectdebit.dateOfSignature", NullValueHandling = NullValueHandling.Ignore)]
        public string SepadirectdebitDateOfSignature { get; set; }

        /// <summary>
        /// Its value corresponds to the pspReference value of the transaction.
        /// </summary>
        [JsonProperty("sepadirectdebit.mandateId", NullValueHandling = NullValueHandling.Ignore)]
        public string SepadirectdebitMandateId { get; set; }

        /// <summary>
        /// This field can take one of the following values:
        /// * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.
        /// * First: (FRST) Initial/first collection in a series of direct debit instructions.
        /// * Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor.
        /// * Final: (FNAL) Last/final collection in a series of direct debit instructions.
        /// Example: OOFF
        /// </summary>
        [JsonProperty("sepadirectdebit.sequenceType", NullValueHandling = NullValueHandling.Ignore)]
        public string SepadirectdebitSequenceType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResponseAdditionalDataSepa : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResponseAdditionalDataSepa other &&                ((this.SepadirectdebitDateOfSignature == null && other.SepadirectdebitDateOfSignature == null) || (this.SepadirectdebitDateOfSignature?.Equals(other.SepadirectdebitDateOfSignature) == true)) &&
                ((this.SepadirectdebitMandateId == null && other.SepadirectdebitMandateId == null) || (this.SepadirectdebitMandateId?.Equals(other.SepadirectdebitMandateId) == true)) &&
                ((this.SepadirectdebitSequenceType == null && other.SepadirectdebitSequenceType == null) || (this.SepadirectdebitSequenceType?.Equals(other.SepadirectdebitSequenceType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SepadirectdebitDateOfSignature = {(this.SepadirectdebitDateOfSignature == null ? "null" : this.SepadirectdebitDateOfSignature)}");
            toStringOutput.Add($"this.SepadirectdebitMandateId = {(this.SepadirectdebitMandateId == null ? "null" : this.SepadirectdebitMandateId)}");
            toStringOutput.Add($"this.SepadirectdebitSequenceType = {(this.SepadirectdebitSequenceType == null ? "null" : this.SepadirectdebitSequenceType)}");
        }
    }
}