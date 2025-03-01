// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents the assigned deployment resource. </summary>
    public partial class AssignedDeploymentResource
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssignedDeploymentResource"/>. </summary>
        /// <param name="region"> The resource region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="region"/> is null. </exception>
        internal AssignedDeploymentResource(string region)
        {
            Argument.AssertNotNull(region, nameof(region));

            Region = region;
        }

        /// <summary> Initializes a new instance of <see cref="AssignedDeploymentResource"/>. </summary>
        /// <param name="azureResourceId"> The resource ID. </param>
        /// <param name="region"> The resource region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssignedDeploymentResource(string azureResourceId, string region, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureResourceId = azureResourceId;
            Region = region;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssignedDeploymentResource"/> for deserialization. </summary>
        internal AssignedDeploymentResource()
        {
        }

        /// <summary> The resource ID. </summary>
        public string AzureResourceId { get; }
        /// <summary> The resource region. </summary>
        public string Region { get; }
    }
}
