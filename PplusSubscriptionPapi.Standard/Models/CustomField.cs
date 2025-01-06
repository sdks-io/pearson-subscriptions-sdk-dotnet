// <copyright file="CustomField.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PplusSubscriptionPapi.Standard;
using PplusSubscriptionPapi.Standard.Utilities;

namespace PplusSubscriptionPapi.Standard.Models
{
    /// <summary>
    /// CustomField.
    /// </summary>
    public class CustomField
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField"/> class.
        /// </summary>
        public CustomField()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        public CustomField(
            string name = null,
            string mValue = null)
        {
            this.Name = name;
            this.MValue = mValue;
        }

        /// <summary>
        /// Custom field name defined for future use
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Custom field value for future use.  paymentMethod__c is Payment Gateway PayPal or CyberSource or REDEMPTION; paymentToken__c is PayPal or CyberSource token.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomField : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomField other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.MValue == null && other.MValue == null ||
                 this.MValue?.Equals(other.MValue) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"MValue = {this.MValue ?? "null"}");
        }
    }
}