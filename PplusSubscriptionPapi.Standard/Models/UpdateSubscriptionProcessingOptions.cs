// <copyright file="UpdateSubscriptionProcessingOptions.cs" company="APIMatic">
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
    /// UpdateSubscriptionProcessingOptions.
    /// </summary>
    public class UpdateSubscriptionProcessingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionProcessingOptions"/> class.
        /// </summary>
        public UpdateSubscriptionProcessingOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionProcessingOptions"/> class.
        /// </summary>
        /// <param name="runBilling">runBilling.</param>
        /// <param name="collectPayment">collectPayment.</param>
        public UpdateSubscriptionProcessingOptions(
            bool? runBilling = null,
            bool? collectPayment = null)
        {
            this.RunBilling = runBilling;
            this.CollectPayment = collectPayment;
        }

        /// <summary>
        /// Indicates if the current request needs to generate an invoice. The invoice will be generated against all subscriptions included in this order.
        /// </summary>
        [JsonProperty("runBilling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunBilling { get; set; }

        /// <summary>
        /// Indicates if the current request needs to collect payments. This value can not be 'true' when 'runBilling' flag is 'false'.
        /// </summary>
        [JsonProperty("collectPayment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CollectPayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionProcessingOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionProcessingOptions other &&
                (this.RunBilling == null && other.RunBilling == null ||
                 this.RunBilling?.Equals(other.RunBilling) == true) &&
                (this.CollectPayment == null && other.CollectPayment == null ||
                 this.CollectPayment?.Equals(other.CollectPayment) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RunBilling = {(this.RunBilling == null ? "null" : this.RunBilling.ToString())}");
            toStringOutput.Add($"CollectPayment = {(this.CollectPayment == null ? "null" : this.CollectPayment.ToString())}");
        }
    }
}