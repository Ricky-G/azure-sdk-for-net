// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusImageDeployMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusImageDeployMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusImageDeployMappingRuleProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureOperatorNexusImageDeployMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageDeployMappingRuleProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ImageMappingRuleProfile))
            {
                writer.WritePropertyName("imageMappingRuleProfile"u8);
                writer.WriteObjectValue(ImageMappingRuleProfile, options);
            }
        }

        AzureOperatorNexusImageDeployMappingRuleProfile IJsonModel<AzureOperatorNexusImageDeployMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusImageDeployMappingRuleProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(document.RootElement, options);
        }

        internal static AzureOperatorNexusImageDeployMappingRuleProfile DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageMappingRuleProfile imageMappingRuleProfile = default;
            ApplicationEnablement? applicationEnablement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageMappingRuleProfile = ImageMappingRuleProfile.DeserializeImageMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationEnablement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationEnablement = new ApplicationEnablement(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureOperatorNexusImageDeployMappingRuleProfile(applicationEnablement, serializedAdditionalRawData, imageMappingRuleProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageDeployMappingRuleProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AzureOperatorNexusImageDeployMappingRuleProfile IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusImageDeployMappingRuleProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusImageDeployMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
