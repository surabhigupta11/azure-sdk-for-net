// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using Azure.Core;
using System.Threading.Tasks;
using System;
using Azure.Core.Pipeline;
using Autorest.CSharp.Core;

namespace Azure.AI.Language.Text.Authoring
{
    [CodeGenSuppress("GetExportedModelAsync", typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModel", typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModelJobStatusAsync", typeof(string), typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModelJobStatus", typeof(string), typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("CreateOrUpdateExportedModelAsync", typeof(WaitUntil), typeof(string), typeof(string), typeof(TextAuthoringExportedModelDetails), typeof(CancellationToken))]
    [CodeGenSuppress("CreateOrUpdateExportedModel", typeof(WaitUntil), typeof(string), typeof(string), typeof(TextAuthoringExportedModelDetails), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModelAsync", typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("GetExportedModel", typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("GetExportedModelJobStatusAsync", typeof(string), typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("GetExportedModelJobStatus", typeof(string), typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("CreateOrUpdateExportedModelAsync", typeof(WaitUntil), typeof(string), typeof(string), typeof(RequestContent), typeof(RequestContext))]
    [CodeGenSuppress("CreateOrUpdateExportedModel", typeof(WaitUntil), typeof(string), typeof(string), typeof(RequestContent), typeof(RequestContext))]
    [CodeGenSuppress("GetExportedModelManifestAsync", typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModelManifest", typeof(string), typeof(string), typeof(CancellationToken))]
    [CodeGenSuppress("GetExportedModelManifestAsync", typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("GetExportedModelManifest", typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("DeleteExportedModelAsync", typeof(WaitUntil), typeof(string), typeof(string), typeof(RequestContext))]
    [CodeGenSuppress("DeleteExportedModel", typeof(WaitUntil), typeof(string), typeof(string), typeof(RequestContext))]

    //[CodeGenSuppress("GetExportedModelsAsync", typeof(string), typeof(int?), typeof(int?), typeof(int?), typeof(CancellationToken))]
    //[CodeGenSuppress("GetExportedModels", typeof(string), typeof(int?), typeof(int?), typeof(int?), typeof(CancellationToken))]
    public partial class TextAuthoringExportedModel
    {
        private readonly string _projectName;
        private readonly string _exportedModelName;

        /// <summary> Initializes a new instance of TextAuthoringModel. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoint e.g., https://&lt;resource-name&gt;.api.cognitiveservices.azure.com. </param>
        /// <param name="apiVersion"> The API version to use for this operation. </param>
        /// <param name="projectName"> The new project name. </param>
        /// <param name="exportedModelName"> The new exported model name. </param>
        internal TextAuthoringExportedModel(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, TokenCredential tokenCredential, Uri endpoint, string apiVersion, string projectName, string exportedModelName)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
            _projectName = projectName;
            _exportedModelName = exportedModelName;
        }

        /// <summary> Gets the details of an exported model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TextAuthoringExportedTrainedModel>> GetExportedModelAsync(
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetExportedModelAsync(context).ConfigureAwait(false);
            return Response.FromValue(TextAuthoringExportedTrainedModel.FromResponse(response), response);
        }

        /// <summary> Gets the details of an exported model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TextAuthoringExportedTrainedModel> GetExportedModel(
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetExportedModel(context);
            return Response.FromValue(TextAuthoringExportedTrainedModel.FromResponse(response), response);
        }

        /// <summary> Gets the status for an existing job to create or update an exported model. </summary>
        /// <param name="jobId"> The job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TextAuthoringExportedModelState>> GetExportedModelJobStatusAsync(
            string jobId,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetExportedModelJobStatusAsync(jobId, context).ConfigureAwait(false);
            return Response.FromValue(TextAuthoringExportedModelState.FromResponse(response), response);
        }

        /// <summary> Gets the status for an existing job to create or update an exported model. </summary>
        /// <param name="jobId"> The job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TextAuthoringExportedModelState> GetExportedModelJobStatus(
            string jobId,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetExportedModelJobStatus(jobId, context);
            return Response.FromValue(TextAuthoringExportedModelState.FromResponse(response), response);
        }

        /// <summary> Creates a new exported model or replaces an existing one. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="details"> The exported model info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Operation> CreateOrUpdateExportedModelAsync(
            WaitUntil waitUntil,
            TextAuthoringExportedModelDetails details,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNull(details, nameof(details));

            using RequestContent content = details.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            return await CreateOrUpdateExportedModelAsync(waitUntil, content, context).ConfigureAwait(false);
        }

        /// <summary> Creates a new exported model or replaces an existing one. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="details"> The exported model info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation CreateOrUpdateExportedModel(
            WaitUntil waitUntil,
            TextAuthoringExportedModelDetails details,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNull(details, nameof(details));

            using RequestContent content = details.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            return CreateOrUpdateExportedModel(waitUntil, content, context);
        }

        /// <summary> Deletes an exported model. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Operation> DeleteExportedModelAsync(
            WaitUntil waitUntil,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            return await DeleteExportedModelAsync(waitUntil, context).ConfigureAwait(false);
        }

        /// <summary> Deletes an exported model. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation DeleteExportedModel(
            WaitUntil waitUntil,
            CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            return DeleteExportedModel(waitUntil, context);
        }

