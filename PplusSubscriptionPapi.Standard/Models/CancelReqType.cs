// <copyright file="CancelReqType.cs" company="APIMatic">
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
    /// CancelReqType.
    /// </summary>
    public class CancelReqType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelReqType"/> class.
        /// </summary>
        public CancelReqType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelReqType"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="subscriptionSource">subscriptionSource.</param>
        /// <param name="cancelReason">cancelReason.</param>
        /// <param name="cancelDate">cancelDate.</param>
        public CancelReqType(
            string subscriptionId,
            Models.SubscriptionSourceEnum subscriptionSource,
            string cancelReason,
            string cancelDate)
        {
            this.SubscriptionId = subscriptionId;
            this.SubscriptionSource = subscriptionSource;
            this.CancelReason = cancelReason;
            this.CancelDate = cancelDate;
        }

        /// <summary>
        /// Subscription id
        /// </summary>
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Internal or external
        /// </summary>
        [JsonProperty("subscriptionSource")]
        public Models.SubscriptionSourceEnum SubscriptionSource { get; set; }

        /// <summary>
        /// Reason for subscription cancel
        /// </summary>
        [JsonProperty("cancelReason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// cancellation date
        /// </summary>
        [JsonProperty("cancelDate")]
        public string CancelDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CancelReqType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancelReqType other &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.SubscriptionSource.Equals(other.SubscriptionSource)) &&
                (this.CancelReason == null && other.CancelReason == null ||
                 this.CancelReason?.Equals(other.CancelReason) == true) &&
                (this.CancelDate == null && other.CancelDate == null ||
                 this.CancelDate?.Equals(other.CancelDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId ?? "null"}");
            toStringOutput.Add($"SubscriptionSource = {this.SubscriptionSource}");
            toStringOutput.Add($"CancelReason = {this.CancelReason ?? "null"}");
            toStringOutput.Add($"CancelDate = {this.CancelDate ?? "null"}");
        }
    }
}