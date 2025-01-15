// <copyright file="OrderErrorTypeException.cs" company="APIMatic">
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
    /// OrderErrorTypeException.
    /// </summary>
    public class OrderErrorTypeException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderErrorTypeException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public OrderErrorTypeException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Order Number.
        /// </summary>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets OrderError.
        /// </summary>
        [JsonProperty("orderError", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderError OrderError { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OrderErrorTypeException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"OrderNumber = {this.OrderNumber ?? "null"}");
            toStringOutput.Add($"OrderError = {(this.OrderError == null ? "null" : this.OrderError.ToString())}");
        }
    }
}