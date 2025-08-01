// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The overwrite option for SSIS object migration, only ignore and overwrite are supported in DMS (classic) now and future may add Reuse option for container object. </summary>
    public readonly partial struct SsisMigrationOverwriteOption : IEquatable<SsisMigrationOverwriteOption>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SsisMigrationOverwriteOption"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsisMigrationOverwriteOption(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IgnoreValue = "Ignore";
        private const string OverwriteValue = "Overwrite";

        /// <summary> Ignore. </summary>
        public static SsisMigrationOverwriteOption Ignore { get; } = new SsisMigrationOverwriteOption(IgnoreValue);
        /// <summary> Overwrite. </summary>
        public static SsisMigrationOverwriteOption Overwrite { get; } = new SsisMigrationOverwriteOption(OverwriteValue);
        /// <summary> Determines if two <see cref="SsisMigrationOverwriteOption"/> values are the same. </summary>
        public static bool operator ==(SsisMigrationOverwriteOption left, SsisMigrationOverwriteOption right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SsisMigrationOverwriteOption"/> values are not the same. </summary>
        public static bool operator !=(SsisMigrationOverwriteOption left, SsisMigrationOverwriteOption right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SsisMigrationOverwriteOption"/>. </summary>
        public static implicit operator SsisMigrationOverwriteOption(string value) => new SsisMigrationOverwriteOption(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SsisMigrationOverwriteOption other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SsisMigrationOverwriteOption other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
