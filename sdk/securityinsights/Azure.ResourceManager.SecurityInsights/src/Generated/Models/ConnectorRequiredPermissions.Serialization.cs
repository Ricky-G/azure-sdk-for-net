// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ConnectorRequiredPermissions : IUtf8JsonSerializable, IJsonModel<ConnectorRequiredPermissions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectorRequiredPermissions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectorRequiredPermissions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorRequiredPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorRequiredPermissions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsCustomAction))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteBooleanValue(IsCustomAction.Value);
            }
            if (Optional.IsDefined(IsWriteAction))
            {
                writer.WritePropertyName("write"u8);
                writer.WriteBooleanValue(IsWriteAction.Value);
            }
            if (Optional.IsDefined(IsReadAction))
            {
                writer.WritePropertyName("read"u8);
                writer.WriteBooleanValue(IsReadAction.Value);
            }
            if (Optional.IsDefined(IsDeleteAction))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteBooleanValue(IsDeleteAction.Value);
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

        ConnectorRequiredPermissions IJsonModel<ConnectorRequiredPermissions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorRequiredPermissions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorRequiredPermissions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorRequiredPermissions(document.RootElement, options);
        }

        internal static ConnectorRequiredPermissions DeserializeConnectorRequiredPermissions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? action = default;
            bool? write = default;
            bool? read = default;
            bool? delete = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("write"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    write = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("read"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    read = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectorRequiredPermissions(action, write, read, delete, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsCustomAction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  action: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsCustomAction))
                {
                    builder.Append("  action: ");
                    var boolValue = IsCustomAction.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsWriteAction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  write: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsWriteAction))
                {
                    builder.Append("  write: ");
                    var boolValue = IsWriteAction.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsReadAction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  read: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsReadAction))
                {
                    builder.Append("  read: ");
                    var boolValue = IsReadAction.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDeleteAction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  delete: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDeleteAction))
                {
                    builder.Append("  delete: ");
                    var boolValue = IsDeleteAction.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ConnectorRequiredPermissions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorRequiredPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConnectorRequiredPermissions)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectorRequiredPermissions IPersistableModel<ConnectorRequiredPermissions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorRequiredPermissions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectorRequiredPermissions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectorRequiredPermissions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectorRequiredPermissions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
