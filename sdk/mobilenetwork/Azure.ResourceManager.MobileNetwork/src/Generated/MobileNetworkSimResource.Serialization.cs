// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkSimResource : IJsonModel<MobileNetworkSimData>
    {
        void IJsonModel<MobileNetworkSimData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkSimData>)Data).Write(writer, options);

        MobileNetworkSimData IJsonModel<MobileNetworkSimData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkSimData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MobileNetworkSimData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MobileNetworkSimData>(Data, options, AzureResourceManagerMobileNetworkContext.Default);

        MobileNetworkSimData IPersistableModel<MobileNetworkSimData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MobileNetworkSimData>(data, options, AzureResourceManagerMobileNetworkContext.Default);

        string IPersistableModel<MobileNetworkSimData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MobileNetworkSimData>)Data).GetFormatFromOptions(options);
    }
}
