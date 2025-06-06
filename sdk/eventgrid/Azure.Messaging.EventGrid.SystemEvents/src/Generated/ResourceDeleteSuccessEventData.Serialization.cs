// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceDeleteSuccessEventDataConverter))]
    public partial class ResourceDeleteSuccessEventData : IUtf8JsonSerializable, IJsonModel<ResourceDeleteSuccessEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceDeleteSuccessEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceDeleteSuccessEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceDeleteSuccessEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceDeleteSuccessEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(ResourceProvider))
            {
                writer.WritePropertyName("resourceProvider"u8);
                writer.WriteStringValue(ResourceProvider);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUri);
            }
            if (Optional.IsDefined(OperationName))
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WritePropertyName("authorization"u8);
            AuthorizationJson.WriteTo(writer);
            writer.WritePropertyName("claims"u8);
            ClaimsJson.WriteTo(writer);
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            writer.WritePropertyName("httpRequest"u8);
            HttpRequestJson.WriteTo(writer);
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

        ResourceDeleteSuccessEventData IJsonModel<ResourceDeleteSuccessEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceDeleteSuccessEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceDeleteSuccessEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceDeleteSuccessEventData(document.RootElement, options);
        }

        internal static ResourceDeleteSuccessEventData DeserializeResourceDeleteSuccessEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tenantId = default;
            string subscriptionId = default;
            string resourceGroup = default;
            string resourceProvider = default;
            string resourceUri = default;
            string operationName = default;
            string status = default;
            JsonElement authorization = default;
            JsonElement claims = default;
            string correlationId = default;
            JsonElement httpRequest = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProvider"u8))
                {
                    resourceProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    authorization = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    claims = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpRequest"u8))
                {
                    httpRequest = property.Value.Clone();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceDeleteSuccessEventData(
                tenantId,
                subscriptionId,
                resourceGroup,
                resourceProvider,
                resourceUri,
                operationName,
                status,
                authorization,
                claims,
                correlationId,
                httpRequest,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceDeleteSuccessEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceDeleteSuccessEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureMessagingEventGridSystemEventsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ResourceDeleteSuccessEventData)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceDeleteSuccessEventData IPersistableModel<ResourceDeleteSuccessEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceDeleteSuccessEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceDeleteSuccessEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceDeleteSuccessEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceDeleteSuccessEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceDeleteSuccessEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeResourceDeleteSuccessEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }

        internal partial class ResourceDeleteSuccessEventDataConverter : JsonConverter<ResourceDeleteSuccessEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceDeleteSuccessEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model, ModelSerializationExtensions.WireOptions);
            }

            public override ResourceDeleteSuccessEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceDeleteSuccessEventData(document.RootElement);
            }
        }
    }
}
