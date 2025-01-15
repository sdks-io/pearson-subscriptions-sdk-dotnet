// <copyright file="CreateSubscription.cs" company="APIMatic">
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
    /// CreateSubscription.
    /// </summary>
    public class CreateSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscription"/> class.
        /// </summary>
        public CreateSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscription"/> class.
        /// </summary>
        /// <param name="terms">terms.</param>
        /// <param name="subscribeToRatePlans">subscribeToRatePlans.</param>
        public CreateSubscription(
            Models.Terms terms = null,
            List<Models.SubscribeToRatePlan> subscribeToRatePlans = null)
        {
            this.Terms = terms;
            this.SubscribeToRatePlans = subscribeToRatePlans;
        }

        /// <summary>
        /// Container for the terms and renewal settings of the subscription.
        /// </summary>
        [JsonProperty("terms", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Terms Terms { get; set; }

        /// <summary>
        /// Gets or sets SubscribeToRatePlans.
        /// </summary>
        [JsonProperty("subscribeToRatePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscribeToRatePlan> SubscribeToRatePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSubscription other &&
                (this.Terms == null && other.Terms == null ||
                 this.Terms?.Equals(other.Terms) == true) &&
                (this.SubscribeToRatePlans == null && other.SubscribeToRatePlans == null ||
                 this.SubscribeToRatePlans?.Equals(other.SubscribeToRatePlans) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Terms = {(this.Terms == null ? "null" : this.Terms.ToString())}");
            toStringOutput.Add($"SubscribeToRatePlans = {(this.SubscribeToRatePlans == null ? "null" : $"[{string.Join(", ", this.SubscribeToRatePlans)} ]")}");
        }
    }
}