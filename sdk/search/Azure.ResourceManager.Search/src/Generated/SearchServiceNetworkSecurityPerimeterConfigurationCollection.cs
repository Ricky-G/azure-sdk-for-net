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

namespace Azure.ResourceManager.Search
{
    /// <summary>
    /// A class representing a collection of <see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/> and their operations.
    /// Each <see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/> in the collection will belong to the same instance of <see cref="SearchServiceResource"/>.
    /// To get a <see cref="SearchServiceNetworkSecurityPerimeterConfigurationCollection"/> instance call the GetSearchServiceNetworkSecurityPerimeterConfigurations method from an instance of <see cref="SearchServiceResource"/>.
    /// </summary>
    public partial class SearchServiceNetworkSecurityPerimeterConfigurationCollection : ArmCollection, IEnumerable<SearchServiceNetworkSecurityPerimeterConfigurationResource>, IAsyncEnumerable<SearchServiceNetworkSecurityPerimeterConfigurationResource>
    {
        private readonly ClientDiagnostics _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics;
        private readonly NetworkSecurityPerimeterConfigurationsRestOperations _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SearchServiceNetworkSecurityPerimeterConfigurationCollection"/> class for mocking. </summary>
        protected SearchServiceNetworkSecurityPerimeterConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SearchServiceNetworkSecurityPerimeterConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SearchServiceNetworkSecurityPerimeterConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Search", SearchServiceNetworkSecurityPerimeterConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SearchServiceNetworkSecurityPerimeterConfigurationResource.ResourceType, out string searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
            _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient = new NetworkSecurityPerimeterConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SearchServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SearchServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a network security perimeter configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual async Task<Response<SearchServiceNetworkSecurityPerimeterConfigurationResource>> GetAsync(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network security perimeter configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual Response<SearchServiceNetworkSecurityPerimeterConfigurationResource> Get(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of network security perimeter configurations for a search service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SearchServiceNetworkSecurityPerimeterConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, SearchServiceNetworkSecurityPerimeterConfigurationData.DeserializeSearchServiceNetworkSecurityPerimeterConfigurationData(e)), _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, "SearchServiceNetworkSecurityPerimeterConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of network security perimeter configurations for a search service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SearchServiceNetworkSecurityPerimeterConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, SearchServiceNetworkSecurityPerimeterConfigurationData.DeserializeSearchServiceNetworkSecurityPerimeterConfigurationData(e)), _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, "SearchServiceNetworkSecurityPerimeterConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual Response<bool> Exists(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual async Task<NullableResponse<SearchServiceNetworkSecurityPerimeterConfigurationResource>> GetIfExistsAsync(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SearchServiceNetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{searchServiceName}/networkSecurityPerimeterConfigurations/{nspConfigName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SearchServiceNetworkSecurityPerimeterConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nspConfigName"> The network security perimeter configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nspConfigName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nspConfigName"/> is null. </exception>
        public virtual NullableResponse<SearchServiceNetworkSecurityPerimeterConfigurationResource> GetIfExists(string nspConfigName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nspConfigName, nameof(nspConfigName));

            using var scope = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("SearchServiceNetworkSecurityPerimeterConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _searchServiceNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nspConfigName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SearchServiceNetworkSecurityPerimeterConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SearchServiceNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SearchServiceNetworkSecurityPerimeterConfigurationResource> IEnumerable<SearchServiceNetworkSecurityPerimeterConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SearchServiceNetworkSecurityPerimeterConfigurationResource> IAsyncEnumerable<SearchServiceNetworkSecurityPerimeterConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
