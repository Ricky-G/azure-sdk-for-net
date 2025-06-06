// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ElasticSan
{
    public partial class ElasticSanVolumeResource : IJsonModel<ElasticSanVolumeData>
    {
        private static ElasticSanVolumeData s_dataDeserializationInstance;
        private static ElasticSanVolumeData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ElasticSanVolumeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ElasticSanVolumeData>)Data).Write(writer, options);

        ElasticSanVolumeData IJsonModel<ElasticSanVolumeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ElasticSanVolumeData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ElasticSanVolumeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ElasticSanVolumeData>(Data, options, AzureResourceManagerElasticSanContext.Default);

        ElasticSanVolumeData IPersistableModel<ElasticSanVolumeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ElasticSanVolumeData>(data, options, AzureResourceManagerElasticSanContext.Default);

        string IPersistableModel<ElasticSanVolumeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ElasticSanVolumeData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
