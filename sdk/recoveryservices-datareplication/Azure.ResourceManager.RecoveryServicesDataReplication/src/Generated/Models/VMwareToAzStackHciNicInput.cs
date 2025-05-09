// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMwareToAzStackHCI NIC properties. </summary>
    public partial class VMwareToAzStackHciNicInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciNicInput"/>. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="label"> Gets or sets the NIC label. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nicId"/> or <paramref name="label"/> is null. </exception>
        public VMwareToAzStackHciNicInput(string nicId, string label, VmNicSelection selectionTypeForFailover)
        {
            Argument.AssertNotNull(nicId, nameof(nicId));
            Argument.AssertNotNull(label, nameof(label));

            NicId = nicId;
            Label = label;
            SelectionTypeForFailover = selectionTypeForFailover;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciNicInput"/>. </summary>
        /// <param name="nicId"> Gets or sets the NIC Id. </param>
        /// <param name="label"> Gets or sets the NIC label. </param>
        /// <param name="networkName"> Gets or sets the network name. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="selectionTypeForFailover"> Gets or sets the selection type of the NIC. </param>
        /// <param name="isStaticIPMigrationEnabled"> Gets or sets a value indicating whether static ip migration is enabled. </param>
        /// <param name="isMacMigrationEnabled"> Gets or sets a value indicating whether mac address migration is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareToAzStackHciNicInput(string nicId, string label, string networkName, string targetNetworkId, string testNetworkId, VmNicSelection selectionTypeForFailover, bool? isStaticIPMigrationEnabled, bool? isMacMigrationEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NicId = nicId;
            Label = label;
            NetworkName = networkName;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            SelectionTypeForFailover = selectionTypeForFailover;
            IsStaticIPMigrationEnabled = isStaticIPMigrationEnabled;
            IsMacMigrationEnabled = isMacMigrationEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciNicInput"/> for deserialization. </summary>
        internal VMwareToAzStackHciNicInput()
        {
        }

        /// <summary> Gets or sets the NIC Id. </summary>
        public string NicId { get; set; }
        /// <summary> Gets or sets the NIC label. </summary>
        public string Label { get; set; }
        /// <summary> Gets or sets the network name. </summary>
        public string NetworkName { get; }
        /// <summary> Gets or sets the target network Id within AzStackHCI Cluster. </summary>
        public string TargetNetworkId { get; set; }
        /// <summary> Gets or sets the target test network Id within AzStackHCI Cluster. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> Gets or sets the selection type of the NIC. </summary>
        public VmNicSelection SelectionTypeForFailover { get; set; }
        /// <summary> Gets or sets a value indicating whether static ip migration is enabled. </summary>
        public bool? IsStaticIPMigrationEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether mac address migration is enabled. </summary>
        public bool? IsMacMigrationEnabled { get; set; }
    }
}
