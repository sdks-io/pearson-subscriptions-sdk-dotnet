// <copyright file="BillingOptions.cs" company="APIMatic">
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
    /// BillingOptions.
    /// </summary>
    public class BillingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOptions"/> class.
        /// </summary>
        public BillingOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingOptions"/> class.
        /// </summary>
        /// <param name="documentDate">documentDate.</param>
        /// <param name="targetDate">targetDate.</param>
        public BillingOptions(
            DateTime? documentDate = null,
            DateTime? targetDate = null)
        {
            this.DocumentDate = documentDate;
            this.TargetDate = targetDate;
        }

        /// <summary>
        /// Gets or sets DocumentDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("documentDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// For REDEMPTION, it is end of term date
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("targetDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillingOptions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillingOptions other &&
                (this.DocumentDate == null && other.DocumentDate == null ||
                 this.DocumentDate?.Equals(other.DocumentDate) == true) &&
                (this.TargetDate == null && other.TargetDate == null ||
                 this.TargetDate?.Equals(other.TargetDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DocumentDate = {(this.DocumentDate == null ? "null" : this.DocumentDate.ToString())}");
            toStringOutput.Add($"TargetDate = {(this.TargetDate == null ? "null" : this.TargetDate.ToString())}");
        }
    }
}