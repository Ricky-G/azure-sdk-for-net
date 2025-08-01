// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageDiscovery.Models
{
    public partial class StorageDiscoveryWorkspaceProperties : IUtf8JsonSerializable, IJsonModel<StorageDiscoveryWorkspaceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageDiscoveryWorkspaceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageDiscoveryWorkspaceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageDiscoveryWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageDiscoveryWorkspaceProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("workspaceRoots"u8);
            writer.WriteStartArray();
            foreach (var item in WorkspaceRoots)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("scopes"u8);
            writer.WriteStartArray();
            foreach (var item in Scopes)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        StorageDiscoveryWorkspaceProperties IJsonModel<StorageDiscoveryWorkspaceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageDiscoveryWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageDiscoveryWorkspaceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageDiscoveryWorkspaceProperties(document.RootElement, options);
        }

        internal static StorageDiscoveryWorkspaceProperties DeserializeStorageDiscoveryWorkspaceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageDiscoverySku? sku = default;
            string description = default;
            IList<ResourceIdentifier> workspaceRoots = default;
            IList<StorageDiscoveryScope> scopes = default;
            StorageDiscoveryProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = new StorageDiscoverySku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceRoots"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    workspaceRoots = array;
                    continue;
                }
                if (property.NameEquals("scopes"u8))
                {
                    List<StorageDiscoveryScope> array = new List<StorageDiscoveryScope>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageDiscoveryScope.DeserializeStorageDiscoveryScope(item, options));
                    }
                    scopes = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new StorageDiscoveryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageDiscoveryWorkspaceProperties(
                sku,
                description,
                workspaceRoots,
                scopes,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageDiscoveryWorkspaceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageDiscoveryWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageDiscoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StorageDiscoveryWorkspaceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageDiscoveryWorkspaceProperties IPersistableModel<StorageDiscoveryWorkspaceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageDiscoveryWorkspaceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageDiscoveryWorkspaceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageDiscoveryWorkspaceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageDiscoveryWorkspaceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
