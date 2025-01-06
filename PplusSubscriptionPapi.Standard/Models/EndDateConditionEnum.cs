// <copyright file="EndDateConditionEnum.cs" company="APIMatic">
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
    /// EndDateConditionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EndDateConditionEnum
    {
        /// <summary>
        /// SubscriptionEnd.
        /// </summary>
        [EnumMember(Value = "Subscription_End")]
        SubscriptionEnd,

        /// <summary>
        /// FixedPeriod.
        /// </summary>
        [EnumMember(Value = "Fixed_Period")]
        FixedPeriod,

        /// <summary>
        /// SpecificEndDate.
        /// </summary>
        [EnumMember(Value = "Specific_End_Date")]
        SpecificEndDate
    }
}