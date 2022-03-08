// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace custom_baseUrl_paging_LowLevel
{
    /// <summary> The Paging service client. </summary>
    public partial class PagingClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _host;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of PagingClient for mocking. </summary>
        protected PagingClient()
        {
        }

        /// <summary> Initializes a new instance of PagingClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="host"/> is null. </exception>
        public PagingClient(AzureKeyCredential credential, string host = "host", PagingClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            Argument.AssertNotNull(host, nameof(host));
            options ??= new PagingClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _host = host;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlAsync(string accountName, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "PagingClient.GetPagesPartialUrl");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlRequest(accountName, context)
                        : CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetPagesPartialUrl(string accountName, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "PagingClient.GetPagesPartialUrl");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlRequest(accountName, context)
                        : CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlOperationAsync(string accountName, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "PagingClient.GetPagesPartialUrlOperation");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlOperationRequest(accountName, context)
                        : CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetPagesPartialUrlOperation(string accountName, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "PagingClient.GetPagesPartialUrlOperation");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetPagesPartialUrlOperationRequest(accountName, context)
                        : CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> GetPagesPartialUrlOperationNextAsync(string accountName, string nextLink, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, "PagingClient.GetPagesPartialUrlOperationNext");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "values", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   values: [
        ///     {
        ///       properties: {
        ///         id: number,
        ///         name: string
        ///       }
        ///     }
        ///   ],
        ///   nextLink: string
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> GetPagesPartialUrlOperationNext(string accountName, string nextLink, RequestContext context = null)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, "PagingClient.GetPagesPartialUrlOperationNext");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "values", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateGetPagesPartialUrlRequest(string accountName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlink", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationRequest(string accountName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/partialnextlinkop", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlOperationNextRequest(string accountName, string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendPath("/paging/customurl/", false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPagesPartialUrlNextPageRequest(string nextLink, string accountName, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(_host, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
