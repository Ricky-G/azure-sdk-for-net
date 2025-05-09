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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityIssue : IUtf8JsonSerializable, IJsonModel<ConnectivityIssue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityIssue>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectivityIssue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityIssue)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Origin))
            {
                writer.WritePropertyName("origin"u8);
                writer.WriteStringValue(Origin.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IssueType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IssueType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStartArray();
                foreach (var item in Context)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item)
                    {
                        writer.WritePropertyName(item0.Key);
                        writer.WriteStringValue(item0.Value);
                    }
                    writer.WriteEndObject();
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

        ConnectivityIssue IJsonModel<ConnectivityIssue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityIssue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityIssue(document.RootElement, options);
        }

        internal static ConnectivityIssue DeserializeConnectivityIssue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IssueOrigin? origin = default;
            IssueSeverity? severity = default;
            IssueType? type = default;
            IReadOnlyList<IDictionary<string, string>> context = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    origin = new IssueOrigin(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new IssueSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new IssueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IDictionary<string, string>> array = new List<IDictionary<string, string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                dictionary.Add(property0.Name, property0.Value.GetString());
                            }
                            array.Add(dictionary);
                        }
                    }
                    context = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectivityIssue(origin, severity, type, context ?? new ChangeTrackingList<IDictionary<string, string>>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Origin), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  origin: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Origin))
                {
                    builder.Append("  origin: ");
                    builder.AppendLine($"'{Origin.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Severity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  severity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Severity))
                {
                    builder.Append("  severity: ");
                    builder.AppendLine($"'{Severity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IssueType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IssueType))
                {
                    builder.Append("  type: ");
                    builder.AppendLine($"'{IssueType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Context), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  context: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Context))
                {
                    if (Context.Any())
                    {
                        builder.Append("  context: ");
                        builder.AppendLine("[");
                        foreach (var item in Context)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("{");
                            foreach (var item0 in item)
                            {
                                builder.Append($"    '{item0.Key}': ");
                                if (item0.Value == null)
                                {
                                    builder.Append("null");
                                    continue;
                                }
                                if (item0.Value.Contains(Environment.NewLine))
                                {
                                    builder.AppendLine("'''");
                                    builder.AppendLine($"{item0.Value}'''");
                                }
                                else
                                {
                                    builder.AppendLine($"'{item0.Value}'");
                                }
                            }
                            builder.AppendLine("  }");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ConnectivityIssue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityIssue)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectivityIssue IPersistableModel<ConnectivityIssue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectivityIssue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityIssue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityIssue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
