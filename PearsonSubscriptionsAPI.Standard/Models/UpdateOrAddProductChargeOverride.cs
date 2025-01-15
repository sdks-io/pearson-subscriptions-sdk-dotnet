// <copyright file="UpdateOrAddProductChargeOverride.cs" company="APIMatic">
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
    /// UpdateOrAddProductChargeOverride.
    /// </summary>
    public class UpdateOrAddProductChargeOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrAddProductChargeOverride"/> class.
        /// </summary>
        public UpdateOrAddProductChargeOverride()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrAddProductChargeOverride"/> class.
        /// </summary>
        /// <param name="productRatePlanChargeId">productRatePlanChargeId.</param>
        /// <param name="customerFacingCustomFields">customerFacingCustomFields.</param>
        /// <param name="overridesPricing">overridesPricing.</param>
        /// <param name="addProductEndDate">addProductEndDate.</param>
        public UpdateOrAddProductChargeOverride(
            string productRatePlanChargeId = null,
            Models.CustomerFacingCustomFields customerFacingCustomFields = null,
            Models.OverridesPricing overridesPricing = null,
            Models.AddProductEndDate addProductEndDate = null)
        {
            this.ProductRatePlanChargeId = productRatePlanChargeId;
            this.CustomerFacingCustomFields = customerFacingCustomFields;
            this.OverridesPricing = overridesPricing;
            this.AddProductEndDate = addProductEndDate;
        }

        /// <summary>
        /// This is unique rate plan charge id respective to rate plan id. It signifies the subscription type,entitlementLevel,maxEntitlements,numEntitlements etc.
        /// </summary>
        [JsonProperty("productRatePlanChargeId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRatePlanChargeId { get; set; }

        /// <summary>
        /// Gets or sets CustomerFacingCustomFields.
        /// </summary>
        [JsonProperty("customerFacingCustomFields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerFacingCustomFields CustomerFacingCustomFields { get; set; }

        /// <summary>
        /// Gets or sets OverridesPricing.
        /// </summary>
        [JsonProperty("overridesPricing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OverridesPricing OverridesPricing { get; set; }

        /// <summary>
        /// Gets or sets AddProductEndDate.
        /// </summary>
        [JsonProperty("addProductEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddProductEndDate AddProductEndDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateOrAddProductChargeOverride : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateOrAddProductChargeOverride other &&
                (this.ProductRatePlanChargeId == null && other.ProductRatePlanChargeId == null ||
                 this.ProductRatePlanChargeId?.Equals(other.ProductRatePlanChargeId) == true) &&
                (this.CustomerFacingCustomFields == null && other.CustomerFacingCustomFields == null ||
                 this.CustomerFacingCustomFields?.Equals(other.CustomerFacingCustomFields) == true) &&
                (this.OverridesPricing == null && other.OverridesPricing == null ||
                 this.OverridesPricing?.Equals(other.OverridesPricing) == true) &&
                (this.AddProductEndDate == null && other.AddProductEndDate == null ||
                 this.AddProductEndDate?.Equals(other.AddProductEndDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductRatePlanChargeId = {this.ProductRatePlanChargeId ?? "null"}");
            toStringOutput.Add($"CustomerFacingCustomFields = {(this.CustomerFacingCustomFields == null ? "null" : this.CustomerFacingCustomFields.ToString())}");
            toStringOutput.Add($"OverridesPricing = {(this.OverridesPricing == null ? "null" : this.OverridesPricing.ToString())}");
            toStringOutput.Add($"AddProductEndDate = {(this.AddProductEndDate == null ? "null" : this.AddProductEndDate.ToString())}");
        }
    }
}