// <copyright file="OverridesPricing.cs" company="APIMatic">
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
    /// OverridesPricing.
    /// </summary>
    public class OverridesPricing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverridesPricing"/> class.
        /// </summary>
        public OverridesPricing()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverridesPricing"/> class.
        /// </summary>
        /// <param name="discount">discount.</param>
        public OverridesPricing(
            Models.Discount discount = null)
        {
            this.Discount = discount;
        }

        /// <summary>
        /// Gets or sets Discount.
        /// </summary>
        [JsonProperty("discount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Discount Discount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OverridesPricing : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OverridesPricing other &&
                (this.Discount == null && other.Discount == null ||
                 this.Discount?.Equals(other.Discount) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
        }
    }
}