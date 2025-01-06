// <copyright file="OrderRequestProcessingOptions.cs" company="APIMatic">
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
    /// OrderRequestProcessingOptions.
    /// </summary>
    public class OrderRequestProcessingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestProcessingOptions"/> class.
        /// </summary>
        public OrderRequestProcessingOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestProcessingOptions"/> class.
        /// </summary>
        /// <param name="runBilling">runBilling.</param>
        /// <param name="billingOptions">billingOptions.</param>
        /// <param name="collectPayment">collectPayment.</param>
        public OrderRequestProcessingOptions(
            bool? runBilling = null,
            Models.BillingOptions billingOptions = null,
            bool? collectPayment = null)
        {
            this.RunBilling = runBilling;
            this.BillingOptions = billingOptions;
            this.CollectPayment = collectPayment;
        }

        /// <summary>
        /// Indicates if the current request needs to generate an invoice. The invoice will be generated against all subscriptions included in this order. For REDEMPTION, default it to true.
        /// </summary>
        [JsonProperty("runBilling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunBilling { get; set; }

        /// <summary>
        /// Gets or sets BillingOptions.
        /// </summary>
        [JsonProperty("billingOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingOptions BillingOptions { get; set; }

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
            return $"OrderRequestProcessingOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderRequestProcessingOptions other &&
                (this.RunBilling == null && other.RunBilling == null ||
                 this.RunBilling?.Equals(other.RunBilling) == true) &&
                (this.BillingOptions == null && other.BillingOptions == null ||
                 this.BillingOptions?.Equals(other.BillingOptions) == true) &&
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
            toStringOutput.Add($"BillingOptions = {(this.BillingOptions == null ? "null" : this.BillingOptions.ToString())}");
            toStringOutput.Add($"CollectPayment = {(this.CollectPayment == null ? "null" : this.CollectPayment.ToString())}");
        }
    }
}