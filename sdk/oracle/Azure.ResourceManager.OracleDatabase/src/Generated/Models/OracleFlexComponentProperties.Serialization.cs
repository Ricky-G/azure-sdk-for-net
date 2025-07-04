// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class OracleFlexComponentProperties : IUtf8JsonSerializable, IJsonModel<OracleFlexComponentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OracleFlexComponentProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OracleFlexComponentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleFlexComponentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleFlexComponentProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(MinimumCoreCount))
            {
                writer.WritePropertyName("minimumCoreCount"u8);
                writer.WriteNumberValue(MinimumCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableCoreCount))
            {
                writer.WritePropertyName("availableCoreCount"u8);
                writer.WriteNumberValue(AvailableCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableDBStorageInGbs))
            {
                writer.WritePropertyName("availableDbStorageInGbs"u8);
                writer.WriteNumberValue(AvailableDBStorageInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RuntimeMinimumCoreCount))
            {
                writer.WritePropertyName("runtimeMinimumCoreCount"u8);
                writer.WriteNumberValue(RuntimeMinimumCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Shape))
            {
                writer.WritePropertyName("shape"u8);
                writer.WriteStringValue(Shape);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableMemoryInGbs))
            {
                writer.WritePropertyName("availableMemoryInGbs"u8);
                writer.WriteNumberValue(AvailableMemoryInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailableLocalStorageInGbs))
            {
                writer.WritePropertyName("availableLocalStorageInGbs"u8);
                writer.WriteNumberValue(AvailableLocalStorageInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ComputeModel))
            {
                writer.WritePropertyName("computeModel"u8);
                writer.WriteStringValue(ComputeModel);
            }
            if (options.Format != "W" && Optional.IsDefined(HardwareType))
            {
                writer.WritePropertyName("hardwareType"u8);
                writer.WriteStringValue(HardwareType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DescriptionSummary))
            {
                writer.WritePropertyName("descriptionSummary"u8);
                writer.WriteStringValue(DescriptionSummary);
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

        OracleFlexComponentProperties IJsonModel<OracleFlexComponentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleFlexComponentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleFlexComponentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOracleFlexComponentProperties(document.RootElement, options);
        }

        internal static OracleFlexComponentProperties DeserializeOracleFlexComponentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minimumCoreCount = default;
            int? availableCoreCount = default;
            int? availableDbStorageInGbs = default;
            int? runtimeMinimumCoreCount = default;
            string shape = default;
            int? availableMemoryInGbs = default;
            int? availableLocalStorageInGbs = default;
            string computeModel = default;
            FlexComponentHardwareType? hardwareType = default;
            string descriptionSummary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availableCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availableDbStorageInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableDbStorageInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runtimeMinimumCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeMinimumCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("shape"u8))
                {
                    shape = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("availableMemoryInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableMemoryInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availableLocalStorageInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableLocalStorageInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("computeModel"u8))
                {
                    computeModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hardwareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareType = new FlexComponentHardwareType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("descriptionSummary"u8))
                {
                    descriptionSummary = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OracleFlexComponentProperties(
                minimumCoreCount,
                availableCoreCount,
                availableDbStorageInGbs,
                runtimeMinimumCoreCount,
                shape,
                availableMemoryInGbs,
                availableLocalStorageInGbs,
                computeModel,
                hardwareType,
                descriptionSummary,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OracleFlexComponentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleFlexComponentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOracleDatabaseContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OracleFlexComponentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OracleFlexComponentProperties IPersistableModel<OracleFlexComponentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleFlexComponentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOracleFlexComponentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OracleFlexComponentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OracleFlexComponentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
