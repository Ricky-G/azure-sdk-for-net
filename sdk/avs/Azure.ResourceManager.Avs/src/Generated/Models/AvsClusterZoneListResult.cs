// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> List of all zones and associated hosts for a cluster. </summary>
    public partial class AvsClusterZoneListResult
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

        /// <summary> Initializes a new instance of <see cref="AvsClusterZoneListResult"/>. </summary>
        internal AvsClusterZoneListResult()
        {
            Zones = new ChangeTrackingList<AvsClusterZone>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsClusterZoneListResult"/>. </summary>
        /// <param name="zones"> Zone and associated hosts info. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsClusterZoneListResult(IReadOnlyList<AvsClusterZone> zones, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Zone and associated hosts info. </summary>
        public IReadOnlyList<AvsClusterZone> Zones { get; }
    }
}
