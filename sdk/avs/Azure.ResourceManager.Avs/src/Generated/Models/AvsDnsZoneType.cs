// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The type of DNS zone. </summary>
    public readonly partial struct AvsDnsZoneType : IEquatable<AvsDnsZoneType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsDnsZoneType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsDnsZoneType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PublicValue = "Public";
        private const string PrivateValue = "Private";

        /// <summary> Primary DNS zone. </summary>
        public static AvsDnsZoneType Public { get; } = new AvsDnsZoneType(PublicValue);
        /// <summary> Private DNS zone. </summary>
        public static AvsDnsZoneType Private { get; } = new AvsDnsZoneType(PrivateValue);
        /// <summary> Determines if two <see cref="AvsDnsZoneType"/> values are the same. </summary>
        public static bool operator ==(AvsDnsZoneType left, AvsDnsZoneType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsDnsZoneType"/> values are not the same. </summary>
        public static bool operator !=(AvsDnsZoneType left, AvsDnsZoneType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AvsDnsZoneType"/>. </summary>
        public static implicit operator AvsDnsZoneType(string value) => new AvsDnsZoneType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsDnsZoneType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsDnsZoneType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
