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

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisInstanceDetails : IUtf8JsonSerializable, IJsonModel<RedisInstanceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisInstanceDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedisInstanceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisInstanceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(SslPort))
            {
                writer.WritePropertyName("sslPort"u8);
                writer.WriteNumberValue(SslPort.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NonSslPort))
            {
                writer.WritePropertyName("nonSslPort"u8);
                writer.WriteNumberValue(NonSslPort.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Zone))
            {
                writer.WritePropertyName("zone"u8);
                writer.WriteStringValue(Zone);
            }
            if (options.Format != "W" && Optional.IsDefined(ShardId))
            {
                writer.WritePropertyName("shardId"u8);
                writer.WriteNumberValue(ShardId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsMaster))
            {
                writer.WritePropertyName("isMaster"u8);
                writer.WriteBooleanValue(IsMaster.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
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

        RedisInstanceDetails IJsonModel<RedisInstanceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisInstanceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisInstanceDetails(document.RootElement, options);
        }

        internal static RedisInstanceDetails DeserializeRedisInstanceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? sslPort = default;
            int? nonSslPort = default;
            string zone = default;
            int? shardId = default;
            bool? isMaster = default;
            bool? isPrimary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sslPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nonSslPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonSslPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("zone"u8))
                {
                    zone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shardId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isMaster"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMaster = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedisInstanceDetails(
                sslPort,
                nonSslPort,
                zone,
                shardId,
                isMaster,
                isPrimary,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SslPort), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sslPort: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SslPort))
                {
                    builder.Append("  sslPort: ");
                    builder.AppendLine($"{SslPort.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NonSslPort), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nonSslPort: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NonSslPort))
                {
                    builder.Append("  nonSslPort: ");
                    builder.AppendLine($"{NonSslPort.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Zone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  zone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Zone))
                {
                    builder.Append("  zone: ");
                    if (Zone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Zone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Zone}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ShardId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  shardId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ShardId))
                {
                    builder.Append("  shardId: ");
                    builder.AppendLine($"{ShardId.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsMaster), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isMaster: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsMaster))
                {
                    builder.Append("  isMaster: ");
                    var boolValue = IsMaster.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPrimary), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isPrimary: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPrimary))
                {
                    builder.Append("  isPrimary: ");
                    var boolValue = IsPrimary.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RedisInstanceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisInstanceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRedisContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support writing '{options.Format}' format.");
            }
        }

        RedisInstanceDetails IPersistableModel<RedisInstanceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisInstanceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRedisInstanceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisInstanceDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisInstanceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
