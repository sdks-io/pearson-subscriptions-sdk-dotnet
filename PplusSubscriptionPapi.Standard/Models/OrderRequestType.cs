// <copyright file="OrderRequestType.cs" company="APIMatic">
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
    /// OrderRequestType.
    /// </summary>
    public class OrderRequestType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestType"/> class.
        /// </summary>
        public OrderRequestType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequestType"/> class.
        /// </summary>
        /// <param name="orderNumber">orderNumber.</param>
        /// <param name="orderDate">orderDate.</param>
        /// <param name="description">description.</param>
        /// <param name="subscriptionModelName">subscriptionModelName.</param>
        /// <param name="storeCode">storeCode.</param>
        /// <param name="swapTitle">swapTitle.</param>
        /// <param name="sendEmail">sendEmail.</param>
        /// <param name="account">account.</param>
        /// <param name="orderRequestTypeSubscriptions">orderRequestTypeSubscriptions.</param>
        /// <param name="orderRequestProcessingOptions">orderRequestProcessingOptions.</param>
        /// <param name="orderRequestTypeProducts">orderRequestTypeProducts.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="paymentCapture">paymentCapture.</param>
        public OrderRequestType(
            string orderNumber = null,
            DateTime? orderDate = null,
            string description = null,
            string subscriptionModelName = null,
            string storeCode = null,
            bool? swapTitle = null,
            bool? sendEmail = null,
            Models.Account account = null,
            List<Models.OrderRequestTypeSubscription> orderRequestTypeSubscriptions = null,
            Models.OrderRequestProcessingOptions orderRequestProcessingOptions = null,
            List<Models.OrderRequestTypeProduct> orderRequestTypeProducts = null,
            List<Models.CustomField> customFields = null,
            object paymentCapture = null)
        {
            this.OrderNumber = orderNumber;
            this.OrderDate = orderDate;
            this.Description = description;
            this.SubscriptionModelName = subscriptionModelName;
            this.StoreCode = storeCode;
            this.SwapTitle = swapTitle;
            this.SendEmail = sendEmail;
            this.Account = account;
            this.OrderRequestTypeSubscriptions = orderRequestTypeSubscriptions;
            this.OrderRequestProcessingOptions = orderRequestProcessingOptions;
            this.OrderRequestTypeProducts = orderRequestTypeProducts;
            this.CustomFields = customFields;
            this.PaymentCapture = paymentCapture;
        }

        /// <summary>
        /// Hybris/PMC/OASIS Order Number.
        /// </summary>
        [JsonProperty("orderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// The date when the order is signed. All the order actions under this order will use this order date as the contract effective date if the contract effective date field is skipped or its value is left as null.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("orderDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// A description of the order.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Subscription Model Name.
        /// </summary>
        [JsonProperty("subscriptionModelName", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionModelName { get; set; }

        /// <summary>
        /// store identifier
        /// </summary>
        [JsonProperty("storeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreCode { get; set; }

        /// <summary>
        /// Use for swapTitle.If swaptitle than value will be true.
        /// </summary>
        [JsonProperty("swapTitle", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwapTitle { get; set; }

        /// <summary>
        /// send email to the user
        /// </summary>
        [JsonProperty("sendEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendEmail { get; set; }

        /// <summary>
        /// Gets or sets Account.
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Account Account { get; set; }

        /// <summary>
        /// new account details required to create subscription. This block is mandate for new customer
        /// </summary>
        [JsonProperty("orderRequestTypeSubscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderRequestTypeSubscription> OrderRequestTypeSubscriptions { get; set; }

        /// <summary>
        /// Invoice or Payment.
        /// </summary>
        [JsonProperty("orderRequestProcessingOptions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderRequestProcessingOptions OrderRequestProcessingOptions { get; set; }

        /// <summary>
        /// Gets or sets OrderRequestTypeProducts.
        /// </summary>
        [JsonProperty("orderRequestTypeProducts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.OrderRequestTypeProduct> OrderRequestTypeProducts { get; set; }

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
            return $"OrderRequestType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OrderRequestType other &&
                (this.OrderNumber == null && other.OrderNumber == null ||
                 this.OrderNumber?.Equals(other.OrderNumber) == true) &&
                (this.OrderDate == null && other.OrderDate == null ||
                 this.OrderDate?.Equals(other.OrderDate) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.SubscriptionModelName == null && other.SubscriptionModelName == null ||
                 this.SubscriptionModelName?.Equals(other.SubscriptionModelName) == true) &&
                (this.StoreCode == null && other.StoreCode == null ||
                 this.StoreCode?.Equals(other.StoreCode) == true) &&
                (this.SwapTitle == null && other.SwapTitle == null ||
                 this.SwapTitle?.Equals(other.SwapTitle) == true) &&
                (this.SendEmail == null && other.SendEmail == null ||
                 this.SendEmail?.Equals(other.SendEmail) == true) &&
                (this.Account == null && other.Account == null ||
                 this.Account?.Equals(other.Account) == true) &&
                (this.OrderRequestTypeSubscriptions == null && other.OrderRequestTypeSubscriptions == null ||
                 this.OrderRequestTypeSubscriptions?.Equals(other.OrderRequestTypeSubscriptions) == true) &&
                (this.OrderRequestProcessingOptions == null && other.OrderRequestProcessingOptions == null ||
                 this.OrderRequestProcessingOptions?.Equals(other.OrderRequestProcessingOptions) == true) &&
                (this.OrderRequestTypeProducts == null && other.OrderRequestTypeProducts == null ||
                 this.OrderRequestTypeProducts?.Equals(other.OrderRequestTypeProducts) == true) &&
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
            toStringOutput.Add($"OrderNumber = {this.OrderNumber ?? "null"}");
            toStringOutput.Add($"OrderDate = {(this.OrderDate == null ? "null" : this.OrderDate.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"SubscriptionModelName = {this.SubscriptionModelName ?? "null"}");
            toStringOutput.Add($"StoreCode = {this.StoreCode ?? "null"}");
            toStringOutput.Add($"SwapTitle = {(this.SwapTitle == null ? "null" : this.SwapTitle.ToString())}");
            toStringOutput.Add($"SendEmail = {(this.SendEmail == null ? "null" : this.SendEmail.ToString())}");
            toStringOutput.Add($"Account = {(this.Account == null ? "null" : this.Account.ToString())}");
            toStringOutput.Add($"OrderRequestTypeSubscriptions = {(this.OrderRequestTypeSubscriptions == null ? "null" : $"[{string.Join(", ", this.OrderRequestTypeSubscriptions)} ]")}");
            toStringOutput.Add($"OrderRequestProcessingOptions = {(this.OrderRequestProcessingOptions == null ? "null" : this.OrderRequestProcessingOptions.ToString())}");
            toStringOutput.Add($"OrderRequestTypeProducts = {(this.OrderRequestTypeProducts == null ? "null" : $"[{string.Join(", ", this.OrderRequestTypeProducts)} ]")}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"PaymentCapture = {(this.PaymentCapture == null ? "null" : this.PaymentCapture.ToString())}");
        }
    }
}