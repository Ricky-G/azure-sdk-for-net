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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SqlServerDatabaseRestorePointResource"/> and their operations.
    /// Each <see cref="SqlServerDatabaseRestorePointResource"/> in the collection will belong to the same instance of <see cref="SqlDatabaseResource"/>.
    /// To get a <see cref="SqlServerDatabaseRestorePointCollection"/> instance call the GetSqlServerDatabaseRestorePoints method from an instance of <see cref="SqlDatabaseResource"/>.
    /// </summary>
    public partial class SqlServerDatabaseRestorePointCollection : ArmCollection, IEnumerable<SqlServerDatabaseRestorePointResource>, IAsyncEnumerable<SqlServerDatabaseRestorePointResource>
    {
        private readonly ClientDiagnostics _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics;
        private readonly RestorePointsRestOperations _sqlServerDatabaseRestorePointRestorePointsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlServerDatabaseRestorePointCollection"/> class for mocking. </summary>
        protected SqlServerDatabaseRestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerDatabaseRestorePointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SqlServerDatabaseRestorePointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SqlServerDatabaseRestorePointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SqlServerDatabaseRestorePointResource.ResourceType, out string sqlServerDatabaseRestorePointRestorePointsApiVersion);
            _sqlServerDatabaseRestorePointRestorePointsRestClient = new RestorePointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerDatabaseRestorePointRestorePointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a restore point.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<SqlServerDatabaseRestorePointResource>> GetAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseRestorePointRestorePointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseRestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a restore point.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<SqlServerDatabaseRestorePointResource> Get(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseRestorePointRestorePointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseRestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of database restore points.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlServerDatabaseRestorePointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlServerDatabaseRestorePointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDatabaseRestorePointRestorePointsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDatabaseRestorePointRestorePointsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SqlServerDatabaseRestorePointResource(Client, SqlServerDatabaseRestorePointData.DeserializeSqlServerDatabaseRestorePointData(e)), _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics, Pipeline, "SqlServerDatabaseRestorePointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of database restore points.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_ListByDatabase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlServerDatabaseRestorePointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlServerDatabaseRestorePointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sqlServerDatabaseRestorePointRestorePointsRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sqlServerDatabaseRestorePointRestorePointsRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SqlServerDatabaseRestorePointResource(Client, SqlServerDatabaseRestorePointData.DeserializeSqlServerDatabaseRestorePointData(e)), _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics, Pipeline, "SqlServerDatabaseRestorePointCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseRestorePointRestorePointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseRestorePointRestorePointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<NullableResponse<SqlServerDatabaseRestorePointResource>> GetIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlServerDatabaseRestorePointRestorePointsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDatabaseRestorePointResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseRestorePointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/restorePoints/{restorePointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorePoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SqlServerDatabaseRestorePointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual NullableResponse<SqlServerDatabaseRestorePointResource> GetIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _sqlServerDatabaseRestorePointRestorePointsClientDiagnostics.CreateScope("SqlServerDatabaseRestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlServerDatabaseRestorePointRestorePointsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, restorePointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SqlServerDatabaseRestorePointResource>(response.GetRawResponse());
                return Response.FromValue(new SqlServerDatabaseRestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SqlServerDatabaseRestorePointResource> IEnumerable<SqlServerDatabaseRestorePointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlServerDatabaseRestorePointResource> IAsyncEnumerable<SqlServerDatabaseRestorePointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
