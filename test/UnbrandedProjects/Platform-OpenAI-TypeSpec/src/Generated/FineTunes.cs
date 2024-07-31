// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The FineTunes sub-client. </summary>
    public partial class FineTunes
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FineTunes for mocking. </summary>
        protected FineTunes()
        {
        }

        /// <summary> Initializes a new instance of FineTunes. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> The <see cref="string"/> to use. </param>
        internal FineTunes(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary>
        /// Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// </summary>
        /// <param name="fineTune"> The <see cref="CreateFineTuneRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTune"/> is null. </exception>
        /// <remarks> Create. </remarks>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult<FineTune>> CreateAsync(CreateFineTuneRequest fineTune)
        {
            Argument.AssertNotNull(fineTune, nameof(fineTune));

            using BinaryContent content = fineTune.ToBinaryContent();
            ClientResult result = await CreateAsync(content, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// </summary>
        /// <param name="fineTune"> The <see cref="CreateFineTuneRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTune"/> is null. </exception>
        /// <remarks> Create. </remarks>
        [Obsolete("deprecated")]
        public virtual ClientResult<FineTune> Create(CreateFineTuneRequest fineTune)
        {
            Argument.AssertNotNull(fineTune, nameof(fineTune));

            using BinaryContent content = fineTune.ToBinaryContent();
            ClientResult result = Create(content, null);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(CreateFineTuneRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult> CreateAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Creates a job that fine-tunes a specified model from a given dataset.
        ///
        /// Response includes details of the enqueued job including job status and the name of the fine-tuned models once complete.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(CreateFineTuneRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual ClientResult Create(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> List your organization's fine-tuning jobs. </summary>
        /// <remarks> List. </remarks>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult<ListFineTunesResponse>> GetFineTunesAsync()
        {
            ClientResult result = await GetFineTunesAsync(null).ConfigureAwait(false);
            return ClientResult.FromValue(ListFineTunesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> List your organization's fine-tuning jobs. </summary>
        /// <remarks> List. </remarks>
        [Obsolete("deprecated")]
        public virtual ClientResult<ListFineTunesResponse> GetFineTunes()
        {
            ClientResult result = GetFineTunes(null);
            return ClientResult.FromValue(ListFineTunesResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] List your organization's fine-tuning jobs
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetFineTunesAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult> GetFineTunesAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetFineTunesRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] List your organization's fine-tuning jobs
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetFineTunes()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual ClientResult GetFineTunes(RequestOptions options)
        {
            using PipelineMessage message = CreateGetFineTunesRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary>
        /// Gets info about the fine-tune job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Retrieve. </remarks>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult<FineTune>> RetrieveAsync(string fineTuneId)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = await RetrieveAsync(fineTuneId, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// Gets info about the fine-tune job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Retrieve. </remarks>
        [Obsolete("deprecated")]
        public virtual ClientResult<FineTune> Retrieve(string fineTuneId)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = Retrieve(fineTuneId, null);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Gets info about the fine-tune job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="RetrieveAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult> RetrieveAsync(string fineTuneId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateRetrieveRequest(fineTuneId, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Gets info about the fine-tune job.
        ///
        /// [Learn more about fine-tuning](/docs/guides/legacy-fine-tuning)
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Retrieve(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual ClientResult Retrieve(string fineTuneId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateRetrieveRequest(fineTuneId, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Get fine-grained status updates for a fine-tune job. </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to get events for. </param>
        /// <param name="stream">
        /// Whether to stream events for the fine-tune job. If set to true, events will be sent as
        /// data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available. The stream will terminate with a `data: [DONE]` message when the
        /// job is finished (succeeded, cancelled, or failed).
        ///
        /// If set to false, only events generated so far will be returned.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> List events. </remarks>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult<ListFineTuneEventsResponse>> GetEventsAsync(string fineTuneId, bool? stream = null)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = await GetEventsAsync(fineTuneId, stream, null).ConfigureAwait(false);
            return ClientResult.FromValue(ListFineTuneEventsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Get fine-grained status updates for a fine-tune job. </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to get events for. </param>
        /// <param name="stream">
        /// Whether to stream events for the fine-tune job. If set to true, events will be sent as
        /// data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available. The stream will terminate with a `data: [DONE]` message when the
        /// job is finished (succeeded, cancelled, or failed).
        ///
        /// If set to false, only events generated so far will be returned.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> List events. </remarks>
        [Obsolete("deprecated")]
        public virtual ClientResult<ListFineTuneEventsResponse> GetEvents(string fineTuneId, bool? stream = null)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = GetEvents(fineTuneId, stream, null);
            return ClientResult.FromValue(ListFineTuneEventsResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get fine-grained status updates for a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEventsAsync(string,bool?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to get events for. </param>
        /// <param name="stream">
        /// Whether to stream events for the fine-tune job. If set to true, events will be sent as
        /// data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available. The stream will terminate with a `data: [DONE]` message when the
        /// job is finished (succeeded, cancelled, or failed).
        ///
        /// If set to false, only events generated so far will be returned.
        /// </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult> GetEventsAsync(string fineTuneId, bool? stream, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateGetEventsRequest(fineTuneId, stream, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get fine-grained status updates for a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetEvents(string,bool?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to get events for. </param>
        /// <param name="stream">
        /// Whether to stream events for the fine-tune job. If set to true, events will be sent as
        /// data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available. The stream will terminate with a `data: [DONE]` message when the
        /// job is finished (succeeded, cancelled, or failed).
        ///
        /// If set to false, only events generated so far will be returned.
        /// </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual ClientResult GetEvents(string fineTuneId, bool? stream, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateGetEventsRequest(fineTuneId, stream, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Immediately cancel a fine-tune job. </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to cancel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Cancel. </remarks>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult<FineTune>> CancelAsync(string fineTuneId)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = await CancelAsync(fineTuneId, null).ConfigureAwait(false);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Immediately cancel a fine-tune job. </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to cancel. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <remarks> Cancel. </remarks>
        [Obsolete("deprecated")]
        public virtual ClientResult<FineTune> Cancel(string fineTuneId)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            ClientResult result = Cancel(fineTuneId, null);
            return ClientResult.FromValue(FineTune.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Immediately cancel a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CancelAsync(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to cancel. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual async Task<ClientResult> CancelAsync(string fineTuneId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateCancelRequest(fineTuneId, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Immediately cancel a fine-tune job.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Cancel(string)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fineTuneId"> The ID of the fine-tune job to cancel. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fineTuneId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fineTuneId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        [Obsolete("deprecated")]
        public virtual ClientResult Cancel(string fineTuneId, RequestOptions options)
        {
            Argument.AssertNotNullOrEmpty(fineTuneId, nameof(fineTuneId));

            using PipelineMessage message = CreateCancelRequest(fineTuneId, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateCreateRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine-tunes", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetFineTunesRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine-tunes", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateRetrieveRequest(string fineTuneId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine-tunes/", false);
            uri.AppendPath(fineTuneId, true);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateGetEventsRequest(string fineTuneId, bool? stream, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine-tunes/", false);
            uri.AppendPath(fineTuneId, true);
            uri.AppendPath("/events", false);
            if (stream != null)
            {
                uri.AppendQuery("stream", stream.Value, true);
            }
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateCancelRequest(string fineTuneId, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/fine-tunes/", false);
            uri.AppendPath(fineTuneId, true);
            uri.AppendPath("/cancel", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}
