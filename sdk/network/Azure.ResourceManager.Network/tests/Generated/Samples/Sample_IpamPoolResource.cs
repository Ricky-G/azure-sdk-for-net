// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_IpamPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_IpamPoolsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/IpamPools_Get.json
            // this example is just showing the usage of "IpamPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // invoke the operation
            IpamPoolResource result = await ipamPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IpamPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_IpamPoolsDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/IpamPools_Delete.json
            // this example is just showing the usage of "IpamPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // invoke the operation
            await ipamPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_IpamPoolsUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/IpamPools_Update.json
            // this example is just showing the usage of "IpamPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // invoke the operation
            IpamPoolPatch patch = new IpamPoolPatch();
            IpamPoolResource result = await ipamPool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IpamPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPoolUsage_IpamPoolsGetPoolUsage()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/IpamPools_GetPoolUsage.json
            // this example is just showing the usage of "IpamPools_GetPoolUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // invoke the operation
            IpamPoolUsage result = await ipamPool.GetPoolUsageAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAssociatedResources_IpamPoolsListAssociatedResources()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/IpamPools_ListAssociatedResources.json
            // this example is just showing the usage of "IpamPools_ListAssociatedResources" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (IpamPoolAssociation item in ipamPool.GetAssociatedResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
