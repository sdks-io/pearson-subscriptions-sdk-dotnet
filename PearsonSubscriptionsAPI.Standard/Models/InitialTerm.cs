// <copyright file="InitialTerm.cs" company="APIMatic">
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
    /// InitialTerm.
    /// </summary>
    public class InitialTerm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialTerm"/> class.
        /// </summary>
        public InitialTerm()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialTerm"/> class.
        /// </summary>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="period">period.</param>
        /// <param name="periodType">periodType.</param>
        /// <param name="termType">termType.</param>
        public InitialTerm(
            string startDate = null,
            string endDate = null,
            int? period = null,
            Models.PeriodTypeEnum? periodType = null,
            Models.TermTypeEnum? termType = null)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Period = period;
            this.PeriodType = periodType;
            this.TermType = termType;
        }

        /// <summary>
        /// Start date of the first term, in yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// End data of a subscription. in yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Duration of the first term in months, years, days, or weeks, depending on the value of the `periodType` field. Only applicable if the value of the `termType` field is `TERMED`.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// Unit of time that the renewal term is measured in.
        /// </summary>
        [JsonProperty("periodType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PeriodTypeEnum? PeriodType { get; set; }

        /// <summary>
        /// Type of the first term. If the value of this field is `TERMED`, the first term has a predefined duration based on the value of the `period` field. If the value of this field is `EVERGREEN`, the first term does not have a predefined duration.
        /// </summary>
        [JsonProperty("termType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TermTypeEnum? TermType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InitialTerm : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InitialTerm other &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.Period == null && other.Period == null ||
                 this.Period?.Equals(other.Period) == true) &&
                (this.PeriodType == null && other.PeriodType == null ||
                 this.PeriodType?.Equals(other.PeriodType) == true) &&
                (this.TermType == null && other.TermType == null ||
                 this.TermType?.Equals(other.TermType) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartDate = {this.StartDate ?? "null"}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"PeriodType = {(this.PeriodType == null ? "null" : this.PeriodType.ToString())}");
            toStringOutput.Add($"TermType = {(this.TermType == null ? "null" : this.TermType.ToString())}");
        }
    }
}