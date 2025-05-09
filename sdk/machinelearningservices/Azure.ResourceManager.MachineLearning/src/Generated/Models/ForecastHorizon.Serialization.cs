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

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownForecastHorizon))]
    public partial class ForecastHorizon : IUtf8JsonSerializable, IJsonModel<ForecastHorizon>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ForecastHorizon>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ForecastHorizon>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastHorizon)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        ForecastHorizon IJsonModel<ForecastHorizon>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ForecastHorizon)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastHorizon(document.RootElement, options);
        }

        internal static ForecastHorizon DeserializeForecastHorizon(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Auto": return AutoForecastHorizon.DeserializeAutoForecastHorizon(element, options);
                    case "Custom": return CustomForecastHorizon.DeserializeCustomForecastHorizon(element, options);
                }
            }
            return UnknownForecastHorizon.DeserializeUnknownForecastHorizon(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Mode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  mode: ");
                builder.AppendLine($"'{Mode.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ForecastHorizon>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ForecastHorizon)} does not support writing '{options.Format}' format.");
            }
        }

        ForecastHorizon IPersistableModel<ForecastHorizon>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ForecastHorizon>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeForecastHorizon(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ForecastHorizon)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ForecastHorizon>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
