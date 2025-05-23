// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class AsAsset : IUtf8JsonSerializable, IJsonModel<AsAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AsAsset>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AsAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsAsset)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (Optional.IsCollectionDefined(AsNames))
            {
                writer.WritePropertyName("asNames"u8);
                writer.WriteStartArray();
                foreach (var item in AsNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OrgNames))
            {
                writer.WritePropertyName("orgNames"u8);
                writer.WriteStartArray();
                foreach (var item in OrgNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OrgIds))
            {
                writer.WritePropertyName("orgIds"u8);
                writer.WriteStartArray();
                foreach (var item in OrgIds)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Countries))
            {
                writer.WritePropertyName("countries"u8);
                writer.WriteStartArray();
                foreach (var item in Countries)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Registries))
            {
                writer.WritePropertyName("registries"u8);
                writer.WriteStartArray();
                foreach (var item in Registries)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirstSeen))
            {
                writer.WritePropertyName("firstSeen"u8);
                writer.WriteStringValue(FirstSeen.Value, "O");
            }
            if (Optional.IsDefined(LastSeen))
            {
                writer.WritePropertyName("lastSeen"u8);
                writer.WriteStringValue(LastSeen.Value, "O");
            }
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsCollectionDefined(RegistrarCreatedAt))
            {
                writer.WritePropertyName("registrarCreatedAt"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarCreatedAt)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistrarUpdatedAt))
            {
                writer.WritePropertyName("registrarUpdatedAt"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarUpdatedAt)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistrantContacts))
            {
                writer.WritePropertyName("registrantContacts"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantContacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdminContacts))
            {
                writer.WritePropertyName("adminContacts"u8);
                writer.WriteStartArray();
                foreach (var item in AdminContacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TechnicalContacts))
            {
                writer.WritePropertyName("technicalContacts"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalContacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistrarNames))
            {
                writer.WritePropertyName("registrarNames"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrarNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistrantNames))
            {
                writer.WritePropertyName("registrantNames"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdminNames))
            {
                writer.WritePropertyName("adminNames"u8);
                writer.WriteStartArray();
                foreach (var item in AdminNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TechnicalNames))
            {
                writer.WritePropertyName("technicalNames"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalNames)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdminOrgs))
            {
                writer.WritePropertyName("adminOrgs"u8);
                writer.WriteStartArray();
                foreach (var item in AdminOrgs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TechnicalOrgs))
            {
                writer.WritePropertyName("technicalOrgs"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalOrgs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistrantPhones))
            {
                writer.WritePropertyName("registrantPhones"u8);
                writer.WriteStartArray();
                foreach (var item in RegistrantPhones)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdminPhones))
            {
                writer.WritePropertyName("adminPhones"u8);
                writer.WriteStartArray();
                foreach (var item in AdminPhones)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TechnicalPhones))
            {
                writer.WritePropertyName("technicalPhones"u8);
                writer.WriteStartArray();
                foreach (var item in TechnicalPhones)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DetailedFromWhoisAt))
            {
                writer.WritePropertyName("detailedFromWhoisAt"u8);
                writer.WriteStringValue(DetailedFromWhoisAt.Value, "O");
            }
        }

        AsAsset IJsonModel<AsAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AsAsset)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAsAsset(document.RootElement, options);
        }

        internal static AsAsset DeserializeAsAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? asn = default;
            IReadOnlyList<ObservedString> asNames = default;
            IReadOnlyList<ObservedString> orgNames = default;
            IReadOnlyList<ObservedString> orgIds = default;
            IReadOnlyList<ObservedString> countries = default;
            IReadOnlyList<ObservedString> registries = default;
            IReadOnlyList<SourceDetails> sources = default;
            DateTimeOffset? firstSeen = default;
            DateTimeOffset? lastSeen = default;
            long? count = default;
            IReadOnlyList<ObservedLong> registrarCreatedAt = default;
            IReadOnlyList<ObservedLong> registrarUpdatedAt = default;
            IReadOnlyList<ObservedString> registrantContacts = default;
            IReadOnlyList<ObservedString> adminContacts = default;
            IReadOnlyList<ObservedString> technicalContacts = default;
            IReadOnlyList<ObservedString> registrarNames = default;
            IReadOnlyList<ObservedString> registrantNames = default;
            IReadOnlyList<ObservedString> adminNames = default;
            IReadOnlyList<ObservedString> technicalNames = default;
            IReadOnlyList<ObservedString> adminOrgs = default;
            IReadOnlyList<ObservedString> technicalOrgs = default;
            IReadOnlyList<ObservedString> registrantPhones = default;
            IReadOnlyList<ObservedString> adminPhones = default;
            IReadOnlyList<ObservedString> technicalPhones = default;
            DateTimeOffset? detailedFromWhoisAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("asNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    asNames = array;
                    continue;
                }
                if (property.NameEquals("orgNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    orgNames = array;
                    continue;
                }
                if (property.NameEquals("orgIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    orgIds = array;
                    continue;
                }
                if (property.NameEquals("countries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    countries = array;
                    continue;
                }
                if (property.NameEquals("registries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registries = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SourceDetails> array = new List<SourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SourceDetails.DeserializeSourceDetails(item, options));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("registrarCreatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    registrarCreatedAt = array;
                    continue;
                }
                if (property.NameEquals("registrarUpdatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item, options));
                    }
                    registrarUpdatedAt = array;
                    continue;
                }
                if (property.NameEquals("registrantContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantContacts = array;
                    continue;
                }
                if (property.NameEquals("adminContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminContacts = array;
                    continue;
                }
                if (property.NameEquals("technicalContacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalContacts = array;
                    continue;
                }
                if (property.NameEquals("registrarNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrarNames = array;
                    continue;
                }
                if (property.NameEquals("registrantNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantNames = array;
                    continue;
                }
                if (property.NameEquals("adminNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminNames = array;
                    continue;
                }
                if (property.NameEquals("technicalNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalNames = array;
                    continue;
                }
                if (property.NameEquals("adminOrgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminOrgs = array;
                    continue;
                }
                if (property.NameEquals("technicalOrgs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalOrgs = array;
                    continue;
                }
                if (property.NameEquals("registrantPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    registrantPhones = array;
                    continue;
                }
                if (property.NameEquals("adminPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    adminPhones = array;
                    continue;
                }
                if (property.NameEquals("technicalPhones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item, options));
                    }
                    technicalPhones = array;
                    continue;
                }
                if (property.NameEquals("detailedFromWhoisAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detailedFromWhoisAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AsAsset(
                serializedAdditionalRawData,
                asn,
                asNames ?? new ChangeTrackingList<ObservedString>(),
                orgNames ?? new ChangeTrackingList<ObservedString>(),
                orgIds ?? new ChangeTrackingList<ObservedString>(),
                countries ?? new ChangeTrackingList<ObservedString>(),
                registries ?? new ChangeTrackingList<ObservedString>(),
                sources ?? new ChangeTrackingList<SourceDetails>(),
                firstSeen,
                lastSeen,
                count,
                registrarCreatedAt ?? new ChangeTrackingList<ObservedLong>(),
                registrarUpdatedAt ?? new ChangeTrackingList<ObservedLong>(),
                registrantContacts ?? new ChangeTrackingList<ObservedString>(),
                adminContacts ?? new ChangeTrackingList<ObservedString>(),
                technicalContacts ?? new ChangeTrackingList<ObservedString>(),
                registrarNames ?? new ChangeTrackingList<ObservedString>(),
                registrantNames ?? new ChangeTrackingList<ObservedString>(),
                adminNames ?? new ChangeTrackingList<ObservedString>(),
                technicalNames ?? new ChangeTrackingList<ObservedString>(),
                adminOrgs ?? new ChangeTrackingList<ObservedString>(),
                technicalOrgs ?? new ChangeTrackingList<ObservedString>(),
                registrantPhones ?? new ChangeTrackingList<ObservedString>(),
                adminPhones ?? new ChangeTrackingList<ObservedString>(),
                technicalPhones ?? new ChangeTrackingList<ObservedString>(),
                detailedFromWhoisAt);
        }

        BinaryData IPersistableModel<AsAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAnalyticsDefenderEasmContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AsAsset)} does not support writing '{options.Format}' format.");
            }
        }

        AsAsset IPersistableModel<AsAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AsAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAsAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AsAsset)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AsAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AsAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAsAsset(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
