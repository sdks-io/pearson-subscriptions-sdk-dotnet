// <copyright file="AddProduct.cs" company="APIMatic">
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
    /// AddProduct.
    /// </summary>
    public class AddProduct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddProduct"/> class.
        /// </summary>
        public AddProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProduct"/> class.
        /// </summary>
        /// <param name="productRatePlanId">productRatePlanId.</param>
        /// <param name="updateOrAddProductChargeOverrides">updateOrAddProductChargeOverrides.</param>
        public AddProduct(
            string productRatePlanId = null,
            List<Models.UpdateOrAddProductChargeOverride> updateOrAddProductChargeOverrides = null)
        {
            this.ProductRatePlanId = productRatePlanId;
            this.UpdateOrAddProductChargeOverrides = updateOrAddProductChargeOverrides;
        }

        /// <summary>
        /// Internal identifier of the product rate plan that the rate plan is based on.
        /// </summary>
        [JsonProperty("productRatePlanId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRatePlanId { get; set; }

        /// <summary>
        /// Gets or sets UpdateOrAddProductChargeOverrides.
        /// </summary>
        [JsonProperty("updateOrAddProductChargeOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateOrAddProductChargeOverride> UpdateOrAddProductChargeOverrides { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddProduct : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddProduct other &&
                (this.ProductRatePlanId == null && other.ProductRatePlanId == null ||
                 this.ProductRatePlanId?.Equals(other.ProductRatePlanId) == true) &&
                (this.UpdateOrAddProductChargeOverrides == null && other.UpdateOrAddProductChargeOverrides == null ||
                 this.UpdateOrAddProductChargeOverrides?.Equals(other.UpdateOrAddProductChargeOverrides) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductRatePlanId = {this.ProductRatePlanId ?? "null"}");
            toStringOutput.Add($"UpdateOrAddProductChargeOverrides = {(this.UpdateOrAddProductChargeOverrides == null ? "null" : $"[{string.Join(", ", this.UpdateOrAddProductChargeOverrides)} ]")}");
        }
    }
}