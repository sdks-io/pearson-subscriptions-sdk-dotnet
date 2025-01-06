// <copyright file="RatePlanPricing.cs" company="APIMatic">
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
    /// RatePlanPricing.
    /// </summary>
    public class RatePlanPricing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatePlanPricing"/> class.
        /// </summary>
        public RatePlanPricing()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatePlanPricing"/> class.
        /// </summary>
        /// <param name="discount">discount.</param>
        /// <param name="recurringFlatFee">recurringFlatFee.</param>
        public RatePlanPricing(
            Models.Discount discount = null,
            Models.RecurringFlatFee recurringFlatFee = null)
        {
            this.Discount = discount;
            this.RecurringFlatFee = recurringFlatFee;
        }

        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets RecurringFlatFee.
        /// </summary>
        [JsonProperty("recurringFlatFee", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RecurringFlatFee RecurringFlatFee { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RatePlanPricing : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RatePlanPricing other &&
                (this.Discount == null && other.Discount == null ||
                 this.Discount?.Equals(other.Discount) == true) &&
                (this.RecurringFlatFee == null && other.RecurringFlatFee == null ||
                 this.RecurringFlatFee?.Equals(other.RecurringFlatFee) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
            toStringOutput.Add($"RecurringFlatFee = {(this.RecurringFlatFee == null ? "null" : this.RecurringFlatFee.ToString())}");
        }
    }
}