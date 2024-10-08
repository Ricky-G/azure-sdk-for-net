// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The OAuth 2.0 authentication mechanism used for authentication. </summary>
    public readonly partial struct GoogleBigQueryV2AuthenticationType : IEquatable<GoogleBigQueryV2AuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GoogleBigQueryV2AuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GoogleBigQueryV2AuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceAuthenticationValue = "ServiceAuthentication";
        private const string UserAuthenticationValue = "UserAuthentication";

        /// <summary> ServiceAuthentication. </summary>
        public static GoogleBigQueryV2AuthenticationType ServiceAuthentication { get; } = new GoogleBigQueryV2AuthenticationType(ServiceAuthenticationValue);
        /// <summary> UserAuthentication. </summary>
        public static GoogleBigQueryV2AuthenticationType UserAuthentication { get; } = new GoogleBigQueryV2AuthenticationType(UserAuthenticationValue);
        /// <summary> Determines if two <see cref="GoogleBigQueryV2AuthenticationType"/> values are the same. </summary>
        public static bool operator ==(GoogleBigQueryV2AuthenticationType left, GoogleBigQueryV2AuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GoogleBigQueryV2AuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(GoogleBigQueryV2AuthenticationType left, GoogleBigQueryV2AuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GoogleBigQueryV2AuthenticationType"/>. </summary>
        public static implicit operator GoogleBigQueryV2AuthenticationType(string value) => new GoogleBigQueryV2AuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GoogleBigQueryV2AuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GoogleBigQueryV2AuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
