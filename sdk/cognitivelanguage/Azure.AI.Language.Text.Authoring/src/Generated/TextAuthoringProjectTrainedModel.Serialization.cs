// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class TextAuthoringProjectTrainedModel : IUtf8JsonSerializable, IJsonModel<TextAuthoringProjectTrainedModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringProjectTrainedModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringProjectTrainedModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringProjectTrainedModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringProjectTrainedModel)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("lastTrainedDateTime"u8);
            writer.WriteStringValue(LastTrainedOn, "O");
            writer.WritePropertyName("lastTrainingDurationInSeconds"u8);
            writer.WriteNumberValue(LastTrainingDurationInSeconds);
            writer.WritePropertyName("modelExpirationDate"u8);
            writer.WriteStringValue(ModelExpiredOn, "D");
            writer.WritePropertyName("modelTrainingConfigVersion"u8);
            writer.WriteStringValue(ModelTrainingConfigVersion);
            writer.WritePropertyName("hasSnapshot"u8);
            writer.WriteBooleanValue(HasSnapshot);
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

        TextAuthoringProjectTrainedModel IJsonModel<TextAuthoringProjectTrainedModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringProjectTrainedModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringProjectTrainedModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringProjectTrainedModel(document.RootElement, options);
        }

        internal static TextAuthoringProjectTrainedModel DeserializeTextAuthoringProjectTrainedModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string label = default;
            string modelId = default;
            DateTimeOffset lastTrainedDateTime = default;
            int lastTrainingDurationInSeconds = default;
            DateTimeOffset modelExpirationDate = default;
            string modelTrainingConfigVersion = default;
            bool hasSnapshot = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastTrainedDateTime"u8))
                {
                    lastTrainedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTrainingDurationInSeconds"u8))
                {
                    lastTrainingDurationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("modelExpirationDate"u8))
                {
                    modelExpirationDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("modelTrainingConfigVersion"u8))
                {
                    modelTrainingConfigVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasSnapshot"u8))
                {
                    hasSnapshot = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringProjectTrainedModel(
                label,
                modelId,
                lastTrainedDateTime,
                lastTrainingDurationInSeconds,
                modelExpirationDate,
                modelTrainingConfigVersion,
                hasSnapshot,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringProjectTrainedModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringProjectTrainedModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringProjectTrainedModel)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringProjectTrainedModel IPersistableModel<TextAuthoringProjectTrainedModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringProjectTrainedModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringProjectTrainedModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringProjectTrainedModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringProjectTrainedModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringProjectTrainedModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringProjectTrainedModel(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
