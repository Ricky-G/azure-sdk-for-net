// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4Meta : IUtf8JsonSerializable, IJsonModel<FhirR4Meta>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Meta>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FhirR4Meta>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Meta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Meta)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(VersionId))
            {
                writer.WritePropertyName("versionId"u8);
                writer.WriteStringValue(VersionId);
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsCollectionDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStartArray();
                foreach (var item in Profile)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Security))
            {
                writer.WritePropertyName("security"u8);
                writer.WriteStartArray();
                foreach (var item in Security)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStartArray();
                foreach (var item in Tag)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        FhirR4Meta IJsonModel<FhirR4Meta>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Meta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Meta)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Meta(document.RootElement, options);
        }

        internal static FhirR4Meta DeserializeFhirR4Meta(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string versionId = default;
            string lastUpdated = default;
            string source = default;
            IList<string> profile = default;
            IList<FhirR4Coding> security = default;
            IList<FhirR4Coding> tag = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("versionId"u8))
                {
                    versionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    lastUpdated = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    profile = array;
                    continue;
                }
                if (property.NameEquals("security"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Coding> array = new List<FhirR4Coding>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Coding.DeserializeFhirR4Coding(item, options));
                    }
                    security = array;
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Coding> array = new List<FhirR4Coding>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Coding.DeserializeFhirR4Coding(item, options));
                    }
                    tag = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FhirR4Meta(
                versionId,
                lastUpdated,
                source,
                profile ?? new ChangeTrackingList<string>(),
                security ?? new ChangeTrackingList<FhirR4Coding>(),
                tag ?? new ChangeTrackingList<FhirR4Coding>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FhirR4Meta>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Meta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureHealthInsightsRadiologyInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Meta)} does not support writing '{options.Format}' format.");
            }
        }

        FhirR4Meta IPersistableModel<FhirR4Meta>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Meta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFhirR4Meta(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Meta)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Meta>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FhirR4Meta FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeFhirR4Meta(document.RootElement);
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
