// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The type of signal the alert is based on, which could be metrics, logs or activity logs. </summary>
    public readonly partial struct ServiceAlertSignalType : IEquatable<ServiceAlertSignalType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceAlertSignalType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceAlertSignalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MetricValue = "Metric";
        private const string LogValue = "Log";
        private const string UnknownValue = "Unknown";

        /// <summary> Metric. </summary>
        public static ServiceAlertSignalType Metric { get; } = new ServiceAlertSignalType(MetricValue);
        /// <summary> Log. </summary>
        public static ServiceAlertSignalType Log { get; } = new ServiceAlertSignalType(LogValue);
        /// <summary> Unknown. </summary>
        public static ServiceAlertSignalType Unknown { get; } = new ServiceAlertSignalType(UnknownValue);
        /// <summary> Determines if two <see cref="ServiceAlertSignalType"/> values are the same. </summary>
        public static bool operator ==(ServiceAlertSignalType left, ServiceAlertSignalType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceAlertSignalType"/> values are not the same. </summary>
        public static bool operator !=(ServiceAlertSignalType left, ServiceAlertSignalType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceAlertSignalType"/>. </summary>
        public static implicit operator ServiceAlertSignalType(string value) => new ServiceAlertSignalType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceAlertSignalType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceAlertSignalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
