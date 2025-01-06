// <copyright file="Discount.cs" company="APIMatic">
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
    /// Discount.
    /// </summary>
    public class Discount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount"/> class.
        /// </summary>
        public Discount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discount"/> class.
        /// </summary>
        /// <param name="discountAmount">discountAmount.</param>
        /// <param name="discountPercentage">discountPercentage.</param>
        public Discount(
            double? discountAmount = null,
            double? discountPercentage = null)
        {
            this.DiscountAmount = discountAmount;
            this.DiscountPercentage = discountPercentage;
        }

        /// <summary>
        /// Only applicable if the discount charge is a fixed-amount discount.
        /// </summary>
        [JsonProperty("discountAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// Only applicable if the discount charge is a percentage discount
        /// </summary>
        [JsonProperty("discountPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? DiscountPercentage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Discount : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Discount other &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                (this.DiscountPercentage == null && other.DiscountPercentage == null ||
                 this.DiscountPercentage?.Equals(other.DiscountPercentage) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DiscountAmount = {(this.DiscountAmount == null ? "null" : this.DiscountAmount.ToString())}");
            toStringOutput.Add($"DiscountPercentage = {(this.DiscountPercentage == null ? "null" : this.DiscountPercentage.ToString())}");
        }
    }
}