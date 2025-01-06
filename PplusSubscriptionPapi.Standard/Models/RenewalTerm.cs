// <copyright file="RenewalTerm.cs" company="APIMatic">
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
    /// RenewalTerm.
    /// </summary>
    public class RenewalTerm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalTerm"/> class.
        /// </summary>
        public RenewalTerm()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalTerm"/> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="periodType">periodType.</param>
        public RenewalTerm(
            int? period = null,
            Models.PeriodTypeEnum? periodType = null)
        {
            this.Period = period;
            this.PeriodType = periodType;
        }

        /// <summary>
        /// Duration of the renewal term in months, years, days, or weeks, depending on the value of the `periodType` field.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// Unit of time that the renewal term is measured in.
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PeriodTypeEnum? PeriodType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RenewalTerm : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RenewalTerm other &&
                (this.Period == null && other.Period == null ||
                 this.Period?.Equals(other.Period) == true) &&
                (this.PeriodType == null && other.PeriodType == null ||
                 this.PeriodType?.Equals(other.PeriodType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"PeriodType = {(this.PeriodType == null ? "null" : this.PeriodType.ToString())}");
        }
    }
}