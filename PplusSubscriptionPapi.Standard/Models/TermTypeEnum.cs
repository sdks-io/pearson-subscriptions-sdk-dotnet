// <copyright file="TermTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PplusSubscriptionPapi.Standard;
using PplusSubscriptionPapi.Standard.Utilities;

namespace PplusSubscriptionPapi.Standard.Models
{
    /// <summary>
    /// TermTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TermTypeEnum
    {
        /// <summary>
        /// TERMED.
        /// </summary>
        [EnumMember(Value = "TERMED")]
        TERMED,

        /// <summary>
        /// EVERGREEN.
        /// </summary>
        [EnumMember(Value = "EVERGREEN")]
        EVERGREEN
    }
}