﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class ElasticPoolDatabaseActivitiesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivitiesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ElasticPoolDatabaseActivitiesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2014-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByElasticPoolRequestUri(string subscriptionId, string resourceGroupName, string serverName, string elasticPoolName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/elasticPools/", false);
            uri.AppendPath(elasticPoolName, true);
            uri.AppendPath("/elasticPoolDatabaseActivity", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByElasticPoolRequest(string subscriptionId, string resourceGroupName, string serverName, string elasticPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/servers/", false);
            uri.AppendPath(serverName, true);
            uri.AppendPath("/elasticPools/", false);
            uri.AppendPath(elasticPoolName, true);
            uri.AppendPath("/elasticPoolDatabaseActivity", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns activity on databases inside of an elastic pool. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="elasticPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ElasticPoolDatabaseActivityListResult>> ListByElasticPoolAsync(string subscriptionId, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var message = CreateListByElasticPoolRequest(subscriptionId, resourceGroupName, serverName, elasticPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticPoolDatabaseActivityListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ElasticPoolDatabaseActivityListResult.DeserializeElasticPoolDatabaseActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns activity on databases inside of an elastic pool. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="elasticPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="serverName"/> or <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ElasticPoolDatabaseActivityListResult> ListByElasticPool(string subscriptionId, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var message = CreateListByElasticPoolRequest(subscriptionId, resourceGroupName, serverName, elasticPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ElasticPoolDatabaseActivityListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ElasticPoolDatabaseActivityListResult.DeserializeElasticPoolDatabaseActivityListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
