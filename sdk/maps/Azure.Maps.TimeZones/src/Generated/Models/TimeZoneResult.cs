// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.TimeZones
{
    /// <summary> This object is returned from a successful Timezone By ID call or By Coordinates call. </summary>
    public partial class TimeZoneResult
    {
        /// <summary> Initializes a new instance of <see cref="TimeZoneResult"/>. </summary>
        internal TimeZoneResult()
        {
            TimeZones = new ChangeTrackingList<TimeZoneId>();
        }

        /// <summary> Initializes a new instance of <see cref="TimeZoneResult"/>. </summary>
        /// <param name="version"> Version property. </param>
        /// <param name="referenceUtcTimestamp"> Reference Utc Timestamp property. </param>
        /// <param name="timeZones"> TimeZoneId array. </param>
        internal TimeZoneResult(string version, DateTimeOffset? referenceUtcTimestamp, IReadOnlyList<TimeZoneId> timeZones)
        {
            Version = version;
            ReferenceUtcTimestamp = referenceUtcTimestamp;
            TimeZones = timeZones;
        }

        /// <summary> Version property. </summary>
        public string Version { get; }
        /// <summary> Reference Utc Timestamp property. </summary>
        public DateTimeOffset? ReferenceUtcTimestamp { get; }
        /// <summary> TimeZoneId array. </summary>
        public IReadOnlyList<TimeZoneId> TimeZones { get; }
    }
}
