// <copyright file="OrderTypeEnum.cs" company="APIMatic">
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
    /// OrderTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderTypeEnum
    {
        /// <summary>
        /// UPGRADE.
        /// </summary>
        [EnumMember(Value = "UPGRADE")]
        UPGRADE,

        /// <summary>
        /// DOWNGRADE.
        /// </summary>
        [EnumMember(Value = "DOWNGRADE")]
        DOWNGRADE,

        /// <summary>
        /// RENEWON.
        /// </summary>
        [EnumMember(Value = "RENEWON")]
        RENEWON,

        /// <summary>
        /// RENEWOFF.
        /// </summary>
        [EnumMember(Value = "RENEWOFF")]
        RENEWOFF,

        /// <summary>
        /// MIBUPGRADE.
        /// </summary>
        [EnumMember(Value = "MIBUPGRADE")]
        MIBUPGRADE,

        /// <summary>
        /// MIBRENEWON.
        /// </summary>
        [EnumMember(Value = "MIBRENEWON")]
        MIBRENEWON,

        /// <summary>
        /// MIBRENEWOFF.
        /// </summary>
        [EnumMember(Value = "MIBRENEWOFF")]
        MIBRENEWOFF
    }
}