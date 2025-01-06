// <copyright file="HealthController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using PplusSubscriptionPapi.Standard;
using PplusSubscriptionPapi.Standard.Http.Client;
using PplusSubscriptionPapi.Standard.Utilities;
using System.Net.Http;

namespace PplusSubscriptionPapi.Standard.Controllers
{
    /// <summary>
    /// HealthController.
    /// </summary>
    public class HealthController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthController"/> class.
        /// </summary>
        internal HealthController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// HealthCheck EndPoint.
        /// </summary>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic HealthCheck()
            => CoreHelper.RunTask(HealthCheckAsync());

        /// <summary>
        /// HealthCheck EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> HealthCheckAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<dynamic>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/health-check"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}