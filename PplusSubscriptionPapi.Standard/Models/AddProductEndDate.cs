// <copyright file="AddProductEndDate.cs" company="APIMatic">
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
    /// AddProductEndDate.
    /// </summary>
    public class AddProductEndDate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddProductEndDate"/> class.
        /// </summary>
        public AddProductEndDate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProductEndDate"/> class.
        /// </summary>
        /// <param name="endDateCondition">endDateCondition.</param>
        /// <param name="specificEndDate">specificEndDate.</param>
        /// <param name="upToPeriods">upToPeriods.</param>
        /// <param name="upToPeriodsType">upToPeriodsType.</param>
        public AddProductEndDate(
            Models.EndDateConditionEnum? endDateCondition = null,
            string specificEndDate = null,
            double? upToPeriods = null,
            string upToPeriodsType = null)
        {
            this.EndDateCondition = endDateCondition;
            this.SpecificEndDate = specificEndDate;
            this.UpToPeriods = upToPeriods;
            this.UpToPeriodsType = upToPeriodsType;
        }

        /// <summary>
        /// enum values are "Subscription_End" "Fixed_Period" "Specific_End_Date"
        /// </summary>
        [JsonProperty("endDateCondition", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EndDateConditionEnum? EndDateCondition { get; set; }

        /// <summary>
        /// Gets or sets SpecificEndDate.
        /// </summary>
        [JsonProperty("specificEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificEndDate { get; set; }

        /// <summary>
        /// Gets or sets UpToPeriods.
        /// </summary>
        [JsonProperty("upToPeriods", NullValueHandling = NullValueHandling.Ignore)]
        public double? UpToPeriods { get; set; }

        /// <summary>
        /// Gets or sets UpToPeriodsType.
        /// </summary>
        [JsonProperty("upToPeriodsType", NullValueHandling = NullValueHandling.Ignore)]
        public string UpToPeriodsType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddProductEndDate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddProductEndDate other &&
                (this.EndDateCondition == null && other.EndDateCondition == null ||
                 this.EndDateCondition?.Equals(other.EndDateCondition) == true) &&
                (this.SpecificEndDate == null && other.SpecificEndDate == null ||
                 this.SpecificEndDate?.Equals(other.SpecificEndDate) == true) &&
                (this.UpToPeriods == null && other.UpToPeriods == null ||
                 this.UpToPeriods?.Equals(other.UpToPeriods) == true) &&
                (this.UpToPeriodsType == null && other.UpToPeriodsType == null ||
                 this.UpToPeriodsType?.Equals(other.UpToPeriodsType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EndDateCondition = {(this.EndDateCondition == null ? "null" : this.EndDateCondition.ToString())}");
            toStringOutput.Add($"SpecificEndDate = {this.SpecificEndDate ?? "null"}");
            toStringOutput.Add($"UpToPeriods = {(this.UpToPeriods == null ? "null" : this.UpToPeriods.ToString())}");
            toStringOutput.Add($"UpToPeriodsType = {this.UpToPeriodsType ?? "null"}");
        }
    }
}