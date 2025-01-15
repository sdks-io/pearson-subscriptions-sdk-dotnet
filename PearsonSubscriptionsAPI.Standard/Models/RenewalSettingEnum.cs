// <copyright file="RenewalSettingEnum.cs" company="APIMatic">
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
    /// RenewalSettingEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RenewalSettingEnum
    {
        /// <summary>
        /// RENEWWITHSPECIFICTERM.
        /// </summary>
        [EnumMember(Value = "RENEW_WITH_SPECIFIC_TERM")]
        RENEWWITHSPECIFICTERM,

        /// <summary>
        /// RENEWTOEVERGREEN.
        /// </summary>
        [EnumMember(Value = "RENEW_TO_EVERGREEN")]
        RENEWTOEVERGREEN
    }
}