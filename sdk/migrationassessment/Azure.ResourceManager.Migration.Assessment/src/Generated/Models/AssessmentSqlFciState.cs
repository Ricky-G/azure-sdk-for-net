// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> The AssessmentSqlFciState. </summary>
    public readonly partial struct AssessmentSqlFciState : IEquatable<AssessmentSqlFciState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssessmentSqlFciState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssessmentSqlFciState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ActiveValue = "Active";
        private const string PassiveValue = "Passive";
        private const string NotApplicableValue = "NotApplicable";

        /// <summary> Unknown. </summary>
        public static AssessmentSqlFciState Unknown { get; } = new AssessmentSqlFciState(UnknownValue);
        /// <summary> Active. </summary>
        public static AssessmentSqlFciState Active { get; } = new AssessmentSqlFciState(ActiveValue);
        /// <summary> Passive. </summary>
        public static AssessmentSqlFciState Passive { get; } = new AssessmentSqlFciState(PassiveValue);
        /// <summary> NotApplicable. </summary>
        public static AssessmentSqlFciState NotApplicable { get; } = new AssessmentSqlFciState(NotApplicableValue);
        /// <summary> Determines if two <see cref="AssessmentSqlFciState"/> values are the same. </summary>
        public static bool operator ==(AssessmentSqlFciState left, AssessmentSqlFciState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssessmentSqlFciState"/> values are not the same. </summary>
        public static bool operator !=(AssessmentSqlFciState left, AssessmentSqlFciState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssessmentSqlFciState"/>. </summary>
        public static implicit operator AssessmentSqlFciState(string value) => new AssessmentSqlFciState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssessmentSqlFciState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssessmentSqlFciState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
