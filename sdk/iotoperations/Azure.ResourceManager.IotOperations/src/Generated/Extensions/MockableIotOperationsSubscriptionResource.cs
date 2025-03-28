// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.IotOperations.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableIotOperationsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _iotOperationsInstanceInstanceClientDiagnostics;
        private InstanceRestOperations _iotOperationsInstanceInstanceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableIotOperationsSubscriptionResource"/> class for mocking. </summary>
        protected MockableIotOperationsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableIotOperationsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableIotOperationsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics IotOperationsInstanceInstanceClientDiagnostics => _iotOperationsInstanceInstanceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IotOperations", IotOperationsInstanceResource.ResourceType.Namespace, Diagnostics);
        private InstanceRestOperations IotOperationsInstanceInstanceRestClient => _iotOperationsInstanceInstanceRestClient ??= new InstanceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IotOperationsInstanceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IotOperationsInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IotOperationsInstanceResource> GetIotOperationsInstancesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IotOperationsInstanceInstanceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IotOperationsInstanceInstanceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IotOperationsInstanceResource(Client, IotOperationsInstanceData.DeserializeIotOperationsInstanceData(e)), IotOperationsInstanceInstanceClientDiagnostics, Pipeline, "MockableIotOperationsSubscriptionResource.GetIotOperationsInstances", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InstanceResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IoTOperations/instances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InstanceResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IotOperationsInstanceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IotOperationsInstanceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IotOperationsInstanceResource> GetIotOperationsInstances(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IotOperationsInstanceInstanceRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IotOperationsInstanceInstanceRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IotOperationsInstanceResource(Client, IotOperationsInstanceData.DeserializeIotOperationsInstanceData(e)), IotOperationsInstanceInstanceClientDiagnostics, Pipeline, "MockableIotOperationsSubscriptionResource.GetIotOperationsInstances", "value", "nextLink", cancellationToken);
        }
    }
}
