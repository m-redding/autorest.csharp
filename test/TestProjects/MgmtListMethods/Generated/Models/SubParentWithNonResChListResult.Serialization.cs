// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    internal partial class SubParentWithNonResChListResult
    {
        internal static SubParentWithNonResChListResult DeserializeSubParentWithNonResChListResult(JsonElement element)
        {
            IReadOnlyList<SubParentWithNonResChData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SubParentWithNonResChData> array = new List<SubParentWithNonResChData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubParentWithNonResChData.DeserializeSubParentWithNonResChData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SubParentWithNonResChListResult(value, nextLink.Value);
        }
    }
}