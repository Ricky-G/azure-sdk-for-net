// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeDeviceResource : IJsonModel<DataBoxEdgeDeviceData>
    {
        void IJsonModel<DataBoxEdgeDeviceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataBoxEdgeDeviceData>)Data).Write(writer, options);

        DataBoxEdgeDeviceData IJsonModel<DataBoxEdgeDeviceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataBoxEdgeDeviceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataBoxEdgeDeviceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataBoxEdgeDeviceData>(Data, options, AzureResourceManagerDataBoxEdgeContext.Default);

        DataBoxEdgeDeviceData IPersistableModel<DataBoxEdgeDeviceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataBoxEdgeDeviceData>(data, options, AzureResourceManagerDataBoxEdgeContext.Default);

        string IPersistableModel<DataBoxEdgeDeviceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataBoxEdgeDeviceData>)Data).GetFormatFromOptions(options);
    }
}
