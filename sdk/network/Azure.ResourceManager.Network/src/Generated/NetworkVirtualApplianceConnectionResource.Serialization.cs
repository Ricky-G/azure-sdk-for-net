// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceConnectionResource : IJsonModel<NetworkVirtualApplianceConnectionData>
    {
        private static NetworkVirtualApplianceConnectionData s_dataDeserializationInstance;
        private static NetworkVirtualApplianceConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<NetworkVirtualApplianceConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkVirtualApplianceConnectionData>)Data).Write(writer, options);

        NetworkVirtualApplianceConnectionData IJsonModel<NetworkVirtualApplianceConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkVirtualApplianceConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkVirtualApplianceConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkVirtualApplianceConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        NetworkVirtualApplianceConnectionData IPersistableModel<NetworkVirtualApplianceConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkVirtualApplianceConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<NetworkVirtualApplianceConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkVirtualApplianceConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
