// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class ExtensionTopicResource : IJsonModel<ExtensionTopicData>
    {
        private static ExtensionTopicData s_dataDeserializationInstance;
        private static ExtensionTopicData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ExtensionTopicData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExtensionTopicData>)Data).Write(writer, options);

        ExtensionTopicData IJsonModel<ExtensionTopicData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExtensionTopicData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ExtensionTopicData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ExtensionTopicData>(Data, options, AzureResourceManagerEventGridContext.Default);

        ExtensionTopicData IPersistableModel<ExtensionTopicData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExtensionTopicData>(data, options, AzureResourceManagerEventGridContext.Default);

        string IPersistableModel<ExtensionTopicData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExtensionTopicData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
