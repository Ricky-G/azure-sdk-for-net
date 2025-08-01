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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ConfluentAgreement : IUtf8JsonSerializable, IJsonModel<ConfluentAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfluentAgreement>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfluentAgreement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentAgreement)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (Optional.IsDefined(LicenseTextLink))
            {
                writer.WritePropertyName("licenseTextLink"u8);
                writer.WriteStringValue(LicenseTextLink);
            }
            if (Optional.IsDefined(PrivacyPolicyLink))
            {
                writer.WritePropertyName("privacyPolicyLink"u8);
                writer.WriteStringValue(PrivacyPolicyLink);
            }
            if (Optional.IsDefined(RetrieveOn))
            {
                writer.WritePropertyName("retrieveDatetime"u8);
                writer.WriteStringValue(RetrieveOn.Value, "O");
            }
            if (Optional.IsDefined(Signature))
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (Optional.IsDefined(IsAccepted))
            {
                writer.WritePropertyName("accepted"u8);
                writer.WriteBooleanValue(IsAccepted.Value);
            }
            writer.WriteEndObject();
        }

        ConfluentAgreement IJsonModel<ConfluentAgreement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentAgreement)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfluentAgreement(document.RootElement, options);
        }

        internal static ConfluentAgreement DeserializeConfluentAgreement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string publisher = default;
            string product = default;
            string plan = default;
            string licenseTextLink = default;
            string privacyPolicyLink = default;
            DateTimeOffset? retrieveDatetime = default;
            string signature = default;
            bool? accepted = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConfluentContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseTextLink"u8))
                        {
                            licenseTextLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyLink"u8))
                        {
                            privacyPolicyLink = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retrieveDatetime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrieveDatetime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("signature"u8))
                        {
                            signature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accepted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accepted = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfluentAgreement(
                id,
                name,
                type,
                systemData,
                publisher,
                product,
                plan,
                licenseTextLink,
                privacyPolicyLink,
                retrieveDatetime,
                signature,
                accepted,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfluentAgreement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConfluentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConfluentAgreement)} does not support writing '{options.Format}' format.");
            }
        }

        ConfluentAgreement IPersistableModel<ConfluentAgreement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfluentAgreement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfluentAgreement)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfluentAgreement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
