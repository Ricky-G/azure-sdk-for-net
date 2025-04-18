// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Communication.Samples
{
    public partial class Sample_SenderUsernameResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSenderUsernamesResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/senderUsernames/get.json
            // this example is just showing the usage of "SenderUsernames_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SenderUsernameResource created on azure
            // for more information of creating SenderUsernameResource, please refer to the document of SenderUsernameResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "contosoResourceGroup";
            string emailServiceName = "contosoEmailService";
            string domainName = "contoso.com";
            string senderUsername = "contosoNewsAlerts";
            ResourceIdentifier senderUsernameResourceId = SenderUsernameResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName, senderUsername);
            SenderUsernameResource senderUsernameResource = client.GetSenderUsernameResource(senderUsernameResourceId);

            // invoke the operation
            SenderUsernameResource result = await senderUsernameResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SenderUsernameResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSenderUsernamesResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/senderUsernames/delete.json
            // this example is just showing the usage of "SenderUsernames_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SenderUsernameResource created on azure
            // for more information of creating SenderUsernameResource, please refer to the document of SenderUsernameResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "MyResourceGroup";
            string emailServiceName = "MyEmailServiceResource";
            string domainName = "mydomain.com";
            string senderUsername = "contosoNewsAlerts";
            ResourceIdentifier senderUsernameResourceId = SenderUsernameResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName, senderUsername);
            SenderUsernameResource senderUsernameResource = client.GetSenderUsernameResource(senderUsernameResourceId);

            // invoke the operation
            await senderUsernameResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateSenderUsernamesResource()
        {
            // Generated from example definition: specification/communication/resource-manager/Microsoft.Communication/stable/2023-04-01/examples/senderUsernames/createOrUpdate.json
            // this example is just showing the usage of "SenderUsernames_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SenderUsernameResource created on azure
            // for more information of creating SenderUsernameResource, please refer to the document of SenderUsernameResource
            string subscriptionId = "11112222-3333-4444-5555-666677778888";
            string resourceGroupName = "contosoResourceGroup";
            string emailServiceName = "contosoEmailService";
            string domainName = "contoso.com";
            string senderUsername = "contosoNewsAlerts";
            ResourceIdentifier senderUsernameResourceId = SenderUsernameResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, emailServiceName, domainName, senderUsername);
            SenderUsernameResource senderUsernameResource = client.GetSenderUsernameResource(senderUsernameResourceId);

            // invoke the operation
            SenderUsernameResourceData data = new SenderUsernameResourceData
            {
                Username = "contosoNewsAlerts",
                DisplayName = "Contoso News Alerts",
            };
            ArmOperation<SenderUsernameResource> lro = await senderUsernameResource.UpdateAsync(WaitUntil.Completed, data);
            SenderUsernameResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SenderUsernameResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
