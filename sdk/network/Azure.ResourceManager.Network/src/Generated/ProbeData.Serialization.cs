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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ProbeData : IUtf8JsonSerializable, IJsonModel<ProbeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProbeData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProbeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProbeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProbeData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(LoadBalancingRules))
            {
                writer.WritePropertyName("loadBalancingRules"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancingRules)
                {
                    ((IJsonModel<WritableSubResource>)item).Write(writer, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(NoHealthyBackendsBehavior))
            {
                writer.WritePropertyName("noHealthyBackendsBehavior"u8);
                writer.WriteStringValue(NoHealthyBackendsBehavior.Value.ToString());
            }
            if (Optional.IsDefined(NumberOfProbes))
            {
                writer.WritePropertyName("numberOfProbes"u8);
                writer.WriteNumberValue(NumberOfProbes.Value);
            }
            if (Optional.IsDefined(ProbeThreshold))
            {
                writer.WritePropertyName("probeThreshold"u8);
                writer.WriteNumberValue(ProbeThreshold.Value);
            }
            if (Optional.IsDefined(RequestPath))
            {
                writer.WritePropertyName("requestPath"u8);
                writer.WriteStringValue(RequestPath);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ProbeData IJsonModel<ProbeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProbeData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProbeData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProbeData(document.RootElement, options);
        }

        internal static ProbeData DeserializeProbeData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            IReadOnlyList<WritableSubResource> loadBalancingRules = default;
            ProbeProtocol? protocol = default;
            int? port = default;
            int? intervalInSeconds = default;
            ProbeNoHealthyBackendsBehavior? noHealthyBackendsBehavior = default;
            int? numberOfProbes = default;
            int? probeThreshold = default;
            string requestPath = default;
            NetworkProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("loadBalancingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(item.GetRawText())), options, AzureResourceManagerNetworkContext.Default));
                            }
                            loadBalancingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ProbeProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("intervalInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("noHealthyBackendsBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            noHealthyBackendsBehavior = new ProbeNoHealthyBackendsBehavior(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("numberOfProbes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfProbes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probeThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probeThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestPath"u8))
                        {
                            requestPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
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
            return new ProbeData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                etag,
                loadBalancingRules ?? new ChangeTrackingList<WritableSubResource>(),
                protocol,
                port,
                intervalInSeconds,
                noHealthyBackendsBehavior,
                numberOfProbes,
                probeThreshold,
                requestPath,
                provisioningState);
        }

        BinaryData IPersistableModel<ProbeData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProbeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ProbeData)} does not support writing '{options.Format}' format.");
            }
        }

        ProbeData IPersistableModel<ProbeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProbeData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProbeData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProbeData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProbeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
