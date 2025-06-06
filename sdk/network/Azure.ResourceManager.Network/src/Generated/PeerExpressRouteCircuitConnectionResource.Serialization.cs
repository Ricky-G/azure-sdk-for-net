// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class PeerExpressRouteCircuitConnectionResource : IJsonModel<PeerExpressRouteCircuitConnectionData>
    {
        private static PeerExpressRouteCircuitConnectionData s_dataDeserializationInstance;
        private static PeerExpressRouteCircuitConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<PeerExpressRouteCircuitConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PeerExpressRouteCircuitConnectionData>)Data).Write(writer, options);

        PeerExpressRouteCircuitConnectionData IJsonModel<PeerExpressRouteCircuitConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PeerExpressRouteCircuitConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<PeerExpressRouteCircuitConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PeerExpressRouteCircuitConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        PeerExpressRouteCircuitConnectionData IPersistableModel<PeerExpressRouteCircuitConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PeerExpressRouteCircuitConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<PeerExpressRouteCircuitConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PeerExpressRouteCircuitConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
