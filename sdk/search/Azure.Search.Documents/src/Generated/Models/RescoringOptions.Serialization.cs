// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class RescoringOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EnableRescoring))
            {
                if (EnableRescoring != null)
                {
                    writer.WritePropertyName("enableRescoring"u8);
                    writer.WriteBooleanValue(EnableRescoring.Value);
                }
                else
                {
                    writer.WriteNull("enableRescoring");
                }
            }
            if (Optional.IsDefined(DefaultOversampling))
            {
                if (DefaultOversampling != null)
                {
                    writer.WritePropertyName("defaultOversampling"u8);
                    writer.WriteNumberValue(DefaultOversampling.Value);
                }
                else
                {
                    writer.WriteNull("defaultOversampling");
                }
            }
            if (Optional.IsDefined(RescoreStorageMethod))
            {
                if (RescoreStorageMethod != null)
                {
                    writer.WritePropertyName("rescoreStorageMethod"u8);
                    writer.WriteStringValue(RescoreStorageMethod.Value.ToString());
                }
                else
                {
                    writer.WriteNull("rescoreStorageMethod");
                }
            }
            writer.WriteEndObject();
        }

        internal static RescoringOptions DeserializeRescoringOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableRescoring = default;
            double? defaultOversampling = default;
            VectorSearchCompressionRescoreStorageMethod? rescoreStorageMethod = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableRescoring"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableRescoring = null;
                        continue;
                    }
                    enableRescoring = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultOversampling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultOversampling = null;
                        continue;
                    }
                    defaultOversampling = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("rescoreStorageMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rescoreStorageMethod = null;
                        continue;
                    }
                    rescoreStorageMethod = new VectorSearchCompressionRescoreStorageMethod(property.Value.GetString());
                    continue;
                }
            }
            return new RescoringOptions(enableRescoring, defaultOversampling, rescoreStorageMethod);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RescoringOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRescoringOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
