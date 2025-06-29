// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CloudHealth.Models
{
    /// <summary> Discovery rule properties. </summary>
    public partial class HealthModelDiscoveryRuleProperties
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

        /// <summary> Initializes a new instance of <see cref="HealthModelDiscoveryRuleProperties"/>. </summary>
        /// <param name="resourceGraphQuery"> Azure Resource Graph query text in KQL syntax. The query must return at least a column named 'id' which contains the resource ID of the discovered resources. </param>
        /// <param name="authenticationSetting"> Reference to the name of the authentication setting which is used for querying Azure Resource Graph. The same authentication setting will also be assigned to any discovered entities. </param>
        /// <param name="discoverRelationships"> Whether to create relationships between the discovered entities based on a set of built-in rules. These relationships cannot be manually deleted. </param>
        /// <param name="addRecommendedSignals"> Whether to add all recommended signals to the discovered entities. </param>
        /// <param name="entityName"> Name of the entity which represents the discovery rule. Note: It might take a few minutes after creating the discovery rule until the entity is created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGraphQuery"/> or <paramref name="authenticationSetting"/> is null. </exception>
        public HealthModelDiscoveryRuleProperties(string resourceGraphQuery, string authenticationSetting, DiscoveryRuleRelationshipDiscoveryBehavior discoverRelationships, DiscoveryRuleRecommendedSignalsBehavior addRecommendedSignals, string entityName)
        {
            Argument.AssertNotNull(resourceGraphQuery, nameof(resourceGraphQuery));
            Argument.AssertNotNull(authenticationSetting, nameof(authenticationSetting));

            ResourceGraphQuery = resourceGraphQuery;
            AuthenticationSetting = authenticationSetting;
            DiscoverRelationships = discoverRelationships;
            AddRecommendedSignals = addRecommendedSignals;
            EntityName = entityName;
        }

        /// <summary> Initializes a new instance of <see cref="HealthModelDiscoveryRuleProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="displayName"> Display name. </param>
        /// <param name="resourceGraphQuery"> Azure Resource Graph query text in KQL syntax. The query must return at least a column named 'id' which contains the resource ID of the discovered resources. </param>
        /// <param name="authenticationSetting"> Reference to the name of the authentication setting which is used for querying Azure Resource Graph. The same authentication setting will also be assigned to any discovered entities. </param>
        /// <param name="discoverRelationships"> Whether to create relationships between the discovered entities based on a set of built-in rules. These relationships cannot be manually deleted. </param>
        /// <param name="addRecommendedSignals"> Whether to add all recommended signals to the discovered entities. </param>
        /// <param name="deletedOn"> Date when the discovery rule was (soft-)deleted. </param>
        /// <param name="errorMessage"> Error message if the last discovery operation failed. </param>
        /// <param name="numberOfDiscoveredEntities"> Number of discovered entities in the last discovery operation. </param>
        /// <param name="entityName"> Name of the entity which represents the discovery rule. Note: It might take a few minutes after creating the discovery rule until the entity is created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthModelDiscoveryRuleProperties(HealthModelProvisioningState? provisioningState, string displayName, string resourceGraphQuery, string authenticationSetting, DiscoveryRuleRelationshipDiscoveryBehavior discoverRelationships, DiscoveryRuleRecommendedSignalsBehavior addRecommendedSignals, DateTimeOffset? deletedOn, string errorMessage, int? numberOfDiscoveredEntities, string entityName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            ResourceGraphQuery = resourceGraphQuery;
            AuthenticationSetting = authenticationSetting;
            DiscoverRelationships = discoverRelationships;
            AddRecommendedSignals = addRecommendedSignals;
            DeletedOn = deletedOn;
            ErrorMessage = errorMessage;
            NumberOfDiscoveredEntities = numberOfDiscoveredEntities;
            EntityName = entityName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthModelDiscoveryRuleProperties"/> for deserialization. </summary>
        internal HealthModelDiscoveryRuleProperties()
        {
        }

        /// <summary> The status of the last operation. </summary>
        public HealthModelProvisioningState? ProvisioningState { get; }
        /// <summary> Display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Azure Resource Graph query text in KQL syntax. The query must return at least a column named 'id' which contains the resource ID of the discovered resources. </summary>
        public string ResourceGraphQuery { get; set; }
        /// <summary> Reference to the name of the authentication setting which is used for querying Azure Resource Graph. The same authentication setting will also be assigned to any discovered entities. </summary>
        public string AuthenticationSetting { get; set; }
        /// <summary> Whether to create relationships between the discovered entities based on a set of built-in rules. These relationships cannot be manually deleted. </summary>
        public DiscoveryRuleRelationshipDiscoveryBehavior DiscoverRelationships { get; set; }
        /// <summary> Whether to add all recommended signals to the discovered entities. </summary>
        public DiscoveryRuleRecommendedSignalsBehavior AddRecommendedSignals { get; set; }
        /// <summary> Date when the discovery rule was (soft-)deleted. </summary>
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> Error message if the last discovery operation failed. </summary>
        public string ErrorMessage { get; }
        /// <summary> Number of discovered entities in the last discovery operation. </summary>
        public int? NumberOfDiscoveredEntities { get; }
        /// <summary> Name of the entity which represents the discovery rule. Note: It might take a few minutes after creating the discovery rule until the entity is created. </summary>
        public string EntityName { get; }
    }
}
