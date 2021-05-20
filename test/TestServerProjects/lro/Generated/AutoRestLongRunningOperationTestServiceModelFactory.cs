// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using lro.Models;

namespace lro
{
    /// <summary> Model factory for AutoRestLongRunningOperationTestService read-only models. </summary>
    public static partial class AutoRestLongRunningOperationTestServiceModelFactory
    {
        /// <summary> Initializes new instance of Resource class. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="type"> Resource Type. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="name"> Resource Name. </param>
        /// <returns> A new <see cref="Models.Resource"/> instance for mocking. </returns>
        public static Resource Resource(string id = default, string type = default, IDictionary<string, string> tags = default, string location = default, string name = default)
        {
            tags ??= new Dictionary<string, string>();
            return new Resource(id, type, tags, location, name);
        }

        /// <summary> Initializes new instance of Product class. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="type"> Resource Type. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="provisioningState"> . </param>
        /// <param name="provisioningStateValues"> . </param>
        /// <returns> A new <see cref="Models.Product"/> instance for mocking. </returns>
        public static Product Product(string id = default, string type = default, IDictionary<string, string> tags = default, string location = default, string name = default, string provisioningState = default, ProductPropertiesProvisioningStateValues? provisioningStateValues = default)
        {
            tags ??= new Dictionary<string, string>();
            return new Product(id, type, tags, location, name, provisioningState, provisioningStateValues);
        }

        /// <summary> Initializes new instance of SubResource class. </summary>
        /// <param name="id"> Sub Resource Id. </param>
        /// <returns> A new <see cref="Models.SubResource"/> instance for mocking. </returns>
        public static SubResource SubResource(string id = default)
        {
            return new SubResource(id);
        }

        /// <summary> Initializes new instance of SubProduct class. </summary>
        /// <param name="id"> Sub Resource Id. </param>
        /// <param name="provisioningState"> . </param>
        /// <param name="provisioningStateValues"> . </param>
        /// <returns> A new <see cref="Models.SubProduct"/> instance for mocking. </returns>
        public static SubProduct SubProduct(string id = default, string provisioningState = default, SubProductPropertiesProvisioningStateValues? provisioningStateValues = default)
        {
            return new SubProduct(id, provisioningState, provisioningStateValues);
        }
    }
}