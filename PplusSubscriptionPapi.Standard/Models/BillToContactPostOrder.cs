// <copyright file="BillToContactPostOrder.cs" company="APIMatic">
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
    /// BillToContactPostOrder.
    /// </summary>
    public class BillToContactPostOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillToContactPostOrder"/> class.
        /// </summary>
        public BillToContactPostOrder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillToContactPostOrder"/> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="county">county.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="personalEmail">personalEmail.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="state">state.</param>
        /// <param name="workEmail">workEmail.</param>
        /// <param name="workPhone">workPhone.</param>
        public BillToContactPostOrder(
            string address1 = null,
            string address2 = null,
            string city = null,
            string country = null,
            string county = null,
            string firstName = null,
            string lastName = null,
            string mobilePhone = null,
            string personalEmail = null,
            string postalCode = null,
            string state = null,
            string workEmail = null,
            string workPhone = null)
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.Country = country;
            this.County = county;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MobilePhone = mobilePhone;
            this.PersonalEmail = personalEmail;
            this.PostalCode = postalCode;
            this.State = state;
            this.WorkEmail = workEmail;
            this.WorkPhone = workPhone;
        }

        /// <summary>
        /// First line of the contact's address. This is often a street address or a business name.
        /// </summary>
        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; set; }

        /// <summary>
        /// Second line of the contact's address.
        /// </summary>
        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the contact's address.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Country; must be a valid country name or abbreviation. If using Zuora Tax, you must specify a country in the bill-to contact to calculate tax.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// County of the contact's address.
        /// </summary>
        [JsonProperty("county", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        /// <summary>
        /// First name of the contact.
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the contact.
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Mobile phone number of the contact.
        /// </summary>
        [JsonProperty("mobilePhone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Personal email address of the contact.
        /// </summary>
        [JsonProperty("personalEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalEmail { get; set; }

        /// <summary>
        /// ZIP code or other postal code of the contact's address.
        /// </summary>
        [JsonProperty("postalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }

        /// <summary>
        /// State or province of the contact's address.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Business email address of the contact.
        /// </summary>
        [JsonProperty("workEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkEmail { get; set; }

        /// <summary>
        /// Business phone number of the contact.
        /// </summary>
        [JsonProperty("workPhone", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkPhone { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillToContactPostOrder : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillToContactPostOrder other &&
                (this.Address1 == null && other.Address1 == null ||
                 this.Address1?.Equals(other.Address1) == true) &&
                (this.Address2 == null && other.Address2 == null ||
                 this.Address2?.Equals(other.Address2) == true) &&
                (this.City == null && other.City == null ||
                 this.City?.Equals(other.City) == true) &&
                (this.Country == null && other.Country == null ||
                 this.Country?.Equals(other.Country) == true) &&
                (this.County == null && other.County == null ||
                 this.County?.Equals(other.County) == true) &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.MobilePhone == null && other.MobilePhone == null ||
                 this.MobilePhone?.Equals(other.MobilePhone) == true) &&
                (this.PersonalEmail == null && other.PersonalEmail == null ||
                 this.PersonalEmail?.Equals(other.PersonalEmail) == true) &&
                (this.PostalCode == null && other.PostalCode == null ||
                 this.PostalCode?.Equals(other.PostalCode) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.WorkEmail == null && other.WorkEmail == null ||
                 this.WorkEmail?.Equals(other.WorkEmail) == true) &&
                (this.WorkPhone == null && other.WorkPhone == null ||
                 this.WorkPhone?.Equals(other.WorkPhone) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Address1 = {this.Address1 ?? "null"}");
            toStringOutput.Add($"Address2 = {this.Address2 ?? "null"}");
            toStringOutput.Add($"City = {this.City ?? "null"}");
            toStringOutput.Add($"Country = {this.Country ?? "null"}");
            toStringOutput.Add($"County = {this.County ?? "null"}");
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"MobilePhone = {this.MobilePhone ?? "null"}");
            toStringOutput.Add($"PersonalEmail = {this.PersonalEmail ?? "null"}");
            toStringOutput.Add($"PostalCode = {this.PostalCode ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"WorkEmail = {this.WorkEmail ?? "null"}");
            toStringOutput.Add($"WorkPhone = {this.WorkPhone ?? "null"}");
        }
    }
}