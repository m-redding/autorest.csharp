// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ModelsInCadl
{
    /// <summary> Model used both as input and output with primitive types. </summary>
    public partial class RoundTripPrimitiveModel
    {
        /// <summary> Initializes a new instance of RoundTripPrimitiveModel. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredInt64"></param>
        /// <param name="requiredSafeInt"></param>
        /// <param name="requiredFloat"></param>
        /// <param name="requiredDouble"></param>
        /// <param name="requiredBoolean"></param>
        /// <param name="requiredDateTimeOffset"></param>
        /// <param name="requiredTimeSpan"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/> is null. </exception>
        public RoundTripPrimitiveModel(string requiredString, int requiredInt, long requiredInt64, long requiredSafeInt, float requiredFloat, double requiredDouble, bool requiredBoolean, DateTimeOffset requiredDateTimeOffset, TimeSpan requiredTimeSpan)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredInt64 = requiredInt64;
            RequiredSafeInt = requiredSafeInt;
            RequiredFloat = requiredFloat;
            RequiredDouble = requiredDouble;
            RequiredBoolean = requiredBoolean;
            RequiredDateTimeOffset = requiredDateTimeOffset;
            RequiredTimeSpan = requiredTimeSpan;
        }

        public string RequiredString { get; set; }

        public int RequiredInt { get; set; }

        public long RequiredInt64 { get; set; }

        public long RequiredSafeInt { get; set; }

        public float RequiredFloat { get; set; }

        public double RequiredDouble { get; set; }

        public bool RequiredBoolean { get; set; }

        public DateTimeOffset RequiredDateTimeOffset { get; set; }

        public TimeSpan RequiredTimeSpan { get; set; }
    }
}