// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingPolicyWidevineConfiguration : IUtf8JsonSerializable, IJsonModel<StreamingPolicyWidevineConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingPolicyWidevineConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingPolicyWidevineConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CustomLicenseAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customLicenseAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomLicenseAcquisitionUriTemplate);
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

        StreamingPolicyWidevineConfiguration IJsonModel<StreamingPolicyWidevineConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingPolicyWidevineConfiguration(document.RootElement, options);
        }

        internal static StreamingPolicyWidevineConfiguration DeserializeStreamingPolicyWidevineConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customLicenseAcquisitionUriTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customLicenseAcquisitionUrlTemplate"u8))
                {
                    customLicenseAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamingPolicyWidevineConfiguration(customLicenseAcquisitionUriTemplate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingPolicyWidevineConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingPolicyWidevineConfiguration IPersistableModel<StreamingPolicyWidevineConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingPolicyWidevineConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingPolicyWidevineConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingPolicyWidevineConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingPolicyWidevineConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
