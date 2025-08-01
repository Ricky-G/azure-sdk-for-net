// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes a provisioning issue for a network security perimeter configuration. </summary>
    public partial class SearchServiceNetworkSecurityPerimeterProvisioningIssue
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

        /// <summary> Initializes a new instance of <see cref="SearchServiceNetworkSecurityPerimeterProvisioningIssue"/>. </summary>
        internal SearchServiceNetworkSecurityPerimeterProvisioningIssue()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceNetworkSecurityPerimeterProvisioningIssue"/>. </summary>
        /// <param name="name"> Name of the issue. </param>
        /// <param name="properties"> Details of a provisioning issue for a network security perimeter (NSP) configuration. Resource providers should generate separate provisioning issue elements for each separate issue detected, and include a meaningful and distinctive description, as well as any appropriate suggestedResourceIds and suggestedAccessRules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceNetworkSecurityPerimeterProvisioningIssue(string name, SearchServiceNetworkSecurityPerimeterProvisioningIssueProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the issue. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Details of a provisioning issue for a network security perimeter (NSP) configuration. Resource providers should generate separate provisioning issue elements for each separate issue detected, and include a meaningful and distinctive description, as well as any appropriate suggestedResourceIds and suggestedAccessRules. </summary>
        [WirePath("properties")]
        public SearchServiceNetworkSecurityPerimeterProvisioningIssueProperties Properties { get; }
    }
}
