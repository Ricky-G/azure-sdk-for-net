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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class MarketplaceSaaSInfo : IUtf8JsonSerializable, IJsonModel<MarketplaceSaaSInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceSaaSInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MarketplaceSaaSInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSaaSInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MarketplaceSubscription))
            {
                writer.WritePropertyName("marketplaceSubscription"u8);
                ((IJsonModel<SubResource>)MarketplaceSubscription).Write(writer, options);
            }
            if (Optional.IsDefined(MarketplaceName))
            {
                writer.WritePropertyName("marketplaceName"u8);
                writer.WriteStringValue(MarketplaceName);
            }
            if (Optional.IsDefined(MarketplaceResourceId))
            {
                writer.WritePropertyName("marketplaceResourceId"u8);
                writer.WriteStringValue(MarketplaceResourceId);
            }
            if (Optional.IsDefined(MarketplaceStatus))
            {
                writer.WritePropertyName("marketplaceStatus"u8);
                writer.WriteStringValue(MarketplaceStatus);
            }
            if (Optional.IsDefined(BilledAzureSubscriptionId))
            {
                writer.WritePropertyName("billedAzureSubscriptionId"u8);
                writer.WriteStringValue(BilledAzureSubscriptionId);
            }
            if (Optional.IsDefined(IsSubscribed))
            {
                writer.WritePropertyName("subscribed"u8);
                writer.WriteBooleanValue(IsSubscribed.Value);
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

        MarketplaceSaaSInfo IJsonModel<MarketplaceSaaSInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceSaaSInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceSaaSInfo(document.RootElement, options);
        }

        internal static MarketplaceSaaSInfo DeserializeMarketplaceSaaSInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubResource marketplaceSubscription = default;
            string marketplaceName = default;
            string marketplaceResourceId = default;
            string marketplaceStatus = default;
            string billedAzureSubscriptionId = default;
            bool? subscribed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("marketplaceSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscription = ModelReaderWriter.Read<SubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerElasticContext.Default);
                    continue;
                }
                if (property.NameEquals("marketplaceName"u8))
                {
                    marketplaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceResourceId"u8))
                {
                    marketplaceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("marketplaceStatus"u8))
                {
                    marketplaceStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billedAzureSubscriptionId"u8))
                {
                    billedAzureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscribed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscribed = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MarketplaceSaaSInfo(
                marketplaceSubscription,
                marketplaceName,
                marketplaceResourceId,
                marketplaceStatus,
                billedAzureSubscriptionId,
                subscribed,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceSaaSInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerElasticContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSaaSInfo)} does not support writing '{options.Format}' format.");
            }
        }

        MarketplaceSaaSInfo IPersistableModel<MarketplaceSaaSInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceSaaSInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMarketplaceSaaSInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceSaaSInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceSaaSInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
