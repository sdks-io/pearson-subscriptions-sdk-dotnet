// <copyright file="CancelResType.cs" company="APIMatic">
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
    /// CancelResType.
    /// </summary>
    public class CancelResType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelResType"/> class.
        /// </summary>
        public CancelResType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelResType"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        public CancelResType(
            string message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Response Message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CancelResType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancelResType other &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Message = {this.Message ?? "null"}");
        }
    }
}