// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class ListIndexesResult
    {
        internal static ListIndexesResult DeserializeListIndexesResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SearchIndex> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SearchIndex> array = new List<SearchIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndex.DeserializeSearchIndex(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListIndexesResult(value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ListIndexesResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeListIndexesResult(document.RootElement);
        }
    }
}
