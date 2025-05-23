// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteBuildResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            StaticSiteBuildResource result = await staticSiteBuild.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteBuildData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/DeleteStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_DeleteStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            await staticSiteBuild.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateAppSettings_CreatesOrUpdatesTheFunctionAppSettingsOfAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CreateOrUpdateStaticSiteBuildAppSettings.json
            // this example is just showing the usage of "StaticSites_CreateOrUpdateStaticSiteBuildAppSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            AppServiceConfigurationDictionary appSettings = new AppServiceConfigurationDictionary
            {
                Properties =
{
["setting1"] = "someval",
["setting2"] = "someval2"
},
            };
            AppServiceConfigurationDictionary result = await staticSiteBuild.CreateOrUpdateAppSettingsAsync(appSettings);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdateFunctionAppSettings_CreatesOrUpdatesTheFunctionAppSettingsOfAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/CreateOrUpdateStaticSiteBuildFunctionAppSettings.json
            // this example is just showing the usage of "StaticSites_CreateOrUpdateStaticSiteBuildFunctionAppSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            AppServiceConfigurationDictionary appSettings = new AppServiceConfigurationDictionary
            {
                Properties =
{
["setting1"] = "someval",
["setting2"] = "someval2"
},
            };
            AppServiceConfigurationDictionary result = await staticSiteBuild.CreateOrUpdateFunctionAppSettingsAsync(appSettings);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetFunctions_GetsTheFunctionsOfAParticularStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/ListStaticSiteBuildFunctions.json
            // this example is just showing the usage of "StaticSites_ListStaticSiteBuildFunctions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation and iterate over the result
            await foreach (StaticSiteFunctionOverview item in staticSiteBuild.GetFunctionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetStaticSiteBuildAppSettings_GetAppSettingsOfAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/ListStaticSiteBuildAppSettings.json
            // this example is just showing the usage of "StaticSites_ListStaticSiteBuildAppSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            AppServiceConfigurationDictionary result = await staticSiteBuild.GetStaticSiteBuildAppSettingsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetFunctionAppSettings_GetFunctionAppSettingsOfAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/ListStaticSiteBuildFunctionAppSettings.json
            // this example is just showing the usage of "StaticSites_ListStaticSiteBuildFunctionAppSettings" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            AppServiceConfigurationDictionary result = await staticSiteBuild.GetFunctionAppSettingsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBuildDatabaseConnectionsWithDetails_ListFullDetailsOfDatabaseConnectionsForTheStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/GetStaticSiteBuildDatabaseConnectionsWithDetails.json
            // this example is just showing the usage of "StaticSites_GetBuildDatabaseConnectionsWithDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation and iterate over the result
            await foreach (StaticSiteDatabaseConnectionData item in staticSiteBuild.GetBuildDatabaseConnectionsWithDetailsAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateZipDeployment_DeployASiteFromAZippedPackageToAParticularStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-11-01/examples/StaticSiteBuildZipDeploy.json
            // this example is just showing the usage of "StaticSites_CreateZipDeploymentForStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildResource created on azure
            // for more information of creating StaticSiteBuildResource, please refer to the document of StaticSiteBuildResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            ResourceIdentifier staticSiteBuildResourceId = StaticSiteBuildResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName);
            StaticSiteBuildResource staticSiteBuild = client.GetStaticSiteBuildResource(staticSiteBuildResourceId);

            // invoke the operation
            StaticSiteZipDeployment staticSiteZipDeploymentEnvelope = new StaticSiteZipDeployment
            {
                AppZipUri = new Uri("https://teststorageaccount.net/happy-sea-15afae3e-master-81828877/app-zipdeploy.zip"),
                ApiZipUri = new Uri("https://teststorageaccount.net/happy-sea-15afae3e-master-81828877/api-zipdeploy.zip"),
                DeploymentTitle = "Update index.html",
                Provider = "testProvider",
                FunctionLanguage = "testFunctionLanguage",
            };
            await staticSiteBuild.CreateZipDeploymentAsync(WaitUntil.Completed, staticSiteZipDeploymentEnvelope);

            Console.WriteLine("Succeeded");
        }
    }
}
