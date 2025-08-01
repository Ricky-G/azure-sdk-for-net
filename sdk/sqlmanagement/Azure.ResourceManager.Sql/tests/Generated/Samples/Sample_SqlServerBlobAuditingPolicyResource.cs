// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerBlobAuditingPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServerSBlobAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ServerBlobAuditingGet.json
            // this example is just showing the usage of "ServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerBlobAuditingPolicyResource created on azure
            // for more information of creating SqlServerBlobAuditingPolicyResource, please refer to the document of SqlServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ResourceIdentifier sqlServerBlobAuditingPolicyResourceId = SqlServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, blobAuditingPolicyName);
            SqlServerBlobAuditingPolicyResource sqlServerBlobAuditingPolicy = client.GetSqlServerBlobAuditingPolicyResource(sqlServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SqlServerBlobAuditingPolicyResource result = await sqlServerBlobAuditingPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAServerSBlobAuditingPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ServerBlobAuditingCreateMax.json
            // this example is just showing the usage of "ServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerBlobAuditingPolicyResource created on azure
            // for more information of creating SqlServerBlobAuditingPolicyResource, please refer to the document of SqlServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ResourceIdentifier sqlServerBlobAuditingPolicyResourceId = SqlServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, blobAuditingPolicyName);
            SqlServerBlobAuditingPolicyResource sqlServerBlobAuditingPolicy = client.GetSqlServerBlobAuditingPolicyResource(sqlServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SqlServerBlobAuditingPolicyData data = new SqlServerBlobAuditingPolicyData
            {
                RetentionDays = 6,
                AuditActionsAndGroups = { "SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP", "FAILED_DATABASE_AUTHENTICATION_GROUP", "BATCH_COMPLETED_GROUP" },
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
            };
            ArmOperation<SqlServerBlobAuditingPolicyResource> lro = await sqlServerBlobAuditingPolicy.UpdateAsync(WaitUntil.Completed, data);
            SqlServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAServerSBlobAuditingPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2024-11-01-preview/examples/ServerBlobAuditingCreateMin.json
            // this example is just showing the usage of "ServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerBlobAuditingPolicyResource created on azure
            // for more information of creating SqlServerBlobAuditingPolicyResource, please refer to the document of SqlServerBlobAuditingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ResourceIdentifier sqlServerBlobAuditingPolicyResourceId = SqlServerBlobAuditingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, blobAuditingPolicyName);
            SqlServerBlobAuditingPolicyResource sqlServerBlobAuditingPolicy = client.GetSqlServerBlobAuditingPolicyResource(sqlServerBlobAuditingPolicyResourceId);

            // invoke the operation
            SqlServerBlobAuditingPolicyData data = new SqlServerBlobAuditingPolicyData
            {
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<SqlServerBlobAuditingPolicyResource> lro = await sqlServerBlobAuditingPolicy.UpdateAsync(WaitUntil.Completed, data);
            SqlServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
