// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisFirewallRuleResource : IJsonModel<RedisFirewallRuleData>
    {
        private static RedisFirewallRuleData s_dataDeserializationInstance;
        private static RedisFirewallRuleData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<RedisFirewallRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisFirewallRuleData>)Data).Write(writer, options);

        RedisFirewallRuleData IJsonModel<RedisFirewallRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisFirewallRuleData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<RedisFirewallRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RedisFirewallRuleData>(Data, options, AzureResourceManagerRedisContext.Default);

        RedisFirewallRuleData IPersistableModel<RedisFirewallRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisFirewallRuleData>(data, options, AzureResourceManagerRedisContext.Default);

        string IPersistableModel<RedisFirewallRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisFirewallRuleData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
