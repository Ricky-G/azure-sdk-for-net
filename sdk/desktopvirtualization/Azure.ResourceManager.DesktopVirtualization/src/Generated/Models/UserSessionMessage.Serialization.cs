// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class UserSessionMessage : IUtf8JsonSerializable, IJsonModel<UserSessionMessage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserSessionMessage>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserSessionMessage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserSessionMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserSessionMessage)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MessageTitle))
            {
                writer.WritePropertyName("messageTitle"u8);
                writer.WriteStringValue(MessageTitle);
            }
            if (Optional.IsDefined(MessageBody))
            {
                writer.WritePropertyName("messageBody"u8);
                writer.WriteStringValue(MessageBody);
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

        UserSessionMessage IJsonModel<UserSessionMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserSessionMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserSessionMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserSessionMessage(document.RootElement, options);
        }

        internal static UserSessionMessage DeserializeUserSessionMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string messageTitle = default;
            string messageBody = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageTitle"u8))
                {
                    messageTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageBody"u8))
                {
                    messageBody = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserSessionMessage(messageTitle, messageBody, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserSessionMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserSessionMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDesktopVirtualizationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(UserSessionMessage)} does not support writing '{options.Format}' format.");
            }
        }

        UserSessionMessage IPersistableModel<UserSessionMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserSessionMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUserSessionMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserSessionMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserSessionMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
