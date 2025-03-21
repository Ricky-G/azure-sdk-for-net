// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase
{
    internal class CloudAccountDetailsOperationSource : IOperationSource<CloudAccountDetails>
    {
        CloudAccountDetails IOperationSource<CloudAccountDetails>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return CloudAccountDetails.DeserializeCloudAccountDetails(document.RootElement);
        }

        async ValueTask<CloudAccountDetails> IOperationSource<CloudAccountDetails>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return CloudAccountDetails.DeserializeCloudAccountDetails(document.RootElement);
        }
    }
}
