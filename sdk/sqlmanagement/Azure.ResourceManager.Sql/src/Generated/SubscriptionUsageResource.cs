// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SubscriptionUsage along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionUsageResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionUsageResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSubscriptionUsage method.
    /// </summary>
    public partial class SubscriptionUsageResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionUsageResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        /// <param name="usageName"> The usageName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation locationName, string usageName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionUsageClientDiagnostics;
        private readonly SubscriptionUsagesRestOperations _subscriptionUsageRestClient;
        private readonly SubscriptionUsageData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/locations/usages";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageResource"/> class for mocking. </summary>
        protected SubscriptionUsageResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionUsageResource(ArmClient client, SubscriptionUsageData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionUsageResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionUsageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionUsageApiVersion);
            _subscriptionUsageRestClient = new SubscriptionUsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionUsageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionUsageData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionUsageResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionUsageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionUsageResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
