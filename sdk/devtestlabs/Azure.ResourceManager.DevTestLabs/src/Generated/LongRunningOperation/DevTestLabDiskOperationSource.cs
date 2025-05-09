// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs
{
    internal class DevTestLabDiskOperationSource : IOperationSource<DevTestLabDiskResource>
    {
        private readonly ArmClient _client;

        internal DevTestLabDiskOperationSource(ArmClient client)
        {
            _client = client;
        }

        DevTestLabDiskResource IOperationSource<DevTestLabDiskResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabDiskData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return new DevTestLabDiskResource(_client, data);
        }

        async ValueTask<DevTestLabDiskResource> IOperationSource<DevTestLabDiskResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DevTestLabDiskData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDevTestLabsContext.Default);
            return await Task.FromResult(new DevTestLabDiskResource(_client, data)).ConfigureAwait(false);
        }
    }
}
