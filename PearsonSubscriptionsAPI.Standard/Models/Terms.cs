// <copyright file="Terms.cs" company="APIMatic">
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
    /// Terms.
    /// </summary>
    public class Terms
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Terms"/> class.
        /// </summary>
        public Terms()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Terms"/> class.
        /// </summary>
        /// <param name="initialTerm">initialTerm.</param>
        /// <param name="renewalTerms">renewalTerms.</param>
        /// <param name="renewalSetting">renewalSetting.</param>
        /// <param name="autoRenew">autoRenew.</param>
        public Terms(
            Models.InitialTerm initialTerm = null,
            List<Models.RenewalTerm> renewalTerms = null,
            Models.RenewalSettingEnum? renewalSetting = null,
            bool? autoRenew = null)
        {
            this.InitialTerm = initialTerm;
            this.RenewalTerms = renewalTerms;
            this.RenewalSetting = renewalSetting;
            this.AutoRenew = autoRenew;
        }

        /// <summary>
        /// Information about the first term of the subscription.
        /// </summary>
        [JsonProperty("initialTerm", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InitialTerm InitialTerm { get; set; }

        /// <summary>
        /// List of renewal terms of the subscription. Only applicable if the type of the first term is `TERMED` and the value of the `renewalSetting` field is `RENEW_WITH_SPECIFIC_TERM`.
        /// </summary>
        [JsonProperty("renewalTerms", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RenewalTerm> RenewalTerms { get; set; }

        /// <summary>
        /// Specifies the type of the terms that follow the first term if the subscription is renewed. Only applicable if the type of the first term is `TERMED`.
        /// * `RENEW_WITH_SPECIFIC_TERM` - Each renewal term has a predefined duration. The first entry in `renewalTerms` specifies the duration of the second term of the subscription, the second entry in `renewalTerms` specifies the duration of the third term of the subscription, and so on. The last entry in `renewalTerms` specifies the ultimate duration of each renewal term.
        /// * `RENEW_TO_EVERGREEN` - The second term of the subscription does not have a predefined duration.
        /// </summary>
        [JsonProperty("renewalSetting", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RenewalSettingEnum? RenewalSetting { get; set; }

        /// <summary>
        /// Specifies whether the subscription automatically renews at the end of the each term. For REDEMPTION, default it to false.
        /// </summary>
        [JsonProperty("autoRenew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRenew { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Terms : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Terms other &&
                (this.InitialTerm == null && other.InitialTerm == null ||
                 this.InitialTerm?.Equals(other.InitialTerm) == true) &&
                (this.RenewalTerms == null && other.RenewalTerms == null ||
                 this.RenewalTerms?.Equals(other.RenewalTerms) == true) &&
                (this.RenewalSetting == null && other.RenewalSetting == null ||
                 this.RenewalSetting?.Equals(other.RenewalSetting) == true) &&
                (this.AutoRenew == null && other.AutoRenew == null ||
                 this.AutoRenew?.Equals(other.AutoRenew) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"InitialTerm = {(this.InitialTerm == null ? "null" : this.InitialTerm.ToString())}");
            toStringOutput.Add($"RenewalTerms = {(this.RenewalTerms == null ? "null" : $"[{string.Join(", ", this.RenewalTerms)} ]")}");
            toStringOutput.Add($"RenewalSetting = {(this.RenewalSetting == null ? "null" : this.RenewalSetting.ToString())}");
            toStringOutput.Add($"AutoRenew = {(this.AutoRenew == null ? "null" : this.AutoRenew.ToString())}");
        }
    }
}