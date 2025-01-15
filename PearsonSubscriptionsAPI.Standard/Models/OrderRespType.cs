// <copyright file="OrderRespType.cs" company="APIMatic">
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
    /// OrderRespType.
    /// </summary>
    public class OrderRespType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRespType"/> class.
        /// </summary>
        public OrderRespType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRespType"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="subscriptionNumber">subscriptionNumber.</param>
        public OrderRespType(
            string message = null,
            string orderNumber = null,
            string subscriptionNumber = null)
        {
            this.Message = message;
            this.OrderNumber = orderNumber;
            this.SubscriptionNumber = subscriptionNumber;
        }

        /// <summary>
        /// message description once subscription creation is sucess.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// order number.
        /// </summary>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// subscription id.
        /// </summary>
        [JsonProperty("subscriptionNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderRespType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderRespType other &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true) &&
                (this.OrderNumber == null && other.OrderNumber == null ||
                 this.OrderNumber?.Equals(other.OrderNumber) == true) &&
                (this.SubscriptionNumber == null && other.SubscriptionNumber == null ||
                 this.SubscriptionNumber?.Equals(other.SubscriptionNumber) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
            toStringOutput.Add($"OrderNumber = {this.OrderNumber ?? "null"}");
            toStringOutput.Add($"SubscriptionNumber = {this.SubscriptionNumber ?? "null"}");
        }
    }
}