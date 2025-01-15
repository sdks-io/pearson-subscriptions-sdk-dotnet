// <copyright file="UpdateSubscriptionSubscription.cs" company="APIMatic">
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
    /// UpdateSubscriptionSubscription.
    /// </summary>
    public class UpdateSubscriptionSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionSubscription"/> class.
        /// </summary>
        public UpdateSubscriptionSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionSubscription"/> class.
        /// </summary>
        /// <param name="subscriptionNumber">subscriptionNumber.</param>
        /// <param name="orderActions">orderActions.</param>
        public UpdateSubscriptionSubscription(
            string subscriptionNumber,
            List<Models.UpdateOrderOrderAction> orderActions = null)
        {
            this.SubscriptionNumber = subscriptionNumber;
            this.OrderActions = orderActions;
        }

        /// <summary>
        /// Subscription number or ID. Subscription status must be active for the same.
        /// </summary>
        [JsonProperty("subscriptionNumber")]
        public string SubscriptionNumber { get; set; }

        /// <summary>
        /// The actions to be applied to the subscription. Order actions will be stored with the sequence when it was provided in the request.
        /// </summary>
        [JsonProperty("orderActions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateOrderOrderAction> OrderActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionSubscription other &&
                (this.SubscriptionNumber == null && other.SubscriptionNumber == null ||
                 this.SubscriptionNumber?.Equals(other.SubscriptionNumber) == true) &&
                (this.OrderActions == null && other.OrderActions == null ||
                 this.OrderActions?.Equals(other.OrderActions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionNumber = {this.SubscriptionNumber ?? "null"}");
            toStringOutput.Add($"OrderActions = {(this.OrderActions == null ? "null" : $"[{string.Join(", ", this.OrderActions)} ]")}");
        }
    }
}