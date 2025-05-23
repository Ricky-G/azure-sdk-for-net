// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class WebApplicationFirewallComponentVersions : IUtf8JsonSerializable, IJsonModel<WebApplicationFirewallComponentVersions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebApplicationFirewallComponentVersions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebApplicationFirewallComponentVersions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallComponentVersions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallComponentVersions)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("wafEngineVersion"u8);
            writer.WriteStringValue(WafEngineVersion);
            writer.WritePropertyName("wafNginxVersion"u8);
            writer.WriteStringValue(WafNginxVersion);
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

        WebApplicationFirewallComponentVersions IJsonModel<WebApplicationFirewallComponentVersions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallComponentVersions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebApplicationFirewallComponentVersions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebApplicationFirewallComponentVersions(document.RootElement, options);
        }

        internal static WebApplicationFirewallComponentVersions DeserializeWebApplicationFirewallComponentVersions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string wafEngineVersion = default;
            string wafNginxVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wafEngineVersion"u8))
                {
                    wafEngineVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wafNginxVersion"u8))
                {
                    wafNginxVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebApplicationFirewallComponentVersions(wafEngineVersion, wafNginxVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebApplicationFirewallComponentVersions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallComponentVersions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNginxContext.Default);
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallComponentVersions)} does not support writing '{options.Format}' format.");
            }
        }

        WebApplicationFirewallComponentVersions IPersistableModel<WebApplicationFirewallComponentVersions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebApplicationFirewallComponentVersions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebApplicationFirewallComponentVersions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebApplicationFirewallComponentVersions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebApplicationFirewallComponentVersions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
