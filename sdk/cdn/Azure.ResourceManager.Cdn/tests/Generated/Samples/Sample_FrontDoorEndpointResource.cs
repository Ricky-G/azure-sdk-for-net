// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorEndpointResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AFDEndpointsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_Get.json
            // this example is just showing the usage of "FrontDoorEndpoints_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation
            FrontDoorEndpointResource result = await frontDoorEndpoint.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_AFDEndpointsDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_Delete.json
            // this example is just showing the usage of "FrontDoorEndpoints_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation
            await frontDoorEndpoint.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_AFDEndpointsUpdate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_Update.json
            // this example is just showing the usage of "FrontDoorEndpoints_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation
            FrontDoorEndpointPatch patch = new FrontDoorEndpointPatch
            {
                Tags = { },
                EnabledState = EnabledState.Enabled,
            };
            ArmOperation<FrontDoorEndpointResource> lro = await frontDoorEndpoint.UpdateAsync(WaitUntil.Completed, patch);
            FrontDoorEndpointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorEndpointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task PurgeContent_AFDEndpointsPurgeContent()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_PurgeContent.json
            // this example is just showing the usage of "FrontDoorEndpoints_PurgeContent" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation
            FrontDoorPurgeContent content = new FrontDoorPurgeContent(new string[] { "/folder1" })
            {
                Domains = { "endpoint1-abcdefghijklmnop.z01.azurefd.net" },
            };
            await frontDoorEndpoint.PurgeContentAsync(WaitUntil.Completed, content);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetResourceUsages_AFDEndpointsListResourceUsage()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_ListResourceUsage.json
            // this example is just showing the usage of "FrontDoorEndpoints_ListResourceUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation and iterate over the result
            await foreach (FrontDoorUsage item in frontDoorEndpoint.GetResourceUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateCustomDomain_EndpointsValidateCustomDomain()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2025-04-15/examples/AFDEndpoints_ValidateCustomDomain.json
            // this example is just showing the usage of "FrontDoorEndpoints_ValidateCustomDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorEndpointResource created on azure
            // for more information of creating FrontDoorEndpointResource, please refer to the document of FrontDoorEndpointResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            ResourceIdentifier frontDoorEndpointResourceId = FrontDoorEndpointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName);
            FrontDoorEndpointResource frontDoorEndpoint = client.GetFrontDoorEndpointResource(frontDoorEndpointResourceId);

            // invoke the operation
            ValidateCustomDomainContent content = new ValidateCustomDomainContent("www.someDomain.com");
            ValidateCustomDomainResult result = await frontDoorEndpoint.ValidateCustomDomainAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
