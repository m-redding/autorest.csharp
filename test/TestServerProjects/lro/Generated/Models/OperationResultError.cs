// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace lro.Models
{
    /// <summary> The OperationResultError. </summary>
    public partial class OperationResultError
    {
        /// <summary> Initializes a new instance of OperationResultError. </summary>
        internal OperationResultError()
        {
        }

        /// <summary> Initializes a new instance of OperationResultError. </summary>
        /// <param name="code"> The error code for an operation failure. </param>
        /// <param name="message"> The detailed arror message. </param>
        internal OperationResultError(int? code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> The error code for an operation failure. </summary>
        public int? Code { get; }
        /// <summary> The detailed arror message. </summary>
        public string Message { get; }
    }
}