// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityExpandResponseValue : IUtf8JsonSerializable, IJsonModel<EntityExpandResponseValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityExpandResponseValue>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EntityExpandResponseValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityExpandResponseValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityExpandResponseValue)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Entities))
            {
                writer.WritePropertyName("entities"u8);
                writer.WriteStartArray();
                foreach (var item in Entities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Edges))
            {
                writer.WritePropertyName("edges"u8);
                writer.WriteStartArray();
                foreach (var item in Edges)
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

        EntityExpandResponseValue IJsonModel<EntityExpandResponseValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityExpandResponseValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityExpandResponseValue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityExpandResponseValue(document.RootElement, options);
        }

        internal static EntityExpandResponseValue DeserializeEntityExpandResponseValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SecurityInsightsEntity> entities = default;
            IReadOnlyList<EntityEdges> edges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsEntity> array = new List<SecurityInsightsEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsEntity.DeserializeSecurityInsightsEntity(item, options));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("edges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EntityEdges> array = new List<EntityEdges>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityEdges.DeserializeEntityEdges(item, options));
                    }
                    edges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EntityExpandResponseValue(entities ?? new ChangeTrackingList<SecurityInsightsEntity>(), edges ?? new ChangeTrackingList<EntityEdges>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Entities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  entities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Entities))
                {
                    if (Entities.Any())
                    {
                        builder.Append("  entities: ");
                        builder.AppendLine("[");
                        foreach (var item in Entities)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  entities: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Edges), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  edges: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Edges))
                {
                    if (Edges.Any())
                    {
                        builder.Append("  edges: ");
                        builder.AppendLine("[");
                        foreach (var item in Edges)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  edges: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EntityExpandResponseValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityExpandResponseValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EntityExpandResponseValue)} does not support writing '{options.Format}' format.");
            }
        }

        EntityExpandResponseValue IPersistableModel<EntityExpandResponseValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityExpandResponseValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEntityExpandResponseValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EntityExpandResponseValue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EntityExpandResponseValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
