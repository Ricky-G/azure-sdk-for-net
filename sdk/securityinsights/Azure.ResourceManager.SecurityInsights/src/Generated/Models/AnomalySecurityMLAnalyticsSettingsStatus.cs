// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The anomaly SecurityMLAnalyticsSettings status. </summary>
    public readonly partial struct AnomalySecurityMLAnalyticsSettingsStatus : IEquatable<AnomalySecurityMLAnalyticsSettingsStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnomalySecurityMLAnalyticsSettingsStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnomalySecurityMLAnalyticsSettingsStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProductionValue = "Production";
        private const string FlightingValue = "Flighting";

        /// <summary> Anomaly settings status in Production mode. </summary>
        public static AnomalySecurityMLAnalyticsSettingsStatus Production { get; } = new AnomalySecurityMLAnalyticsSettingsStatus(ProductionValue);
        /// <summary> Anomaly settings status in Flighting mode. </summary>
        public static AnomalySecurityMLAnalyticsSettingsStatus Flighting { get; } = new AnomalySecurityMLAnalyticsSettingsStatus(FlightingValue);
        /// <summary> Determines if two <see cref="AnomalySecurityMLAnalyticsSettingsStatus"/> values are the same. </summary>
        public static bool operator ==(AnomalySecurityMLAnalyticsSettingsStatus left, AnomalySecurityMLAnalyticsSettingsStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnomalySecurityMLAnalyticsSettingsStatus"/> values are not the same. </summary>
        public static bool operator !=(AnomalySecurityMLAnalyticsSettingsStatus left, AnomalySecurityMLAnalyticsSettingsStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AnomalySecurityMLAnalyticsSettingsStatus"/>. </summary>
        public static implicit operator AnomalySecurityMLAnalyticsSettingsStatus(string value) => new AnomalySecurityMLAnalyticsSettingsStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnomalySecurityMLAnalyticsSettingsStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnomalySecurityMLAnalyticsSettingsStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
