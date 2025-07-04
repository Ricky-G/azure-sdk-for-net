// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtTypeSpec.Models
{
    /// <summary> The FooSettingsProperties. </summary>
    public partial class FooSettingsProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="FooSettingsProperties"/>. </summary>
        /// <param name="accessControlEnabled"></param>
        public FooSettingsProperties(bool accessControlEnabled)
        {
            AccessControlEnabled = accessControlEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="FooSettingsProperties"/>. </summary>
        /// <param name="accessControlEnabled"></param>
        /// <param name="provisioningState"></param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal FooSettingsProperties(bool accessControlEnabled, ResourceProvisioningState? provisioningState, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            AccessControlEnabled = accessControlEnabled;
            ProvisioningState = provisioningState;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Gets or sets the AccessControlEnabled. </summary>
        public bool AccessControlEnabled { get; set; }

        /// <summary> Gets the ProvisioningState. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
    }
}
