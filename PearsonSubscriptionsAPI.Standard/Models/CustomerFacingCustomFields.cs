// <copyright file="CustomerFacingCustomFields.cs" company="APIMatic">
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
    /// CustomerFacingCustomFields.
    /// </summary>
    public class CustomerFacingCustomFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFacingCustomFields"/> class.
        /// </summary>
        public CustomerFacingCustomFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFacingCustomFields"/> class.
        /// </summary>
        /// <param name="customerFacingC">customerFacing__c.</param>
        public CustomerFacingCustomFields(
            string customerFacingC = null)
        {
            this.CustomerFacingC = customerFacingC;
        }

        /// <summary>
        /// Gets or sets CustomerFacingC.
        /// </summary>
        [JsonProperty("customerFacing__c", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerFacingC { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomerFacingCustomFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomerFacingCustomFields other &&
                (this.CustomerFacingC == null && other.CustomerFacingC == null ||
                 this.CustomerFacingC?.Equals(other.CustomerFacingC) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CustomerFacingC = {this.CustomerFacingC ?? "null"}");
        }
    }
}