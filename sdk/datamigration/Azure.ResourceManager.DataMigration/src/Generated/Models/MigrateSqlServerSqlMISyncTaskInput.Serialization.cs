// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMISyncTaskInput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMISyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMISyncTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSqlServerSqlMISyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskInput)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(NumberOfParallelDatabaseMigrations))
            {
                writer.WritePropertyName("numberOfParallelDatabaseMigrations"u8);
                writer.WriteNumberValue(NumberOfParallelDatabaseMigrations.Value);
            }
        }

        MigrateSqlServerSqlMISyncTaskInput IJsonModel<MigrateSqlServerSqlMISyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMISyncTaskInput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMISyncTaskInput DeserializeMigrateSqlServerSqlMISyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? numberOfParallelDatabaseMigrations = default;
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            DataMigrationFileShareInfo backupFileShare = default;
            string storageResourceId = default;
            DataMigrationSqlConnectionInfo sourceConnectionInfo = default;
            DataMigrationMISqlConnectionInfo targetConnectionInfo = default;
            DataMigrationAadApp azureApp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfParallelDatabaseMigrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfParallelDatabaseMigrations = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = DataMigrationFileShareInfo.DeserializeDataMigrationFileShareInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    storageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = DataMigrationSqlConnectionInfo.DeserializeDataMigrationSqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = DataMigrationMISqlConnectionInfo.DeserializeDataMigrationMISqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureApp"u8))
                {
                    azureApp = DataMigrationAadApp.DeserializeDataMigrationAadApp(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateSqlServerSqlMISyncTaskInput(
                selectedDatabases,
                backupFileShare,
                storageResourceId,
                sourceConnectionInfo,
                targetConnectionInfo,
                azureApp,
                serializedAdditionalRawData,
                numberOfParallelDatabaseMigrations);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataMigrationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMISyncTaskInput IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMigrateSqlServerSqlMISyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMISyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
