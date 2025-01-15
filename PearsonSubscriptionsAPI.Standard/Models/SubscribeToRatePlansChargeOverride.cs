// <copyright file="SubscribeToRatePlansChargeOverride.cs" company="APIMatic">
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
    /// SubscribeToRatePlansChargeOverride.
    /// </summary>
    public class SubscribeToRatePlansChargeOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToRatePlansChargeOverride"/> class.
        /// </summary>
        public SubscribeToRatePlansChargeOverride()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToRatePlansChargeOverride"/> class.
        /// </summary>
        /// <param name="productRatePlanChargeId">productRatePlanChargeId.</param>
        /// <param name="customerFacingCustomFields">customerFacingCustomFields.</param>
        /// <param name="ratePlanPricing">ratePlanPricing.</param>
        /// <param name="ratePlanEndDate">ratePlanEndDate.</param>
        public SubscribeToRatePlansChargeOverride(
            string productRatePlanChargeId = null,
            Models.CustomerFacingCustomFields customerFacingCustomFields = null,
            Models.RatePlanPricing ratePlanPricing = null,
            Models.RatePlanEndDate ratePlanEndDate = null)
        {
            this.ProductRatePlanChargeId = productRatePlanChargeId;
            this.CustomerFacingCustomFields = customerFacingCustomFields;
            this.RatePlanPricing = ratePlanPricing;
            this.RatePlanEndDate = ratePlanEndDate;
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
        /// Gets or sets RatePlanPricing.
        /// </summary>
        [JsonProperty("ratePlanPricing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RatePlanPricing RatePlanPricing { get; set; }

        /// <summary>
        /// Gets or sets RatePlanEndDate.
        /// </summary>
        [JsonProperty("ratePlanEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RatePlanEndDate RatePlanEndDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscribeToRatePlansChargeOverride : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscribeToRatePlansChargeOverride other &&
                (this.ProductRatePlanChargeId == null && other.ProductRatePlanChargeId == null ||
                 this.ProductRatePlanChargeId?.Equals(other.ProductRatePlanChargeId) == true) &&
                (this.CustomerFacingCustomFields == null && other.CustomerFacingCustomFields == null ||
                 this.CustomerFacingCustomFields?.Equals(other.CustomerFacingCustomFields) == true) &&
                (this.RatePlanPricing == null && other.RatePlanPricing == null ||
                 this.RatePlanPricing?.Equals(other.RatePlanPricing) == true) &&
                (this.RatePlanEndDate == null && other.RatePlanEndDate == null ||
                 this.RatePlanEndDate?.Equals(other.RatePlanEndDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductRatePlanChargeId = {this.ProductRatePlanChargeId ?? "null"}");
            toStringOutput.Add($"CustomerFacingCustomFields = {(this.CustomerFacingCustomFields == null ? "null" : this.CustomerFacingCustomFields.ToString())}");
            toStringOutput.Add($"RatePlanPricing = {(this.RatePlanPricing == null ? "null" : this.RatePlanPricing.ToString())}");
            toStringOutput.Add($"RatePlanEndDate = {(this.RatePlanEndDate == null ? "null" : this.RatePlanEndDate.ToString())}");
        }
    }
}