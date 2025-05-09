// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices
{
    internal class CognitiveServicesAccountDeploymentOperationSource : IOperationSource<CognitiveServicesAccountDeploymentResource>
    {
        private readonly ArmClient _client;

        internal CognitiveServicesAccountDeploymentOperationSource(ArmClient client)
        {
            _client = client;
        }

        CognitiveServicesAccountDeploymentResource IOperationSource<CognitiveServicesAccountDeploymentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CognitiveServicesAccountDeploymentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCognitiveServicesContext.Default);
            return new CognitiveServicesAccountDeploymentResource(_client, data);
        }

        async ValueTask<CognitiveServicesAccountDeploymentResource> IOperationSource<CognitiveServicesAccountDeploymentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CognitiveServicesAccountDeploymentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCognitiveServicesContext.Default);
            return await Task.FromResult(new CognitiveServicesAccountDeploymentResource(_client, data)).ConfigureAwait(false);
        }
    }
}
