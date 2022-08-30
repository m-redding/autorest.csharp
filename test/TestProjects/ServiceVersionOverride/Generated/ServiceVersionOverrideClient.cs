// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace ServiceVersionOverride
{
    /// <summary> The ServiceVersionOverride service client. </summary>
    public partial class ServiceVersionOverrideClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ServiceVersionOverrideClient. </summary>
        public ServiceVersionOverrideClient() : this(new Uri(""), new ServiceVersionOverrideClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ServiceVersionOverrideClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ServiceVersionOverrideClient(Uri endpoint, ServiceVersionOverrideClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ServiceVersionOverrideClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <param name="notApiVersionEnum"> The ApiVersion to use. Allowed values: &quot;2.0&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notApiVersionEnum"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call OperationAsync with required parameters.
        /// <code><![CDATA[
        /// var client = new ServiceVersionOverrideClient();
        /// 
        /// Response response = await client.OperationAsync("<notApiVersionEnum>");
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        public virtual async Task<Response> OperationAsync(string notApiVersionEnum, RequestContext context = null)
        {
            Argument.AssertNotNull(notApiVersionEnum, nameof(notApiVersionEnum));

            using var scope = ClientDiagnostics.CreateScope("ServiceVersionOverrideClient.Operation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOperationRequest(notApiVersionEnum, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="notApiVersionEnum"> The ApiVersion to use. Allowed values: &quot;2.0&quot;. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="notApiVersionEnum"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call Operation with required parameters.
        /// <code><![CDATA[
        /// var client = new ServiceVersionOverrideClient();
        /// 
        /// Response response = client.Operation("<notApiVersionEnum>");
        /// Console.WriteLine(response.Status);
        /// ]]></code>
        /// </example>
        public virtual Response Operation(string notApiVersionEnum, RequestContext context = null)
        {
            Argument.AssertNotNull(notApiVersionEnum, nameof(notApiVersionEnum));

            using var scope = ClientDiagnostics.CreateScope("ServiceVersionOverrideClient.Operation");
            scope.Start();
            try
            {
                using HttpMessage message = CreateOperationRequest(notApiVersionEnum, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateOperationRequest(string notApiVersionEnum, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/op", false);
            uri.AppendQuery("not-api-version-enum", notApiVersionEnum, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            uri.AppendQuery("not-api-version-constant", "2.0", true);
            request.Uri = uri;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}