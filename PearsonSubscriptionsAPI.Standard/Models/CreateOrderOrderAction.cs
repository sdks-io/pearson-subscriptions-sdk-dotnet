// <copyright file="CreateOrderOrderAction.cs" company="APIMatic">
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
    /// CreateOrderOrderAction.
    /// </summary>
    public class CreateOrderOrderAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderOrderAction"/> class.
        /// </summary>
        public CreateOrderOrderAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderOrderAction"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="triggerDates">triggerDates.</param>
        /// <param name="createSubscription">createSubscription.</param>
        public CreateOrderOrderAction(
            Models.TypeEnum? type = null,
            List<Models.TriggerDate> triggerDates = null,
            Models.CreateSubscription createSubscription = null)
        {
            this.Type = type;
            this.TriggerDates = triggerDates;
            this.CreateSubscription = createSubscription;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets TriggerDates.
        /// </summary>
        [JsonProperty("triggerDates", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TriggerDate> TriggerDates { get; set; }

        /// <summary>
        /// Information about an order action of type `CreateSubscription`.
        /// </summary>
        [JsonProperty("createSubscription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreateSubscription CreateSubscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateOrderOrderAction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateOrderOrderAction other &&
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.TriggerDates == null && other.TriggerDates == null ||
                 this.TriggerDates?.Equals(other.TriggerDates) == true) &&
                (this.CreateSubscription == null && other.CreateSubscription == null ||
                 this.CreateSubscription?.Equals(other.CreateSubscription) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"TriggerDates = {(this.TriggerDates == null ? "null" : $"[{string.Join(", ", this.TriggerDates)} ]")}");
            toStringOutput.Add($"CreateSubscription = {(this.CreateSubscription == null ? "null" : this.CreateSubscription.ToString())}");
        }
    }
}