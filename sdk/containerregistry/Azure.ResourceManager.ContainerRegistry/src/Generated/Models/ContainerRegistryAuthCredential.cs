// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> Authentication credential stored for an upstream. </summary>
    public partial class ContainerRegistryAuthCredential
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryAuthCredential"/>. </summary>
        public ContainerRegistryAuthCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryAuthCredential"/>. </summary>
        /// <param name="name"> The name of the credential. </param>
        /// <param name="usernameSecretIdentifier"> KeyVault Secret URI for accessing the username. </param>
        /// <param name="passwordSecretIdentifier"> KeyVault Secret URI for accessing the password. </param>
        /// <param name="credentialHealth"> This provides data pertaining to the health of the auth credential. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryAuthCredential(ContainerRegistryCredentialName? name, string usernameSecretIdentifier, string passwordSecretIdentifier, ContainerRegistryCredentialHealth credentialHealth, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            UsernameSecretIdentifier = usernameSecretIdentifier;
            PasswordSecretIdentifier = passwordSecretIdentifier;
            CredentialHealth = credentialHealth;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the credential. </summary>
        [WirePath("name")]
        public ContainerRegistryCredentialName? Name { get; set; }
        /// <summary> KeyVault Secret URI for accessing the username. </summary>
        [WirePath("usernameSecretIdentifier")]
        public string UsernameSecretIdentifier { get; set; }
        /// <summary> KeyVault Secret URI for accessing the password. </summary>
        [WirePath("passwordSecretIdentifier")]
        public string PasswordSecretIdentifier { get; set; }
        /// <summary> This provides data pertaining to the health of the auth credential. </summary>
        [WirePath("credentialHealth")]
        public ContainerRegistryCredentialHealth CredentialHealth { get; }
    }
}
