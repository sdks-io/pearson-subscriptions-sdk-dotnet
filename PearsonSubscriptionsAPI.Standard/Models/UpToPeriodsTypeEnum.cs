// <copyright file="UpToPeriodsTypeEnum.cs" company="APIMatic">
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
    /// UpToPeriodsTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpToPeriodsTypeEnum
    {
        /// <summary>
        /// BillingPeriods.
        /// </summary>
        [EnumMember(Value = "Billing_Periods")]
        BillingPeriods,

        /// <summary>
        /// Days.
        /// </summary>
        [EnumMember(Value = "Days")]
        Days,

        /// <summary>
        /// Weeks.
        /// </summary>
        [EnumMember(Value = "Weeks")]
        Weeks,

        /// <summary>
        /// Months.
        /// </summary>
        [EnumMember(Value = "Months")]
        Months,

        /// <summary>
        /// Years.
        /// </summary>
        [EnumMember(Value = "Years")]
        Years
    }
}