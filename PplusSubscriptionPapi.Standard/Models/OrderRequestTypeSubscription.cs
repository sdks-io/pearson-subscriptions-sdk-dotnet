// <copyright file="OrderRequestTypeSubscription.cs" company="APIMatic">
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
    /// OrderRequestTypeSubscription.
    /// </summary>
    public class OrderRequestTypeSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestTypeSubscription"/> class.
        /// </summary>
        public OrderRequestTypeSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestTypeSubscription"/> class.
        /// </summary>
        /// <param name="orderActions">orderActions.</param>
        public OrderRequestTypeSubscription(
            List<Models.CreateOrderOrderAction> orderActions = null)
        {
            this.OrderActions = orderActions;
        }

        /// <summary>
        /// The actions to be applied to the subscription. Order actions will be stored with the sequence when it was provided in the request.
        /// </summary>
        [JsonProperty("orderActions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateOrderOrderAction> OrderActions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderRequestTypeSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderRequestTypeSubscription other &&
                (this.OrderActions == null && other.OrderActions == null ||
                 this.OrderActions?.Equals(other.OrderActions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"OrderActions = {(this.OrderActions == null ? "null" : $"[{string.Join(", ", this.OrderActions)} ]")}");
        }
    }
}