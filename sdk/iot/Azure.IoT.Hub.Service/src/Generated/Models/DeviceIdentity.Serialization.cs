// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class DeviceIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(GenerationId))
            {
                writer.WritePropertyName("generationId"u8);
                writer.WriteStringValue(GenerationId);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteStringValue(ConnectionState.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StatusReason))
            {
                writer.WritePropertyName("statusReason"u8);
                writer.WriteStringValue(StatusReason);
            }
            if (Optional.IsDefined(ConnectionStateUpdatedTime))
            {
                writer.WritePropertyName("connectionStateUpdatedTime"u8);
                writer.WriteStringValue(ConnectionStateUpdatedTime.Value, "O");
            }
            if (Optional.IsDefined(StatusUpdatedTime))
            {
                writer.WritePropertyName("statusUpdatedTime"u8);
                writer.WriteStringValue(StatusUpdatedTime.Value, "O");
            }
            if (Optional.IsDefined(LastActivityTime))
            {
                writer.WritePropertyName("lastActivityTime"u8);
                writer.WriteStringValue(LastActivityTime.Value, "O");
            }
            if (Optional.IsDefined(CloudToDeviceMessageCount))
            {
                writer.WritePropertyName("cloudToDeviceMessageCount"u8);
                writer.WriteNumberValue(CloudToDeviceMessageCount.Value);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
            if (Optional.IsDefined(DeviceScope))
            {
                writer.WritePropertyName("deviceScope"u8);
                writer.WriteStringValue(DeviceScope);
            }
            writer.WriteEndObject();
        }

        internal static DeviceIdentity DeserializeDeviceIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deviceId = default;
            string generationId = default;
            string etag = default;
            DeviceConnectionState? connectionState = default;
            DeviceStatus? status = default;
            string statusReason = default;
            DateTimeOffset? connectionStateUpdatedTime = default;
            DateTimeOffset? statusUpdatedTime = default;
            DateTimeOffset? lastActivityTime = default;
            int? cloudToDeviceMessageCount = default;
            AuthenticationMechanism authentication = default;
            DeviceCapabilities capabilities = default;
            string deviceScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generationId"u8))
                {
                    generationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = new DeviceConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DeviceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionStateUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStateUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActivityTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastActivityTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cloudToDeviceMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDeviceMessageCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = AuthenticationMechanism.DeserializeAuthenticationMechanism(property.Value);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = DeviceCapabilities.DeserializeDeviceCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("deviceScope"u8))
                {
                    deviceScope = property.Value.GetString();
                    continue;
                }
            }
            return new DeviceIdentity(
                deviceId,
                generationId,
                etag,
                connectionState,
                status,
                statusReason,
                connectionStateUpdatedTime,
                statusUpdatedTime,
                lastActivityTime,
                cloudToDeviceMessageCount,
                authentication,
                capabilities,
                deviceScope);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DeviceIdentity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDeviceIdentity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
