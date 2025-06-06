// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Blueprint
{
    public partial class AssignmentOperationResource : IJsonModel<AssignmentOperationData>
    {
        private static AssignmentOperationData s_dataDeserializationInstance;
        private static AssignmentOperationData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<AssignmentOperationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AssignmentOperationData>)Data).Write(writer, options);

        AssignmentOperationData IJsonModel<AssignmentOperationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AssignmentOperationData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<AssignmentOperationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AssignmentOperationData>(Data, options, AzureResourceManagerBlueprintContext.Default);

        AssignmentOperationData IPersistableModel<AssignmentOperationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AssignmentOperationData>(data, options, AzureResourceManagerBlueprintContext.Default);

        string IPersistableModel<AssignmentOperationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AssignmentOperationData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
