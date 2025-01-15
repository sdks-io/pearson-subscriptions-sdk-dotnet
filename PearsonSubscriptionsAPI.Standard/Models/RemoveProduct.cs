// <copyright file="RemoveProduct.cs" company="APIMatic">
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
    /// RemoveProduct.
    /// </summary>
    public class RemoveProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProduct"/> class.
        /// </summary>
        public RemoveProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveProduct"/> class.
        /// </summary>
        /// <param name="productRatePlanId">productRatePlanId.</param>
        public RemoveProduct(
            string productRatePlanId = null)
        {
            this.ProductRatePlanId = productRatePlanId;
        }

        /// <summary>
        /// Internal identifier of the product rate plan that the rate plan is based on.
        /// </summary>
        [JsonProperty("productRatePlanId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRatePlanId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RemoveProduct : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RemoveProduct other &&
                (this.ProductRatePlanId == null && other.ProductRatePlanId == null ||
                 this.ProductRatePlanId?.Equals(other.ProductRatePlanId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductRatePlanId = {this.ProductRatePlanId ?? "null"}");
        }
    }
}