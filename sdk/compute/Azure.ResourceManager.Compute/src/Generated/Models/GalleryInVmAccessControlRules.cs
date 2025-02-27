// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the Access Control Rules specification for an inVMAccessControlProfile version. </summary>
    public partial class GalleryInVmAccessControlRules
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

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRules"/>. </summary>
        public GalleryInVmAccessControlRules()
        {
            Privileges = new ChangeTrackingList<GalleryInVmAccessControlRulesPrivilege>();
            Roles = new ChangeTrackingList<GalleryInVmAccessControlRulesRole>();
            Identities = new ChangeTrackingList<GalleryInVmAccessControlRulesIdentity>();
            RoleAssignments = new ChangeTrackingList<GalleryInVmAccessControlRulesRoleAssignment>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRules"/>. </summary>
        /// <param name="privileges"> A list of privileges. </param>
        /// <param name="roles"> A list of roles. </param>
        /// <param name="identities"> A list of identities. </param>
        /// <param name="roleAssignments"> A list of role assignments. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryInVmAccessControlRules(IList<GalleryInVmAccessControlRulesPrivilege> privileges, IList<GalleryInVmAccessControlRulesRole> roles, IList<GalleryInVmAccessControlRulesIdentity> identities, IList<GalleryInVmAccessControlRulesRoleAssignment> roleAssignments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Privileges = privileges;
            Roles = roles;
            Identities = identities;
            RoleAssignments = roleAssignments;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A list of privileges. </summary>
        public IList<GalleryInVmAccessControlRulesPrivilege> Privileges { get; }
        /// <summary> A list of roles. </summary>
        public IList<GalleryInVmAccessControlRulesRole> Roles { get; }
        /// <summary> A list of identities. </summary>
        public IList<GalleryInVmAccessControlRulesIdentity> Identities { get; }
        /// <summary> A list of role assignments. </summary>
        public IList<GalleryInVmAccessControlRulesRoleAssignment> RoleAssignments { get; }
    }
}
