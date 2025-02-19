// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingInvoiceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_InvoicesGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesGetByBillingAccount.json
            // this example is just showing the usage of "Invoices_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingInvoiceResource
            BillingInvoiceCollection collection = billingAccount.GetBillingInvoices();

            // invoke the operation
            string invoiceName = "G123456789";
            BillingInvoiceResource result = await collection.GetAsync(invoiceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingInvoiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_InvoicesListByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesListByBillingAccount.json
            // this example is just showing the usage of "Invoices_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingInvoiceResource
            BillingInvoiceCollection collection = billingAccount.GetBillingInvoices();

            // invoke the operation and iterate over the result
            BillingInvoiceCollectionGetAllOptions options = new BillingInvoiceCollectionGetAllOptions { PeriodStartDate = DateTimeOffset.Parse("2023-01-01"), PeriodEndDate = DateTimeOffset.Parse("2023-06-30") };
            await foreach (BillingInvoiceResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingInvoiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_InvoicesGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesGetByBillingAccount.json
            // this example is just showing the usage of "Invoices_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingInvoiceResource
            BillingInvoiceCollection collection = billingAccount.GetBillingInvoices();

            // invoke the operation
            string invoiceName = "G123456789";
            bool result = await collection.ExistsAsync(invoiceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_InvoicesGetByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/invoicesGetByBillingAccount.json
            // this example is just showing the usage of "Invoices_GetByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingInvoiceResource
            BillingInvoiceCollection collection = billingAccount.GetBillingInvoices();

            // invoke the operation
            string invoiceName = "G123456789";
            NullableResponse<BillingInvoiceResource> response = await collection.GetIfExistsAsync(invoiceName);
            BillingInvoiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingInvoiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
