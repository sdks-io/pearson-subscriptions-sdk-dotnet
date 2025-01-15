// <copyright file="TriggerDate.cs" company="APIMatic">
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
    /// TriggerDate.
    /// </summary>
    public class TriggerDate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerDate"/> class.
        /// </summary>
        public TriggerDate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerDate"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="triggerDateProp">triggerDate.</param>
        public TriggerDate(
            string name = null,
            string triggerDateProp = null)
        {
            this.Name = name;
            this.TriggerDateProp = triggerDateProp;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Date in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("triggerDate", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerDateProp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TriggerDate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TriggerDate other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.TriggerDateProp == null && other.TriggerDateProp == null ||
                 this.TriggerDateProp?.Equals(other.TriggerDateProp) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"TriggerDateProp = {this.TriggerDateProp ?? "null"}");
        }
    }
}