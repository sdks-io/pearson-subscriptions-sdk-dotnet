// <copyright file="TermsAndConditions.cs" company="APIMatic">
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
    /// TermsAndConditions.
    /// </summary>
    public class TermsAndConditions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsAndConditions"/> class.
        /// </summary>
        public TermsAndConditions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermsAndConditions"/> class.
        /// </summary>
        /// <param name="autorenew">autorenew.</param>
        public TermsAndConditions(
            bool? autorenew = null)
        {
            this.Autorenew = autorenew;
        }

        /// <summary>
        /// autorenew flag
        /// </summary>
        [JsonProperty("autorenew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"TermsAndConditions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is TermsAndConditions other &&
                (this.Autorenew == null && other.Autorenew == null ||
                 this.Autorenew?.Equals(other.Autorenew) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Autorenew = {(this.Autorenew == null ? "null" : this.Autorenew.ToString())}");
        }
    }
}