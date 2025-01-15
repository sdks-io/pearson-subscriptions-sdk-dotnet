// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Http.Configuration;
using APIMatic.Core.Response;
using PearsonSubscriptionsAPI.Standard.Exceptions;
using PearsonSubscriptionsAPI.Standard.Http.Client;
using PearsonSubscriptionsAPI.Standard.Http.Request;
using PearsonSubscriptionsAPI.Standard.Http.Response;
using PearsonSubscriptionsAPI.Standard.Utilities;
using System;

namespace PearsonSubscriptionsAPI.Standard.Controllers
{
    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    public class BaseController
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        internal BaseController(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>(ArraySerialization arraySerialization = ArraySerialization.Indexed)
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory,
                serialization: arraySerialization
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
    }
}