        /// <summary>
        /// [Protocol Method] Gets the details of an exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> GetExportedModelAsync(RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.GetExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelRequest(_projectName, _exportedModelName, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the details of an exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response GetExportedModel(RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.GetExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelRequest(_projectName, _exportedModelName, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the status for an existing job to create or update an exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetExportedModelJobStatusAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The job ID. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> GetExportedModelJobStatusAsync(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.GetExportedModelJobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelJobStatusRequest(_projectName, _exportedModelName, jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the status for an existing job to create or update an exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetExportedModelJobStatus(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> The job ID. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response GetExportedModelJobStatus(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.GetExportedModelJobStatus");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelJobStatusRequest(_projectName, _exportedModelName, jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates a new exported model or replaces an existing one.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateOrUpdateExportedModelAsync(WaitUntil,TextAuthoringExportedModelDetails,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        public virtual async Task<Operation> CreateOrUpdateExportedModelAsync(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.CreateOrUpdateExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateExportedModelRequest(_projectName, _exportedModelName, content, context);
                return await ProtocolOperationHelpers.ProcessMessageWithoutResponseValueAsync(_pipeline, message, ClientDiagnostics, "TextAuthoringModel.CreateOrUpdateExportedModel", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates a new exported model or replaces an existing one.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateOrUpdateExportedModel(WaitUntil,TextAuthoringExportedModelDetails,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        public virtual Operation CreateOrUpdateExportedModel(WaitUntil waitUntil, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringModel.CreateOrUpdateExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateExportedModelRequest(_projectName, _exportedModelName, content, context);
                return ProtocolOperationHelpers.ProcessMessageWithoutResponseValue(_pipeline, message, ClientDiagnostics, "TextAuthoringModel.CreateOrUpdateExportedModel", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details and URL needed to download the exported model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExportedModelManifest>> GetExportedModelManifestAsync(CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetExportedModelManifestAsync(context).ConfigureAwait(false);
            return Response.FromValue(ExportedModelManifest.FromResponse(response), response);
        }

        /// <summary> Gets the details and URL needed to download the exported model. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExportedModelManifest> GetExportedModelManifest(CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetExportedModelManifest(context);
            return Response.FromValue(ExportedModelManifest.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Gets the details and URL needed to download the exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetExportedModelManifestAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> GetExportedModelManifestAsync(RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringExportedModel.GetExportedModelManifest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelManifestRequest(_projectName, _exportedModelName, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets the details and URL needed to download the exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetExportedModelManifest(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response GetExportedModelManifest(RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringExportedModel.GetExportedModelManifest");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetExportedModelManifestRequest(_projectName, _exportedModelName, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Deletes an existing exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        public virtual async Task<Operation> DeleteExportedModelAsync(WaitUntil waitUntil, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringExportedModel.DeleteExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteExportedModelRequest(_projectName, _exportedModelName, context);
                return await ProtocolOperationHelpers.ProcessMessageWithoutResponseValueAsync(_pipeline, message, ClientDiagnostics, "TextAuthoringExportedModel.DeleteExportedModel", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Deletes an existing exported model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        public virtual Operation DeleteExportedModel(WaitUntil waitUntil, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(_projectName, nameof(_projectName));
            Argument.AssertNotNullOrEmpty(_exportedModelName, nameof(_exportedModelName));

            using var scope = ClientDiagnostics.CreateScope("TextAuthoringExportedModel.DeleteExportedModel");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteExportedModelRequest(_projectName, _exportedModelName, context);
                return ProtocolOperationHelpers.ProcessMessageWithoutResponseValue(_pipeline, message, ClientDiagnostics, "TextAuthoringExportedModel.DeleteExportedModel", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
