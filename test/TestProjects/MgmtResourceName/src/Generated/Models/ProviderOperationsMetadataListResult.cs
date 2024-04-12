// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace MgmtResourceName.Models
{
    /// <summary> Provider operations metadata list. </summary>
    internal partial class ProviderOperationsMetadataListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProviderOperationsMetadataListResult"/>. </summary>
        internal ProviderOperationsMetadataListResult()
        {
            Value = new ChangeTrackingList<ProviderOperationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderOperationsMetadataListResult"/>. </summary>
        /// <param name="value"> The list of providers. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ProviderOperationsMetadataListResult(IReadOnlyList<ProviderOperationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of providers. </summary>
        public IReadOnlyList<ProviderOperationData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}