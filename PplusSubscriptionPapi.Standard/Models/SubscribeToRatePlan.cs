// <copyright file="SubscribeToRatePlan.cs" company="APIMatic">
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
    /// SubscribeToRatePlan.
    /// </summary>
    public class SubscribeToRatePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToRatePlan"/> class.
        /// </summary>
        public SubscribeToRatePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeToRatePlan"/> class.
        /// </summary>
        /// <param name="productRatePlanId">productRatePlanId.</param>
        /// <param name="subscribeToRatePlansChargeOverrides">subscribeToRatePlansChargeOverrides.</param>
        public SubscribeToRatePlan(
            string productRatePlanId = null,
            List<Models.SubscribeToRatePlansChargeOverride> subscribeToRatePlansChargeOverrides = null)
        {
            this.ProductRatePlanId = productRatePlanId;
            this.SubscribeToRatePlansChargeOverrides = subscribeToRatePlansChargeOverrides;
        }

        /// <summary>
        /// This is unique Product Rate Plan id which signifies the subscription type,entitlementLevel,maxEntitlements,numEntitlements etc.
        /// </summary>
        [JsonProperty("productRatePlanId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductRatePlanId { get; set; }

        /// <summary>
        /// Gets or sets SubscribeToRatePlansChargeOverrides.
        /// </summary>
        [JsonProperty("subscribeToRatePlansChargeOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscribeToRatePlansChargeOverride> SubscribeToRatePlansChargeOverrides { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscribeToRatePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscribeToRatePlan other &&
                (this.ProductRatePlanId == null && other.ProductRatePlanId == null ||
                 this.ProductRatePlanId?.Equals(other.ProductRatePlanId) == true) &&
                (this.SubscribeToRatePlansChargeOverrides == null && other.SubscribeToRatePlansChargeOverrides == null ||
                 this.SubscribeToRatePlansChargeOverrides?.Equals(other.SubscribeToRatePlansChargeOverrides) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductRatePlanId = {this.ProductRatePlanId ?? "null"}");
            toStringOutput.Add($"SubscribeToRatePlansChargeOverrides = {(this.SubscribeToRatePlansChargeOverrides == null ? "null" : $"[{string.Join(", ", this.SubscribeToRatePlansChargeOverrides)} ]")}");
        }
    }
}