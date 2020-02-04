// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace paging.Models
{
    /// <summary> The OperationResult. </summary>
    public partial class OperationResult
    {
        /// <summary> The status of the request. </summary>
        public OperationResultStatus? Status { get; set; }
    }
}