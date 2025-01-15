// <copyright file="RecurringFlatFee.cs" company="APIMatic">
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
using PearsonSubscriptionsAPI.Standard;
using PearsonSubscriptionsAPI.Standard.Utilities;

namespace PearsonSubscriptionsAPI.Standard.Models
{
    /// <summary>
    /// RecurringFlatFee.
    /// </summary>
    public class RecurringFlatFee
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringFlatFee"/> class.
        /// </summary>
        public RecurringFlatFee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurringFlatFee"/> class.
        /// </summary>
        /// <param name="listPrice">listPrice.</param>
        public RecurringFlatFee(
            double? listPrice = null)
        {
            this.ListPrice = listPrice;
        }

        /// <summary>
        /// Only applicable for REDEMPTION to pass another price in addition to product price.
        /// </summary>
        [JsonProperty("listPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? ListPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RecurringFlatFee : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RecurringFlatFee other &&
                (this.ListPrice == null && other.ListPrice == null ||
                 this.ListPrice?.Equals(other.ListPrice) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ListPrice = {(this.ListPrice == null ? "null" : this.ListPrice.ToString())}");
        }
    }
}