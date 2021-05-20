// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using ModelShapes.Models;

namespace ModelShapes
{
    /// <summary> Model factory for SchemaMapping read-only models. </summary>
    public static partial class SchemaMappingModelFactory
    {
        /// <summary> Initializes new instance of MixedModel class. </summary>
        /// <param name="requiredString"> . </param>
        /// <param name="requiredInt"> . </param>
        /// <param name="requiredStringList"> . </param>
        /// <param name="requiredIntList"> . </param>
        /// <param name="nonRequiredString"> . </param>
        /// <param name="nonRequiredInt"> . </param>
        /// <param name="nonRequiredStringList"> . </param>
        /// <param name="nonRequiredIntList"> . </param>
        /// <param name="requiredNullableString"> . </param>
        /// <param name="requiredNullableInt"> . </param>
        /// <param name="requiredNullableStringList"> . </param>
        /// <param name="requiredNullableIntList"> . </param>
        /// <param name="nonRequiredNullableString"> . </param>
        /// <param name="nonRequiredNullableInt"> . </param>
        /// <param name="nonRequiredNullableStringList"> . </param>
        /// <param name="nonRequiredNullableIntList"> . </param>
        /// <param name="requiredReadonlyInt"> . </param>
        /// <param name="nonRequiredReadonlyInt"> . </param>
        /// <returns> A new <see cref="Models.MixedModel"/> instance for mocking. </returns>
        public static MixedModel MixedModel(string requiredString = default, int requiredInt = default, IList<string> requiredStringList = default, IList<int> requiredIntList = default, string nonRequiredString = default, int? nonRequiredInt = default, IList<string> nonRequiredStringList = default, IList<int> nonRequiredIntList = default, string requiredNullableString = default, int? requiredNullableInt = default, IList<string> requiredNullableStringList = default, IList<int> requiredNullableIntList = default, string nonRequiredNullableString = default, int? nonRequiredNullableInt = default, IList<string> nonRequiredNullableStringList = default, IList<int> nonRequiredNullableIntList = default, int requiredReadonlyInt = default, int? nonRequiredReadonlyInt = default)
        {
            requiredStringList ??= new List<string>();
            requiredIntList ??= new List<int>();
            nonRequiredStringList ??= new List<string>();
            nonRequiredIntList ??= new List<int>();
            requiredNullableStringList ??= new List<string>();
            requiredNullableIntList ??= new List<int>();
            nonRequiredNullableStringList ??= new List<string>();
            nonRequiredNullableIntList ??= new List<int>();
            return new MixedModel(requiredString, requiredInt, requiredStringList, requiredIntList, nonRequiredString, nonRequiredInt, nonRequiredStringList, nonRequiredIntList, requiredNullableString, requiredNullableInt, requiredNullableStringList, requiredNullableIntList, nonRequiredNullableString, nonRequiredNullableInt, nonRequiredNullableStringList, nonRequiredNullableIntList, requiredReadonlyInt, nonRequiredReadonlyInt);
        }

        /// <summary> Initializes new instance of OutputModel class. </summary>
        /// <param name="requiredString"> . </param>
        /// <param name="requiredInt"> . </param>
        /// <param name="requiredStringList"> . </param>
        /// <param name="requiredIntList"> . </param>
        /// <param name="nonRequiredString"> . </param>
        /// <param name="nonRequiredInt"> . </param>
        /// <param name="nonRequiredStringList"> . </param>
        /// <param name="nonRequiredIntList"> . </param>
        /// <param name="requiredNullableString"> . </param>
        /// <param name="requiredNullableInt"> . </param>
        /// <param name="requiredNullableStringList"> . </param>
        /// <param name="requiredNullableIntList"> . </param>
        /// <param name="nonRequiredNullableString"> . </param>
        /// <param name="nonRequiredNullableInt"> . </param>
        /// <param name="nonRequiredNullableStringList"> . </param>
        /// <param name="nonRequiredNullableIntList"> . </param>
        /// <param name="requiredReadonlyInt"> . </param>
        /// <param name="nonRequiredReadonlyInt"> . </param>
        /// <returns> A new <see cref="Models.OutputModel"/> instance for mocking. </returns>
        public static OutputModel OutputModel(string requiredString = default, int requiredInt = default, IReadOnlyList<string> requiredStringList = default, IReadOnlyList<int> requiredIntList = default, string nonRequiredString = default, int? nonRequiredInt = default, IReadOnlyList<string> nonRequiredStringList = default, IReadOnlyList<int> nonRequiredIntList = default, string requiredNullableString = default, int? requiredNullableInt = default, IReadOnlyList<string> requiredNullableStringList = default, IReadOnlyList<int> requiredNullableIntList = default, string nonRequiredNullableString = default, int? nonRequiredNullableInt = default, IReadOnlyList<string> nonRequiredNullableStringList = default, IReadOnlyList<int> nonRequiredNullableIntList = default, int requiredReadonlyInt = default, int? nonRequiredReadonlyInt = default)
        {
            requiredStringList ??= new List<string>();
            requiredIntList ??= new List<int>();
            nonRequiredStringList ??= new List<string>();
            nonRequiredIntList ??= new List<int>();
            requiredNullableStringList ??= new List<string>();
            requiredNullableIntList ??= new List<int>();
            nonRequiredNullableStringList ??= new List<string>();
            nonRequiredNullableIntList ??= new List<int>();
            return new OutputModel(requiredString, requiredInt, requiredStringList, requiredIntList, nonRequiredString, nonRequiredInt, nonRequiredStringList, nonRequiredIntList, requiredNullableString, requiredNullableInt, requiredNullableStringList, requiredNullableIntList, nonRequiredNullableString, nonRequiredNullableInt, nonRequiredNullableStringList, nonRequiredNullableIntList, requiredReadonlyInt, nonRequiredReadonlyInt);
        }

        /// <summary> Initializes new instance of MixedModelWithReadonlyProperty class. </summary>
        /// <param name="readonlyProperty"> . </param>
        /// <param name="readonlyListProperty"> . </param>
        /// <returns> A new <see cref="Models.MixedModelWithReadonlyProperty"/> instance for mocking. </returns>
        public static MixedModelWithReadonlyProperty MixedModelWithReadonlyProperty(ReadonlyModel readonlyProperty = default, IReadOnlyList<ReadonlyModel> readonlyListProperty = default)
        {
            readonlyListProperty ??= new List<ReadonlyModel>();
            return new MixedModelWithReadonlyProperty(readonlyProperty, readonlyListProperty);
        }

        /// <summary> Initializes new instance of ReadonlyModel class. </summary>
        /// <param name="name"> . </param>
        /// <returns> A new <see cref="Models.ReadonlyModel"/> instance for mocking. </returns>
        public static ReadonlyModel ReadonlyModel(string name = default)
        {
            return new ReadonlyModel(name);
        }
    }
}