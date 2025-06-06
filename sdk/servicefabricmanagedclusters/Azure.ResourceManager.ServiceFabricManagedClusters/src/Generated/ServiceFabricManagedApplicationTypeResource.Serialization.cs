// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedApplicationTypeResource : IJsonModel<ServiceFabricManagedApplicationTypeData>
    {
        private static ServiceFabricManagedApplicationTypeData s_dataDeserializationInstance;
        private static ServiceFabricManagedApplicationTypeData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<ServiceFabricManagedApplicationTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricManagedApplicationTypeData>)Data).Write(writer, options);

        ServiceFabricManagedApplicationTypeData IJsonModel<ServiceFabricManagedApplicationTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceFabricManagedApplicationTypeData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceFabricManagedApplicationTypeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ServiceFabricManagedApplicationTypeData>(Data, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);

        ServiceFabricManagedApplicationTypeData IPersistableModel<ServiceFabricManagedApplicationTypeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceFabricManagedApplicationTypeData>(data, options, AzureResourceManagerServiceFabricManagedClustersContext.Default);

        string IPersistableModel<ServiceFabricManagedApplicationTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceFabricManagedApplicationTypeData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
