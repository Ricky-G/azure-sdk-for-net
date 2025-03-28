// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    internal class StreamAnalyticsTestDatasourceResultOperationSource : IOperationSource<StreamAnalyticsTestDatasourceResult>
    {
        StreamAnalyticsTestDatasourceResult IOperationSource<StreamAnalyticsTestDatasourceResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return StreamAnalyticsTestDatasourceResult.DeserializeStreamAnalyticsTestDatasourceResult(document.RootElement);
        }

        async ValueTask<StreamAnalyticsTestDatasourceResult> IOperationSource<StreamAnalyticsTestDatasourceResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return StreamAnalyticsTestDatasourceResult.DeserializeStreamAnalyticsTestDatasourceResult(document.RootElement);
        }
    }
}
