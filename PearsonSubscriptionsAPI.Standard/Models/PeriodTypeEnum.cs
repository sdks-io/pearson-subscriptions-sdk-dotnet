// <copyright file="PeriodTypeEnum.cs" company="APIMatic">
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
    /// PeriodTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeriodTypeEnum
    {
        /// <summary>
        /// Month.
        /// </summary>
        [EnumMember(Value = "Month")]
        Month,

        /// <summary>
        /// Year.
        /// </summary>
        [EnumMember(Value = "Year")]
        Year,

        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "Day")]
        Day,

        /// <summary>
        /// Week.
        /// </summary>
        [EnumMember(Value = "Week")]
        Week
    }
}