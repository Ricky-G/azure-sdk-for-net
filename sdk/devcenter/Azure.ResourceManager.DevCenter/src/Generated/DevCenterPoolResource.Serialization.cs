// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterPoolResource : IJsonModel<DevCenterPoolData>
    {
        private static DevCenterPoolData s_dataDeserializationInstance;
        private static DevCenterPoolData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<DevCenterPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevCenterPoolData>)Data).Write(writer, options);

        DevCenterPoolData IJsonModel<DevCenterPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevCenterPoolData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<DevCenterPoolData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DevCenterPoolData>(Data, options, AzureResourceManagerDevCenterContext.Default);

        DevCenterPoolData IPersistableModel<DevCenterPoolData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevCenterPoolData>(data, options, AzureResourceManagerDevCenterContext.Default);

        string IPersistableModel<DevCenterPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevCenterPoolData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
