// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.OpenAI
{
    internal static partial class ElasticsearchChatDataSourceParametersQueryTypeExtensions
    {
        /// <param name="value"> The value to serialize. </param>
        public static string ToSerialString(this ElasticsearchChatDataSourceParametersQueryType value) => value switch
        {
            ElasticsearchChatDataSourceParametersQueryType.Simple => "simple",
            ElasticsearchChatDataSourceParametersQueryType.Vector => "vector",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticsearchChatDataSourceParametersQueryType value.")
        };

        /// <param name="value"> The value to deserialize. </param>
        public static ElasticsearchChatDataSourceParametersQueryType ToElasticsearchChatDataSourceParametersQueryType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "simple"))
            {
                return ElasticsearchChatDataSourceParametersQueryType.Simple;
            }
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "vector"))
            {
                return ElasticsearchChatDataSourceParametersQueryType.Vector;
            }
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ElasticsearchChatDataSourceParametersQueryType value.");
        }
    }
}
