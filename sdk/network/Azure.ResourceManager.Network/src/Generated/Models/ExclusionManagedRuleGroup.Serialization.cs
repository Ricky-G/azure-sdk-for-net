// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExclusionManagedRuleGroup : IUtf8JsonSerializable, IJsonModel<ExclusionManagedRuleGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExclusionManagedRuleGroup>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExclusionManagedRuleGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExclusionManagedRuleGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExclusionManagedRuleGroup)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ruleGroupName"u8);
            writer.WriteStringValue(RuleGroupName);
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
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

        ExclusionManagedRuleGroup IJsonModel<ExclusionManagedRuleGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExclusionManagedRuleGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExclusionManagedRuleGroup)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExclusionManagedRuleGroup(document.RootElement, options);
        }

        internal static ExclusionManagedRuleGroup DeserializeExclusionManagedRuleGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleGroupName = default;
            IList<ExclusionManagedRule> rules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"u8))
                {
                    ruleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExclusionManagedRule> array = new List<ExclusionManagedRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExclusionManagedRule.DeserializeExclusionManagedRule(item, options));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExclusionManagedRuleGroup(ruleGroupName, rules ?? new ChangeTrackingList<ExclusionManagedRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExclusionManagedRuleGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExclusionManagedRuleGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExclusionManagedRuleGroup)} does not support writing '{options.Format}' format.");
            }
        }

        ExclusionManagedRuleGroup IPersistableModel<ExclusionManagedRuleGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExclusionManagedRuleGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExclusionManagedRuleGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExclusionManagedRuleGroup)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExclusionManagedRuleGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
