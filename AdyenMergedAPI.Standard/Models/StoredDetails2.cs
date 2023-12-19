// <copyright file="StoredDetails2.cs" company="APIMatic">
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
    /// StoredDetails2.
    /// </summary>
    public class StoredDetails2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredDetails2"/> class.
        /// </summary>
        public StoredDetails2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredDetails2"/> class.
        /// </summary>
        /// <param name="bank">bank.</param>
        /// <param name="card">card.</param>
        /// <param name="emailAddress">emailAddress.</param>
        public StoredDetails2(
            Models.BankAccount1 bank = null,
            Models.Card3 card = null,
            string emailAddress = null)
        {
            this.Bank = bank;
            this.Card = card;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// The stored bank account.
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccount1 Bank { get; set; }

        /// <summary>
        /// The stored card information.
        /// </summary>
        [JsonProperty("card", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Card3 Card { get; set; }

        /// <summary>
        /// The email associated with stored payment details.
        /// </summary>
        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoredDetails2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoredDetails2 other &&                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.Card == null && other.Card == null) || (this.Card?.Equals(other.Card) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank.ToString())}");
            toStringOutput.Add($"this.Card = {(this.Card == null ? "null" : this.Card.ToString())}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
        }
    }
}