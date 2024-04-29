// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm._Type._Enum.Fixed
{
    // Data plane generated client.
    /// <summary> The Fixed service client. </summary>
    public partial class FixedClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FixedClient. </summary>
        public FixedClient() : this(new Uri("http://localhost:3000"), new FixedClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FixedClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public FixedClient(Uri endpoint, FixedClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new FixedClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private String _cachedString;

        /// <summary> Initializes a new instance of String. </summary>
        public virtual String GetStringClient()
        {
            return Volatile.Read(ref _cachedString) ?? Interlocked.CompareExchange(ref _cachedString, new String(_pipeline, _endpoint), null) ?? _cachedString;
        }
    }
}