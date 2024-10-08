// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The current provisioning state of the registration definition. </summary>
    public readonly partial struct ManagedServicesProvisioningState : IEquatable<ManagedServicesProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedServicesProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedServicesProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AcceptedValue = "Accepted";
        private const string RunningValue = "Running";
        private const string ReadyValue = "Ready";
        private const string CreatingValue = "Creating";
        private const string CreatedValue = "Created";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";

        /// <summary> NotSpecified. </summary>
        public static ManagedServicesProvisioningState NotSpecified { get; } = new ManagedServicesProvisioningState(NotSpecifiedValue);
        /// <summary> Accepted. </summary>
        public static ManagedServicesProvisioningState Accepted { get; } = new ManagedServicesProvisioningState(AcceptedValue);
        /// <summary> Running. </summary>
        public static ManagedServicesProvisioningState Running { get; } = new ManagedServicesProvisioningState(RunningValue);
        /// <summary> Ready. </summary>
        public static ManagedServicesProvisioningState Ready { get; } = new ManagedServicesProvisioningState(ReadyValue);
        /// <summary> Creating. </summary>
        public static ManagedServicesProvisioningState Creating { get; } = new ManagedServicesProvisioningState(CreatingValue);
        /// <summary> Created. </summary>
        public static ManagedServicesProvisioningState Created { get; } = new ManagedServicesProvisioningState(CreatedValue);
        /// <summary> Deleting. </summary>
        public static ManagedServicesProvisioningState Deleting { get; } = new ManagedServicesProvisioningState(DeletingValue);
        /// <summary> Deleted. </summary>
        public static ManagedServicesProvisioningState Deleted { get; } = new ManagedServicesProvisioningState(DeletedValue);
        /// <summary> Canceled. </summary>
        public static ManagedServicesProvisioningState Canceled { get; } = new ManagedServicesProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static ManagedServicesProvisioningState Failed { get; } = new ManagedServicesProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static ManagedServicesProvisioningState Succeeded { get; } = new ManagedServicesProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static ManagedServicesProvisioningState Updating { get; } = new ManagedServicesProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="ManagedServicesProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ManagedServicesProvisioningState left, ManagedServicesProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedServicesProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ManagedServicesProvisioningState left, ManagedServicesProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedServicesProvisioningState"/>. </summary>
        public static implicit operator ManagedServicesProvisioningState(string value) => new ManagedServicesProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedServicesProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedServicesProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
