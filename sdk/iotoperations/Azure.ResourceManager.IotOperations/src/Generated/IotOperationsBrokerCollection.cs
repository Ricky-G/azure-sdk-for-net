// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.IotOperations
{
    /// <summary>
    /// A class representing a collection of <see cref="IotOperationsBrokerResource"/> and their operations.
    /// Each <see cref="IotOperationsBrokerResource"/> in the collection will belong to the same instance of <see cref="IotOperationsInstanceResource"/>.
    /// To get an <see cref="IotOperationsBrokerCollection"/> instance call the GetIotOperationsBrokers method from an instance of <see cref="IotOperationsInstanceResource"/>.
    /// </summary>
    public partial class IotOperationsBrokerCollection : ArmCollection, IEnumerable<IotOperationsBrokerResource>, IAsyncEnumerable<IotOperationsBrokerResource>
    {
        private readonly ClientDiagnostics _iotOperationsBrokerBrokerClientDiagnostics;
        private readonly BrokerRestOperations _iotOperationsBrokerBrokerRestClient;

        /// <summary> Initializes a new instance of the <see cref="IotOperationsBrokerCollection"/> class for mocking. </summary>
        protected IotOperationsBrokerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotOperationsBrokerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IotOperationsBrokerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotOperationsBrokerBrokerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotOperations", IotOperationsBrokerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IotOperationsBrokerResource.ResourceType, out string iotOperationsBrokerBrokerApiVersion);
            _iotOperationsBrokerBrokerRestClient = new BrokerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotOperationsBrokerBrokerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != IotOperationsInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, IotOperationsInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a BrokerResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IotOperationsBrokerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string brokerName, IotOperationsBrokerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerBrokerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new IotOperationsArmOperation<IotOperationsBrokerResource>(new IotOperationsBrokerOperationSource(Client), _iotOperationsBrokerBrokerClientDiagnostics, Pipeline, _iotOperationsBrokerBrokerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a BrokerResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IotOperationsBrokerResource> CreateOrUpdate(WaitUntil waitUntil, string brokerName, IotOperationsBrokerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerBrokerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, data, cancellationToken);
                var operation = new IotOperationsArmOperation<IotOperationsBrokerResource>(new IotOperationsBrokerOperationSource(Client), _iotOperationsBrokerBrokerClientDiagnostics, Pipeline, _iotOperationsBrokerBrokerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a BrokerResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual async Task<Response<IotOperationsBrokerResource>> GetAsync(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.Get");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerBrokerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a BrokerResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual Response<IotOperationsBrokerResource> Get(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.Get");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerBrokerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List BrokerResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotOperationsBrokerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotOperationsBrokerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotOperationsBrokerBrokerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotOperationsBrokerBrokerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotOperationsBrokerResource(Client, IotOperationsBrokerData.DeserializeIotOperationsBrokerData(e)), _iotOperationsBrokerBrokerClientDiagnostics, Pipeline, "IotOperationsBrokerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List BrokerResource resources by InstanceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotOperationsBrokerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotOperationsBrokerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _iotOperationsBrokerBrokerRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _iotOperationsBrokerBrokerRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotOperationsBrokerResource(Client, IotOperationsBrokerData.DeserializeIotOperationsBrokerData(e)), _iotOperationsBrokerBrokerClientDiagnostics, Pipeline, "IotOperationsBrokerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerBrokerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual Response<bool> Exists(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.Exists");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerBrokerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual async Task<NullableResponse<IotOperationsBrokerResource>> GetIfExistsAsync(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _iotOperationsBrokerBrokerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IotOperationsBrokerResource>(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTOperations/instances/{instanceName}/brokers/{brokerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BrokerResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsBrokerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="brokerName"> Name of broker. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="brokerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerName"/> is null. </exception>
        public virtual NullableResponse<IotOperationsBrokerResource> GetIfExists(string brokerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(brokerName, nameof(brokerName));

            using var scope = _iotOperationsBrokerBrokerClientDiagnostics.CreateScope("IotOperationsBrokerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _iotOperationsBrokerBrokerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, brokerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IotOperationsBrokerResource>(response.GetRawResponse());
                return Response.FromValue(new IotOperationsBrokerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IotOperationsBrokerResource> IEnumerable<IotOperationsBrokerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IotOperationsBrokerResource> IAsyncEnumerable<IotOperationsBrokerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
