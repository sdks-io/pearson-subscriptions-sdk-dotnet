// <copyright file="Account.cs" company="APIMatic">
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
    /// Account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="additionalEmailAddresses">additionalEmailAddresses.</param>
        /// <param name="customerServiceRepName">customerServiceRepName.</param>
        /// <param name="purchaseOrderNumber">purchaseOrderNumber.</param>
        /// <param name="salesRep">salesRep.</param>
        /// <param name="sequenceSetId">sequenceSetId.</param>
        /// <param name="allowInvoiceEdit">allowInvoiceEdit.</param>
        /// <param name="name">name.</param>
        /// <param name="currency">currency.</param>
        /// <param name="billCycleDay">billCycleDay.</param>
        /// <param name="invoiceDeliveryPrefsPrint">invoiceDeliveryPrefsPrint.</param>
        /// <param name="invoiceDeliveryPrefsEmail">invoiceDeliveryPrefsEmail.</param>
        /// <param name="autoPay">autoPay.</param>
        /// <param name="paymentTerm">paymentTerm.</param>
        /// <param name="communicationProfileId">communicationProfileId.</param>
        /// <param name="batch">batch.</param>
        /// <param name="invoiceTemplateId">invoiceTemplateId.</param>
        /// <param name="debitMemoTemplateId">debitMemoTemplateId.</param>
        /// <param name="creditMemoTemplateId">creditMemoTemplateId.</param>
        /// <param name="billToContact">billToContact.</param>
        /// <param name="soldToContact">soldToContact.</param>
        public Account(
            string accountNumber = null,
            string additionalEmailAddresses = null,
            string customerServiceRepName = null,
            string purchaseOrderNumber = null,
            string salesRep = null,
            string sequenceSetId = null,
            bool? allowInvoiceEdit = false,
            string name = null,
            string currency = null,
            int? billCycleDay = null,
            bool? invoiceDeliveryPrefsPrint = false,
            bool? invoiceDeliveryPrefsEmail = false,
            bool? autoPay = true,
            string paymentTerm = null,
            string communicationProfileId = null,
            string batch = null,
            string invoiceTemplateId = null,
            string debitMemoTemplateId = null,
            string creditMemoTemplateId = null,
            Models.BillToContactPostOrder billToContact = null,
            Models.BillToContactPostOrder soldToContact = null)
        {
            this.AccountNumber = accountNumber;
            this.AdditionalEmailAddresses = additionalEmailAddresses;
            this.CustomerServiceRepName = customerServiceRepName;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.SalesRep = salesRep;
            this.SequenceSetId = sequenceSetId;
            this.AllowInvoiceEdit = allowInvoiceEdit;
            this.Name = name;
            this.Currency = currency;
            this.BillCycleDay = billCycleDay;
            this.InvoiceDeliveryPrefsPrint = invoiceDeliveryPrefsPrint;
            this.InvoiceDeliveryPrefsEmail = invoiceDeliveryPrefsEmail;
            this.AutoPay = autoPay;
            this.PaymentTerm = paymentTerm;
            this.CommunicationProfileId = communicationProfileId;
            this.Batch = batch;
            this.InvoiceTemplateId = invoiceTemplateId;
            this.DebitMemoTemplateId = debitMemoTemplateId;
            this.CreditMemoTemplateId = creditMemoTemplateId;
            this.BillToContact = billToContact;
            this.SoldToContact = soldToContact;
        }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("accountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// List of additional email addresses to receive emailed invoices. Values should be a comma-separated list of email addresses.
        /// </summary>
        [JsonProperty("additionalEmailAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalEmailAddresses { get; set; }

        /// <summary>
        /// Name of the account's customer service representative, if applicable.
        /// </summary>
        [JsonProperty("customerServiceRepName", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerServiceRepName { get; set; }

        /// <summary>
        /// The number of the purchase order associated with this account. Purchase order information generally comes from customers.
        /// </summary>
        [JsonProperty("purchaseOrderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The name of the sales representative associated with this account, if applicable.
        /// </summary>
        [JsonProperty("salesRep", NullValueHandling = NullValueHandling.Ignore)]
        public string SalesRep { get; set; }

        /// <summary>
        /// The ID of the billing document sequence set to assign to the customer account.
        /// The billing documents to generate for this account will adopt the prefix and starting document number configured in the sequence set.
        /// </summary>
        [JsonProperty("sequenceSetId", NullValueHandling = NullValueHandling.Ignore)]
        public string SequenceSetId { get; set; }

        /// <summary>
        /// Indicates if associated invoices can be edited.
        /// Values are:
        /// * `true`
        /// * `false` (default)
        /// </summary>
        [JsonProperty("allowInvoiceEdit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowInvoiceEdit { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 3 uppercase character currency code
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Day of the month that the account prefers billing periods to begin on. If set to 0, the bill cycle day will be set as "AutoSet".
        /// </summary>
        [JsonProperty("billCycleDay", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillCycleDay { get; set; }

        /// <summary>
        /// Specifies whether to turn on the invoice delivery method 'Print' for the new account.
        /// Values are:
        /// * `true`. Turn on the invoice delivery method 'Print' for the new account.
        /// * `false` (default). Turn off the invoice delivery method 'Print' for the new account.
        /// </summary>
        [JsonProperty("invoiceDeliveryPrefsPrint", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoiceDeliveryPrefsPrint { get; set; }

        /// <summary>
        /// Specifies whether to turn on the invoice delivery method 'Email' for the new account.
        /// Values are:
        /// * `true` (default). Turn on the invoice delivery method 'Email' for the new account.
        /// * `false`. Turn off the invoice delivery method 'Email' for the new account.
        /// </summary>
        [JsonProperty("invoiceDeliveryPrefsEmail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoiceDeliveryPrefsEmail { get; set; }

        /// <summary>
        /// Specifies whether future payments are to be automatically billed when they are due. Possible values are `true`, `false`.
        /// </summary>
        [JsonProperty("autoPay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Gets or sets PaymentTerm.
        /// </summary>
        [JsonProperty("paymentTerm", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// aaa.
        /// </summary>
        [JsonProperty("communicationProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string CommunicationProfileId { get; set; }

        /// <summary>
        /// Organizes your customer accounts into groups to optimize your billing and payment operations.
        /// </summary>
        [JsonProperty("batch", NullValueHandling = NullValueHandling.Ignore)]
        public string Batch { get; set; }

        /// <summary>
        /// Invoice template ID, configured in Billing Settings.
        /// </summary>
        [JsonProperty("invoiceTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the debit memo template, configured in Billing Settings.
        /// </summary>
        [JsonProperty("debitMemoTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitMemoTemplateId { get; set; }

        /// <summary>
        /// The unique ID of the credit memo template, configured in Billing Settings.
        /// </summary>
        [JsonProperty("creditMemoTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string CreditMemoTemplateId { get; set; }

        /// <summary>
        /// Gets or sets BillToContact.
        /// </summary>
        [JsonProperty("billToContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillToContactPostOrder BillToContact { get; set; }

        /// <summary>
        /// Gets or sets SoldToContact.
        /// </summary>
        [JsonProperty("soldToContact", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillToContactPostOrder SoldToContact { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Account : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Account other &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.AdditionalEmailAddresses == null && other.AdditionalEmailAddresses == null ||
                 this.AdditionalEmailAddresses?.Equals(other.AdditionalEmailAddresses) == true) &&
                (this.CustomerServiceRepName == null && other.CustomerServiceRepName == null ||
                 this.CustomerServiceRepName?.Equals(other.CustomerServiceRepName) == true) &&
                (this.PurchaseOrderNumber == null && other.PurchaseOrderNumber == null ||
                 this.PurchaseOrderNumber?.Equals(other.PurchaseOrderNumber) == true) &&
                (this.SalesRep == null && other.SalesRep == null ||
                 this.SalesRep?.Equals(other.SalesRep) == true) &&
                (this.SequenceSetId == null && other.SequenceSetId == null ||
                 this.SequenceSetId?.Equals(other.SequenceSetId) == true) &&
                (this.AllowInvoiceEdit == null && other.AllowInvoiceEdit == null ||
                 this.AllowInvoiceEdit?.Equals(other.AllowInvoiceEdit) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.BillCycleDay == null && other.BillCycleDay == null ||
                 this.BillCycleDay?.Equals(other.BillCycleDay) == true) &&
                (this.InvoiceDeliveryPrefsPrint == null && other.InvoiceDeliveryPrefsPrint == null ||
                 this.InvoiceDeliveryPrefsPrint?.Equals(other.InvoiceDeliveryPrefsPrint) == true) &&
                (this.InvoiceDeliveryPrefsEmail == null && other.InvoiceDeliveryPrefsEmail == null ||
                 this.InvoiceDeliveryPrefsEmail?.Equals(other.InvoiceDeliveryPrefsEmail) == true) &&
                (this.AutoPay == null && other.AutoPay == null ||
                 this.AutoPay?.Equals(other.AutoPay) == true) &&
                (this.PaymentTerm == null && other.PaymentTerm == null ||
                 this.PaymentTerm?.Equals(other.PaymentTerm) == true) &&
                (this.CommunicationProfileId == null && other.CommunicationProfileId == null ||
                 this.CommunicationProfileId?.Equals(other.CommunicationProfileId) == true) &&
                (this.Batch == null && other.Batch == null ||
                 this.Batch?.Equals(other.Batch) == true) &&
                (this.InvoiceTemplateId == null && other.InvoiceTemplateId == null ||
                 this.InvoiceTemplateId?.Equals(other.InvoiceTemplateId) == true) &&
                (this.DebitMemoTemplateId == null && other.DebitMemoTemplateId == null ||
                 this.DebitMemoTemplateId?.Equals(other.DebitMemoTemplateId) == true) &&
                (this.CreditMemoTemplateId == null && other.CreditMemoTemplateId == null ||
                 this.CreditMemoTemplateId?.Equals(other.CreditMemoTemplateId) == true) &&
                (this.BillToContact == null && other.BillToContact == null ||
                 this.BillToContact?.Equals(other.BillToContact) == true) &&
                (this.SoldToContact == null && other.SoldToContact == null ||
                 this.SoldToContact?.Equals(other.SoldToContact) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"AdditionalEmailAddresses = {this.AdditionalEmailAddresses ?? "null"}");
            toStringOutput.Add($"CustomerServiceRepName = {this.CustomerServiceRepName ?? "null"}");
            toStringOutput.Add($"PurchaseOrderNumber = {this.PurchaseOrderNumber ?? "null"}");
            toStringOutput.Add($"SalesRep = {this.SalesRep ?? "null"}");
            toStringOutput.Add($"SequenceSetId = {this.SequenceSetId ?? "null"}");
            toStringOutput.Add($"AllowInvoiceEdit = {(this.AllowInvoiceEdit == null ? "null" : this.AllowInvoiceEdit.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"BillCycleDay = {(this.BillCycleDay == null ? "null" : this.BillCycleDay.ToString())}");
            toStringOutput.Add($"InvoiceDeliveryPrefsPrint = {(this.InvoiceDeliveryPrefsPrint == null ? "null" : this.InvoiceDeliveryPrefsPrint.ToString())}");
            toStringOutput.Add($"InvoiceDeliveryPrefsEmail = {(this.InvoiceDeliveryPrefsEmail == null ? "null" : this.InvoiceDeliveryPrefsEmail.ToString())}");
            toStringOutput.Add($"AutoPay = {(this.AutoPay == null ? "null" : this.AutoPay.ToString())}");
            toStringOutput.Add($"PaymentTerm = {this.PaymentTerm ?? "null"}");
            toStringOutput.Add($"CommunicationProfileId = {this.CommunicationProfileId ?? "null"}");
            toStringOutput.Add($"Batch = {this.Batch ?? "null"}");
            toStringOutput.Add($"InvoiceTemplateId = {this.InvoiceTemplateId ?? "null"}");
            toStringOutput.Add($"DebitMemoTemplateId = {this.DebitMemoTemplateId ?? "null"}");
            toStringOutput.Add($"CreditMemoTemplateId = {this.CreditMemoTemplateId ?? "null"}");
            toStringOutput.Add($"BillToContact = {(this.BillToContact == null ? "null" : this.BillToContact.ToString())}");
            toStringOutput.Add($"SoldToContact = {(this.SoldToContact == null ? "null" : this.SoldToContact.ToString())}");
        }
    }
}