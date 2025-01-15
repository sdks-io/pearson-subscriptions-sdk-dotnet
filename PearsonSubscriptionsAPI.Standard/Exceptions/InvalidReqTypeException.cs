// <copyright file="InvalidReqTypeException.cs" company="APIMatic">
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
using PearsonSubscriptionsAPI.Standard.Http.Client;
using PearsonSubscriptionsAPI.Standard.Models;
using PearsonSubscriptionsAPI.Standard.Utilities;

namespace PearsonSubscriptionsAPI.Standard.Exceptions
{
    /// <summary>
    /// InvalidReqTypeException.
    /// </summary>
    public class InvalidReqTypeException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidReqTypeException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public InvalidReqTypeException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets InvalidReqTypeError.
        /// </summary>
        [JsonProperty("InvalidReqTypeError", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvalidReqTypeError InvalidReqTypeError { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvalidReqTypeException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"InvalidReqTypeError = {(this.InvalidReqTypeError == null ? "null" : this.InvalidReqTypeError.ToString())}");
        }
    }
}