// <copyright file="SubscriptionSourceEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PearsonSubscriptionsAPI.Standard;
using PearsonSubscriptionsAPI.Standard.Utilities;

namespace PearsonSubscriptionsAPI.Standard.Models
{
    /// <summary>
    /// SubscriptionSourceEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSourceEnum
    {
        /// <summary>
        /// Internal.
        /// </summary>
        [EnumMember(Value = "Internal")]
        Internal,

        /// <summary>
        /// EnumPcom.
        /// </summary>
        [EnumMember(Value = "p.com")]
        EnumPcom
    }
}