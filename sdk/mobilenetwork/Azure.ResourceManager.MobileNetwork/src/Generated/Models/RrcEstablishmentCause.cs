// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Radio connection establishment cause. </summary>
    public readonly partial struct RrcEstablishmentCause : IEquatable<RrcEstablishmentCause>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RrcEstablishmentCause"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RrcEstablishmentCause(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EmergencyValue = "Emergency";
        private const string MobileOriginatedSignalingValue = "MobileOriginatedSignaling";
        private const string MobileTerminatedSignalingValue = "MobileTerminatedSignaling";
        private const string MobileOriginatedDataValue = "MobileOriginatedData";
        private const string MobileTerminatedDataValue = "MobileTerminatedData";
        private const string SmsValue = "SMS";

        /// <summary> Emergency. </summary>
        public static RrcEstablishmentCause Emergency { get; } = new RrcEstablishmentCause(EmergencyValue);
        /// <summary> MobileOriginatedSignaling. </summary>
        public static RrcEstablishmentCause MobileOriginatedSignaling { get; } = new RrcEstablishmentCause(MobileOriginatedSignalingValue);
        /// <summary> MobileTerminatedSignaling. </summary>
        public static RrcEstablishmentCause MobileTerminatedSignaling { get; } = new RrcEstablishmentCause(MobileTerminatedSignalingValue);
        /// <summary> MobileOriginatedData. </summary>
        public static RrcEstablishmentCause MobileOriginatedData { get; } = new RrcEstablishmentCause(MobileOriginatedDataValue);
        /// <summary> MobileTerminatedData. </summary>
        public static RrcEstablishmentCause MobileTerminatedData { get; } = new RrcEstablishmentCause(MobileTerminatedDataValue);
        /// <summary> SMS. </summary>
        public static RrcEstablishmentCause Sms { get; } = new RrcEstablishmentCause(SmsValue);
        /// <summary> Determines if two <see cref="RrcEstablishmentCause"/> values are the same. </summary>
        public static bool operator ==(RrcEstablishmentCause left, RrcEstablishmentCause right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RrcEstablishmentCause"/> values are not the same. </summary>
        public static bool operator !=(RrcEstablishmentCause left, RrcEstablishmentCause right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RrcEstablishmentCause"/>. </summary>
        public static implicit operator RrcEstablishmentCause(string value) => new RrcEstablishmentCause(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RrcEstablishmentCause other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RrcEstablishmentCause other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
