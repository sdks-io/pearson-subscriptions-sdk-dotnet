// <copyright file="UpdateOrderOrderAction.cs" company="APIMatic">
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
    /// UpdateOrderOrderAction.
    /// </summary>
    public class UpdateOrderOrderAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderOrderAction"/> class.
        /// </summary>
        public UpdateOrderOrderAction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderOrderAction"/> class.
        /// </summary>
        /// <param name="triggerDates">triggerDates.</param>
        /// <param name="addProduct">addProduct.</param>
        /// <param name="removeProduct">removeProduct.</param>
        /// <param name="termsAndConditions">termsAndConditions.</param>
        public UpdateOrderOrderAction(
            List<Models.TriggerDate> triggerDates = null,
            Models.AddProduct addProduct = null,
            Models.RemoveProduct removeProduct = null,
            Models.TermsAndConditions termsAndConditions = null)
        {
            this.TriggerDates = triggerDates;
            this.AddProduct = addProduct;
            this.RemoveProduct = removeProduct;
            this.TermsAndConditions = termsAndConditions;
        }

        /// <summary>
        /// Gets or sets TriggerDates.
        /// </summary>
        [JsonProperty("triggerDates", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TriggerDate> TriggerDates { get; set; }

        /// <summary>
        /// Information about an order action of type `addProduct`.
        /// If you want to create a pending order through the "Add product" order action, and if the charge's trigger condition is `Specific Date`, you must set a charge number in the `chargeNumber` field for the "Add product" order action.
        /// </summary>
        [JsonProperty("addProduct", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AddProduct AddProduct { get; set; }

        /// <summary>
        /// Remove product details from the subscription plan
        /// </summary>
        [JsonProperty("removeProduct", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RemoveProduct RemoveProduct { get; set; }

        /// <summary>
        /// change the terms and conditions of a subscription .
        /// </summary>
        [JsonProperty("termsAndConditions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TermsAndConditions TermsAndConditions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateOrderOrderAction : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateOrderOrderAction other &&
                (this.TriggerDates == null && other.TriggerDates == null ||
                 this.TriggerDates?.Equals(other.TriggerDates) == true) &&
                (this.AddProduct == null && other.AddProduct == null ||
                 this.AddProduct?.Equals(other.AddProduct) == true) &&
                (this.RemoveProduct == null && other.RemoveProduct == null ||
                 this.RemoveProduct?.Equals(other.RemoveProduct) == true) &&
                (this.TermsAndConditions == null && other.TermsAndConditions == null ||
                 this.TermsAndConditions?.Equals(other.TermsAndConditions) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerDates = {(this.TriggerDates == null ? "null" : $"[{string.Join(", ", this.TriggerDates)} ]")}");
            toStringOutput.Add($"AddProduct = {(this.AddProduct == null ? "null" : this.AddProduct.ToString())}");
            toStringOutput.Add($"RemoveProduct = {(this.RemoveProduct == null ? "null" : this.RemoveProduct.ToString())}");
            toStringOutput.Add($"TermsAndConditions = {(this.TermsAndConditions == null ? "null" : this.TermsAndConditions.ToString())}");
        }
    }
}