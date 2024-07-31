// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace AnomalyDetector
{
    // Data plane generated client.
    /// <summary>
    /// The Anomaly Detector API detects anomalies automatically in time series data.
    /// It supports two kinds of mode, one is for stateless using, another is for
    /// stateful using. In stateless mode, there are three functionalities. Entire
    /// Detect is for detecting the whole series with model trained by the time series,
    /// Last Detect is detecting last point with model trained by points before.
    /// ChangePoint Detect is for detecting trend changes in time series. In stateful
    /// mode, user can store time series, the stored time series will be used for
    /// detection anomalies. Under this mode, user can still use the above three
    /// functionalities by only giving a time range without preparing time series in
    /// client side. Besides the above three functionalities, stateful model also
    /// provide group based detection and labeling service. By leveraging labeling
    /// service user can provide labels for each detection result, these labels will be
    /// used for retuning or regenerating detection models. Inconsistency detection is
    /// a kind of group based detection, this detection will find inconsistency ones in
    /// a set of time series. By using anomaly detector service, business customers can
    /// discover incidents and establish a logic flow for root cause analysis.
    /// </summary>
    public partial class AnomalyDetectorClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AnomalyDetectorClient for mocking. </summary>
        protected AnomalyDetectorClient()
        {
        }

        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://westus2.api.cognitive.microsoft.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public AnomalyDetectorClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new AnomalyDetectorClientOptions())
        {
        }

        /// <summary> Initializes a new instance of AnomalyDetectorClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://westus2.api.cognitive.microsoft.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public AnomalyDetectorClient(Uri endpoint, AzureKeyCredential credential, AnomalyDetectorClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AnomalyDetectorClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        private Univariate _cachedUnivariate;
        private Multivariate _cachedMultivariate;

        /// <summary> Initializes a new instance of Univariate. </summary>
        public virtual Univariate GetUnivariateClient()
        {
            return Volatile.Read(ref _cachedUnivariate) ?? Interlocked.CompareExchange(ref _cachedUnivariate, new Univariate(ClientDiagnostics, _pipeline, _keyCredential, _endpoint, _apiVersion), null) ?? _cachedUnivariate;
        }

        /// <summary> Initializes a new instance of Multivariate. </summary>
        public virtual Multivariate GetMultivariateClient()
        {
            return Volatile.Read(ref _cachedMultivariate) ?? Interlocked.CompareExchange(ref _cachedMultivariate, new Multivariate(ClientDiagnostics, _pipeline, _keyCredential, _endpoint, _apiVersion), null) ?? _cachedMultivariate;
        }
    }
}
