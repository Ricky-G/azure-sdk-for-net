// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Status while trying to fetch the deployment information. </summary>
    public readonly partial struct SourceControlDeploymentResult : IEquatable<SourceControlDeploymentResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SourceControlDeploymentResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SourceControlDeploymentResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SuccessValue = "Success";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Success. </summary>
        public static SourceControlDeploymentResult Success { get; } = new SourceControlDeploymentResult(SuccessValue);
        /// <summary> Canceled. </summary>
        public static SourceControlDeploymentResult Canceled { get; } = new SourceControlDeploymentResult(CanceledValue);
        /// <summary> Failed. </summary>
        public static SourceControlDeploymentResult Failed { get; } = new SourceControlDeploymentResult(FailedValue);
        /// <summary> Determines if two <see cref="SourceControlDeploymentResult"/> values are the same. </summary>
        public static bool operator ==(SourceControlDeploymentResult left, SourceControlDeploymentResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SourceControlDeploymentResult"/> values are not the same. </summary>
        public static bool operator !=(SourceControlDeploymentResult left, SourceControlDeploymentResult right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SourceControlDeploymentResult"/>. </summary>
        public static implicit operator SourceControlDeploymentResult(string value) => new SourceControlDeploymentResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SourceControlDeploymentResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SourceControlDeploymentResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
