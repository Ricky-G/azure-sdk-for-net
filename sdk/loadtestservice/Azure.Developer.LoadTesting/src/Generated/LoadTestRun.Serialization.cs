// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting
{
    public partial class LoadTestRun : IUtf8JsonSerializable, IJsonModel<LoadTestRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestRun>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LoadTestRun>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestRun)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("testRunId"u8);
                writer.WriteStringValue(TestRunId);
            }
            if (Optional.IsDefined(PassFailCriteria))
            {
                writer.WritePropertyName("passFailCriteria"u8);
                writer.WriteObjectValue(PassFailCriteria, options);
            }
            if (Optional.IsDefined(AutoStopCriteria))
            {
                writer.WritePropertyName("autoStopCriteria"u8);
                writer.WriteObjectValue(AutoStopCriteria, options);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartObject();
                foreach (var item in Secrets)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteObjectValue(Certificate, options);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables"u8);
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ErrorDetails))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(TestRunStatistics))
            {
                writer.WritePropertyName("testRunStatistics"u8);
                writer.WriteStartObject();
                foreach (var item in TestRunStatistics)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RegionalStatistics))
            {
                writer.WritePropertyName("regionalStatistics"u8);
                writer.WriteStartObject();
                foreach (var item in RegionalStatistics)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(LoadTestConfiguration))
            {
                writer.WritePropertyName("loadTestConfiguration"u8);
                writer.WriteObjectValue(LoadTestConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TestArtifacts))
            {
                writer.WritePropertyName("testArtifacts"u8);
                writer.WriteObjectValue(TestArtifacts, options);
            }
            if (options.Format != "W" && Optional.IsDefined(TestResult))
            {
                writer.WritePropertyName("testResult"u8);
                writer.WriteStringValue(TestResult.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualUsers))
            {
                writer.WritePropertyName("virtualUsers"u8);
                writer.WriteNumberValue(VirtualUsers.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(TestId))
            {
                writer.WritePropertyName("testId"u8);
                writer.WriteStringValue(TestId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartDateTime))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndDateTime))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExecutedDateTime))
            {
                writer.WritePropertyName("executedDateTime"u8);
                writer.WriteStringValue(ExecutedDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PortalUri))
            {
                writer.WritePropertyName("portalUrl"u8);
                writer.WriteStringValue(PortalUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Duration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualUserHours))
            {
                writer.WritePropertyName("virtualUserHours"u8);
                writer.WriteNumberValue(VirtualUserHours.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(RequestDataLevel))
            {
                writer.WritePropertyName("requestDataLevel"u8);
                writer.WriteStringValue(RequestDataLevel.Value.ToString());
            }
            if (Optional.IsDefined(DebugLogsEnabled))
            {
                writer.WritePropertyName("debugLogsEnabled"u8);
                writer.WriteBooleanValue(DebugLogsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicIpDisabled))
            {
                writer.WritePropertyName("publicIPDisabled"u8);
                writer.WriteBooleanValue(PublicIpDisabled.Value);
            }
            if (Optional.IsDefined(CreatedByType))
            {
                writer.WritePropertyName("createdByType"u8);
                writer.WriteStringValue(CreatedByType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedDateTime))
            {
                writer.WritePropertyName("createdDateTime"u8);
                writer.WriteStringValue(CreatedDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedDateTime))
            {
                writer.WritePropertyName("lastModifiedDateTime"u8);
                writer.WriteStringValue(LastModifiedDateTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedBy))
            {
                writer.WritePropertyName("lastModifiedBy"u8);
                writer.WriteStringValue(LastModifiedBy);
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

        LoadTestRun IJsonModel<LoadTestRun>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestRun>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestRun)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestRun(document.RootElement, options);
        }

        internal static LoadTestRun DeserializeLoadTestRun(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string testRunId = default;
            PassFailCriteria passFailCriteria = default;
            AutoStopCriteria autoStopCriteria = default;
            IDictionary<string, TestSecret> secrets = default;
            TestCertificate certificate = default;
            IDictionary<string, string> environmentVariables = default;
            IReadOnlyList<ErrorDetails> errorDetails = default;
            IReadOnlyDictionary<string, TestRunStatistics> testRunStatistics = default;
            IReadOnlyDictionary<string, TestRunStatistics> regionalStatistics = default;
            LoadTestConfiguration loadTestConfiguration = default;
            TestRunArtifacts testArtifacts = default;
            PassFailTestResult? testResult = default;
            int? virtualUsers = default;
            string displayName = default;
            string testId = default;
            string description = default;
            TestRunStatus? status = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? endDateTime = default;
            DateTimeOffset? executedDateTime = default;
            Uri portalUrl = default;
            long? duration = default;
            double? virtualUserHours = default;
            string subnetId = default;
            LoadTestKind? kind = default;
            RequestDataLevel? requestDataLevel = default;
            bool? debugLogsEnabled = default;
            bool? publicIPDisabled = default;
            CreatedByType? createdByType = default;
            DateTimeOffset? createdDateTime = default;
            string createdBy = default;
            DateTimeOffset? lastModifiedDateTime = default;
            string lastModifiedBy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("testRunId"u8))
                {
                    testRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("passFailCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    passFailCriteria = PassFailCriteria.DeserializePassFailCriteria(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoStopCriteria"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoStopCriteria = AutoStopCriteria.DeserializeAutoStopCriteria(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TestSecret> dictionary = new Dictionary<string, TestSecret>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, TestSecret.DeserializeTestSecret(property0.Value, options));
                    }
                    secrets = dictionary;
                    continue;
                }
                if (property.NameEquals("certificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificate = TestCertificate.DeserializeTestCertificate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ErrorDetails> array = new List<ErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTesting.ErrorDetails.DeserializeErrorDetails(item, options));
                    }
                    errorDetails = array;
                    continue;
                }
                if (property.NameEquals("testRunStatistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TestRunStatistics> dictionary = new Dictionary<string, TestRunStatistics>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, LoadTesting.TestRunStatistics.DeserializeTestRunStatistics(property0.Value, options));
                    }
                    testRunStatistics = dictionary;
                    continue;
                }
                if (property.NameEquals("regionalStatistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, TestRunStatistics> dictionary = new Dictionary<string, TestRunStatistics>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, LoadTesting.TestRunStatistics.DeserializeTestRunStatistics(property0.Value, options));
                    }
                    regionalStatistics = dictionary;
                    continue;
                }
                if (property.NameEquals("loadTestConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadTestConfiguration = LoadTestConfiguration.DeserializeLoadTestConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testArtifacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testArtifacts = TestRunArtifacts.DeserializeTestRunArtifacts(property.Value, options);
                    continue;
                }
                if (property.NameEquals("testResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testResult = new PassFailTestResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualUsers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualUsers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testId"u8))
                {
                    testId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new TestRunStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("executedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("portalUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portalUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("virtualUserHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualUserHours = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new LoadTestKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestDataLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestDataLevel = new RequestDataLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("debugLogsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugLogsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicIPDisabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicIPDisabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("createdByType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByType = new CreatedByType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    lastModifiedBy = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LoadTestRun(
                testRunId,
                passFailCriteria,
                autoStopCriteria,
                secrets ?? new ChangeTrackingDictionary<string, TestSecret>(),
                certificate,
                environmentVariables ?? new ChangeTrackingDictionary<string, string>(),
                errorDetails ?? new ChangeTrackingList<ErrorDetails>(),
                testRunStatistics ?? new ChangeTrackingDictionary<string, TestRunStatistics>(),
                regionalStatistics ?? new ChangeTrackingDictionary<string, TestRunStatistics>(),
                loadTestConfiguration,
                testArtifacts,
                testResult,
                virtualUsers,
                displayName,
                testId,
                description,
                status,
                startDateTime,
                endDateTime,
                executedDateTime,
                portalUrl,
                duration,
                virtualUserHours,
                subnetId,
                kind,
                requestDataLevel,
                debugLogsEnabled,
                publicIPDisabled,
                createdByType,
                createdDateTime,
                createdBy,
                lastModifiedDateTime,
                lastModifiedBy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestRun>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureDeveloperLoadTestingContext.Default);
                default:
                    throw new FormatException($"The model {nameof(LoadTestRun)} does not support writing '{options.Format}' format.");
            }
        }

        LoadTestRun IPersistableModel<LoadTestRun>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestRun>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLoadTestRun(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadTestRun)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadTestRun>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LoadTestRun FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeLoadTestRun(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
