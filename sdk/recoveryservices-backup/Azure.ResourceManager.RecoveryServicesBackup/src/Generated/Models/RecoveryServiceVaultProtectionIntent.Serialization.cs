// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryServiceVaultProtectionIntent : IUtf8JsonSerializable, IJsonModel<RecoveryServiceVaultProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryServiceVaultProtectionIntent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryServiceVaultProtectionIntent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        RecoveryServiceVaultProtectionIntent IJsonModel<RecoveryServiceVaultProtectionIntent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServiceVaultProtectionIntent(document.RootElement, options);
        }

        internal static RecoveryServiceVaultProtectionIntent DeserializeRecoveryServiceVaultProtectionIntent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectionIntentItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadAutoProtectionIntent": return WorkloadAutoProtectionIntent.DeserializeWorkloadAutoProtectionIntent(element, options);
                    case "AzureWorkloadSQLAutoProtectionIntent": return WorkloadSqlAutoProtectionIntent.DeserializeWorkloadSqlAutoProtectionIntent(element, options);
                }
            }
            ProtectionIntentItemType protectionIntentItemType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            BackupManagementType? backupManagementType = default;
            ResourceIdentifier sourceResourceId = default;
            ResourceIdentifier itemId = default;
            ResourceIdentifier policyId = default;
            BackupProtectionStatus? protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionIntentItemType"u8))
                {
                    protectionIntentItemType = new ProtectionIntentItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryServiceVaultProtectionIntent(
                protectionIntentItemType,
                backupManagementType,
                sourceResourceId,
                itemId,
                policyId,
                protectionState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryServiceVaultProtectionIntent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryServiceVaultProtectionIntent IPersistableModel<RecoveryServiceVaultProtectionIntent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecoveryServiceVaultProtectionIntent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServiceVaultProtectionIntent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
