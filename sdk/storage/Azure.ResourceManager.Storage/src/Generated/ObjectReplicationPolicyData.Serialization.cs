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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class ObjectReplicationPolicyData : IUtf8JsonSerializable, IJsonModel<ObjectReplicationPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ObjectReplicationPolicyData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ObjectReplicationPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObjectReplicationPolicyData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (options.Format != "W" && Optional.IsDefined(EnabledOn))
            {
                writer.WritePropertyName("enabledTime"u8);
                writer.WriteStringValue(EnabledOn.Value, "O");
            }
            if (Optional.IsDefined(SourceAccount))
            {
                writer.WritePropertyName("sourceAccount"u8);
                writer.WriteStringValue(SourceAccount);
            }
            if (Optional.IsDefined(DestinationAccount))
            {
                writer.WritePropertyName("destinationAccount"u8);
                writer.WriteStringValue(DestinationAccount);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteObjectValue(Metrics, options);
            }
            writer.WriteEndObject();
        }

        ObjectReplicationPolicyData IJsonModel<ObjectReplicationPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ObjectReplicationPolicyData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeObjectReplicationPolicyData(document.RootElement, options);
        }

        internal static ObjectReplicationPolicyData DeserializeObjectReplicationPolicyData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string policyId = default;
            DateTimeOffset? enabledTime = default;
            string sourceAccount = default;
            string destinationAccount = default;
            IList<ObjectReplicationPolicyRule> rules = default;
            ObjectReplicationPolicyPropertiesMetrics metrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerStorageContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("policyId"u8))
                        {
                            policyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabledTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceAccount"u8))
                        {
                            sourceAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destinationAccount"u8))
                        {
                            destinationAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ObjectReplicationPolicyRule> array = new List<ObjectReplicationPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ObjectReplicationPolicyRule.DeserializeObjectReplicationPolicyRule(item, options));
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metrics = ObjectReplicationPolicyPropertiesMetrics.DeserializeObjectReplicationPolicyPropertiesMetrics(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ObjectReplicationPolicyData(
                id,
                name,
                type,
                systemData,
                policyId,
                enabledTime,
                sourceAccount,
                destinationAccount,
                rules ?? new ChangeTrackingList<ObjectReplicationPolicyRule>(),
                metrics,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PolicyId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    policyId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PolicyId))
                {
                    builder.Append("    policyId: ");
                    if (PolicyId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PolicyId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PolicyId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnabledOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enabledTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnabledOn))
                {
                    builder.Append("    enabledTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EnabledOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceAccount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sourceAccount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceAccount))
                {
                    builder.Append("    sourceAccount: ");
                    if (SourceAccount.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceAccount}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceAccount}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DestinationAccount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    destinationAccount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DestinationAccount))
                {
                    builder.Append("    destinationAccount: ");
                    if (DestinationAccount.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DestinationAccount}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DestinationAccount}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Rules))
                {
                    if (Rules.Any())
                    {
                        builder.Append("    rules: ");
                        builder.AppendLine("[");
                        foreach (var item in Rules)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    rules: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("IsMetricsEnabled", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    metrics: ");
                builder.AppendLine("{");
                builder.AppendLine("      metrics: {");
                builder.Append("        enabled: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Metrics))
                {
                    builder.Append("    metrics: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Metrics, options, 4, false, "    metrics: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ObjectReplicationPolicyData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ObjectReplicationPolicyData)} does not support writing '{options.Format}' format.");
            }
        }

        ObjectReplicationPolicyData IPersistableModel<ObjectReplicationPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ObjectReplicationPolicyData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeObjectReplicationPolicyData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ObjectReplicationPolicyData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ObjectReplicationPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
