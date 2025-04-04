// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsScriptExecutionCancelledEventDataConverter))]
    public partial class AvsScriptExecutionCancelledEventData
    {
        internal static AvsScriptExecutionCancelledEventData DeserializeAvsScriptExecutionCancelledEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            string cmdletId = default;
            IReadOnlyList<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cmdletId"u8))
                {
                    cmdletId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
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
                    output = array;
                    continue;
                }
            }
            return new AvsScriptExecutionCancelledEventData(operationId, cmdletId, output ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsScriptExecutionCancelledEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAvsScriptExecutionCancelledEventData(document.RootElement);
        }

        internal partial class AvsScriptExecutionCancelledEventDataConverter : JsonConverter<AvsScriptExecutionCancelledEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsScriptExecutionCancelledEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AvsScriptExecutionCancelledEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsScriptExecutionCancelledEventData(document.RootElement);
            }
        }
    }
}
