// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    internal partial class MaintenanceApplyUpdateListResult : IUtf8JsonSerializable, IJsonModel<MaintenanceApplyUpdateListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceApplyUpdateListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MaintenanceApplyUpdateListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceApplyUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceApplyUpdateListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        MaintenanceApplyUpdateListResult IJsonModel<MaintenanceApplyUpdateListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceApplyUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceApplyUpdateListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceApplyUpdateListResult(document.RootElement, options);
        }

        internal static MaintenanceApplyUpdateListResult DeserializeMaintenanceApplyUpdateListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MaintenanceApplyUpdateData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceApplyUpdateData> array = new List<MaintenanceApplyUpdateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceApplyUpdateData.DeserializeMaintenanceApplyUpdateData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MaintenanceApplyUpdateListResult(value ?? new ChangeTrackingList<MaintenanceApplyUpdateData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceApplyUpdateListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceApplyUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMaintenanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceApplyUpdateListResult)} does not support writing '{options.Format}' format.");
            }
        }

        MaintenanceApplyUpdateListResult IPersistableModel<MaintenanceApplyUpdateListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceApplyUpdateListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMaintenanceApplyUpdateListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceApplyUpdateListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceApplyUpdateListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
