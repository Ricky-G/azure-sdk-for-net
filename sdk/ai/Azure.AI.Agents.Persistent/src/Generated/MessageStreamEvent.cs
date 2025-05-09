// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Message operation related streaming events. </summary>
    public readonly partial struct MessageStreamEvent : IEquatable<MessageStreamEvent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageStreamEvent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageStreamEvent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadMessageCreatedValue = "thread.message.created";
        private const string ThreadMessageInProgressValue = "thread.message.in_progress";
        private const string ThreadMessageDeltaValue = "thread.message.delta";
        private const string ThreadMessageCompletedValue = "thread.message.completed";
        private const string ThreadMessageIncompleteValue = "thread.message.incomplete";

        /// <summary> Event sent when a new message is created. The data of this event is of type ThreadMessage. </summary>
        public static MessageStreamEvent ThreadMessageCreated { get; } = new MessageStreamEvent(ThreadMessageCreatedValue);
        /// <summary> Event sent when a message moves to `in_progress` status. The data of this event is of type ThreadMessage. </summary>
        public static MessageStreamEvent ThreadMessageInProgress { get; } = new MessageStreamEvent(ThreadMessageInProgressValue);
        /// <summary> Event sent when a message is being streamed. The data of this event is of type MessageDeltaChunk. </summary>
        public static MessageStreamEvent ThreadMessageDelta { get; } = new MessageStreamEvent(ThreadMessageDeltaValue);
        /// <summary> Event sent when a message is completed. The data of this event is of type ThreadMessage. </summary>
        public static MessageStreamEvent ThreadMessageCompleted { get; } = new MessageStreamEvent(ThreadMessageCompletedValue);
        /// <summary> Event sent before a message is completed. The data of this event is of type ThreadMessage. </summary>
        public static MessageStreamEvent ThreadMessageIncomplete { get; } = new MessageStreamEvent(ThreadMessageIncompleteValue);
        /// <summary> Determines if two <see cref="MessageStreamEvent"/> values are the same. </summary>
        public static bool operator ==(MessageStreamEvent left, MessageStreamEvent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageStreamEvent"/> values are not the same. </summary>
        public static bool operator !=(MessageStreamEvent left, MessageStreamEvent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MessageStreamEvent"/>. </summary>
        public static implicit operator MessageStreamEvent(string value) => new MessageStreamEvent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageStreamEvent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageStreamEvent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
