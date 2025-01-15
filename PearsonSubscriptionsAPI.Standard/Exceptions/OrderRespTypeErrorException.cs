// <copyright file="OrderRespTypeErrorException.cs" company="APIMatic">
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
using PearsonSubscriptionsAPI.Standard.Http.Client;
using PearsonSubscriptionsAPI.Standard.Models;
using PearsonSubscriptionsAPI.Standard.Utilities;

namespace PearsonSubscriptionsAPI.Standard.Exceptions
{
    /// <summary>
    /// OrderRespTypeErrorException.
    /// </summary>
    public class OrderRespTypeErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRespTypeErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public OrderRespTypeErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Order Number.
        /// </summary>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Pearson subscription id.
        /// </summary>
        [JsonProperty("subscriptionId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets OrderRespError.
        /// </summary>
        [JsonProperty("orderRespError", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderRespError OrderRespError { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderRespTypeErrorException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"OrderNumber = {this.OrderNumber ?? "null"}");
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId ?? "null"}");
            toStringOutput.Add($"OrderRespError = {(this.OrderRespError == null ? "null" : this.OrderRespError.ToString())}");
        }
    }
}