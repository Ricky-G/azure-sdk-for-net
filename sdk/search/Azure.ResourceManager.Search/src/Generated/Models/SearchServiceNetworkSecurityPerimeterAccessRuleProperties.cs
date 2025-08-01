// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Properties of Access Rule. </summary>
    public partial class SearchServiceNetworkSecurityPerimeterAccessRuleProperties
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

        /// <summary> Initializes a new instance of <see cref="SearchServiceNetworkSecurityPerimeterAccessRuleProperties"/>. </summary>
        public SearchServiceNetworkSecurityPerimeterAccessRuleProperties()
        {
            AddressPrefixes = new ChangeTrackingList<string>();
            Subscriptions = new ChangeTrackingList<WritableSubResource>();
            NetworkSecurityPerimeters = new ChangeTrackingList<SearchServiceNetworkSecurityPerimeter>();
            FullyQualifiedDomainNames = new ChangeTrackingList<string>();
            EmailAddresses = new ChangeTrackingList<string>();
            PhoneNumbers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceNetworkSecurityPerimeterAccessRuleProperties"/>. </summary>
        /// <param name="direction"> Direction of Access Rule. </param>
        /// <param name="addressPrefixes"> Address prefixes in the CIDR format for inbound rules. </param>
        /// <param name="subscriptions"> Subscriptions for inbound rules. </param>
        /// <param name="networkSecurityPerimeters"> Network security perimeters for inbound rules. </param>
        /// <param name="fullyQualifiedDomainNames"> Fully qualified domain names (FQDN) for outbound rules. </param>
        /// <param name="emailAddresses"> Email addresses for outbound rules. </param>
        /// <param name="phoneNumbers"> Phone numbers for outbound rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceNetworkSecurityPerimeterAccessRuleProperties(SearchServiceNetworkSecurityPerimeterAccessRuleDirection? direction, IList<string> addressPrefixes, IList<WritableSubResource> subscriptions, IList<SearchServiceNetworkSecurityPerimeter> networkSecurityPerimeters, IList<string> fullyQualifiedDomainNames, IList<string> emailAddresses, IList<string> phoneNumbers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Direction = direction;
            AddressPrefixes = addressPrefixes;
            Subscriptions = subscriptions;
            NetworkSecurityPerimeters = networkSecurityPerimeters;
            FullyQualifiedDomainNames = fullyQualifiedDomainNames;
            EmailAddresses = emailAddresses;
            PhoneNumbers = phoneNumbers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Direction of Access Rule. </summary>
        [WirePath("direction")]
        public SearchServiceNetworkSecurityPerimeterAccessRuleDirection? Direction { get; set; }
        /// <summary> Address prefixes in the CIDR format for inbound rules. </summary>
        [WirePath("addressPrefixes")]
        public IList<string> AddressPrefixes { get; }
        /// <summary> Subscriptions for inbound rules. </summary>
        [WirePath("subscriptions")]
        public IList<WritableSubResource> Subscriptions { get; }
        /// <summary> Network security perimeters for inbound rules. </summary>
        [WirePath("networkSecurityPerimeters")]
        public IList<SearchServiceNetworkSecurityPerimeter> NetworkSecurityPerimeters { get; }
        /// <summary> Fully qualified domain names (FQDN) for outbound rules. </summary>
        [WirePath("fullyQualifiedDomainNames")]
        public IList<string> FullyQualifiedDomainNames { get; }
        /// <summary> Email addresses for outbound rules. </summary>
        [WirePath("emailAddresses")]
        public IList<string> EmailAddresses { get; }
        /// <summary> Phone numbers for outbound rules. </summary>
        [WirePath("phoneNumbers")]
        public IList<string> PhoneNumbers { get; }
    }
}
