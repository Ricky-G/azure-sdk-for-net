﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerCommunicationLinkResource"/> and their operations.
    /// Each <see cref="SqlServerCommunicationLinkResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="SqlServerCommunicationLinkCollection"/> instance call the GetSqlServerCommunicationLinks method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class SqlServerCommunicationLinkCollection : ArmCollection, IEnumerable<SqlServerCommunicationLinkResource>, IAsyncEnumerable<SqlServerCommunicationLinkResource>
    {
        private readonly ClientDiagnostics _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics;
        private readonly ServerCommunicationLinksRestOperations _sqlServerCommunicationLinkServerCommunicationLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerCommunicationLinkCollection"/> class for mocking. </summary>
        protected SqlServerCommunicationLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerCommunicationLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerCommunicationLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerCommunicationLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerCommunicationLinkResource.ResourceType, out string sqlServerCommunicationLinkServerCommunicationLinksApiVersion);
            _sqlServerCommunicationLinkServerCommunicationLinksRestClient = new ServerCommunicationLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerCommunicationLinkServerCommunicationLinksApiVersion);
#if DEBUG
            ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a server communication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="data"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SqlServerCommunicationLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string communicationLinkName, SqlServerCommunicationLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<SqlServerCommunicationLinkResource>(new SqlServerCommunicationLinkOperationSource(Client), _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics, Pipeline, _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a server communication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="data"> The required parameters for creating a server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SqlServerCommunicationLinkResource> CreateOrUpdate(WaitUntil waitUntil, string communicationLinkName, SqlServerCommunicationLinkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, data, cancellationToken);
                var operation = new SqlArmOperation<SqlServerCommunicationLinkResource>(new SqlServerCommunicationLinkOperationSource(Client), _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics, Pipeline, _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns a server communication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<Response<SqlServerCommunicationLinkResource>> GetAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerCommunicationLinkServerCommunicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerCommunicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a server communication link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<SqlServerCommunicationLinkResource> Get(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerCommunicationLinkServerCommunicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerCommunicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server communication links.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerCommunicationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerCommunicationLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new SqlServerCommunicationLinkResource(Client, SqlServerCommunicationLinkData.DeserializeSqlServerCommunicationLinkData(e)), _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics, Pipeline, "SqlServerCommunicationLinkCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets a list of server communication links.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerCommunicationLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerCommunicationLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerCommunicationLinkServerCommunicationLinksRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new SqlServerCommunicationLinkResource(Client, SqlServerCommunicationLinkData.DeserializeSqlServerCommunicationLinkData(e)), _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics, Pipeline, "SqlServerCommunicationLinkCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerCommunicationLinkServerCommunicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerCommunicationLinkServerCommunicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerCommunicationLinkResource>> GetIfExistsAsync(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerCommunicationLinkServerCommunicationLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerCommunicationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerCommunicationLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/communicationLinks/{communicationLinkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerCommunicationLinks_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2014-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerCommunicationLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationLinkName"> The name of the server communication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationLinkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationLinkName"/> is null. </exception>
        public virtual NullableResponse<SqlServerCommunicationLinkResource> GetIfExists(string communicationLinkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationLinkName, nameof(communicationLinkName));

            using var scope = _sqlServerCommunicationLinkServerCommunicationLinksClientDiagnostics.CreateScope("SqlServerCommunicationLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerCommunicationLinkServerCommunicationLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, communicationLinkName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerCommunicationLinkResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerCommunicationLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerCommunicationLinkResource> IEnumerable<SqlServerCommunicationLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerCommunicationLinkResource> IAsyncEnumerable<SqlServerCommunicationLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
