// <copyright file="CodeEnum.cs" company="APIMatic">
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
    /// CodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodeEnum
    {
        /// <summary>
        /// E01.
        /// </summary>
        [EnumMember(Value = "E01")]
        E01,

        /// <summary>
        /// E40.
        /// </summary>
        [EnumMember(Value = "E40")]
        E40,

        /// <summary>
        /// E41.
        /// </summary>
        [EnumMember(Value = "E41")]
        E41
    }
}