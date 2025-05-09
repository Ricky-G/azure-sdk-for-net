// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmRollingUpgradeMonitoringPolicy : IUtf8JsonSerializable, IJsonModel<ArmRollingUpgradeMonitoringPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmRollingUpgradeMonitoringPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmRollingUpgradeMonitoringPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FailureAction))
            {
                writer.WritePropertyName("failureAction"u8);
                writer.WriteStringValue(FailureAction.Value.ToString());
            }
            if (Optional.IsDefined(HealthCheckWaitDuration))
            {
                writer.WritePropertyName("healthCheckWaitDuration"u8);
                writer.WriteStringValue(HealthCheckWaitDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckStableDuration))
            {
                writer.WritePropertyName("healthCheckStableDuration"u8);
                writer.WriteStringValue(HealthCheckStableDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckRetryTimeout))
            {
                writer.WritePropertyName("healthCheckRetryTimeout"u8);
                writer.WriteStringValue(HealthCheckRetryTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeTimeout))
            {
                writer.WritePropertyName("upgradeTimeout"u8);
                writer.WriteStringValue(UpgradeTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeDomainTimeout))
            {
                writer.WritePropertyName("upgradeDomainTimeout"u8);
                writer.WriteStringValue(UpgradeDomainTimeout.Value, "c");
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

        ArmRollingUpgradeMonitoringPolicy IJsonModel<ArmRollingUpgradeMonitoringPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmRollingUpgradeMonitoringPolicy(document.RootElement, options);
        }

        internal static ArmRollingUpgradeMonitoringPolicy DeserializeArmRollingUpgradeMonitoringPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmUpgradeFailureAction? failureAction = default;
            TimeSpan? healthCheckWaitDuration = default;
            TimeSpan? healthCheckStableDuration = default;
            TimeSpan? healthCheckRetryTimeout = default;
            TimeSpan? upgradeTimeout = default;
            TimeSpan? upgradeDomainTimeout = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureAction = new ArmUpgradeFailureAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmRollingUpgradeMonitoringPolicy(
                failureAction,
                healthCheckWaitDuration,
                healthCheckStableDuration,
                healthCheckRetryTimeout,
                upgradeTimeout,
                upgradeDomainTimeout,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerServiceFabricContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ArmRollingUpgradeMonitoringPolicy IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmRollingUpgradeMonitoringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArmRollingUpgradeMonitoringPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmRollingUpgradeMonitoringPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmRollingUpgradeMonitoringPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
