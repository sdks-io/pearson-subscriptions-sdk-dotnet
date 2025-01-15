// <copyright file="UpdateSubscription.cs" company="APIMatic">
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
    /// UpdateSubscription.
    /// </summary>
    public class UpdateSubscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscription"/> class.
        /// </summary>
        public UpdateSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscription"/> class.
        /// </summary>
        /// <param name="orderType">orderType.</param>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="orderDate">orderDate.</param>
        /// <param name="description">description.</param>
        /// <param name="existingAccountNumber">existingAccountNumber.</param>
        /// <param name="account">account.</param>
        /// <param name="updateSubscriptionSubscriptions">updateSubscriptionSubscriptions.</param>
        /// <param name="updateSubscriptionProcessingOptions">updateSubscriptionProcessingOptions.</param>
        /// <param name="updateSubscriptionProducts">updateSubscriptionProducts.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="paymentCapture">paymentCapture.</param>
        public UpdateSubscription(
            Models.OrderTypeEnum orderType,
            string orderNumber = null,
            string orderDate = null,
            string description = null,
            string existingAccountNumber = null,
            Models.Account account = null,
            List<Models.UpdateSubscriptionSubscription> updateSubscriptionSubscriptions = null,
            Models.UpdateSubscriptionProcessingOptions updateSubscriptionProcessingOptions = null,
            List<Models.Product> updateSubscriptionProducts = null,
            List<Models.CustomField> customFields = null,
            object paymentCapture = null)
        {
            this.OrderType = orderType;
            this.OrderNumber = orderNumber;
            this.OrderDate = orderDate;
            this.Description = description;
            this.ExistingAccountNumber = existingAccountNumber;
            this.Account = account;
            this.UpdateSubscriptionSubscriptions = updateSubscriptionSubscriptions;
            this.UpdateSubscriptionProcessingOptions = updateSubscriptionProcessingOptions;
            this.UpdateSubscriptionProducts = updateSubscriptionProducts;
            this.CustomFields = customFields;
            this.PaymentCapture = paymentCapture;
        }

        /// <summary>
        /// Order Type .
        /// </summary>
        [JsonProperty("orderType")]
        public Models.OrderTypeEnum OrderType { get; set; }

        /// <summary>
        /// Hybris Order Number.
        /// </summary>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null.
        /// </summary>
        [JsonProperty("orderDate", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderDate { get; set; }

        /// <summary>
        /// A description of the order.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The account number that this order will be created under. It can be either the accountNumber or the account info provided.
        /// </summary>
        [JsonProperty("existingAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ExistingAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets Account.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Account Account { get; set; }

        /// <summary>
        /// Each item includes a set of order actions, which will be applied to the same base subscription.
        /// </summary>
        [JsonProperty("updateSubscriptionSubscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateSubscriptionSubscription> UpdateSubscriptionSubscriptions { get; set; }

        /// <summary>
        /// Invoice or Payment.
        /// </summary>
        [JsonProperty("updateSubscriptionProcessingOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdateSubscriptionProcessingOptions UpdateSubscriptionProcessingOptions { get; set; }

        /// <summary>
        /// Gets or sets UpdateSubscriptionProducts.
        /// </summary>
        [JsonProperty("updateSubscriptionProducts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Product> UpdateSubscriptionProducts { get; set; }

        /// <summary>
        /// Information about the payment related fields.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomField> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets PaymentCapture.
        /// </summary>
        [JsonProperty("paymentCapture", NullValueHandling = NullValueHandling.Ignore)]
        public object PaymentCapture { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscription other &&
                (this.OrderType.Equals(other.OrderType)) &&
                (this.OrderNumber == null && other.OrderNumber == null ||
                 this.OrderNumber?.Equals(other.OrderNumber) == true) &&
                (this.OrderDate == null && other.OrderDate == null ||
                 this.OrderDate?.Equals(other.OrderDate) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.ExistingAccountNumber == null && other.ExistingAccountNumber == null ||
                 this.ExistingAccountNumber?.Equals(other.ExistingAccountNumber) == true) &&
                (this.Account == null && other.Account == null ||
                 this.Account?.Equals(other.Account) == true) &&
                (this.UpdateSubscriptionSubscriptions == null && other.UpdateSubscriptionSubscriptions == null ||
                 this.UpdateSubscriptionSubscriptions?.Equals(other.UpdateSubscriptionSubscriptions) == true) &&
                (this.UpdateSubscriptionProcessingOptions == null && other.UpdateSubscriptionProcessingOptions == null ||
                 this.UpdateSubscriptionProcessingOptions?.Equals(other.UpdateSubscriptionProcessingOptions) == true) &&
                (this.UpdateSubscriptionProducts == null && other.UpdateSubscriptionProducts == null ||
                 this.UpdateSubscriptionProducts?.Equals(other.UpdateSubscriptionProducts) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                (this.PaymentCapture == null && other.PaymentCapture == null ||
                 this.PaymentCapture?.Equals(other.PaymentCapture) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"OrderType = {this.OrderType}");
            toStringOutput.Add($"OrderNumber = {this.OrderNumber ?? "null"}");
            toStringOutput.Add($"OrderDate = {this.OrderDate ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"ExistingAccountNumber = {this.ExistingAccountNumber ?? "null"}");
            toStringOutput.Add($"Account = {(this.Account == null ? "null" : this.Account.ToString())}");
            toStringOutput.Add($"UpdateSubscriptionSubscriptions = {(this.UpdateSubscriptionSubscriptions == null ? "null" : $"[{string.Join(", ", this.UpdateSubscriptionSubscriptions)} ]")}");
            toStringOutput.Add($"UpdateSubscriptionProcessingOptions = {(this.UpdateSubscriptionProcessingOptions == null ? "null" : this.UpdateSubscriptionProcessingOptions.ToString())}");
            toStringOutput.Add($"UpdateSubscriptionProducts = {(this.UpdateSubscriptionProducts == null ? "null" : $"[{string.Join(", ", this.UpdateSubscriptionProducts)} ]")}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"PaymentCapture = {(this.PaymentCapture == null ? "null" : this.PaymentCapture.ToString())}");
        }
    }
}