// <copyright file="SubscriptionsController.cs" company="APIMatic">
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
using PplusSubscriptionPapi.Standard.Exceptions;
using PplusSubscriptionPapi.Standard.Http.Client;
using PplusSubscriptionPapi.Standard.Utilities;
using System.Net.Http;

namespace PplusSubscriptionPapi.Standard.Controllers
{
    /// <summary>
    /// SubscriptionsController.
    /// </summary>
    public class SubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsController"/> class.
        /// </summary>
        internal SubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// UpdateSubscription EndPoint.
        /// </summary>
        /// <param name="xUserId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <returns>Returns the Models.OrderRespType response from the API call.</returns>
        public Models.OrderRespType UpdateSubscription(
                string xUserId,
                string xAuthorization,
                Models.UpdateSubscription body,
                string xTransactionId = null)
            => CoreHelper.RunTask(UpdateSubscriptionAsync(xUserId, xAuthorization, body, xTransactionId));

        /// <summary>
        /// UpdateSubscription EndPoint.
        /// </summary>
        /// <param name="xUserId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrderRespType response from the API call.</returns>
        public async Task<Models.OrderRespType> UpdateSubscriptionAsync(
                string xUserId,
                string xAuthorization,
                Models.UpdateSubscription body,
                string xTransactionId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderRespType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/mojo/aggregate-subscription")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("X-UserId", xUserId))
                      .Header(_header => _header.Setup("X-Authorization", xAuthorization))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-TransactionId", xTransactionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new InvalidReqTypeException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new AuthErrorTypeException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Error", (_reason, _context) => new OrderErrorTypeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel subscription for a given subscription ID.
        /// </summary>
        /// <param name="userId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <param name="origin">Optional parameter: Originating System.</param>
        /// <returns>Returns the Models.CancelResType response from the API call.</returns>
        public Models.CancelResType CancelSubscription(
                string userId,
                string xAuthorization,
                Models.CancelReqType body,
                string xTransactionId = null,
                string origin = null)
            => CoreHelper.RunTask(CancelSubscriptionAsync(userId, xAuthorization, body, xTransactionId, origin));

        /// <summary>
        /// Cancel subscription for a given subscription ID.
        /// </summary>
        /// <param name="userId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <param name="origin">Optional parameter: Originating System.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CancelResType response from the API call.</returns>
        public async Task<Models.CancelResType> CancelSubscriptionAsync(
                string userId,
                string xAuthorization,
                Models.CancelReqType body,
                string xTransactionId = null,
                string origin = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelResType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v1/subscriptions/cancel")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("userId", userId))
                      .Header(_header => _header.Setup("X-Authorization", xAuthorization))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-TransactionId", xTransactionId))
                      .Header(_header => _header.Setup("origin", origin))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new InvalidReqTypeException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new AuthErrorTypeException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Error", (_reason, _context) => new OrderErrorTypeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// AggregateSubscription EndPoint.
        /// </summary>
        /// <param name="xUserId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <returns>Returns the Models.OrderRespType response from the API call.</returns>
        public Models.OrderRespType AggregateSubscription(
                string xUserId,
                string xAuthorization,
                Models.OrderRequestType body,
                string xTransactionId = null)
            => CoreHelper.RunTask(AggregateSubscriptionAsync(xUserId, xAuthorization, body, xTransactionId));

        /// <summary>
        /// AggregateSubscription EndPoint.
        /// </summary>
        /// <param name="xUserId">Required parameter: UserId of an user who bought a subscription. This will be an IES userId.</param>
        /// <param name="xAuthorization">Required parameter: This will be an IES system token.</param>
        /// <param name="body">Required parameter: Data.</param>
        /// <param name="xTransactionId">Optional parameter: Unique ID for a transaction.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OrderRespType response from the API call.</returns>
        public async Task<Models.OrderRespType> AggregateSubscriptionAsync(
                string xUserId,
                string xAuthorization,
                Models.OrderRequestType body,
                string xTransactionId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OrderRespType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/mojo/aggregate-subscription")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("X-UserId", xUserId))
                      .Header(_header => _header.Setup("X-Authorization", xAuthorization))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-TransactionId", xTransactionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new InvalidReqTypeException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new AuthErrorTypeException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Error", (_reason, _context) => new OrderRespTypeErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Expire subscription for all past enddate internal and IA subscriptions.
        /// </summary>
        /// <returns>Returns the Models.CancelResType response from the API call.</returns>
        public Models.CancelResType ExpireSubscriptions()
            => CoreHelper.RunTask(ExpireSubscriptionsAsync());

        /// <summary>
        /// Expire subscription for all past enddate internal and IA subscriptions.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CancelResType response from the API call.</returns>
        public async Task<Models.CancelResType> ExpireSubscriptionsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelResType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/subscriptions/expiry"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new InvalidReqTypeException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new AuthErrorTypeException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Error", (_reason, _context) => new OrderErrorTypeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}