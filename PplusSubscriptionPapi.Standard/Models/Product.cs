// <copyright file="Product.cs" company="APIMatic">
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
    /// Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="isbn">isbn.</param>
        /// <param name="ppid">ppid.</param>
        /// <param name="duration">duration.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="tax">tax.</param>
        /// <param name="price">price.</param>
        public Product(
            string isbn = null,
            string ppid = null,
            double? duration = null,
            string endDate = null,
            double? tax = null,
            double? price = null)
        {
            this.Isbn = isbn;
            this.Ppid = ppid;
            this.Duration = duration;
            this.EndDate = endDate;
            this.Tax = tax;
            this.Price = price;
        }

        /// <summary>
        /// product isbn number
        /// </summary>
        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn { get; set; }

        /// <summary>
        /// product ppid number
        /// </summary>
        [JsonProperty("ppid", NullValueHandling = NullValueHandling.Ignore)]
        public string Ppid { get; set; }

        /// <summary>
        /// Duration of the entitlement in days for this product
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public double? Duration { get; set; }

        /// <summary>
        /// end date for the entitlement. in yyyy-MM-dd'T'HH:mm:ss.SSSZ format.
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// Cost of tax on the product
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax { get; set; }

        /// <summary>
        /// Cost of the product
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Product : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Product other &&
                (this.Isbn == null && other.Isbn == null ||
                 this.Isbn?.Equals(other.Isbn) == true) &&
                (this.Ppid == null && other.Ppid == null ||
                 this.Ppid?.Equals(other.Ppid) == true) &&
                (this.Duration == null && other.Duration == null ||
                 this.Duration?.Equals(other.Duration) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.Tax == null && other.Tax == null ||
                 this.Tax?.Equals(other.Tax) == true) &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Isbn = {this.Isbn ?? "null"}");
            toStringOutput.Add($"Ppid = {this.Ppid ?? "null"}");
            toStringOutput.Add($"Duration = {(this.Duration == null ? "null" : this.Duration.ToString())}");
            toStringOutput.Add($"EndDate = {this.EndDate ?? "null"}");
            toStringOutput.Add($"Tax = {(this.Tax == null ? "null" : this.Tax.ToString())}");
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
        }
    }
}