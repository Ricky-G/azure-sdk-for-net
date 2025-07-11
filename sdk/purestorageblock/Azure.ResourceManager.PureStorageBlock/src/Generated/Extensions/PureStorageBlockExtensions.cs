// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.PureStorageBlock.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PureStorageBlock
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PureStorageBlock. </summary>
    public static partial class PureStorageBlockExtensions
    {
        private static MockablePureStorageBlockArmClient GetMockablePureStorageBlockArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockablePureStorageBlockArmClient(client0));
        }

        private static MockablePureStorageBlockResourceGroupResource GetMockablePureStorageBlockResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePureStorageBlockResourceGroupResource(client, resource.Id));
        }

        private static MockablePureStorageBlockSubscriptionResource GetMockablePureStorageBlockSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockablePureStorageBlockSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageReservationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageReservationResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageReservationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStorageReservationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStorageReservationResource"/> object. </returns>
        public static PureStorageReservationResource GetPureStorageReservationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStorageReservationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStoragePoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStoragePoolResource.CreateResourceIdentifier" /> to create a <see cref="PureStoragePoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStoragePoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStoragePoolResource"/> object. </returns>
        public static PureStoragePoolResource GetPureStoragePoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStoragePoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsStorageContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsStorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsStorageContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStorageAvsStorageContainerResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStorageAvsStorageContainerResource"/> object. </returns>
        public static PureStorageAvsStorageContainerResource GetPureStorageAvsStorageContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStorageAvsStorageContainerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsStorageContainerVolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsStorageContainerVolumeResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsStorageContainerVolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStorageAvsStorageContainerVolumeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStorageAvsStorageContainerVolumeResource"/> object. </returns>
        public static PureStorageAvsStorageContainerVolumeResource GetPureStorageAvsStorageContainerVolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStorageAvsStorageContainerVolumeResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsVmResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsVmResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsVmResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStorageAvsVmResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStorageAvsVmResource"/> object. </returns>
        public static PureStorageAvsVmResource GetPureStorageAvsVmResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStorageAvsVmResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsVmVolumeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsVmVolumeResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsVmVolumeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockArmClient.GetPureStorageAvsVmVolumeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="PureStorageAvsVmVolumeResource"/> object. </returns>
        public static PureStorageAvsVmVolumeResource GetPureStorageAvsVmVolumeResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockablePureStorageBlockArmClient(client).GetPureStorageAvsVmVolumeResource(id);
        }

        /// <summary>
        /// Gets a collection of PureStorageReservationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStorageReservations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of PureStorageReservationResources and their operations over a PureStorageReservationResource. </returns>
        public static PureStorageReservationCollection GetPureStorageReservations(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStorageReservations();
        }

        /// <summary>
        /// Get a reservation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/reservations/{reservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageReservationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStorageReservationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="reservationName"> Name of the reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="reservationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PureStorageReservationResource>> GetPureStorageReservationAsync(this ResourceGroupResource resourceGroupResource, string reservationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStorageReservationAsync(reservationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a reservation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/reservations/{reservationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageReservationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStorageReservation(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="reservationName"> Name of the reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="reservationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PureStorageReservationResource> GetPureStorageReservation(this ResourceGroupResource resourceGroupResource, string reservationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStorageReservation(reservationName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of PureStoragePoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStoragePools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of PureStoragePoolResources and their operations over a PureStoragePoolResource. </returns>
        public static PureStoragePoolCollection GetPureStoragePools(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStoragePools();
        }

        /// <summary>
        /// Get a storage pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StoragePool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStoragePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStoragePoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storagePoolName"> Name of the storage pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="storagePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storagePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PureStoragePoolResource>> GetPureStoragePoolAsync(this ResourceGroupResource resourceGroupResource, string storagePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStoragePoolAsync(storagePoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a storage pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/PureStorage.Block/storagePools/{storagePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StoragePool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStoragePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockResourceGroupResource.GetPureStoragePool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storagePoolName"> Name of the storage pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="storagePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="storagePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<PureStoragePoolResource> GetPureStoragePool(this ResourceGroupResource resourceGroupResource, string storagePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockablePureStorageBlockResourceGroupResource(resourceGroupResource).GetPureStoragePool(storagePoolName, cancellationToken);
        }

        /// <summary>
        /// List reservations by Azure subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PureStorage.Block/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageReservationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockSubscriptionResource.GetPureStorageReservations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="PureStorageReservationResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PureStorageReservationResource> GetPureStorageReservationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePureStorageBlockSubscriptionResource(subscriptionResource).GetPureStorageReservationsAsync(cancellationToken);
        }

        /// <summary>
        /// List reservations by Azure subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PureStorage.Block/reservations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Reservation_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStorageReservationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockSubscriptionResource.GetPureStorageReservations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="PureStorageReservationResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PureStorageReservationResource> GetPureStorageReservations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePureStorageBlockSubscriptionResource(subscriptionResource).GetPureStorageReservations(cancellationToken);
        }

        /// <summary>
        /// List storage pools by Azure subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PureStorage.Block/storagePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StoragePool_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStoragePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockSubscriptionResource.GetPureStoragePools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="PureStoragePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PureStoragePoolResource> GetPureStoragePoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePureStorageBlockSubscriptionResource(subscriptionResource).GetPureStoragePoolsAsync(cancellationToken);
        }

        /// <summary>
        /// List storage pools by Azure subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/PureStorage.Block/storagePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StoragePool_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PureStoragePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockablePureStorageBlockSubscriptionResource.GetPureStoragePools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="PureStoragePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PureStoragePoolResource> GetPureStoragePools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockablePureStorageBlockSubscriptionResource(subscriptionResource).GetPureStoragePools(cancellationToken);
        }
    }
}
