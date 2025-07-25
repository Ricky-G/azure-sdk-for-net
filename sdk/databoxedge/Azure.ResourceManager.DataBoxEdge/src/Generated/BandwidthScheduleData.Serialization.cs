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
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class BandwidthScheduleData : IUtf8JsonSerializable, IJsonModel<BandwidthScheduleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BandwidthScheduleData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BandwidthScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BandwidthScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BandwidthScheduleData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(StartOn, "T");
            writer.WritePropertyName("stop"u8);
            writer.WriteStringValue(StopOn, "T");
            writer.WritePropertyName("rateInMbps"u8);
            writer.WriteNumberValue(RateInMbps);
            writer.WritePropertyName("days"u8);
            writer.WriteStartArray();
            foreach (var item in Days)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        BandwidthScheduleData IJsonModel<BandwidthScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BandwidthScheduleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BandwidthScheduleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBandwidthScheduleData(document.RootElement, options);
        }

        internal static BandwidthScheduleData DeserializeBandwidthScheduleData(JsonElement element, ModelReaderWriterOptions options = null)
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
            TimeSpan start = default;
            TimeSpan stop = default;
            int rateInMbps = default;
            IList<DataBoxEdgeDayOfWeek> days = default;
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerDataBoxEdgeContext.Default);
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
                        if (property0.NameEquals("start"u8))
                        {
                            start = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("stop"u8))
                        {
                            stop = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("rateInMbps"u8))
                        {
                            rateInMbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("days"u8))
                        {
                            List<DataBoxEdgeDayOfWeek> array = new List<DataBoxEdgeDayOfWeek>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataBoxEdgeDayOfWeek(item.GetString()));
                            }
                            days = array;
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
            return new BandwidthScheduleData(
                id,
                name,
                type,
                systemData,
                start,
                stop,
                rateInMbps,
                days,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BandwidthScheduleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BandwidthScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataBoxEdgeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BandwidthScheduleData)} does not support writing '{options.Format}' format.");
            }
        }

        BandwidthScheduleData IPersistableModel<BandwidthScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BandwidthScheduleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBandwidthScheduleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BandwidthScheduleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BandwidthScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
