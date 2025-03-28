// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableRedisSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _redisClientDiagnostics;
        private RedisRestOperations _redisRestClient;
        private ClientDiagnostics _asyncOperationStatusClientDiagnostics;
        private AsyncOperationStatusRestOperations _asyncOperationStatusRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableRedisSubscriptionResource"/> class for mocking. </summary>
        protected MockableRedisSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRedisSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRedisSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics RedisClientDiagnostics => _redisClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Redis", RedisResource.ResourceType.Namespace, Diagnostics);
        private RedisRestOperations RedisRestClient => _redisRestClient ??= new RedisRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RedisResource.ResourceType));
        private ClientDiagnostics AsyncOperationStatusClientDiagnostics => _asyncOperationStatusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Redis", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AsyncOperationStatusRestOperations AsyncOperationStatusRestClient => _asyncOperationStatusRestClient ??= new AsyncOperationStatusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is 'Microsoft.Cache/redis'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response> CheckRedisNameAvailabilityAsync(RedisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = RedisClientDiagnostics.CreateScope("MockableRedisSubscriptionResource.CheckRedisNameAvailability");
            scope.Start();
            try
            {
                var response = await RedisRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the redis cache name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_CheckNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters supplied to the CheckNameAvailability Redis operation. The only supported resource type is 'Microsoft.Cache/redis'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response CheckRedisNameAvailability(RedisNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = RedisClientDiagnostics.CreateScope("MockableRedisSubscriptionResource.CheckRedisNameAvailability");
            scope.Start();
            try
            {
                var response = RedisRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisResource> GetAllRedisAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RedisRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RedisRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RedisResource(Client, RedisData.DeserializeRedisData(e)), RedisClientDiagnostics, Pipeline, "MockableRedisSubscriptionResource.GetAllRedis", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all Redis caches in the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/redis</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisResource> GetAllRedis(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RedisRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RedisRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RedisResource(Client, RedisData.DeserializeRedisData(e)), RedisClientDiagnostics, Pipeline, "MockableRedisSubscriptionResource.GetAllRedis", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AsyncOperationStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual async Task<Response<RedisOperationStatus>> GetAsyncOperationStatusAsync(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = AsyncOperationStatusClientDiagnostics.CreateScope("MockableRedisSubscriptionResource.GetAsyncOperationStatus");
            scope.Start();
            try
            {
                var response = await AsyncOperationStatusRestClient.GetAsync(Id.SubscriptionId, location, operationId, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// For checking the ongoing status of an operation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Cache/locations/{location}/asyncOperations/{operationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AsyncOperationStatus_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location at which operation was triggered. </param>
        /// <param name="operationId"> The ID of asynchronous operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public virtual Response<RedisOperationStatus> GetAsyncOperationStatus(AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var scope = AsyncOperationStatusClientDiagnostics.CreateScope("MockableRedisSubscriptionResource.GetAsyncOperationStatus");
            scope.Start();
            try
            {
                var response = AsyncOperationStatusRestClient.Get(Id.SubscriptionId, location, operationId, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
