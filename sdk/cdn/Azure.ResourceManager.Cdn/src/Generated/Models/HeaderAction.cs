// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary>
    /// Action to perform
    /// Serialized Name: HeaderAction
    /// </summary>
    public readonly partial struct HeaderAction : IEquatable<HeaderAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HeaderAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HeaderAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppendValue = "Append";
        private const string OverwriteValue = "Overwrite";
        private const string DeleteValue = "Delete";

        /// <summary>
        /// Append
        /// Serialized Name: HeaderAction.Append
        /// </summary>
        public static HeaderAction Append { get; } = new HeaderAction(AppendValue);
        /// <summary>
        /// Overwrite
        /// Serialized Name: HeaderAction.Overwrite
        /// </summary>
        public static HeaderAction Overwrite { get; } = new HeaderAction(OverwriteValue);
        /// <summary>
        /// Delete
        /// Serialized Name: HeaderAction.Delete
        /// </summary>
        public static HeaderAction Delete { get; } = new HeaderAction(DeleteValue);
        /// <summary> Determines if two <see cref="HeaderAction"/> values are the same. </summary>
        public static bool operator ==(HeaderAction left, HeaderAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HeaderAction"/> values are not the same. </summary>
        public static bool operator !=(HeaderAction left, HeaderAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="HeaderAction"/>. </summary>
        public static implicit operator HeaderAction(string value) => new HeaderAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HeaderAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HeaderAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
