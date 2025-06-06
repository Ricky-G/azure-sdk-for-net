// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Gateway Resiliency Information. </summary>
    public partial class GatewayResiliencyInformation
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

        /// <summary> Initializes a new instance of <see cref="GatewayResiliencyInformation"/>. </summary>
        internal GatewayResiliencyInformation()
        {
            Components = new ChangeTrackingList<ResiliencyRecommendationComponents>();
        }

        /// <summary> Initializes a new instance of <see cref="GatewayResiliencyInformation"/>. </summary>
        /// <param name="overallScore"> Current Resiliency Score for the gateway. </param>
        /// <param name="scoreChange"> Update in the Resiliency Score for the gateway from the last computed score. </param>
        /// <param name="minScoreFromRecommendations"> Minimum increase expected in the score if the at least one of the recommendations is applied for the gateway. </param>
        /// <param name="maxScoreFromRecommendations"> Maximum increase expected in the score if all of the recommendations are applied for the gateway. </param>
        /// <param name="lastComputedOn"> Timestamp denoting the last time when the resiliency score was computed for the gateway. </param>
        /// <param name="nextEligibleComputeOn"> Timestamp denoting the next eligible time to re-compute the resiliency score for the gateway. </param>
        /// <param name="components"> List of Resiliency based Recommendation Components for the gateway. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayResiliencyInformation(string overallScore, string scoreChange, string minScoreFromRecommendations, string maxScoreFromRecommendations, DateTimeOffset? lastComputedOn, DateTimeOffset? nextEligibleComputeOn, IReadOnlyList<ResiliencyRecommendationComponents> components, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OverallScore = overallScore;
            ScoreChange = scoreChange;
            MinScoreFromRecommendations = minScoreFromRecommendations;
            MaxScoreFromRecommendations = maxScoreFromRecommendations;
            LastComputedOn = lastComputedOn;
            NextEligibleComputeOn = nextEligibleComputeOn;
            Components = components;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Current Resiliency Score for the gateway. </summary>
        public string OverallScore { get; }
        /// <summary> Update in the Resiliency Score for the gateway from the last computed score. </summary>
        public string ScoreChange { get; }
        /// <summary> Minimum increase expected in the score if the at least one of the recommendations is applied for the gateway. </summary>
        public string MinScoreFromRecommendations { get; }
        /// <summary> Maximum increase expected in the score if all of the recommendations are applied for the gateway. </summary>
        public string MaxScoreFromRecommendations { get; }
        /// <summary> Timestamp denoting the last time when the resiliency score was computed for the gateway. </summary>
        public DateTimeOffset? LastComputedOn { get; }
        /// <summary> Timestamp denoting the next eligible time to re-compute the resiliency score for the gateway. </summary>
        public DateTimeOffset? NextEligibleComputeOn { get; }
        /// <summary> List of Resiliency based Recommendation Components for the gateway. </summary>
        public IReadOnlyList<ResiliencyRecommendationComponents> Components { get; }
    }
}
