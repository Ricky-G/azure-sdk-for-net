// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> Response of liveness session creation. </summary>
    public partial class CreateLivenessSessionResult
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

        /// <summary> Initializes a new instance of <see cref="CreateLivenessSessionResult"/>. </summary>
        /// <param name="sessionId"> The unique session ID of the created session. It will expire 48 hours after it was created or may be deleted sooner using the corresponding Session DELETE operation. </param>
        /// <param name="authToken"> Bearer token to provide authentication for the Vision SDK running on a client application. This Bearer token has limited permissions to perform only the required action and expires after the TTL time. It is also auditable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionId"/> or <paramref name="authToken"/> is null. </exception>
        internal CreateLivenessSessionResult(string sessionId, string authToken)
        {
            Argument.AssertNotNull(sessionId, nameof(sessionId));
            Argument.AssertNotNull(authToken, nameof(authToken));

            SessionId = sessionId;
            AuthToken = authToken;
        }

        /// <summary> Initializes a new instance of <see cref="CreateLivenessSessionResult"/>. </summary>
        /// <param name="sessionId"> The unique session ID of the created session. It will expire 48 hours after it was created or may be deleted sooner using the corresponding Session DELETE operation. </param>
        /// <param name="authToken"> Bearer token to provide authentication for the Vision SDK running on a client application. This Bearer token has limited permissions to perform only the required action and expires after the TTL time. It is also auditable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateLivenessSessionResult(string sessionId, string authToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SessionId = sessionId;
            AuthToken = authToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateLivenessSessionResult"/> for deserialization. </summary>
        internal CreateLivenessSessionResult()
        {
        }

        /// <summary> The unique session ID of the created session. It will expire 48 hours after it was created or may be deleted sooner using the corresponding Session DELETE operation. </summary>
        public string SessionId { get; }
        /// <summary> Bearer token to provide authentication for the Vision SDK running on a client application. This Bearer token has limited permissions to perform only the required action and expires after the TTL time. It is also auditable. </summary>
        public string AuthToken { get; }
    }
}
