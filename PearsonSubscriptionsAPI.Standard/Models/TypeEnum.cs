// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// CreateSubscription.
        /// </summary>
        [EnumMember(Value = "CreateSubscription")]
        CreateSubscription,

        /// <summary>
        /// AddProduct.
        /// </summary>
        [EnumMember(Value = "AddProduct")]
        AddProduct,

        /// <summary>
        /// RemoveProduct.
        /// </summary>
        [EnumMember(Value = "RemoveProduct")]
        RemoveProduct,

        /// <summary>
        /// RenewSubscription.
        /// </summary>
        [EnumMember(Value = "RenewSubscription")]
        RenewSubscription,

        /// <summary>
        /// TermsAndConditions.
        /// </summary>
        [EnumMember(Value = "TermsAndConditions")]
        TermsAndConditions
    }
}