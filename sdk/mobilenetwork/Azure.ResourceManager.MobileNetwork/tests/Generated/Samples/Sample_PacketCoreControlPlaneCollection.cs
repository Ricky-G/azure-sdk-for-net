// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_PacketCoreControlPlaneCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreatePacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneCreate.json
            // this example is just showing the usage of "PacketCoreControlPlanes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PacketCoreControlPlaneResource
            PacketCoreControlPlaneCollection collection = resourceGroupResource.GetPacketCoreControlPlanes();

            // invoke the operation
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            PacketCoreControlPlaneData data = new PacketCoreControlPlaneData(
                new AzureLocation("eastus"),
                new WritableSubResource[]
            {
new WritableSubResource
{
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.MobileNetwork/mobileNetworks/testMobileNetwork/sites/testSite"),
}
            },
                new MobileNetworkPlatformConfiguration(MobileNetworkPlatformType.AksHci)
                {
                    AzureStackEdgeDeviceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.DataBoxEdge/dataBoxEdgeDevices/TestAzureStackEdgeDevice"),
                    ConnectedClusterId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Kubernetes/connectedClusters/TestConnectedCluster"),
                    CustomLocationId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ExtendedLocation/customLocations/TestCustomLocation"),
                },
                new MobileNetworkInterfaceProperties
                {
                    Name = "N2",
                },
                MobileNetworkBillingSku.G0,
                new MobileNetworkLocalDiagnosticsAccessConfiguration(MobileNetworkAuthenticationType.Aad)
                {
                    HttpsServerCertificate = new MobileNetworkHttpsServerCertificate(new Uri("https://contosovault.vault.azure.net/certificates/ingress")),
                })
            {
                Installation = new MobileNetworkInstallation
                {
                    DesiredState = DesiredInstallationState.Installed,
                },
                CoreNetworkTechnology = MobileNetworkCoreNetworkType.FiveGC,
                Version = "0.2.0",
                UEMtu = 1600,
                EventHub = new MobileNetworkEventHubConfiguration(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.EventHub/namespaces/contosoNamespace/eventHubs/contosoHub"))
                {
                    ReportingInterval = 60,
                },
                Signaling = new PacketCoreSignalingConfiguration
                {
                    NasRerouteMacroMmeGroupId = 1024,
                    NasEncryption = { MobileNetworkNasEncryptionType.NEA2EEA2, MobileNetworkNasEncryptionType.NEA1EEA1, MobileNetworkNasEncryptionType.NEA0EEA0 },
                },
            };
            ArmOperation<PacketCoreControlPlaneResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, packetCoreControlPlaneName, data);
            PacketCoreControlPlaneResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCoreControlPlaneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneGet.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PacketCoreControlPlaneResource
            PacketCoreControlPlaneCollection collection = resourceGroupResource.GetPacketCoreControlPlanes();

            // invoke the operation
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            PacketCoreControlPlaneResource result = await collection.GetAsync(packetCoreControlPlaneName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCoreControlPlaneData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPacketCoreControlPlanesInResourceGroup()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneListByResourceGroup.json
            // this example is just showing the usage of "PacketCoreControlPlanes_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PacketCoreControlPlaneResource
            PacketCoreControlPlaneCollection collection = resourceGroupResource.GetPacketCoreControlPlanes();

            // invoke the operation and iterate over the result
            await foreach (PacketCoreControlPlaneResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PacketCoreControlPlaneData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneGet.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PacketCoreControlPlaneResource
            PacketCoreControlPlaneCollection collection = resourceGroupResource.GetPacketCoreControlPlanes();

            // invoke the operation
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            bool result = await collection.ExistsAsync(packetCoreControlPlaneName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetPacketCoreControlPlane()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/PacketCoreControlPlaneGet.json
            // this example is just showing the usage of "PacketCoreControlPlanes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PacketCoreControlPlaneResource
            PacketCoreControlPlaneCollection collection = resourceGroupResource.GetPacketCoreControlPlanes();

            // invoke the operation
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            NullableResponse<PacketCoreControlPlaneResource> response = await collection.GetIfExistsAsync(packetCoreControlPlaneName);
            PacketCoreControlPlaneResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PacketCoreControlPlaneData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
